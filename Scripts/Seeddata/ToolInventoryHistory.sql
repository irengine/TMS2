SET IDENTITY_INSERT [dbo].[ToolInventoryHistory] ON
insert into ToolInventoryHistory(ToolInventoryHistoryID, ToolInventoryHistoryDate, Account, ToolID, UnitPrice,Quantity,PurchaseOrderID, SupplyID)
select ToolID, PurchaseDate, '1000', ToolID, UnitPrice,Quantity, PurchaseOrderID, SupplyID
from PurchaseOrder
SET IDENTITY_INSERT [dbo].[ToolInventoryHistory] OFF
go
