SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([Id], [UserName], [Password], [Role], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (1, N'Admin','f4OPh7E/lzPQVqQu+DrZkAemtwyZ3kW5Sy3WfalR/97+pzCdezLT+n4aEAsLWewrf4OPh7E/lzPQVqQu+DrZkAemtwyZ3kW5Sy3WfalR/94=','Admin','FALSE','0',GETDATE())
INSERT [dbo].[User] ([Id], [UserName], [Password], [Role], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (2, N'Supervisor','PUG8GOPhqfyPwLnpG2l8qozauTZoT1A/wOd2Gpv0at6SnbktHHAfahkltSl9HD+OPUG8GOPhqfyPwLnpG2l8qozauTZoT1A/wOd2Gpv0at4=','Supervisor','FALSE','0',GETDATE())
INSERT [dbo].[User] ([Id], [UserName], [Password], [Role], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (3, N'Staff','f4OPh7E/lzPQVqQu+DrZkAemtwyZ3kW5Sy3WfalR/97+pzCdezLT+n4aEAsLWewrf4OPh7E/lzPQVqQu+DrZkAemtwyZ3kW5Sy3WfalR/94=','Staff','FALSE','0',GETDATE())
INSERT [dbo].[User] ([Id], [UserName], [Password], [Role], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (4, N'NhanVien','32uS9BBanNMLwfyAEKWBEPH/dnZq75Lqaza1x34FsI7krjIq+8HM5iykGEz1Yd1h32uS9BBanNMLwfyAEKWBEPH/dnZq75Lqaza1x34FsI4=','Staff','FALSE','0',GETDATE())
INSERT [dbo].[User] ([Id], [UserName], [Password], [Role], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (5, N'ThanhHuong','soZEG7AnB9d7WDRJ1O4m4DuMWYbKyWKs49R0TT/Gft3x5RPrmE33HA0UsZ91G+B8soZEG7AnB9d7WDRJ1O4m4DuMWYbKyWKs49R0TT/Gft0=','Supervisor','FALSE','0',GETDATE())
SET IDENTITY_INSERT [dbo].[User] OFF
GO

SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT [dbo].[Customer] ([Id], [Name], [Phone], [Address], [TotalPurchase], [Purchase], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (1, N'Nguyễn Văn A','090896254','Phan Rang', 2000000, 2000000,'FALSE','0',GETDATE())
INSERT [dbo].[Customer] ([Id], [Name], [Phone], [Address], [TotalPurchase], [Purchase], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (2, N'Trương Đăng Khoa','0908961689','Phan Rang', 500000, 500000,'FALSE','0',GETDATE())
INSERT [dbo].[Customer] ([Id], [Name], [Phone], [Address], [TotalPurchase], [Purchase], [IsDeleted], [ChangedBy], [ChangedDate]) VALUES (3, N'Mỹ Oanh','0973112949','Phan Rang', 2000000, 2000000,'FALSE','0',GETDATE())
SET IDENTITY_INSERT [dbo].[User] OFF
GO