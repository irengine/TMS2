/****** Object:  Table [dbo].[ScrapOrderDetail]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ScrapOrderDetail](
	[ScrapOrderDetailID] [int] IDENTITY(1000,1) NOT NULL,
	[ScrapOrderID] [int] NOT NULL,
	[ScrapDate] [datetime2](7) NOT NULL,
	[OutboundOrderDetailID] [int] NULL,
	[ToolID] [int] NOT NULL,
	[PrescrapQuantity] [numeric](10, 2) NOT NULL,
	[Quantity] [numeric](10, 2) NOT NULL,
	[ScrapQuantity] [numeric](10, 2) NOT NULL,
	[ScrapReason] [varchar](50) NULL,
	[IsAbnormal] [bit] NOT NULL,
	[RepairingQuantity] [numeric](10, 2) NOT NULL,
	[UnitPrice] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_ScrapOrderDetail] PRIMARY KEY CLUSTERED 
(
	[ScrapOrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ScrapOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_ScrapOrderDetail_OutboundOrderDetail] FOREIGN KEY([OutboundOrderDetailID])
REFERENCES [dbo].[OutboundOrderDetail] ([OutboundOrderDetailID])
GO
ALTER TABLE [dbo].[ScrapOrderDetail] CHECK CONSTRAINT [FK_ScrapOrderDetail_OutboundOrderDetail]
GO
ALTER TABLE [dbo].[ScrapOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_ScrapOrderDetail_ScrapOrder] FOREIGN KEY([ScrapOrderID])
REFERENCES [dbo].[ScrapOrder] ([ScrapOrderID])
GO
ALTER TABLE [dbo].[ScrapOrderDetail] CHECK CONSTRAINT [FK_ScrapOrderDetail_ScrapOrder]
GO
ALTER TABLE [dbo].[ScrapOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_ScrapOrderDetail_Tool] FOREIGN KEY([ToolID])
REFERENCES [dbo].[Tool] ([ToolID])
GO
ALTER TABLE [dbo].[ScrapOrderDetail] CHECK CONSTRAINT [FK_ScrapOrderDetail_Tool]
GO
ALTER TABLE [dbo].[ScrapOrderDetail] ADD  CONSTRAINT [DF_ScrapOrderDetail_PrescrapQuantity]  DEFAULT ((0)) FOR [PrescrapQuantity]
GO
ALTER TABLE [dbo].[ScrapOrderDetail] ADD  CONSTRAINT [DF_ScrapOrderDetail_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[ScrapOrderDetail] ADD  CONSTRAINT [DF_ScrapOrderDetail_ScrapQuantity]  DEFAULT ((0)) FOR [ScrapQuantity]
GO
ALTER TABLE [dbo].[ScrapOrderDetail] ADD  CONSTRAINT [DF_ScrapOrderDetail_IsAbnormal]  DEFAULT ((0)) FOR [IsAbnormal]
GO
ALTER TABLE [dbo].[ScrapOrderDetail] ADD  CONSTRAINT [DF_ScrapOrderDetail_RepairingQuantity]  DEFAULT ((0)) FOR [RepairingQuantity]
GO
ALTER TABLE [dbo].[ScrapOrderDetail] ADD  CONSTRAINT [DF_ScrapOrderDetail_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
