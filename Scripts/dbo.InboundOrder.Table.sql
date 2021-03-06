/****** Object:  Table [dbo].[InboundOrder]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InboundOrder](
	[InboundOrderID] [int] IDENTITY(1000,1) NOT NULL,
	[InboundDate] [datetime2](7) NOT NULL,
	[OutboundOrderID] [int] NOT NULL,
	[Code] [varchar](20) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[LastUpdatedBy] [int] NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_InboundOrder] PRIMARY KEY CLUSTERED 
(
	[InboundOrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[InboundOrder]  WITH CHECK ADD  CONSTRAINT [FK_InboundOrder_OutboundOrder] FOREIGN KEY([OutboundOrderID])
REFERENCES [dbo].[OutboundOrder] ([OutboundOrderID])
GO
ALTER TABLE [dbo].[InboundOrder] CHECK CONSTRAINT [FK_InboundOrder_OutboundOrder]
GO
ALTER TABLE [dbo].[InboundOrder]  WITH CHECK ADD  CONSTRAINT [FK_InboundOrder_SystemUser] FOREIGN KEY([LastUpdatedBy])
REFERENCES [dbo].[SystemUser] ([SystemUserID])
GO
ALTER TABLE [dbo].[InboundOrder] CHECK CONSTRAINT [FK_InboundOrder_SystemUser]
GO
ALTER TABLE [dbo].[InboundOrder]  WITH CHECK ADD  CONSTRAINT [FK_InboundOrder_Unit] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
ALTER TABLE [dbo].[InboundOrder] CHECK CONSTRAINT [FK_InboundOrder_Unit]
GO
