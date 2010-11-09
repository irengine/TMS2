insert into ToolInventory(ToolID, Quantity, UnitPrice, SupplyID, LastInboundDate)
select ToolID, Quantity, UnitPrice, SupplyID, PurchaseDate
from PurchaseOrder
go
