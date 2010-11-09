SET IDENTITY_INSERT [dbo].[SystemUser] ON
INSERT [dbo].[SystemUser] ([SystemUserID], [Code], [Name], [Password], [Roles], [Deleted]) VALUES (1, N'sysAdmin', N'系统管理员', N'P@ssword', N'1', 0)
SET IDENTITY_INSERT [dbo].[SystemUser] OFF
