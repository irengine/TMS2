:r dbclean.sql
print 'clean done'

use tms
go

:r dbo.SystemRole.Table.sql
:r dbo.SystemUser.Table.sql

:r dbo.Unit.Table.sql
print 'system tables done'

:r dbo.Supply.Table.sql

:r dbo.ToolCategory.Table.sql
:r dbo.Tool.Table.sql
:r dbo.ToolGroup.Table.sql
print 'tool tables done'

:r dbo.Article.Table.sql

:r dbo.PurchaseOrder.Table.sql

:r dbo.OutboundOrder.Table.sql
:r dbo.OutboundOrderDetail.Table.sql


:r dbo.InboundOrder.Table.sql
:r dbo.InboundOrderDetail.Table.sql

:r dbo.ScrapOrder.Table.sql
:r dbo.ScrapOrderDetail.Table.sql

:r dbo.RepairOrder.Table.sql
:r dbo.RepairOrderDetail.Table.sql
print 'order tables done'

:r dbo.ToolInventory.Table.sql
:r dbo.ToolInventoryHistory.Table.sql
print 'inventory tables done'

:r .\Seeddata\Unit.sql
:r .\Seeddata\SystemRole.sql
:r .\Seeddata\SystemUser.sql
:r .\Seeddata\ToolCategory.sql
:r .\Seeddata\Supply.sql
:r .\Seeddata\Tool.sql
:r .\Seeddata\PurchaseOrder.sql
:r .\Seeddata\ToolInventory.sql
:r .\Seeddata\ToolInventoryHistory.sql
print 'seeddata done'