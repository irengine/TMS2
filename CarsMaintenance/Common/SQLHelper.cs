using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;

namespace CarsMaintenance.Common
{
	class SQLHelper
	{
		private static string CONNECTION_NAME = "QueryConnectionString";


        private static string sqlQueryLoginFormToTools = @"
                           select Tc.Name,Sum(ti.Quantity) as Quantity,
			                               Sum(ti.OutQuantity) as OutQuantity,
			                               Sum(t.RatedQuantity) as RatedQuantity,
			                               SUM(ti.ScrapQuantity) as ScrapQuantity
                            from ToolCategory as tc
                            inner join Tool as t on tc.ToolCategoryID=t.ToolCategoryID
                            inner join ToolInventory as ti on ti.ToolID=t.ToolID 
                            group by tc.Name";

		private static string sqlOutboundOrder =
						"select o.Code as OrderCode, o.OutboundDate as OrderDate, o.Version, " +
								"o.Job, o.Berth, o.Machine, o.Ship, o.Hatch, o.Cargo, o.Quantity as lots, o.Process, " +
								"c.Name as CustomerName, u.Name as UserName, " +
								"t.Code, t.Name, t.Dimensions, i.Quantity " +
								"from OutboundOrder o " +
								"inner join OutboundOrderDetail i on o.OutboundOrderID = i.OutboundOrderID " +
								"inner join Unit c on o.CustomerID = c.UnitID " +
								"inner join SystemUser u on o.LastUpdatedBy = u.SystemUserID " +
								"inner join Tool t on i.ToolID = t.ToolID " +
								"where  o.OutboundOrderID = {0}";

		private static string sqlScrapReport =
						 @"SELECT ToolCategory.Name AS ToolCategoryName, Tool.Name AS ToolName, 
								  ScrapOrderDetail.UnitPrice * ScrapOrderDetail.ScrapQuantity AS AllUnitPrice, 
								  ScrapOrderDetail.UnitPrice, ScrapOrderDetail.ScrapQuantity AS Quantity, 
								  Tool.Dimensions
							FROM ScrapOrder LEFT OUTER JOIN
								  ScrapOrderDetail ON 
								  ScrapOrder.ScrapOrderID = ScrapOrderDetail.ScrapOrderID LEFT OUTER JOIN
								  Tool ON ScrapOrderDetail.ToolID = Tool.ToolID LEFT OUTER JOIN
								  ToolCategory ON Tool.ToolCategoryID = ToolCategory.ToolCategoryID
							WHERE (ScrapOrderDetail.ScrapQuantity > 0) AND (ScrapOrder.Status = 1) AND 
								  (ScrapOrderDetail.ScrapDate BETWEEN '{0}' AND '{1}')";
		private static string sqlOutBoundOrderByUintReport =
							 @"Select Pu.Name as ParentName,u.Name as Name,O.Berth,O.Cargo,O.Ship,O.Hatch,O.Code,O.Version,Od.Quantity,Od.UnitPrice,T.Name as ToolName,T.Dimensions,T.Code as ToolCode
							 from OutboundOrder as O 
									inner join  OutboundOrderDetail as Od
									on o.OutboundOrderID=Od.OutboundOrderID
									inner join Unit as U on O.CustomerID =U.UnitID
									inner join Unit as Pu on U.ParentUnitID=Pu.UnitID
									inner join Tool as T on Od.ToolID=T.ToolID
									Where Substring(U.InternalCode,1,5) in (
									'2,SDD',
									'2,CQD',
									'2,JXD'
									) AND (O.OutboundDate BETWEEN '{0}' AND '{1}')";


		private static string sqlScrapByUnit =
					 @"Select So.CustomerID,Pu.Name as ParentName,u.Name as UintName,Sum(Sod.ScrapQuantity) as Quantity,Sum(Sod.UnitPrice*Sod.ScrapQuantity) as TotalPrice
					, Sum(Sod.UnitPrice*Sod.ScrapQuantity)/summaryTotalPrice as Percentage
					 from ScrapOrder as so inner join ScrapOrderDetail  as sod on so.ScrapOrderID=sod.ScrapOrderID
					  inner join Unit as u on so.CustomerID=u.UnitID inner join Unit as Pu on u.ParentUnitID=Pu.UnitID 
					  ,(select SUM(sodtotal.ScrapQuantity) as totalQuantity, SUM(sodtotal.ScrapQuantity*sodtotal.UnitPrice)as summaryTotalPrice from ScrapOrderDetail sodtotal) total
					Where Sod.ScrapQuantity>0 and  (So.ScrapDate between '{0}' and '{1}')
						Group by So.CustomerID,u.Name,Pu.Name,summaryTotalPrice";
		private static string sqlScrapByShip =
                    @"Select so.ScrapDate,o.JobType,o.Ship,SUM(sod.ScrapQuantity) as Quantity,SUM(sod.UnitPrice)as UnitPrice  from ScrapOrder as so 
								inner join  ScrapOrderDetail as sod 
									on so.ScrapOrderID=sod.ScrapOrderID
									inner join OutboundOrder as o 
									on so.OutboundOrderID=o.OutboundOrderID
									 Where So.ScrapDate between '{0}' and '{1}'
									Group by o.Ship,so.ScrapDate,o.JobType";
		private static string sqlOutboundSummary =
					"select c.Name as CategroyName, t.Code, t.Name as ToolName, t.Dimensions, t.Unit, sum(i.Quantity) as Quantity from OutboundOrderDetail i " +
								"inner join Tool t on i.ToolID = t.ToolID " +
								"inner join ToolCategory c on SUBSTRING(t.Code, 1, 2) = c.Code and c.ParentCategoryID is null " +
								"where i.OutboundDate between '{0}' and '{1}'" +
								"group by c.Name , t.Code, t.Name, t.Dimensions, t.Unit ";
		private static string sqlToolReport =
					@"Select t.Name as ToolName,T.Dimensions,t.Code,t.Unit,t.[Description], tc.Name as CategoryName,ti.OutQuantity,
								ti.Quantity,ti.PrescrapQuantity,t.RatedQuantity,ti.ScrapQuantity,ti.RepairingQuantity,ti.UnitPrice from Tool as t inner join ToolCategory as tc
								on t.ToolCategoryID=Tc.ToolCategoryID inner join ToolInventory as ti
								on t.ToolID=ti.ToolID Where t.Name like '%{0}%' and t.Code like '%{1}%'";

		private static string sqlColligaterByJobTypeReport = @"Select Sum(sd.UnitPrice * sd.ScrapQuantity) as UnitPrice,o.JobType,
								 (SUM(sd.UnitPrice*sd.ScrapQuantity)/(Select SUM(sd1.ScrapQuantity*sd1.UnitPrice) from ScrapOrderDetail as sd1)) as Percentage from ScrapOrder as s 
								inner join ScrapOrderDetail as sd on s.ScrapOrderID=sd.ScrapOrderID
								inner join OutboundOrder as o on s.OutboundOrderID=o.OutboundOrderID
								inner join OutboundOrderDetail as od on sd.OutboundOrderDetailID=od.OutboundOrderDetailID
								inner join Unit as u on s.CustomerID=u.UnitId
								inner join Unit as pu on u.ParentUnitID=pu.UnitID
								where s.ScrapDate between '{0}' and '{1}'
								Group by o.JobType";
		private static string sqlColligaterByJobPosition = @"Select Sum(sd.UnitPrice * sd.ScrapQuantity) as UnitPrice,o.JobPosition,
								 (SUM(sd.UnitPrice*sd.ScrapQuantity)/(Select SUM(sd1.ScrapQuantity*sd1.UnitPrice) from ScrapOrderDetail as sd1)) as Percentage from ScrapOrder as s 
								inner join ScrapOrderDetail as sd on s.ScrapOrderID=sd.ScrapOrderID
								inner join OutboundOrder as o on s.OutboundOrderID=o.OutboundOrderID
								inner join OutboundOrderDetail as od on sd.OutboundOrderDetailID=od.OutboundOrderDetailID
								inner join Unit as u on s.CustomerID=u.UnitId
								inner join Unit as pu on u.ParentUnitID=pu.UnitID
								where s.ScrapDate between '{0}' and '{1}'
								Group by o.JobPosition";
		private static string sqlColligaterByUnitName = @"
											select findAll.PName,findAll.TotalPrice,findAll.Name as MaxName,findMin.Name as MinName,findMax.Percentage from 
											(
											Select Sum(sd.UnitPrice * sd.ScrapQuantity) as TotalPrice,pu.code as PCode, pu.name as PName,u.Name,u.Code from ScrapOrder as s 
											inner join ScrapOrderDetail as sd on s.ScrapOrderID=sd.ScrapOrderID
											inner join Unit as u on s.CustomerID=u.UnitId
											inner join Unit as pu on u.ParentUnitID=pu.UnitID
											,(Select SUM(sd1.ScrapQuantity*sd1.UnitPrice) as summaryTotalPrice from ScrapOrderDetail as sd1) total
											 where (s.ScrapDate between '{0}' and '{1}') and sd.ScrapQuantity>0 
											Group by pu.code,pu.Name,u.Name,u.Code,summaryTotalPrice) as findAll inner join (
											select PCode, PName, MAX(TotalPrice) as maxTotal, MIN(TotalPrice) as minTotal,SUM(Percentage) as Percentage
											from
											(
											Select Sum(sd.UnitPrice * sd.ScrapQuantity) as TotalPrice,pu.code as PCode, pu.name as PName,u.Code,u.Name ,
											 (SUM(sd.UnitPrice*sd.ScrapQuantity)/(summaryTotalPrice)) as Percentage from ScrapOrder as s 
											inner join ScrapOrderDetail as sd on s.ScrapOrderID=sd.ScrapOrderID
											inner join Unit as u on s.CustomerID=u.UnitId
											inner join Unit as pu on u.ParentUnitID=pu.UnitID
											,(Select SUM(sd1.ScrapQuantity*sd1.UnitPrice) as summaryTotalPrice from ScrapOrderDetail as sd1) total
										   where (s.ScrapDate between '{0}' and '{1}') and sd.ScrapQuantity>0 
											Group by pu.code,pu.Name,u.Code,u.Name,summaryTotalPrice
											) temp1
											group by PCode,PName
											) as  findMax
											 on findMax.PCode= findAll.PCode and findMax.maxTotal = findAll.TotalPrice
											inner join
											(
											Select Sum(sd.UnitPrice * sd.ScrapQuantity) as TotalPrice,pu.code as PCode, pu.name as PName,u.Code,u.Name from ScrapOrder as s 
											inner join ScrapOrderDetail as sd on s.ScrapOrderID=sd.ScrapOrderID
											inner join Unit as u on s.CustomerID=u.UnitId
											inner join Unit as pu on u.ParentUnitID=pu.UnitID
											,(Select SUM(sd1.ScrapQuantity*sd1.UnitPrice) as summaryTotalPrice from ScrapOrderDetail as sd1) total
											where (s.ScrapDate between '{0}' and '{1}') and sd.ScrapQuantity>0 
											Group by pu.code,pu.Name,u.Code,u.Name,summaryTotalPrice
											) as findMin on findMax.PCode = findMin.PCode and findMax.minTotal = findMin.TotalPrice
											";

		private static string sqlToolInfoReport = @"Select s.ScrapDate,s.Code,sd.ScrapQuantity,sd.UnitPrice,sd.ScrapReason, (sd.ScrapQuantity* sd.UnitPrice) as AllUnitPrice,
											t.Name as ToolName,t.Dimensions,u.Name as CustomerName,o.Berth,
											o.Cargo,o.Hatch,o.Job,o.JobPosition,o.JobType,o.Machine,o.Process,
											o.Ship,o.[Version],su.Name as ScrapSystemUnerName,su1.Name as OutboundSystemUserName,pu.Name as ParentUserName,
											Case when o.ClassType=1 then '日班' ELSE '夜班' END as ClassType ,Case When sd.IsAbnormal=0 THEN '否' ELSE '是' END as  IsAbnormal
											 From ScrapOrder as s 
											inner join ScrapOrderDetail as sd on s.ScrapOrderID = sd.ScrapOrderID
											inner join OutboundOrder as o on s.OutboundOrderID=o.OutboundOrderID
											inner join OutboundOrderDetail as od on sd.OutboundOrderDetailID=od.OutboundOrderDetailID
											inner join Tool as t on sd.ToolID=t.ToolID
											inner join Unit as u on s.CustomerID=u.UnitID
											inner join SystemUser as su on s.LastUpdatedBy=su.SystemUserID
											inner join Unit as pu on u.ParentUnitID=pu.UnitID
											inner join SystemUser as su1 on o.LastUpdatedBy=su1.SystemUserID
											Where (s.ScrapDate BETWEEN '{0}' AND '{1}') ";

		private static string sqlAbnormityScrapReport = @"Select S.ScrapDate,o.JobType,o.JobPosition,o.Ship,t.Dimensions,t.Name as ToolName,
											CASE WHEN o.ClassType=1 Then '白班' ELSE '夜班' END as ClassType,pu.Name as ParentUserName,u.Name as UserName,su.Name as SystemUserName,
											sd.ScrapQuantity,sd.UnitPrice,(sd.ScrapQuantity* sd.UnitPrice) as AllUnitPrice ,Case When  sd.IsAbnormal=0  then '否' Else  '是' End as IsAbnormal,sd.ScrapReason from ScrapOrder as s 
											inner join ScrapOrderDetail as sd on s.ScrapOrderID=sd.ScrapOrderID
											inner join Tool as t on sd.ToolID=t.ToolID
											inner join Unit as u on s.CustomerID=u.UnitID
											inner join Unit as pu on u.ParentUnitID= pu.UnitID
											inner join OutboundOrder as o on o.OutboundOrderID=s.OutboundOrderID
											inner join SystemUser as su on s.LastUpdatedBy=su.SystemUserID where sd.IsAbnormal!=0 AND (s.ScrapDate BETWEEN '{0}' AND '{1}')";



        public static DataSet QueryLoginFormToTools()
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql =sqlQueryLoginFormToTools;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                    dataAdapter.Fill(dataSet);
                }
                //catch (Exception e)
                //{
                //}
                finally
                {
                    conn.Close();
                }

            }
            return dataSet;
        }


		public static DataSet QueryAbnormityScrapReport(DateTime beginDate, DateTime endDate)
		{
			DataSet dataSet = new CarsMaintenance.Reports.AbnormityScrapDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{
					conn.Open();

					string sql = string.Format(sqlAbnormityScrapReport, beginDate, endDate);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}


		public static DataSet QueryToolInfoReport(DateTime beginDate, DateTime endDate, string JobPosition,string JobType)
		{
			DataSet dataSet = new CarsMaintenance.Reports.ToolInfoDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{
					conn.Open();

					string sql =string.Format( sqlToolInfoReport,beginDate,endDate);

					if (!JobType.Trim().Equals(string.Empty))
					{ 
						 sql=sql+ " and o.JobType='"+JobType+"' ";
					}

					if (!JobPosition.Trim().Equals(string.Empty))
					{ 
						sql=sql+ " and o.JobPosition='"+JobPosition+"' ";
					}
					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}

		public static DataSet QueryColligateReport(DateTime beginDate, DateTime endDate)
		{
			DataSet dataSet = new CarsMaintenance.Reports.ColligateDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();

					string sql="";
					sql=string.Format( sqlColligaterByJobTypeReport,beginDate,endDate);
					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables["ColligateByJobType"]);
					sql =string.Format( sqlColligaterByJobPosition,beginDate,endDate);
					dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables["ColligateByJobPosition"]);
					sql =string.Format( sqlColligaterByUnitName,beginDate,endDate);
					dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables["CooligateByUnitName"]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}

		public static DataSet QueryOutboundOrder(int id)
		{
			DataSet dataSet = new CarsMaintenance.Reports.OutboundOrderDataSet(); 
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try{

					conn.Open();

					string sql = string.Format(sqlOutboundOrder, id);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}
		public static DataSet QueryToolReport(string name, string code)
		{
			DataSet dataSet = new CarsMaintenance.Reports.ToolDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();

					string sql = string.Format(sqlToolReport, name, code); ;

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}

		public static DataSet QueryScrapByShipReport(DateTime beginDate, DateTime endDate)
		{
			DataSet dataSet = new CarsMaintenance.Reports.ScrapByShipDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();

					string sql =string.Format( sqlScrapByShip,beginDate,endDate);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}

		public static DataSet QueryOutBoundOrderByUintReport(DateTime beginDate, DateTime endDate)
		{
			DataSet dataSet = new CarsMaintenance.Reports.OutboundOrderByUnitDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();

					string sql =string.Format(sqlOutBoundOrderByUintReport, beginDate, endDate);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}

		public static DataSet QuerysqlScrapByUnitReport(DateTime beginDate, DateTime endDate)
		{
			DataSet dataSet = new CarsMaintenance.Reports.ScrapByUnitDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();

					string sql =string.Format( sqlScrapByUnit,beginDate,endDate,beginDate,endDate);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}

		public static DataSet QueryScrapReport(DateTime beginDate, DateTime endDate)
		{
			DataSet dataSet = new CarsMaintenance.Reports.ScrapDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();

					string sql = string.Format(sqlScrapReport, beginDate, endDate);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}


		public static DataSet QueryOutboundSummary(DateTime beginDate, DateTime endDate)
		{
			DataSet dataSet = new CarsMaintenance.Reports.OutboundSummaryDataSet();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();

					string sql = string.Format(sqlOutboundSummary, beginDate, endDate);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
					dataAdapter.Fill(dataSet.Tables[0]);
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return dataSet;
		}

		public static string SQL_TOTAL_RATED = "SELECT SUM(RatedQuantity) FROM Tool";
		public static string SQL_TOTAL_STOCK = "SELECT SUM(Quantity) FROM ToolInventory";
		public static string SQL_TOTAL_OUT = "SELECT SUM(OutQuantity) FROM ToolInventory";
        public static string SQL_TOTAL_SCRAP = "SELECT SUM(ScrapQuantity) FROM ToolInventory";

		public static string QueryLandForm(string sql)
		{
			string val = "";
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();
					SqlCommand cmd = new SqlCommand(sql, conn);
					val = cmd.ExecuteScalar().ToString();
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return val;
		}

		public static string SQL_DAY1_OUT = @"select SUM(OutboundOrderDetail.Quantity) from OutboundOrderDetail 
											inner join OutboundOrder on OutboundOrderDetail.OutboundOrderID = OutboundOrder.OutboundOrderID 
											where ClassType = 1 and DATEPART(day, OutboundOrder.OutboundDate) = {0}";
		public static string SQL_DAY2_OUT = @"select SUM(OutboundOrderDetail.Quantity) from OutboundOrderDetail 
											inner join OutboundOrder on OutboundOrderDetail.OutboundOrderID = OutboundOrder.OutboundOrderID 
											where ClassType = 2 and DATEPART(day, OutboundOrder.OutboundDate) = {0}";
		public static string SQL_MONTH_OUT = @"select SUM(OutboundOrderDetail.Quantity) from OutboundOrderDetail 
											inner join OutboundOrder on OutboundOrderDetail.OutboundOrderID = OutboundOrder.OutboundOrderID 
											where DATEPART(month, OutboundOrder.OutboundDate) = {0}";
		public static string SQL_YEAR_OUT = @"select SUM(OutboundOrderDetail.Quantity) from OutboundOrderDetail 
											inner join OutboundOrder on OutboundOrderDetail.OutboundOrderID = OutboundOrder.OutboundOrderID 
											where DATEPART(year, OutboundOrder.OutboundDate) = {0}";
        public static string SQL_DAY_SCRAP = @"select SUM(ScrapQuantity) from ScrapOrderDetail where DATEPART(day, ScrapDate) = {0}";
        public static string SQL_MONTH_SCRAP = @"select SUM(ScrapQuantity) from ScrapOrderDetail where DATEPART(month, ScrapDate) = {0}";
        public static string SQL_YEAR_SCRAP = @"select SUM(ScrapQuantity) from ScrapOrderDetail where DATEPART(year, ScrapDate) = {0}";

		public static string QueryLandForm(string sql, int cnt)
		{
			string val = "";
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
			{
				try
				{

					conn.Open();
					sql = string.Format(sql, cnt);
					SqlCommand cmd = new SqlCommand(sql, conn);
					val = cmd.ExecuteScalar().ToString();
				}
				//catch (Exception e)
				//{
				//}
				finally
				{
					conn.Close();
				}

			}
			return val;
		}
	}
}
