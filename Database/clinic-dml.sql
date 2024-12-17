USE [clinic]
GO
SET IDENTITY_INSERT [dbo].[BenhNhan] ON 
GO
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SoDienThoai], [CMND]) VALUES (1, N'Nguyễn Thị B', CAST(N'1990-02-07' AS Date), 0, N'Cộng Hòa', N'0906536452', N'210987654321')
GO
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SoDienThoai], [CMND]) VALUES (2, N'Nguyễn Văn A', CAST(N'1995-05-08' AS Date), 1, N'Âu Cơ', N'0906123458', N'123456789012')
GO
SET IDENTITY_INSERT [dbo].[BenhNhan] OFF
GO
SET IDENTITY_INSERT [dbo].[BacSi] ON 
GO
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SoDienThoai], [CMND], [TrinhDo], [ChuyenNganh]) VALUES (1, N'Trần Quang Hiếu', CAST(N'1987-12-22' AS Date), 1, N'Phổ Quang', N'0905123654', N'147852369123', N'Thạc Sĩ', N'Phổi')
GO
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SoDienThoai], [CMND], [TrinhDo], [ChuyenNganh]) VALUES (2, N'Nguyễn Anh Tuấn', CAST(N'1988-06-01' AS Date), 1, N'Lũy Bán Bích', N'0904321654', N'369852147789', N'Chuyên Khoa I', N'Mắt')
GO
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SoDienThoai], [CMND], [TrinhDo], [ChuyenNganh]) VALUES (3, N'Nguyễn Phương Nghi', CAST(N'1984-11-13' AS Date), 0, N'Bà Hạt', N'0901654123', N'14785212325', N'Thạc Sĩ', N'Nhi')
GO
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SoDienThoai], [CMND], [TrinhDo], [ChuyenNganh]) VALUES (4, N'Nguyễn Thanh Việt', CAST(N'1987-04-22' AS Date), 1, N'Nguyễn Thị Nhỏ', N'0908654123', N'654987123147', N'Chuyên Khoa I', N'Tim')
GO
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SoDienThoai], [CMND], [TrinhDo], [ChuyenNganh]) VALUES (5, N'Nguyễn Thanh Xuân', CAST(N'1989-09-28' AS Date), 1, N'Lạc Long Quân', N'0906486179', N'759153456852', N'Đại Học', N'Tim')
GO
SET IDENTITY_INSERT [dbo].[BacSi] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuKhamChuaBenh] ON 
GO
INSERT [dbo].[PhieuKhamChuaBenh] ([MaPhieuKhamChuaBenh], [MaBenhNhan], [MaBacSi], [NgayDangKy], [GhiChu]) VALUES (1, 1, 5, CAST(N'2023-08-02T13:02:52.710' AS DateTime), N'')
GO
INSERT [dbo].[PhieuKhamChuaBenh] ([MaPhieuKhamChuaBenh], [MaBenhNhan], [MaBacSi], [NgayDangKy], [GhiChu]) VALUES (2, 2, 4, CAST(N'2023-08-02T13:03:02.567' AS DateTime), N'')
GO
SET IDENTITY_INSERT [dbo].[PhieuKhamChuaBenh] OFF
GO
SET IDENTITY_INSERT [dbo].[Benh] ON 
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (1, N'Sổ Mũi')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (2, N'Nhức Đầu')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (3, N'Đau Bao Tử')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (4, N'Sâu Răng')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (5, N'Viêm Nang Chân Lông')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (6, N'Nám')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (7, N'Mụn Nội Tiết')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (8, N'Vẹo Cột Sống')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (9, N'Ho')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (10, N'Viêm Xoan')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (11, N'Stress')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (12, N'Chân Tay Miệng')
GO
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (13, N'Covid')
GO
SET IDENTITY_INSERT [dbo].[Benh] OFF
GO
INSERT [dbo].[ChiTietBenh] ([MaPhieuKhamChuaBenh], [MaBenh], [NgayChuanDoan], [PhuongPhapDieuTri]) VALUES (2, 4, CAST(N'2023-08-02T13:53:16.053' AS DateTime), N'Hạn chế ăn đồ ngọt')
GO
INSERT [dbo].[ChiTietBenh] ([MaPhieuKhamChuaBenh], [MaBenh], [NgayChuanDoan], [PhuongPhapDieuTri]) VALUES (2, 6, CAST(N'2023-08-02T13:52:03.930' AS DateTime), N'Tránh đi nắng')
GO
SET IDENTITY_INSERT [dbo].[Thuoc] ON 
GO
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [HuongDanSuDung], [DonGia], [SoLuongTon], [DonViTinh]) VALUES (1, N'Panadol', N'Uống sau khi ăn', CAST(13000.00 AS Decimal(15, 2)), 1000, N'Vỉ')
GO
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [HuongDanSuDung], [DonGia], [SoLuongTon], [DonViTinh]) VALUES (2, N'Efferalgan', N'Uống sau khi ăn', CAST(30000.00 AS Decimal(15, 2)), 999, N'Hộp')
GO
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [HuongDanSuDung], [DonGia], [SoLuongTon], [DonViTinh]) VALUES (3, N'Tylenol', N'Uống sau khi ăn', CAST(16000.00 AS Decimal(15, 2)), 123, N'Vỉ')
GO
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
GO
INSERT [dbo].[ChiTietDonThuoc] ([MaPhieuKhamChuaBenh], [MaThuoc], [SoLuong], [DonGiaHienTai], [HuongDanSuDung]) VALUES (2, 2, 1, CAST(30000.00 AS Decimal(15, 2)), N'Uống sau khi ăn cơm')
GO
SET IDENTITY_INSERT [dbo].[ThanhToan] ON 
GO
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaPhieuKhamChuaBenh], [NgayThanhToan], [SoTien], [GhiChu]) VALUES (1, 2, CAST(N'2023-08-02T14:05:03.937' AS DateTime), CAST(1330000.00 AS Decimal(15, 2)), N'')
GO
SET IDENTITY_INSERT [dbo].[ThanhToan] OFF
GO
SET IDENTITY_INSERT [dbo].[DichVuKhamChuaBenh] ON 
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (1, N'Khám Tổng Quát', CAST(500000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (2, N'Cạo Vôi Răng', CAST(300000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (3, N'Trám Răng', CAST(800000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (4, N'Nhổ Răng', CAST(2000000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (5, N'Khám Mắt', CAST(100000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (6, N'Khám Da Liễu', CAST(350000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (7, N'Khám Nhi', CAST(250000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (8, N'Khám Tai Mũi Họng', CAST(100000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (9, N'Khám Sản', CAST(300000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (10, N'Khám Phối', CAST(200000.00 AS Decimal(15, 2)))
GO
INSERT [dbo].[DichVuKhamChuaBenh] ([MaDichVuKhamChuaBenh], [TenDichVuKhamChuaBenh], [DonGia]) VALUES (11, N'Khám Xương Khớp', CAST(300000.00 AS Decimal(15, 2)))
GO
SET IDENTITY_INSERT [dbo].[DichVuKhamChuaBenh] OFF
GO
INSERT [dbo].[ChiTietDichVuKhamChuaBenh] ([MaPhieuKhamChuaBenh], [MaDichVuKhamChuaBenh], [NgayDangKy], [DonGiaHienTai], [SoLuong], [GhiChu]) VALUES (2, 1, CAST(N'2023-08-02T13:46:26.897' AS DateTime), CAST(500000.00 AS Decimal(15, 2)), 1, N'')
GO
INSERT [dbo].[ChiTietDichVuKhamChuaBenh] ([MaPhieuKhamChuaBenh], [MaDichVuKhamChuaBenh], [NgayDangKy], [DonGiaHienTai], [SoLuong], [GhiChu]) VALUES (2, 3, CAST(N'2023-08-02T13:46:32.313' AS DateTime), CAST(800000.00 AS Decimal(15, 2)), 1, N'')
GO
