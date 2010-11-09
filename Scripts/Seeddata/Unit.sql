SET IDENTITY_INSERT [dbo].[Unit] ON
INSERT [dbo].[Unit] ([UnitID], [Code], [Name], [Comment], [Deleted], [InternalCode], [ParentUnitID]) VALUES (1, N'1', N'部门', NULL, 0, N'1', NULL)
INSERT [dbo].[Unit] ([UnitID], [Code], [Name], [Comment], [Deleted], [InternalCode], [ParentUnitID]) VALUES (2, N'2', N'承包队', NULL, 0, N'2', NULL)
INSERT [dbo].[Unit] ([UnitID], [Code], [Name], [Comment], [Deleted], [InternalCode], [ParentUnitID]) VALUES (3, N'3', N'外部公司', NULL, 0, N'3', NULL)
SET IDENTITY_INSERT [dbo].[Unit] OFF
go
