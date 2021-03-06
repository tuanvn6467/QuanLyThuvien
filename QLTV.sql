USE [master]
GO
/****** Object:  Database [QLTV1]    Script Date: 8/8/2016 9:16:15 AM ******/
CREATE DATABASE [QLTV1]
GO
USE [QLTV1]
GO
/****** Object:  Table [dbo].[CapNhatSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CapNhatSach](
	[So_Phieu] [nchar](16) NOT NULL,
	[Ma_Sach] [nchar](16) NOT NULL,
	[So_Luong] [int] NULL,
	[Don_Gia] [real] NULL,
	[Thanh_Tien] [real] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTCapNhatSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTCapNhatSach](
	[So_Phieu] [nchar](16) NOT NULL,
	[Ngay_Lap] [smalldatetime] NULL,
	[Ma_NV] [nchar](16) NULL,
	[Ma_NhaCC] [nchar](16) NULL,
	[Ghi_Chu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CTCapNhatSach] PRIMARY KEY CLUSTERED 
(
	[So_Phieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTMuonTra]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTMuonTra](
	[So_Phieu] [nchar](16) NOT NULL DEFAULT (''),
	[Ma_NV] [nchar](16) NULL,
	[Ngay_Lap] [smalldatetime] NULL,
	[Ma_DocGia] [nchar](16) NULL,
	[Ngay_Muon] [smalldatetime] NULL,
	[Ngay_TraDuKien] [smalldatetime] NULL,
	[Ghi_Chu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CTMuonTra] PRIMARY KEY CLUSTERED 
(
	[So_Phieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[Ma_LoaiSach] [nchar](16) NOT NULL DEFAULT (''),
	[Ten_LoaiSach] [nvarchar](64) NOT NULL DEFAULT (''),
 CONSTRAINT [PK_Ma_LoaiSach] PRIMARY KEY CLUSTERED 
(
	[Ma_LoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LstDocGia]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LstDocGia](
	[Ma_DocGia] [nchar](16) NOT NULL DEFAULT (''),
	[Ten_DocGia] [nvarchar](64) NOT NULL DEFAULT (''),
	[Dia_Chi] [nvarchar](128) NULL DEFAULT (''),
	[So_DienThoai] [varchar](16) NULL,
	[Ngay_Sinh] [smalldatetime] NULL,
	[Ngay_Lap] [smalldatetime] NULL,
	[Ngay_HetHan] [smalldatetime] NULL,
 CONSTRAINT [PK_lstDocGia] PRIMARY KEY CLUSTERED 
(
	[Ma_DocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LstNhaCC]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LstNhaCC](
	[Ma_NhaCC] [nchar](16) NOT NULL,
	[Ten_NhaCC] [nvarchar](64) NOT NULL,
	[Dia_Chi] [nvarchar](128) NULL,
	[Sdt] [text] NULL,
 CONSTRAINT [PK_lstNhaCC] PRIMARY KEY CLUSTERED 
(
	[Ma_NhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LstNhanVien]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LstNhanVien](
	[Ma_NV] [nchar](16) NOT NULL,
	[Ten_NV] [nvarchar](50) NOT NULL,
	[Chuc_Vu] [nvarchar](64) NOT NULL,
	[Mat_Khau] [nvarchar](50) NOT NULL,
	[Quyen] [nvarchar](50) NOT NULL,
	[Dien_Thoai] [nchar](16) NULL,
	[Dia_Chi] [nvarchar](50) NULL,
 CONSTRAINT [PK_lstNhanVien] PRIMARY KEY CLUSTERED 
(
	[Ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LstNhaXuatBan]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LstNhaXuatBan](
	[Ma_NhaXuatBan] [nchar](16) NOT NULL DEFAULT (''),
	[Ten_NhaXuatBan] [nvarchar](64) NOT NULL DEFAULT (''),
	[Dia_Chi] [nvarchar](128) NULL DEFAULT (''),
 CONSTRAINT [PK_lstNhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[Ma_NhaXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LstSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LstSach](
	[Ma_Sach] [nchar](16) NOT NULL CONSTRAINT [DF__LstSach__Ma_Sach__47DBAE45]  DEFAULT (''),
	[Ten_Sach] [nvarchar](64) NOT NULL CONSTRAINT [DF__LstSach__Ten_Sac__48CFD27E]  DEFAULT (''),
	[So_Trang] [nvarchar](128) NULL CONSTRAINT [DF__LstSach__So_Tran__49C3F6B7]  DEFAULT (''),
	[Ma_NhaXuatBan] [nchar](16) NOT NULL,
	[Ma_TacGia] [nchar](16) NOT NULL,
	[Ma_LoaiSach] [nchar](16) NOT NULL,
	[Ton_Kho] [int] NULL,
 CONSTRAINT [PK_MaSach] PRIMARY KEY CLUSTERED 
(
	[Ma_Sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LstTacGia]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LstTacGia](
	[Ma_TacGia] [nchar](16) NOT NULL DEFAULT (''),
	[Ten_TacGia] [nvarchar](64) NOT NULL DEFAULT (''),
	[Dia_Chi] [nvarchar](128) NULL DEFAULT (''),
	[Ngay_Sinh] [smalldatetime] NULL,
 CONSTRAINT [PK_lstTacGia] PRIMARY KEY CLUSTERED 
(
	[Ma_TacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MuonTra]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonTra](
	[So_Phieu] [nchar](16) NOT NULL,
	[Ma_Sach] [nchar](16) NOT NULL,
	[So_Luong] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[uSyRelation]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uSyRelation](
	[List_Tables] [nchar](16) NOT NULL,
	[Primary_Key] [nchar](16) NOT NULL,
	[Data_Tables] [nchar](16) NOT NULL,
	[Foreign_Key] [nchar](16) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ThongKeSachMuon]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[ThongKeSachMuon]
as

  select 
  ctmt.Ma_DocGia, 
  dg.Ten_DocGia,
  mt.Ma_Sach, 
  ls.Ten_Sach, 
  mt.So_Luong,
  ctmt.Ngay_Muon,
  ctmt.Ngay_TraDuKien,
  ctmt.Ngay_Lap
  --soluongdatra
  --ngaytra
  --soluongchuatra
  --ngayquahan
       
  from 
  CTMuonTra ctmt 
  left join LstDocGia dg on dg.Ma_DocGia = ctmt.Ma_DocGia 
  left join MuonTra mt on mt.So_Phieu = ctmt.So_Phieu 
  left join LstSach ls on ls.Ma_Sach = mt.Ma_Sach 
  where ctmt.So_Phieu like 'PM%'
GO
/****** Object:  View [dbo].[ThongKeSachTra]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[ThongKeSachTra]
as

  select 
  ctmt.Ma_DocGia, 
  dg.Ten_DocGia,
  mt.Ma_Sach, 
  ls.Ten_Sach, 
  mt.So_Luong,
  ctmt.Ngay_Muon,
  ctmt.Ngay_TraDuKien,
  ctmt.Ngay_Lap
  --soluongdatra
  --ngaytra
  --soluongchuatra
  --ngayquahan
       
  from 
  CTMuonTra ctmt 
  left join LstDocGia dg on dg.Ma_DocGia = ctmt.Ma_DocGia 
  left join MuonTra mt on mt.So_Phieu = ctmt.So_Phieu 
  left join LstSach ls on ls.Ma_Sach = mt.Ma_Sach 
  where ctmt.So_Phieu like 'PT%'
GO
/****** Object:  View [dbo].[ViewNhanVien]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewNhanVien]
AS
SELECT        Mat_Khau, Quyen, Ten_NV
FROM            dbo.LstNhanVien

GO
/****** Object:  View [dbo].[ViewSelectLstSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewSelectLstSach]
AS
SELECT        dbo.LstSach.Ma_Sach, dbo.LstSach.Ten_Sach, dbo.LstSach.So_Trang, dbo.LstNhaXuatBan.Ten_NhaXuatBan, dbo.LstTacGia.Ten_TacGia, dbo.LoaiSach.Ten_LoaiSach
FROM            dbo.LstTacGia INNER JOIN
                         dbo.LstSach ON dbo.LstTacGia.Ma_TacGia = dbo.LstSach.Ma_TacGia INNER JOIN
                         dbo.LstNhaXuatBan ON dbo.LstSach.Ma_NhaXuatBan = dbo.LstNhaXuatBan.Ma_NhaXuatBan INNER JOIN
                         dbo.LoaiSach ON dbo.LstSach.Ma_LoaiSach = dbo.LoaiSach.Ma_LoaiSach

GO
/****** Object:  View [dbo].[ViewSelectSach]    Script Date: 8/8/2016 9:16:15 AM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE VIEW [dbo].[ViewSelectSach]
--AS
--SELECT        dbo.CTCapNhatSach.So_Phieu, dbo.LstSach.Ten_Sach, dbo.CTCapNhatSach.Ngay_Lap, dbo.CTCapNhatSach.So_Luong, dbo.LstNhaCC.Ten_NhaCC, dbo.CTCapNhatSach.Ghi_Chu, dbo.LstNhanVien.Ten_NV
--FROM            dbo.CTCapNhatSach INNER JOIN
--                         dbo.LstSach ON dbo.CTCapNhatSach.Ma_Sach = dbo.LstSach.Ma_Sach INNER JOIN
--                         dbo.LstNhaCC ON dbo.CTCapNhatSach.Ma_NhaCC = dbo.LstNhaCC.Ma_NhaCC INNER JOIN
--                         dbo.LstNhanVien ON dbo.CTCapNhatSach.Ma_NV = dbo.LstNhanVien.Ma_NV

--GO
INSERT [dbo].[CTCapNhatSach] ([So_Phieu], [Ngay_Lap], [Ma_NV], [Ma_NhaCC], [Ghi_Chu]) VALUES (N'SP0002          ', CAST(N'2016-01-06 00:00:00' AS SmallDateTime), N'NV0001          ', N'NCCCPI          ', NULL)
GO
INSERT [dbo].[CTCapNhatSach] ([So_Phieu], [Ngay_Lap], [Ma_NV], [Ma_NhaCC], [Ghi_Chu]) VALUES (N'SP0003          ', CAST(N'2016-04-03 00:00:00' AS SmallDateTime), N'NV0001          ', N'NCCCPI          ', NULL)
GO
INSERT [dbo].[CTMuonTra] ([So_Phieu], [Ma_NV], [Ngay_Lap], [Ma_DocGia], [Ngay_Muon], [Ngay_TraDuKien], [Ghi_Chu]) VALUES (N'PM002           ', N'NV0001          ', CAST(N'2016-07-04 00:00:00' AS SmallDateTime), N'HS00003         ', CAST(N'2016-07-04 00:00:00' AS SmallDateTime), CAST(N'2016-07-06 00:00:00' AS SmallDateTime), N'')
GO
INSERT [dbo].[CTMuonTra] ([So_Phieu], [Ma_NV], [Ngay_Lap], [Ma_DocGia], [Ngay_Muon], [Ngay_TraDuKien], [Ghi_Chu]) VALUES (N'PM003           ', N'NV0002		        ', CAST(N'2016-08-07 22:17:00' AS SmallDateTime), N'HS00002         ', CAST(N'2016-08-07 22:17:00' AS SmallDateTime), CAST(N'2016-08-07 22:17:00' AS SmallDateTime), N'')
GO
INSERT [dbo].[CTMuonTra] ([So_Phieu], [Ma_NV], [Ngay_Lap], [Ma_DocGia], [Ngay_Muon], [Ngay_TraDuKien], [Ghi_Chu]) VALUES (N'PT001           ', N'NV0001          ', CAST(N'2016-07-06 00:00:00' AS SmallDateTime), N'HS00003         ', CAST(N'2016-07-04 00:00:00' AS SmallDateTime), CAST(N'2016-07-06 00:00:00' AS SmallDateTime), N'gia sach')
GO
INSERT [dbo].[LoaiSach] ([Ma_LoaiSach], [Ten_LoaiSach]) VALUES (N'G1.KT           ', N'Kế toán')
GO
INSERT [dbo].[LoaiSach] ([Ma_LoaiSach], [Ten_LoaiSach]) VALUES (N'G2.TC           ', N'Tài chính')
GO
INSERT [dbo].[LoaiSach] ([Ma_LoaiSach], [Ten_LoaiSach]) VALUES (N'G3.QT           ', N'Quản trị')
GO
INSERT [dbo].[LoaiSach] ([Ma_LoaiSach], [Ten_LoaiSach]) VALUES (N'G4.LLCT         ', N'Lý luận chính trị')
GO
INSERT [dbo].[LoaiSach] ([Ma_LoaiSach], [Ten_LoaiSach]) VALUES (N'G5.THNN         ', N'Tin học ngoại ngữ')
GO
INSERT [dbo].[LoaiSach] ([Ma_LoaiSach], [Ten_LoaiSach]) VALUES (N'G6.L            ', N'Luật kế toán tài chính')
GO
INSERT [dbo].[LoaiSach] ([Ma_LoaiSach], [Ten_LoaiSach]) VALUES (N'G7.PL           ', N'Pháp luật')
GO
INSERT [dbo].[LoaiSach] ([Ma_LoaiSach], [Ten_LoaiSach]) VALUES (N'G8.VH           ', N'Văn học tổng loại')
GO
INSERT [dbo].[LstDocGia] ([Ma_DocGia], [Ten_DocGia], [Dia_Chi], [So_DienThoai], [Ngay_Sinh], [Ngay_Lap], [Ngay_HetHan]) VALUES (N'HS00000100000000', N'Đào Hồng Hạnh', N'Yên Viên, Gia Lâm, Hà Nội', N'01698081353', CAST(N'1995-08-05 00:00:00' AS SmallDateTime), CAST(N'2016-07-07 00:00:00' AS SmallDateTime), CAST(N'2017-07-07 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstDocGia] ([Ma_DocGia], [Ten_DocGia], [Dia_Chi], [So_DienThoai], [Ngay_Sinh], [Ngay_Lap], [Ngay_HetHan]) VALUES (N'HS00002         ', N'Lương Việt Cường', N'Văn Lâm, Hưng Yên', N'01678123654', CAST(N'1995-09-06 00:00:00' AS SmallDateTime), CAST(N'2016-05-06 00:00:00' AS SmallDateTime), CAST(N'2017-05-06 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstDocGia] ([Ma_DocGia], [Ten_DocGia], [Dia_Chi], [So_DienThoai], [Ngay_Sinh], [Ngay_Lap], [Ngay_HetHan]) VALUES (N'HS00003         ', N'Nguyễn Thị Huế', N'Vĩnh Bảo, Hải Phòng', N'0987275432', CAST(N'1995-04-12 00:00:00' AS SmallDateTime), CAST(N'2016-08-12 00:00:00' AS SmallDateTime), CAST(N'2017-08-12 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstDocGia] ([Ma_DocGia], [Ten_DocGia], [Dia_Chi], [So_DienThoai], [Ngay_Sinh], [Ngay_Lap], [Ngay_HetHan]) VALUES (N'HS00004         ', N'Dương Quang Sơn', N'Văn Lâm, Hưng Yên', N'0963862942', CAST(N'1995-01-02 00:00:00' AS SmallDateTime), CAST(N'2016-01-04 00:00:00' AS SmallDateTime), CAST(N'2017-01-04 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstDocGia] ([Ma_DocGia], [Ten_DocGia], [Dia_Chi], [So_DienThoai], [Ngay_Sinh], [Ngay_Lap], [Ngay_HetHan]) VALUES (N'HS00005         ', N' Lê Thị Tuyết Mai', N'Khu đô thị Ecopark Văn Lâm', N'0167143736', CAST(N'1995-01-09 00:00:00' AS SmallDateTime), CAST(N'2016-11-15 00:00:00' AS SmallDateTime), CAST(N'2017-11-15 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstNhaCC] ([Ma_NhaCC], [Ten_NhaCC], [Dia_Chi], [Sdt]) VALUES (N'NCCCPI          ', N'Công ty Cổ phần In Hà Nội', N'Lô 6B- CN5 cụm công nghiệp Ngọc Hồi, Thanh Trì, Hà Nội', NULL)
GO
INSERT [dbo].[LstNhaCC] ([Ma_NhaCC], [Ten_NhaCC], [Dia_Chi], [Sdt]) VALUES (N'NCCICĐ          ', N'Công ty CP In Công Đoàn Việt Nam', N'167 Tây Sơn, Quang Trung, Đống Đa, Hà Nội', NULL)
GO
INSERT [dbo].[LstNhaCC] ([Ma_NhaCC], [Ten_NhaCC], [Dia_Chi], [Sdt]) VALUES (N'NCCIPN          ', N'Công ty In Phương Nam', N'160/12 Đội Cung, Q.11, TPHCM', NULL)
GO
INSERT [dbo].[LstNhaCC] ([Ma_NhaCC], [Ten_NhaCC], [Dia_Chi], [Sdt]) VALUES (N'NCCIVĐ          ', N'Công ty In Viễn Đông', N'Km19+400, Giai Phạm, Yên Mỹ, Hưng Yên', NULL)
GO
INSERT [dbo].[LstNhanVien] ([Ma_NV], [Ten_NV], [Chuc_Vu], [Mat_Khau], [Quyen], [Dien_Thoai], [Dia_Chi]) VALUES (N'admin           ', N'admin', N'GĐ', N'123', N'admin', N'0904095645      ', N'HN')
GO
INSERT [dbo].[LstNhanVien] ([Ma_NV], [Ten_NV], [Chuc_Vu], [Mat_Khau], [Quyen], [Dien_Thoai], [Dia_Chi]) VALUES (N'NV0001          ', N'Vũ Thị Hoài Thanh', N'Thủ thư', N'1234', N'Nhân viên', NULL, NULL)
GO
INSERT [dbo].[LstNhanVien] ([Ma_NV], [Ten_NV], [Chuc_Vu], [Mat_Khau], [Quyen], [Dien_Thoai], [Dia_Chi]) VALUES (N'NV0002		        ', N'Trần Đình Dũng', N'Quản lý', N'12345', N'admin', N'0913456289      ', N'HD')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBBK           ', N'Đại học Bách khoa', N'Khán đài B, sân vận động Tạ Quang Bửu, Đại học Bách khoa, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBCTQG         ', N'Chính trị quốc gia', N'22-24 Quang Trung, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBĐN           ', N'Nhà xuất bản Đà Nẵng', N'30 Tháng 4, Hòa Cường Bắc, Đà Nẵng')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBGD           ', N'Giáo dục', N'81 Trần Hưng Đạo, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBHNV          ', N'Nhà xuất bản Hội nhà văn', N'65 Nguyễn Du, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBKD           ', N'Kim Đồng', N'55 Quang Trung, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBKTQD         ', N'Đại học Kinh tế quốc dân', N'207 đường Giải Phóng, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBLD           ', N'Lao động', N'175 Giảng Võ, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBLĐ-XH        ', N'Nhà xuất bản Lao Động- Xã Hội', N'Số 36 Ngõ Hòa Bình 4, phố Minh Khai, Hai Bà Trưng, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBLLCT         ', N'Lý luận chính trị', N'56B Quốc Tử Giám, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBSP           ', N'Đại học Sư phạm', N'136 Xuân Thủy, Cầu Giấy, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBT            ', N'Nhà xuất bản Trẻ', N'161B Lý Chính Thắng, Phường 7, Quận 3, TPHCM')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBTC           ', N'Tài chính', N'4 Phan Huy Chú, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBTĐ           ', N'Nhà xuất bản Thời đại', N'B15, Lô 2, Mỹ Đình I, Từ Liêm, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBTG           ', N'Nhà xuất bản Thế giới', N'46 Trần Hưng Đạo, Hàng Bài, Hoàn Kiếm, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBTH           ', N'Nhà xuât bản Tổng hợp TPHCM', N'62 Nguyễn Thị Minh Khai, Đa Kao, Quận 1, Hồ Chí Minh')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBTK           ', N'Thống kê', N'96 Thụy Khuê, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBTN           ', N'Thanh niên', N'62 Bà Triệu, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBVH           ', N'Nhà xuất bản Văn học ', N'18 Nguyễn Trường Tộ, Ba Đình, Hà Nội')
GO
INSERT [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan], [Ten_NhaXuatBan], [Dia_Chi]) VALUES (N'NXBVHTT         ', N'Nhà xuất bản Văn hóa – Thông tin', N'43 Lò Đúc, Hà Nội')
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00001          ', N'English Gramma In Use', N'706', N'NXBTH           ', N'TGRM            ', N'G5.THNN         ', 1004)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00002          ', N'Số đỏ', N'263', N'NXBVHTT         ', N'TGVTP           ', N'G8.VH           ', 1001)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00003          ', N'Chuyện con mèo dạy hải âu bay', N'139', N'NXBHNV          ', N'TGLS            ', N'G8.VH           ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00004          ', N'Dế Mèn Phưu Lưu Kí', N'34', N'NXBHNV          ', N'TG00005         ', N'G8.VH           ', 1023)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00006          ', N'Giáo trình Tài chính quốc tế', N'46', N'NXBTK           ', N'TGNVT           ', N'G2.TC           ', 1019)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00008          ', N'Giáo trình Quản trị học ', N'440', N'NXBLĐ-XH        ', N'TGĐVT           ', N'G3.QT           ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00009          ', N'Mẹ, thơm một cái  ', N'253', N'NXBTĐ           ', N'TGCBĐ           ', N'G8.VH           ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00010          ', N'Truyện Kiều', N'286', N'NXBTN           ', N'TGND            ', N'G8.VH           ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00011          ', N'Những giấc mơ từ cha tôi', N'480', N'NXBVH           ', N'TGBO            ', N'G8.VH           ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00012          ', N'Bên nhau trọn đời', N'346', N'NXBVH           ', N'TGCM            ', N'G8.VH           ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00013          ', N'Con chó nhỏ mang giỏ hoa hồng', N'260', N'NXBT            ', N'TGNNA           ', N'G8.VH           ', 1002)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00014          ', N'Business Vocabulary In Use', N'176', N'NXBT            ', N'TGBM            ', N'G5.THNN         ', 1002)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00015          ', N'Luật thống kê', N'82', N'NXBCTQG         ', N'TGQH            ', N'G7.PL           ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00016          ', N'Quyết tâm tiến lên, biết tiến lên', N'183', N'NXBTH           ', N'TGVNG           ', N'G4.LLCT         ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00018          ', N'Không gia đình', N'574', N'NXBVH           ', N'TGHM            ', N'G8.VH           ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00019          ', N'Những thời khắc quyết định', N'682', N'NXBTG           ', N'TGGB            ', N'G4.LLCT         ', 1003)
GO
INSERT [dbo].[LstSach] ([Ma_Sach], [Ten_Sach], [So_Trang], [Ma_NhaXuatBan], [Ma_TacGia], [Ma_LoaiSach], [Ton_Kho]) VALUES (N'S00020          ', N'Phù thủy xứ OZ', N'224', N'NXBVH           ', N'TGLFB           ', N'G8.VH           ', 1003)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TG00001         ', N'Lỗ Tấn', N'', CAST(N'1900-01-01 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TG00002         ', N'James Surowiecki', N'New york, Mỹ', CAST(N'1967-04-30 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TG00003         ', N'Nguyễn Bính', N'Nam Định, Việt Nam', CAST(N'1918-02-13 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TG00005         ', N'Tô Hoài', N'Hoài Đức, Hà Nội, Việt Nam', CAST(N'1920-09-07 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGBM            ', N'Bill Mascull', N'', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGBO            ', N'Barack Obama', N'Chicago, Illinois', CAST(N'1961-04-08 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGCBĐ           ', N'Cửu Bả Đao', N'Đài Loan', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGCD            ', N'Conan Doyle', N'Scotland', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGCM            ', N'Cố Mạn', N'Trung Quốc', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGĐVT           ', N'TS. Đào Văn Từ', N'', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGGB            ', N'George W.Bush', N'New Haven, Connecticut, Hoa Kỳ', CAST(N'1946-06-07 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGHM            ', N'Hector Malot', N'La Bouille, Pháp', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGLA            ', N'Liaquat Ahamed', N'Kenya', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGLFB           ', N'L. Frank Baum', N'Chittenago, New York, Hoa Kỳ', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGLS            ', N'Luis Sepúlveda', N'Ovalle, Chile', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGLTD           ', N'Lê Thái Dũng', N'', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGMJR           ', N'Michael J.Ritt,JR', N'', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGND            ', N'Nguyễn Du', N'Huế ', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGNNA           ', N'Nguyễn Nhật Ánh', N'Thăng Bình, Quảng Nam', CAST(N'1955-07-05 00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGNQT           ', N'TS. Nguyễn Quốc Thắng', N'', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGNVT           ', N'GS.TS. Nguyễn Văn Tiến', N'', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGQH            ', N'Quốc hội', N'', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGRM            ', N'Raymond Murphy', N'', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGVNG           ', N'Đại tướng Võ Nguyên Giáp', N'Lệ Thủy, Quảng Bình', NULL)
GO
INSERT [dbo].[LstTacGia] ([Ma_TacGia], [Ten_TacGia], [Dia_Chi], [Ngay_Sinh]) VALUES (N'TGVTP           ', N'Vũ Trọng Phụng', N'Mỹ Hào, Hưng Yên', NULL)
GO
INSERT [dbo].[MuonTra] ([So_Phieu], [Ma_Sach], [So_Luong]) VALUES (N'PM002           ', N'S00004          ', 2)
GO
INSERT [dbo].[MuonTra] ([So_Phieu], [Ma_Sach], [So_Luong]) VALUES (N'PM002           ', N'S00006          ', 3)
GO
INSERT [dbo].[MuonTra] ([So_Phieu], [Ma_Sach], [So_Luong]) VALUES (N'PT001           ', N'S00004          ', 1)
GO
INSERT [dbo].[MuonTra] ([So_Phieu], [Ma_Sach], [So_Luong]) VALUES (N'PM003           ', N'S00008          ', 2)
GO
INSERT [dbo].[MuonTra] ([So_Phieu], [Ma_Sach], [So_Luong]) VALUES (N'PT001           ', N'S00006          ', 1)
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'LstNhanVien     ', N'Ma_NV           ', N'CTCapNhatSach   ', N'Ma_NV           ')
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'LstNhanVien     ', N'Ma_NV           ', N'CTMuonTra       ', N'Ma_NV           ')
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'LstSach         ', N'Ma_Sach         ', N'CTMuonTra       ', N'Ma_Sach         ')
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'LstSach         ', N'Ma_Sach         ', N'CTCapNhatSach   ', N'Ma_Sach         ')
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'LoaiSach        ', N'Ma_LoaiSach     ', N'LstSach         ', N'Ma_LoaiSach     ')
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'LstNhaXuatBan   ', N'Ma_NhaXuatBan   ', N'LstSach         ', N'Ma_NhaXuatBan   ')
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'LstTacGia       ', N'Ma_TacGia       ', N'LstSach         ', N'Ma_TacGia       ')
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'MuonTra         ', N'So_Phieu        ', N'CTMuonTra       ', N'So_Phieu        ')
GO
INSERT [dbo].[uSyRelation] ([List_Tables], [Primary_Key], [Data_Tables], [Foreign_Key]) VALUES (N'LstDocGia       ', N'Ma_DocGia       ', N'MuonTra         ', N'Ma_DocGia       ')
GO
ALTER TABLE [dbo].[CapNhatSach]  WITH CHECK ADD  CONSTRAINT [FK_CapNhatSach_CTCapNhatSach] FOREIGN KEY([So_Phieu])
REFERENCES [dbo].[CTCapNhatSach] ([So_Phieu])
GO
ALTER TABLE [dbo].[CapNhatSach] CHECK CONSTRAINT [FK_CapNhatSach_CTCapNhatSach]
GO
ALTER TABLE [dbo].[CapNhatSach]  WITH CHECK ADD  CONSTRAINT [FK_CapNhatSach_LstSach] FOREIGN KEY([Ma_Sach])
REFERENCES [dbo].[LstSach] ([Ma_Sach])
GO
ALTER TABLE [dbo].[CapNhatSach] CHECK CONSTRAINT [FK_CapNhatSach_LstSach]
GO
ALTER TABLE [dbo].[CTCapNhatSach]  WITH CHECK ADD  CONSTRAINT [FK_CTCapNhatSach_LstNhaCC] FOREIGN KEY([Ma_NhaCC])
REFERENCES [dbo].[LstNhaCC] ([Ma_NhaCC])
GO
ALTER TABLE [dbo].[CTCapNhatSach] CHECK CONSTRAINT [FK_CTCapNhatSach_LstNhaCC]
GO
ALTER TABLE [dbo].[CTCapNhatSach]  WITH CHECK ADD  CONSTRAINT [Fk_NVSach] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[LstNhanVien] ([Ma_NV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTCapNhatSach] CHECK CONSTRAINT [Fk_NVSach]
GO
ALTER TABLE [dbo].[CTMuonTra]  WITH CHECK ADD  CONSTRAINT [FK_CTMuonTra_LstDocGia] FOREIGN KEY([Ma_DocGia])
REFERENCES [dbo].[LstDocGia] ([Ma_DocGia])
GO
ALTER TABLE [dbo].[CTMuonTra] CHECK CONSTRAINT [FK_CTMuonTra_LstDocGia]
GO
ALTER TABLE [dbo].[CTMuonTra]  WITH CHECK ADD  CONSTRAINT [FK_CTMuonTra_LstNhanVien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[LstNhanVien] ([Ma_NV])
GO
ALTER TABLE [dbo].[CTMuonTra] CHECK CONSTRAINT [FK_CTMuonTra_LstNhanVien]
GO
ALTER TABLE [dbo].[LstSach]  WITH CHECK ADD  CONSTRAINT [FK_LstSach_LoaiSach] FOREIGN KEY([Ma_LoaiSach])
REFERENCES [dbo].[LoaiSach] ([Ma_LoaiSach])
GO
ALTER TABLE [dbo].[LstSach] CHECK CONSTRAINT [FK_LstSach_LoaiSach]
GO
ALTER TABLE [dbo].[LstSach]  WITH CHECK ADD  CONSTRAINT [Fk_Sach_NXB] FOREIGN KEY([Ma_NhaXuatBan])
REFERENCES [dbo].[LstNhaXuatBan] ([Ma_NhaXuatBan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LstSach] CHECK CONSTRAINT [Fk_Sach_NXB]
GO
ALTER TABLE [dbo].[LstSach]  WITH CHECK ADD  CONSTRAINT [Fk_Sach_TacGia] FOREIGN KEY([Ma_TacGia])
REFERENCES [dbo].[LstTacGia] ([Ma_TacGia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LstSach] CHECK CONSTRAINT [Fk_Sach_TacGia]
GO
ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [FK_MuonTra_CTMuonTra] FOREIGN KEY([So_Phieu])
REFERENCES [dbo].[CTMuonTra] ([So_Phieu])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [FK_MuonTra_CTMuonTra]
GO
ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [FK_MuonTra_LstSach] FOREIGN KEY([Ma_Sach])
REFERENCES [dbo].[LstSach] ([Ma_Sach])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [FK_MuonTra_LstSach]
GO
/****** Object:  StoredProcedure [dbo].[add_CapNhatSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[add_CapNhatSach]
(
@So_Phieu nchar(16),
@Ma_Sach nchar(16),
@Ngay_Lap smalldatetime,
@So_Luong int,
@Ma_NV nchar(16),
@Ma_NhaCC nchar(16),
@Ghi_Chu nvarchar( 50)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--Insert [dbo].[CTCapNhatSach] values(@So_Phieu,@Ma_Sach,@Ngay_Lap,@So_Luong,@Ma_NV,@Ma_NhaCC,@Ghi_Chu)
END

GO
/****** Object:  StoredProcedure [dbo].[delete_CapNhatSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_CapNhatSach]
(
@So_Phieu nchar(16)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    delete from [dbo].[CTCapNhatSach] 
	where [So_Phieu]=@So_Phieu 
END

GO
/****** Object:  StoredProcedure [dbo].[KiemTraTK]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[KiemTraTK]
@Ten_NV nvarchar(50),
@Mat_Khau nvarchar(50),
@Quyen nvarchar(50)
As
Select [Ten_NV],[Mat_Khau],[Quyen]
from [dbo].[ViewNhanVien]
where [Mat_Khau]=@Mat_Khau and [Quyen]=@Quyen and [Ten_NV]=@Ten_NV
return
GO
/****** Object:  StoredProcedure [dbo].[Mls_Sp_Edit_Lst_Foreign_Key]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Mls_Sp_Edit_Lst_Foreign_Key]
	@List_Table NCHAR(16) = N'', --> Tên bảng đóng vai trò là khóa chính
	@Primary_Key NCHAR(16) = N'', --> Khóa chính (Key delete)
	@Primary_Value_Old NCHAR(16) = N'', --> Giá trị cũ cần sửa
	@Primary_Value_New NCHAR(16) = N'' --> Giá trị mới cần sửa
AS
BEGIN
	SET DATEFORMAT DMY;
	SET NOCOUNT ON;
	
	DECLARE @_I INT = '', @_Data_Tables NCHAR(16) = N'', @_Foreign_Key NCHAR(16) = N'',
			@_Exec_SQL NVARCHAR(4000) ;
	
	IF OBJECT_ID('Tempdb..#TmpChk') IS NOT NULL DROP TABLE #TmpChk;
	
	SELECT ROW_NUMBER() OVER (ORDER BY Primary_Key) AS Stt, * 
		INTO #TmpChk
		FROM [dbo].[uSyRelation]
		WHERE (List_Tables = @List_Table) AND (Primary_Key = @Primary_Key)
		ORDER BY Primary_Key;
	
	SET @_I = 0;
	
	WHILE @_I < (SELECT COUNT(*) FROM #TmpChk)
	BEGIN
		SET @_I = @_I + 1;
		
		SELECT @_Data_Tables = Data_Tables, @_Foreign_Key = Foreign_Key
			FROM #TmpChk
			WHERE (List_Tables = @List_Table) AND (Primary_Key = @Primary_Key);
			
		SET @_Exec_SQL = N'
			UPDATE ' + @_Data_Tables + N' SET '  + RTRIM(@_Foreign_Key) + N' = ''' + RTRIM(@Primary_Value_New) + 
				N''' WHERE '  + RTRIM(@_Foreign_Key) + N' = ''' + RTRIM(@Primary_Value_Old) + '''
		'
		EXEC(@_Exec_SQL)
	END
	
	DROP TABLE #TmpChk;
END

GO
/****** Object:  StoredProcedure [dbo].[Mls_Sp_NED_LstDmDg]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Mls_Sp_NED_LstDmDg]
	@_Mess NVARCHAR(128) OUTPUT,
	@Type NCHAR(1) = N'', --> 'N'-Thêm mới, 'E'-Sửa đổi, 'D'-Xóa
	@Ma_Dg_Old NCHAR(16) = N'', -->Mã cũ trước khi sửa
	@Ma_Dg NCHAR(16) = N'', --> Khi thêm, sửa, Mã mới Sẽ được lưu vào
	@Ten_Dg NCHAR(64) = N'',
	@Dia_Chi NCHAR(64) = N'',
	@Dien_Thoai NCHAR(48) = N'',
	@Ngay_Sinh SMALLDATETIME = '',
	@Ngay_Lap SMALLDATETIME = '',
	@Ngay_HetHan SMALLDATETIME = ''
AS
BEGIN
	SET DATEFORMAT DMY;
	SET NOCOUNT ON;
	
	DECLARE @_Local_Mess NVARCHAR(128) = N'';
	
	IF @Type = N'N'
		IF EXISTS(SELECT @Ma_Dg FROM [dbo].[LstDocGia]g WHERE [Ma_DocGia] = @Ma_Dg)
			SET @_Local_Mess = N'Đã tồn tại mã này !'
		ELSE
		BEGIN
			INSERT INTO [dbo].[LstDocGia] (Ma_DocGia,[Ten_DocGia] , Dia_Chi, [So_DienThoai], [Ngay_Sinh],[Ngay_Lap],[Ngay_HetHan]) 
				VALUES (@Ma_Dg, @Ten_Dg, @Dia_Chi, @Dien_Thoai, @Ngay_Sinh, @Ngay_Lap, @Ngay_HetHan)
			SET @_Local_Mess = N'Đã hoàn thành thêm mới';
		END
	ELSE IF @Type = N'E'
		IF EXISTS(SELECT [Ma_DocGia] FROM [dbo].[LstDocGia] WHERE [Ma_DocGia] <> @Ma_Dg_Old  AND @Ma_Dg = @Ma_Dg)
			SET @_Local_Mess = N'Đã tồn tại mã này !'
		ELSE
		BEGIN
			/* Sửa mã ở các bảng dữ liệu (Khóa ngoại lai) */
			
			DECLARE @Primary_Value_Old NCHAR(16) = N'' ;
			
			SELECT @Primary_Value_Old = [Ma_DocGia] FROM  [dbo].[LstDocGia] WHERE [Ma_DocGia] = @Ma_Dg_Old 
			
			EXEC [Mls_Sp_Edit_Lst_Foreign_Key]
				@List_Table = N'LstDocGia',
				@Primary_Key = N'Ma_DocGia',
				@Primary_Value_Old = @Primary_Value_Old,
				@Primary_Value_New = @Ma_Dg
						
			/* Sửa mã ở bảng danh mục gốc (Khóa chính) */
			UPDATE [dbo].[LstDocGia] SET [Ma_DocGia] = @Ma_Dg,[Ten_DocGia]  = @Ten_Dg, Dia_Chi = @Dia_Chi, [So_DienThoai] = @Dien_Thoai, 
				[Ngay_Sinh] = @Ngay_Sinh,[Ngay_Lap]=@Ngay_Lap , [Ngay_HetHan] = @Ngay_HetHan 
				WHERE [Ma_DocGia] = @Ma_Dg_Old 
			
			SET @_Local_Mess = N'Đã hoàn thành sửa đổi';
		END
	ELSE IF @Type = N'D'
		IF NOT EXISTS(SELECT [Ma_DocGia] FROM [dbo].[LstDocGia] WHERE [Ma_DocGia] = @Ma_Dg)
			SET @_Local_Mess = N'Không tồn tại mã này !'
		ELSE
		BEGIN
			DECLARE @_Check_Ok NCHAR(1) = N'', @_Lst_Exists_Tables NVARCHAR(4000) = N'';
			
			DECLARE @Ma_Chk_Value NCHAR(16) = N'' ;			
			SELECT @Ma_Chk_Value =  [Ma_DocGia] FROM [dbo].[LstDocGia] WHERE [Ma_DocGia] = @Ma_Dg
			
			EXEC [Sp_Check_Info_Delete_Lst]
				@_Check_Ok OUTPUT,
				@_Lst_Exists_Tables OUTPUT,
				@List_Table = N'LstDmDt',
				@Primary_Key = N'MA_DT',
				@Primary_Value = @Ma_Chk_Value
			
			IF @_Check_Ok = N'0'
			BEGIN
				DELETE FROM [dbo].[LstDocGia] WHERE [Ma_DocGia] = @Ma_Dg
				SET @_Local_Mess = N'Đã hoàn thành việc xóa';
			END
			ELSE
				SET @_Local_Mess = N'Đã tồn tại [' + RTRIM(CAST(@Ma_Dg AS NVARCHAR(16))) + N'] trong bảng dữ liệu [' + RTRIM(@_Lst_Exists_Tables) + N'] !'
		END
	ELSE
		SET @_Local_Mess = N'Không làm gì !'
	
	SET @_Mess = @_Local_Mess
END


GO
/****** Object:  StoredProcedure [dbo].[search_CapNhatSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[search_CapNhatSach]
@chuoitimkiem nvarchar(256)
AS
BEGIN

	-- interfering with SELECT statements.
	SET NOCOUNT ON
	SELECT *
	from [dbo].[ViewSelectSach]
	where [So_Phieu] like N'%'+ @chuoitimkiem +'%'
	or [Ten_Sach] like N'%'+@chuoitimkiem+'%'
	or [Ngay_Lap] like N'%'+@chuoitimkiem+'%'
	or [Ten_NV] like N'%'+@chuoitimkiem+'%'
	or [Ten_NhaCC] like N'%'+@chuoitimkiem+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[select_capNhatSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[select_capNhatSach]
AS
BEGIN

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [So_Phieu],[Ten_Sach],[Ngay_Lap],[So_Luong],[Ten_NV],[Ten_NhaCC],[Ghi_Chu]
	from [dbo].[ViewSelectSach]
END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Check_Info_Delete_Lst]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[Sp_Check_Info_Delete_Lst]
	@_Check_Ok NCHAR(1) OUTPUT,
	@_Lst_Exists_Tables NVARCHAR(4000) OUTPUT,
	@List_Table NCHAR(16) = N'', --> Tên bảng đóng vai trò là khóa chính
	@Primary_Key NCHAR(16) = N'', --> Khóa chính (Key delete)
	@Primary_Value NCHAR(16) = N'' --> Giá trị cần check
AS
BEGIN
	SET DATEFORMAT DMY;
	SET NOCOUNT ON;
	
	DECLARE @_I INT = '', @_Data_Tables NCHAR(16) = N'', @_Foreign_Key NCHAR(16) = N'',
			@_Exec_SQL NVARCHAR(4000) ;
	
	IF OBJECT_ID('Tempdb..#TmpChk') IS NOT NULL DROP TABLE #TmpChk;
	
	SELECT ROW_NUMBER() OVER (ORDER BY Primary_Key) AS Stt, * 
		INTO #TmpChk
		FROM [dbo].[uSyRelation]
		WHERE (List_Tables = @List_Table) AND (Primary_Key = @Primary_Key)
		ORDER BY Primary_Key;
	
	IF OBJECT_ID('Tempdb..#TmpChkDm') IS NOT NULL DROP TABLE #TmpChkDm;
	
	SELECT TOP 0 Data_Tables, Foreign_Key
		INTO #TmpChkDm 
		FROM [dbo].[uSyRelation];

	SET @_Check_Ok = N'0'
	
	SET @_I = 0;
	
	WHILE @_I < (SELECT COUNT(*) FROM #TmpChk)
	BEGIN
		SET @_I = @_I + 1;
		
		SELECT @_Data_Tables = Data_Tables, @_Foreign_Key = Foreign_Key
			FROM #TmpChk
			WHERE (List_Tables = @List_Table) AND (Primary_Key = @Primary_Key);
		
		SET @_Exec_SQL = N'
		IF EXISTS(SELECT * FROM ' + RTRIM(@_Data_Tables) + N' WHERE ' + RTRIM(@_Foreign_Key) + N' = ''' + RTRIM(@Primary_Value) + N''')
			INSERT INTO #TmpChkDm (Data_Tables, Foreign_Key) VALUES (''' + @_Data_Tables + N''', ''' + @_Foreign_Key + ''')
		'
		EXEC(@_Exec_SQL)
		
		IF EXISTS(SELECT TOP 1 * FROM #TmpChkDm)
		BEGIN
			SET @_Check_Ok = N'1'
			
			SET @_Lst_Exists_Tables = 
			(SELECT ',' + RTRIM(Data_Tables)
			FROM #TmpChkDm Group by Data_Tables
			FOR XML PATH(''))
			
			SET @_Lst_Exists_Tables = RIGHT(@_Lst_Exists_Tables, LEN(@_Lst_Exists_Tables) - 1)
			
			SET @_I = (SELECT COUNT(*) FROM #TmpChk)
		END
	END
	
	DROP TABLE #TmpChk;
	DROP TABLE #TmpChkDm;
END



GO
/****** Object:  StoredProcedure [dbo].[update_CapNhatSach]    Script Date: 8/8/2016 9:16:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[update_CapNhatSach]
(
@So_Phieu nchar(16),
@Ma_Sach nchar(16),
@Ngay_Lap smalldatetime,
@So_Luong int,
@Ma_NV nchar(16),
@Ma_NhaCC nchar(16),
@Ghi_Chu nvarchar( 50)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 --   Update [dbo].[CTCapNhatSach] set [So_Phieu] =@So_Phieu,[Ma_Sach]=@Ma_Sach,[Ngay_Lap]=@Ngay_Lap,[So_Luong]=@So_Luong,[Ma_NV]=@Ma_NV,[Ma_NhaCC]=@Ma_NhaCC,[Ghi_Chu]=@Ghi_Chu
	--where [So_Phieu]=@So_Phieu 
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "LstNhanVien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewNhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewNhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "LstSach"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "LstTacGia"
            Begin Extent = 
               Top = 6
               Left = 461
               Bottom = 136
               Right = 631
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LstNhaXuatBan"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LoaiSach"
            Begin Extent = 
               Top = 134
               Left = 471
               Bottom = 230
               Right = 641
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSelectLstSach'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSelectLstSach'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSelectLstSach'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CTCapNhatSach"
            Begin Extent = 
               Top = 12
               Left = 267
               Bottom = 142
               Right = 437
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "LstSach"
            Begin Extent = 
               Top = 0
               Left = 41
               Bottom = 130
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "LstNhaCC"
            Begin Extent = 
               Top = 121
               Left = 474
               Bottom = 234
               Right = 644
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LstNhanVien"
            Begin Extent = 
               Top = 0
               Left = 478
               Bottom = 113
               Right = 648
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSelectSach'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSelectSach'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSelectSach'
GO
