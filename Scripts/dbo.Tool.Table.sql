/****** Object:  Table [dbo].[Tool]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tool](
	[ToolID] [int] IDENTITY(1000,1) NOT NULL,
	[Code] [varchar](20) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Diameter] [varchar](20) NULL,
	[Length] [varchar](20) NULL,
	[Load2] [varchar](20) NULL,
	[Description] [varchar](20) NULL,
	[Dimensions] [varchar](50) NOT NULL,
	[Unit] [varchar](10) NOT NULL,
	[RatedQuantity] [numeric](10, 2) NOT NULL,
	[Comment] [nvarchar](4000) NULL,
	[Deleted] [bit] NOT NULL,
	[ToolCategoryID] [int] NOT NULL,
 CONSTRAINT [PK_Tool] PRIMARY KEY CLUSTERED 
(
	[ToolID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Tool]  WITH CHECK ADD  CONSTRAINT [FK_Tool_ToolCategory] FOREIGN KEY([ToolCategoryID])
REFERENCES [dbo].[ToolCategory] ([ToolCategoryID])
GO
ALTER TABLE [dbo].[Tool] CHECK CONSTRAINT [FK_Tool_ToolCategory]
GO
ALTER TABLE [dbo].[Tool] ADD  CONSTRAINT [DF_Tool_RatedQuantity]  DEFAULT ((0)) FOR [RatedQuantity]
GO
ALTER TABLE [dbo].[Tool] ADD  CONSTRAINT [DF_Tool_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
