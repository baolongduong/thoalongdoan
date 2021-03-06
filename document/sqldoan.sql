CREATE DATABASE VIECLAM
Go

USE [VIECLAM]
GO
/****** Object:  Table [dbo].[UngVien]    Script Date: 04/20/2021 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UngVien](
	[MaUngVien] [bigint] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[MatKhau] [nvarchar](255) NOT NULL,
	[CMND] [varchar](12) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[SDT] [varchar](10) NOT NULL,
	[ThanhPhoSinhSong] [bigint] NOT NULL,
	[QuanHuyenSinhSong] [bigint] NOT NULL,
	[DiaChiChiTiet] [nvarchar](255) NOT NULL,
	[FileCV] [nvarchar](255) NULL,
	[AnhDaiDien] [varchar](255) NULL,
 CONSTRAINT [PK__UngVien__8FDBA8A90AD2A005] PRIMARY KEY CLUSTERED 
(
	[MaUngVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UngVien] ON
INSERT [dbo].[UngVien] ([MaUngVien], [Email], [MatKhau], [CMND], [HoTen], [SDT], [ThanhPhoSinhSong], [QuanHuyenSinhSong], [DiaChiChiTiet], [FileCV], [AnhDaiDien]) VALUES (1, N'baolongsbs@gmail.com', N'blong123', N'000011112222', N'Dương Bảo Long', N'0906194433', 70000, 3, N'513/36 ĐBP', NULL, NULL)
INSERT [dbo].[UngVien] ([MaUngVien], [Email], [MatKhau], [CMND], [HoTen], [SDT], [ThanhPhoSinhSong], [QuanHuyenSinhSong], [DiaChiChiTiet], [FileCV], [AnhDaiDien]) VALUES (2, N'thoalk@gmail.com', N'thoalk123', N'000011113333', N'Lê Kim Thoa', N'0908194433', 70000, 15, N'65 Phan Đăng Lưu', NULL, NULL)
SET IDENTITY_INSERT [dbo].[UngVien] OFF
/****** Object:  Table [dbo].[NhaTuyenDung]    Script Date: 04/20/2021 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaTuyenDung](
	[MaNhaTuyenDung] [bigint] NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[MatKhau] [nvarchar](255) NOT NULL,
	[TenCongTy] [nvarchar](255) NOT NULL,
	[SDT] [char](12) NOT NULL,
	[MaSoThue] [char](12) NULL,
	[ThanhPhoHoatDong] [bigint] NOT NULL,
	[QuanHuyenHoatDong] [bigint] NOT NULL,
	[DiaChiHoatDong] [nvarchar](255) NOT NULL,
	[AnhDaiDien] [image] NULL,
	[MaNghe] [bigint] NOT NULL,
	[MoTaCongTy] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaTuyenDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhaTuyenDung] ([MaNhaTuyenDung], [Email], [MatKhau], [TenCongTy], [SDT], [MaSoThue], [ThanhPhoHoatDong], [QuanHuyenHoatDong], [DiaChiHoatDong], [AnhDaiDien], [MaNghe], [MoTaCongTy]) VALUES (901, N'itcorp@gmail.com', N'itcorp', N'IT Corp', N'7802886655  ', N'777777777777', 70000, 1, N'6A Nguyễn Huệ', NULL, 102, NULL)
INSERT [dbo].[NhaTuyenDung] ([MaNhaTuyenDung], [Email], [MatKhau], [TenCongTy], [SDT], [MaSoThue], [ThanhPhoHoatDong], [QuanHuyenHoatDong], [DiaChiHoatDong], [AnhDaiDien], [MaNghe], [MoTaCongTy]) VALUES (902, N'bbfront@gmail.com', N'bbfrontt', N'BB Front End Corp', N'9803224455  ', N'888888888888', 70000, 3, N'72 Nguyễn Đình Chiểu', NULL, 102, NULL)
INSERT [dbo].[NhaTuyenDung] ([MaNhaTuyenDung], [Email], [MatKhau], [TenCongTy], [SDT], [MaSoThue], [ThanhPhoHoatDong], [QuanHuyenHoatDong], [DiaChiHoatDong], [AnhDaiDien], [MaNghe], [MoTaCongTy]) VALUES (903, N'various@gmail.com', N'variousmm', N'Various Corp', N'8000070000  ', N'444444444444', 70000, 5, N'172 Nguyễn Trãi', NULL, 105, NULL)
/****** Object:  Table [dbo].[ThongTinDiaDiem]    Script Date: 04/20/2021 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinDiaDiem](
	[MaThanhPho] [bigint] NOT NULL,
	[MaQuanHuyen] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThanhPho] ASC,
	[MaQuanHuyen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ThongTinDiaDiem] ([MaThanhPho], [MaQuanHuyen]) VALUES (70000, 1)
INSERT [dbo].[ThongTinDiaDiem] ([MaThanhPho], [MaQuanHuyen]) VALUES (70000, 2)
INSERT [dbo].[ThongTinDiaDiem] ([MaThanhPho], [MaQuanHuyen]) VALUES (70000, 3)
INSERT [dbo].[ThongTinDiaDiem] ([MaThanhPho], [MaQuanHuyen]) VALUES (70000, 4)
INSERT [dbo].[ThongTinDiaDiem] ([MaThanhPho], [MaQuanHuyen]) VALUES (70000, 5)
/****** Object:  Table [dbo].[ThongTinNganhNghe]    Script Date: 04/20/2021 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinNganhNghe](
	[MaNghe] [bigint] NOT NULL,
	[TenNghe] [nvarchar](50) NULL,
	[LinhVuc] [bigint] NULL,
	[MaThanhPho] [bigint] NOT NULL,
	[MaQuanHuyen] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNghe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ThongTinNganhNghe] ([MaNghe], [TenNghe], [LinhVuc], [MaThanhPho], [MaQuanHuyen]) VALUES (101, N'Kế Toán', 1, 70000, 1)
INSERT [dbo].[ThongTinNganhNghe] ([MaNghe], [TenNghe], [LinhVuc], [MaThanhPho], [MaQuanHuyen]) VALUES (102, N'Lập Trình Web', 2, 70000, 1)
INSERT [dbo].[ThongTinNganhNghe] ([MaNghe], [TenNghe], [LinhVuc], [MaThanhPho], [MaQuanHuyen]) VALUES (103, N'Y Tá', 3, 70000, 5)
INSERT [dbo].[ThongTinNganhNghe] ([MaNghe], [TenNghe], [LinhVuc], [MaThanhPho], [MaQuanHuyen]) VALUES (104, N'Kỹ sư', 4, 70000, 4)
INSERT [dbo].[ThongTinNganhNghe] ([MaNghe], [TenNghe], [LinhVuc], [MaThanhPho], [MaQuanHuyen]) VALUES (105, N'Tư vấn viên', 5, 70000, 1)
/****** Object:  Table [dbo].[PhanHoi]    Script Date: 04/20/2021 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanHoi](
	[MaPhanHoi] [bigint] NOT NULL,
	[NoiDungPhanHoi] [nvarchar](255) NOT NULL,
	[TinhTrang] [bigint] NOT NULL,
	[MaUngVien] [bigint] NOT NULL,
	[MaCongTy] [bigint] NOT NULL,
	[NgayPhanHoi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhanHoi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blog]    Script Date: 04/20/2021 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blog](
	[MaBlog] [bigint] NOT NULL,
	[LinhVucBlog] [bigint] NULL,
	[MaNghe] [bigint] NOT NULL,
	[TenBlog] [nvarchar](50) NOT NULL,
	[NoiDungBlog] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBlog] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Blog] ([MaBlog], [LinhVucBlog], [MaNghe], [TenBlog], [NoiDungBlog]) VALUES (201, 1, 102, N'Nỗi khổ IT', N'Cập nhật')
INSERT [dbo].[Blog] ([MaBlog], [LinhVucBlog], [MaNghe], [TenBlog], [NoiDungBlog]) VALUES (202, 1, 102, N'Hacker là ai?', N'Chưa cập nhật')
/****** Object:  Table [dbo].[TinTuyenDung]    Script Date: 04/20/2021 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TinTuyenDung](
	[MaTinTuyenDung] [bigint] NOT NULL,
	[MaCongTy] [bigint] NOT NULL,
	[ViTriTuyenDung] [nvarchar](50) NOT NULL,
	[HoSoYeuCau] [nvarchar](255) NOT NULL,
	[MoTaCongViec] [nvarchar](255) NOT NULL,
	[QuyenLoi] [nvarchar](255) NOT NULL,
	[SoLuongTuyen] [bigint] NOT NULL,
	[MucLuong] [numeric](18, 0) NOT NULL,
	[NgayDang] [timestamp] NOT NULL,
	[NgayHetHan] [datetime] NULL,
	[MaNganhNghe] [bigint] NULL,
	[hinhanh] [varchar](50) NULL,
	[tieude] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTinTuyenDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TinTuyenDung] ([MaTinTuyenDung], [MaCongTy], [ViTriTuyenDung], [HoSoYeuCau], [MoTaCongViec], [QuyenLoi], [SoLuongTuyen], [MucLuong], [NgayHetHan], [MaNganhNghe], [hinhanh], [tieude]) VALUES (1001, 901, N'C# Developer', N'CV và GSK', N'Viết C# Application', N'Lương tháng 13, BHXH đủ', 20, CAST(20000000 AS Numeric(18, 0)), NULL, NULL, N'1.png', N'C# Developer')
INSERT [dbo].[TinTuyenDung] ([MaTinTuyenDung], [MaCongTy], [ViTriTuyenDung], [HoSoYeuCau], [MoTaCongViec], [QuyenLoi], [SoLuongTuyen], [MucLuong], [NgayHetHan], [MaNganhNghe], [hinhanh], [tieude]) VALUES (1002, 902, N'Front End Developer', N'CV và GSK', N'Làm giao diện app', N'Lương tháng 13, Phụ cấp đủ', 1, CAST(70000000 AS Numeric(18, 0)), NULL, NULL, N'2.jpg', N'Front End Developer')
/****** Object:  Table [dbo].[UngVienDangKy]    Script Date: 04/20/2021 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UngVienDangKy](
	[MaDangKy] [bigint] NOT NULL,
	[MaUngVien] [bigint] NOT NULL,
	[TinhTrangUngVien] [bigint] NOT NULL,
	[MaTinTuyenDung] [bigint] NULL,
	[NgayDangky] [date] NULL,
 CONSTRAINT [PK_UngVienDangKy] PRIMARY KEY CLUSTERED 
(
	[MaDangKy] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[UngVienDangKy] ([MaDangKy], [MaUngVien], [TinhTrangUngVien], [MaTinTuyenDung], [NgayDangky]) VALUES (1001, 2, 1, NULL, NULL)
INSERT [dbo].[UngVienDangKy] ([MaDangKy], [MaUngVien], [TinhTrangUngVien], [MaTinTuyenDung], [NgayDangky]) VALUES (1002, 1, 0, NULL, NULL)
/****** Object:  ForeignKey [FK__Blog__MaNghe__1B0907CE]    Script Date: 04/20/2021 13:49:20 ******/
ALTER TABLE [dbo].[Blog]  WITH CHECK ADD FOREIGN KEY([MaNghe])
REFERENCES [dbo].[ThongTinNganhNghe] ([MaNghe])
GO
/****** Object:  ForeignKey [FK__PhanHoi__MaCongT__1920BF5C]    Script Date: 04/20/2021 13:49:20 ******/
ALTER TABLE [dbo].[PhanHoi]  WITH CHECK ADD FOREIGN KEY([MaCongTy])
REFERENCES [dbo].[NhaTuyenDung] ([MaNhaTuyenDung])
GO
/****** Object:  ForeignKey [FK__PhanHoi__MaUngVi__1FCDBCEB]    Script Date: 04/20/2021 13:49:20 ******/
ALTER TABLE [dbo].[PhanHoi]  WITH CHECK ADD  CONSTRAINT [FK__PhanHoi__MaUngVi__1FCDBCEB] FOREIGN KEY([MaUngVien])
REFERENCES [dbo].[UngVien] ([MaUngVien])
GO
ALTER TABLE [dbo].[PhanHoi] CHECK CONSTRAINT [FK__PhanHoi__MaUngVi__1FCDBCEB]
GO
/****** Object:  ForeignKey [FK_ThongTinNganhNghe_ThongTinDiaDiem]    Script Date: 04/20/2021 13:49:20 ******/
ALTER TABLE [dbo].[ThongTinNganhNghe]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinNganhNghe_ThongTinDiaDiem] FOREIGN KEY([MaThanhPho], [MaQuanHuyen])
REFERENCES [dbo].[ThongTinDiaDiem] ([MaThanhPho], [MaQuanHuyen])
GO
ALTER TABLE [dbo].[ThongTinNganhNghe] CHECK CONSTRAINT [FK_ThongTinNganhNghe_ThongTinDiaDiem]
GO
/****** Object:  ForeignKey [FK__TinTuyenD__MaCon__1BFD2C07]    Script Date: 04/20/2021 13:49:20 ******/
ALTER TABLE [dbo].[TinTuyenDung]  WITH CHECK ADD FOREIGN KEY([MaCongTy])
REFERENCES [dbo].[NhaTuyenDung] ([MaNhaTuyenDung])
GO
/****** Object:  ForeignKey [FK_TinTuyenDung_ThongTinNganhNghe]    Script Date: 04/20/2021 13:49:20 ******/
ALTER TABLE [dbo].[TinTuyenDung]  WITH CHECK ADD  CONSTRAINT [FK_TinTuyenDung_ThongTinNganhNghe] FOREIGN KEY([MaNganhNghe])
REFERENCES [dbo].[ThongTinNganhNghe] ([MaNghe])
GO
ALTER TABLE [dbo].[TinTuyenDung] CHECK CONSTRAINT [FK_TinTuyenDung_ThongTinNganhNghe]
GO
/****** Object:  ForeignKey [FK__UngVienDa__MaUng__276EDEB3]    Script Date: 04/20/2021 13:49:20 ******/
ALTER TABLE [dbo].[UngVienDangKy]  WITH CHECK ADD  CONSTRAINT [FK__UngVienDa__MaUng__276EDEB3] FOREIGN KEY([MaUngVien])
REFERENCES [dbo].[UngVien] ([MaUngVien])
GO
ALTER TABLE [dbo].[UngVienDangKy] CHECK CONSTRAINT [FK__UngVienDa__MaUng__276EDEB3]
GO
/****** Object:  ForeignKey [FK_UngVienDangKy_TinTuyenDung]    Script Date: 04/20/2021 13:49:20 ******/
ALTER TABLE [dbo].[UngVienDangKy]  WITH CHECK ADD  CONSTRAINT [FK_UngVienDangKy_TinTuyenDung] FOREIGN KEY([MaTinTuyenDung])
REFERENCES [dbo].[TinTuyenDung] ([MaTinTuyenDung])
GO
ALTER TABLE [dbo].[UngVienDangKy] CHECK CONSTRAINT [FK_UngVienDangKy_TinTuyenDung]
GO
