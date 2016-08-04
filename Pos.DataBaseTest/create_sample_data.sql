SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([Id], [UserName], [Password], [Role], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (1, N'Admin','Admin','Admin','FALSE','0',GETDATE())
INSERT [dbo].[User] ([Id], [UserName], [Password], [Role], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (2, N'Supervisor','Supervisor','Supervisor','FALSE','0',GETDATE())
INSERT [dbo].[User] ([Id], [UserName], [Password], [Role], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (3, N'Staff','Staff','Staff','FALSE','0',GETDATE())
SET IDENTITY_INSERT [dbo].[User] OFF
GO