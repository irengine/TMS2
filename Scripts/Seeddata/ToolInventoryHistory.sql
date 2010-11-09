SET IDENTITY_INSERT [dbo].[ToolInventoryHistory] ON
insert into ToolInventoryHistory(ToolInventoryHistoryID, ToolInventoryHistoryDate, ToolID, UnitPrice,Quantity,PurchaseOrderID, SupplyID)
select ToolID, PurchaseDate, ToolID, UnitPrice,Quantity, PurchaseOrderID, SupplyID
from PurchaseOrder
SET IDENTITY_INSERT [dbo].[ToolInventoryHistory] OFF
go
