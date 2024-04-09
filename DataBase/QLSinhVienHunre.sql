USE [qlsinhvienhunre]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[tenChucVu] [nvarchar](50) NULL,
	[chucVu] [varchar](5) NOT NULL,
 CONSTRAINT [ChuVu_PK] PRIMARY KEY CLUSTERED 
(
	[chucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioiTinh]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioiTinh](
	[gioiTinh] [varchar](4) NOT NULL,
	[tenGioiTinh] [nvarchar](50) NULL,
 CONSTRAINT [GioiTinh_PK] PRIMARY KEY CLUSTERED 
(
	[gioiTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhThuc]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThuc](
	[hinhThucDanhGia] [varchar](3) NOT NULL,
	[tenHinhThucDanhGia] [nvarchar](100) NULL,
 CONSTRAINT [HinhThuc_PK] PRIMARY KEY CLUSTERED 
(
	[hinhThucDanhGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHocPhan](
	[maLopHocPhan] [varchar](50) NOT NULL,
	[namHoc] [int] NULL,
	[hocKy] [int] NULL,
	[maMonHoc] [varchar](50) NULL,
	[maNhanVien] [varchar](50) NULL,
	[moTa] [nvarchar](100) NULL,
	[gioiHanSinhVien] [float] NULL,
 CONSTRAINT [LopHocPhan_PK] PRIMARY KEY CLUSTERED 
(
	[maLopHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMonHoc] [varchar](50) NOT NULL,
	[tenMonHoc] [nvarchar](100) NULL,
	[soTinChi] [int] NULL,
	[namBatDau] [int] NULL,
	[quyDinh] [varchar](2) NULL,
	[moTaMonHoc] [nvarchar](100) NULL,
	[hinhThucDanhGia] [varchar](3) NULL,
 CONSTRAINT [MonHoc_PK] PRIMARY KEY CLUSTERED 
(
	[maMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MucTieu]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MucTieu](
	[maKetQua] [varchar](2) NOT NULL,
	[tenKetQua] [nvarchar](100) NULL,
 CONSTRAINT [MucTieu_PK] PRIMARY KEY CLUSTERED 
(
	[maKetQua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganhHoc]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganhHoc](
	[maNganhHoc] [varchar](50) NOT NULL,
	[tenNganhHoc] [nvarchar](max) NULL,
	[soTinChi] [int] NULL,
	[namBatDau] [int] NULL,
 CONSTRAINT [PK_NganhHoc] PRIMARY KEY CLUSTERED 
(
	[maNganhHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[chuVu] [varchar](5) NULL,
	[maSinhVien] [varchar](50) NOT NULL,
	[maNhanVien] [varchar](50) NOT NULL,
	[matKhau] [varchar](100) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC,
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNhanVien] [varchar](50) NOT NULL,
	[hoNhanVien] [nvarchar](max) NULL,
	[tenNhanVien] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [varchar](4) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanChiaMon]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanChiaMon](
	[maNganhHoc] [varchar](50) NOT NULL,
	[maMonHoc] [varchar](50) NOT NULL,
 CONSTRAINT [PhanChiaMon_PK] PRIMARY KEY CLUSTERED 
(
	[maNganhHoc] ASC,
	[maMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[quyDinh] [varchar](2) NOT NULL,
	[tenQuyDinh] [nvarchar](50) NULL,
 CONSTRAINT [QuyDinh_PK] PRIMARY KEY CLUSTERED 
(
	[quyDinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSinhVien] [varchar](50) NOT NULL,
	[hoSinhVien] [nvarchar](100) NULL,
	[tenSinhVien] [nvarchar](100) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [varchar](4) NULL,
	[namNhapHoc] [int] NULL,
	[maNganhHoc] [varchar](50) NULL,
 CONSTRAINT [SinhVien_PK] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThamGiaLopHoc]    Script Date: 09/04/2024 4:37:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamGiaLopHoc](
	[maLopHocPhan] [varchar](50) NOT NULL,
	[maSinhVien] [varchar](50) NOT NULL,
	[diemSo] [float] NULL,
	[diemChu] [char](8) NULL,
	[maKetQua] [varchar](2) NULL,
 CONSTRAINT [ThamGiaLopHoc_PK] PRIMARY KEY CLUSTERED 
(
	[maLopHocPhan] ASC,
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([tenChucVu], [chucVu]) VALUES (N'Admin', N'ADMIN')
INSERT [dbo].[ChucVu] ([tenChucVu], [chucVu]) VALUES (N'Giảng viên', N'GV')
INSERT [dbo].[ChucVu] ([tenChucVu], [chucVu]) VALUES (N'Sinh viên', N'SV')
GO
INSERT [dbo].[GioiTinh] ([gioiTinh], [tenGioiTinh]) VALUES (N'khac', N'Khác')
INSERT [dbo].[GioiTinh] ([gioiTinh], [tenGioiTinh]) VALUES (N'nam', N'Nam')
INSERT [dbo].[GioiTinh] ([gioiTinh], [tenGioiTinh]) VALUES (N'nu', N'Nữ')
GO
INSERT [dbo].[HinhThuc] ([hinhThucDanhGia], [tenHinhThucDanhGia]) VALUES (N'BTL', N'Bài tập lớn')
INSERT [dbo].[HinhThuc] ([hinhThucDanhGia], [tenHinhThucDanhGia]) VALUES (N'TH', N'Thực hành')
INSERT [dbo].[HinhThuc] ([hinhThucDanhGia], [tenHinhThucDanhGia]) VALUES (N'TL', N'Tự luận')
INSERT [dbo].[HinhThuc] ([hinhThucDanhGia], [tenHinhThucDanhGia]) VALUES (N'TN', N'Trắc nghiệm')
GO
INSERT [dbo].[LopHocPhan] ([maLopHocPhan], [namHoc], [hocKy], [maMonHoc], [maNhanVien], [moTa], [gioiHanSinhVien]) VALUES (N'1', 2020, 1, N'1', N'1', N'"Chưa có mô tả"', 20)
GO
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia]) VALUES (N'1', N'Toán cao cấp', 3, 2020, N'TC', N'"Chưa có mô tả"', N'TL')
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia]) VALUES (N'2', N'Toán rời rạc', 3, 2020, N'BB', N'"Chưa có mô tả"', N'TN')
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia]) VALUES (N'3', N'Kinh tế vĩ mô', 3, 2020, N'BB', N'"Chưa có mô tả"', N'TL')
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia]) VALUES (N'4', N'Lập trình Android', 3, 2020, N'BB', N'"Chưa có mô tả"', N'TH')
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia]) VALUES (N'5', N'Lập trình WEB', 3, 2020, N'BB', N'"Chưa có mô tả"', N'BTL')
GO
INSERT [dbo].[MucTieu] ([maKetQua], [tenKetQua]) VALUES (N'CD', N'Chưa đạt')
INSERT [dbo].[MucTieu] ([maKetQua], [tenKetQua]) VALUES (N'D', N'Đạt')
GO
INSERT [dbo].[NganhHoc] ([maNganhHoc], [tenNganhHoc], [soTinChi], [namBatDau]) VALUES (N'CNTT', N'Công nghệ thông tinh', NULL, 2022)
INSERT [dbo].[NganhHoc] ([maNganhHoc], [tenNganhHoc], [soTinChi], [namBatDau]) VALUES (N'KT', N'Kế toán', NULL, 2020)
INSERT [dbo].[NganhHoc] ([maNganhHoc], [tenNganhHoc], [soTinChi], [namBatDau]) VALUES (N'QLDD', N'Quản lý đất đai', NULL, 2020)
INSERT [dbo].[NganhHoc] ([maNganhHoc], [tenNganhHoc], [soTinChi], [namBatDau]) VALUES (N'QLKD', N'Quản lý kinh doanh', NULL, 2020)
GO
INSERT [dbo].[NguoiDung] ([chuVu], [maSinhVien], [maNhanVien], [matKhau]) VALUES (N'ADMIN', N'0', N'0', N'1')
INSERT [dbo].[NguoiDung] ([chuVu], [maSinhVien], [maNhanVien], [matKhau]) VALUES (N'GV', N'0', N'1', N'1')
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh]) VALUES (N'0', N'ADMIN', N'ADMIN', NULL, NULL)
INSERT [dbo].[NhanVien] ([maNhanVien], [hoNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh]) VALUES (N'1', N'Nguyễn Văn', N'San', CAST(N'1991-02-03' AS Date), N'nam')
INSERT [dbo].[NhanVien] ([maNhanVien], [hoNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh]) VALUES (N'2', N'Trần Văn', N'Khải', CAST(N'1996-04-04' AS Date), N'nam')
INSERT [dbo].[NhanVien] ([maNhanVien], [hoNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh]) VALUES (N'3', N'Nguyễn Đình', N'Thuận', CAST(N'1990-07-23' AS Date), N'nam')
INSERT [dbo].[NhanVien] ([maNhanVien], [hoNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh]) VALUES (N'4', N'Lê Thị Hồng', N'Anh', CAST(N'1989-06-12' AS Date), N'nu')
INSERT [dbo].[NhanVien] ([maNhanVien], [hoNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh]) VALUES (N'5', N'Đỗ Quang', N'Liêm', CAST(N'2000-01-17' AS Date), N'khac')
GO
INSERT [dbo].[PhanChiaMon] ([maNganhHoc], [maMonHoc]) VALUES (N'CNTT', N'1')
INSERT [dbo].[PhanChiaMon] ([maNganhHoc], [maMonHoc]) VALUES (N'CNTT', N'2')
INSERT [dbo].[PhanChiaMon] ([maNganhHoc], [maMonHoc]) VALUES (N'CNTT', N'4')
INSERT [dbo].[PhanChiaMon] ([maNganhHoc], [maMonHoc]) VALUES (N'CNTT', N'5')
INSERT [dbo].[PhanChiaMon] ([maNganhHoc], [maMonHoc]) VALUES (N'KT', N'1')
INSERT [dbo].[PhanChiaMon] ([maNganhHoc], [maMonHoc]) VALUES (N'KT', N'2')
INSERT [dbo].[PhanChiaMon] ([maNganhHoc], [maMonHoc]) VALUES (N'KT', N'3')
GO
INSERT [dbo].[QuyDinh] ([quyDinh], [tenQuyDinh]) VALUES (N'BB', N'Bắt buộc')
INSERT [dbo].[QuyDinh] ([quyDinh], [tenQuyDinh]) VALUES (N'TC', N'Tự chọn')
GO
INSERT [dbo].[SinhVien] ([maSinhVien], [hoSinhVien], [tenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [maNganhHoc]) VALUES (N'0', N'ADMIN', N'ADMIN', NULL, NULL, NULL, NULL)
INSERT [dbo].[SinhVien] ([maSinhVien], [hoSinhVien], [tenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [maNganhHoc]) VALUES (N'1', N'Đồng Tiến', N'Hiệp', CAST(N'2003-06-12' AS Date), N'nam', 2018, N'CNTT')
INSERT [dbo].[SinhVien] ([maSinhVien], [hoSinhVien], [tenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [maNganhHoc]) VALUES (N'2', N'An Vũ', N'Sơn', CAST(N'2003-07-25' AS Date), N'nam', 2018, N'CNTT')
GO
INSERT [dbo].[ThamGiaLopHoc] ([maLopHocPhan], [maSinhVien], [diemSo], [diemChu], [maKetQua]) VALUES (N'1', N'1', 10, N'A       ', N'D')
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ('0') FOR [maSinhVien]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ('0') FOR [maNhanVien]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_maNhanVien]  DEFAULT ((0)) FOR [maNhanVien]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [LopHocPhan_MonHoc_FK] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MonHoc] ([maMonHoc])
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [LopHocPhan_MonHoc_FK]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [LopHocPhan_NhanVien_FK] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [LopHocPhan_NhanVien_FK]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [MonHoc_HinhThuc_FK] FOREIGN KEY([hinhThucDanhGia])
REFERENCES [dbo].[HinhThuc] ([hinhThucDanhGia])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [MonHoc_HinhThuc_FK]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [MonHoc_QuyDinh_FK] FOREIGN KEY([quyDinh])
REFERENCES [dbo].[QuyDinh] ([quyDinh])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [MonHoc_QuyDinh_FK]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [NguoiDung_ChuVu_FK] FOREIGN KEY([chuVu])
REFERENCES [dbo].[ChucVu] ([chucVu])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [NguoiDung_ChuVu_FK]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [NguoiDung_NhanVien_FK] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [NguoiDung_NhanVien_FK]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [NguoiDung_SinhVien_FK] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SinhVien] ([maSinhVien])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [NguoiDung_SinhVien_FK]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [NhanVien_GioiTinh_FK] FOREIGN KEY([gioiTinh])
REFERENCES [dbo].[GioiTinh] ([gioiTinh])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [NhanVien_GioiTinh_FK]
GO
ALTER TABLE [dbo].[PhanChiaMon]  WITH CHECK ADD  CONSTRAINT [PhanChiaMon_MonHoc_FK] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MonHoc] ([maMonHoc])
GO
ALTER TABLE [dbo].[PhanChiaMon] CHECK CONSTRAINT [PhanChiaMon_MonHoc_FK]
GO
ALTER TABLE [dbo].[PhanChiaMon]  WITH CHECK ADD  CONSTRAINT [PhanChiaMon_NganhHoc_FK] FOREIGN KEY([maNganhHoc])
REFERENCES [dbo].[NganhHoc] ([maNganhHoc])
GO
ALTER TABLE [dbo].[PhanChiaMon] CHECK CONSTRAINT [PhanChiaMon_NganhHoc_FK]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [SinhVien_GioiTinh_FK] FOREIGN KEY([gioiTinh])
REFERENCES [dbo].[GioiTinh] ([gioiTinh])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [SinhVien_GioiTinh_FK]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [SinhVien_NganhHoc_FK] FOREIGN KEY([maNganhHoc])
REFERENCES [dbo].[NganhHoc] ([maNganhHoc])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [SinhVien_NganhHoc_FK]
GO
ALTER TABLE [dbo].[ThamGiaLopHoc]  WITH CHECK ADD  CONSTRAINT [ThamGiaLopHoc_LopHocPhan_FK] FOREIGN KEY([maLopHocPhan])
REFERENCES [dbo].[LopHocPhan] ([maLopHocPhan])
GO
ALTER TABLE [dbo].[ThamGiaLopHoc] CHECK CONSTRAINT [ThamGiaLopHoc_LopHocPhan_FK]
GO
ALTER TABLE [dbo].[ThamGiaLopHoc]  WITH CHECK ADD  CONSTRAINT [ThamGiaLopHoc_MucTieu_FK] FOREIGN KEY([maKetQua])
REFERENCES [dbo].[MucTieu] ([maKetQua])
GO
ALTER TABLE [dbo].[ThamGiaLopHoc] CHECK CONSTRAINT [ThamGiaLopHoc_MucTieu_FK]
GO
ALTER TABLE [dbo].[ThamGiaLopHoc]  WITH CHECK ADD  CONSTRAINT [ThamGiaLopHoc_SinhVien_FK] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SinhVien] ([maSinhVien])
GO
ALTER TABLE [dbo].[ThamGiaLopHoc] CHECK CONSTRAINT [ThamGiaLopHoc_SinhVien_FK]
GO
