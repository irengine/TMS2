/****** Object:  Table [dbo].[InboundOrderDetail]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InboundOrderDetail](
	[InboundOrderDetailID] [int] IDENTITY(1000,1) NOT NULL,
	[InboundOrderID] [int] NOT NULL,
	[InboundDate] [datetime2](7) NOT NULL,
	[OutboundOrderDetailID] [int] NOT NULL,
	[ToolID] [int] NOT NULL,
	[Quantity] [numeric](10, 2) NOT NULL,
	[PrescrapQuantity] [numeric](10, 2) NOT NULL,
	[ScrapReason] [nvarchar](20) NULL,
	[TransferQuantity] [numeric](10, 2) NOT NULL,
	[UnitPrice] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_InboundOrderDetail] PRIMARY KEY CLUSTERED 
(
	[InboundOrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InboundOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_InboundOrderDetail_InboundOrder] FOREIGN KEY([InboundOrderID])
REFERENCES [dbo].[InboundOrder] ([InboundOrderID])
GO
ALTER TABLE [dbo].[InboundOrderDetail] CHECK CONSTRAINT [FK_InboundOrderDetail_InboundOrder]
GO
ALTER TABLE [dbo].[InboundOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_InboundOrderDetail_InboundOrderDetail] FOREIGN KEY([OutboundOrderDetailID])
REFERENCES [dbo].[OutboundOrderDetail] ([OutboundOrderDetailID])
GO
ALTER TABLE [dbo].[InboundOrderDetail] CHECK CONSTRAINT [FK_InboundOrderDetail_InboundOrderDetail]
GO
ALTER TABLE [dbo].[InboundOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_InboundOrderDetail_Tool] FOREIGN KEY([ToolID])
REFERENCES [dbo].[Tool] ([ToolID])
GO
ALTER TABLE [dbo].[InboundOrderDetail] CHECK CONSTRAINT [FK_InboundOrderDetail_Tool]
GO
ALTER TABLE [dbo].[InboundOrderDetail] ADD  CONSTRAINT [DF_InboundOrderDetail_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[InboundOrderDetail] ADD  CONSTRAINT [DF_InboundOrderDetail_PrescrapQuantity]  DEFAULT ((0)) FOR [PrescrapQuantity]
GO
ALTER TABLE [dbo].[InboundOrderDetail] ADD  CONSTRAINT [DF_InboundOrderDetail_TransferQuantity]  DEFAULT ((0)) FOR [TransferQuantity]
GO
ALTER TABLE [dbo].[InboundOrderDetail] ADD  CONSTRAINT [DF_InboundOrderDetail_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
