/****** Object:  Table [dbo].[Supply]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supply](
	[SupplyID] [int] IDENTITY(1000,1) NOT NULL,
	[Code] [varchar](20) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Comment] [nvarchar](400) NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Supply] PRIMARY KEY CLUSTERED 
(
	[SupplyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Supply] ADD  CONSTRAINT [DF_Supply_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
