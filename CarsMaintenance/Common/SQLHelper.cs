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

        private static string sqlOutboundSummary =
            "select c.Name as CategroyName, t.Code, t.Name as ToolName, t.Dimensions, t.Unit, sum(i.Quantity) as Quantity from OutboundOrderDetail i " +
            "inner join Tool t on i.ToolID = t.ToolID " +
            "inner join ToolCategory c on SUBSTRING(t.Code, 1, 2) = c.Code and c.ParentCategoryID is null " +
            "where i.OutboundDate between '{0}' and '{1}'" +
            "group by c.Name , t.Code, t.Name, t.Dimensions, t.Unit ";

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

        private static string sql2 = "select tool.*, toolgroup.* from tool inner join toolgroup on tool.id = toolgroup.toolid";

        public static DataSet QueryToolGroup()
        {
            DataSet dataSet = new CarsMaintenance.Reports.ScrapDetailDataSet();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString))
            {
                try
                {

                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql2, conn);
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
    }
}
