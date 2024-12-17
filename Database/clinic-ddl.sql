

CREATE DATABASE clinic;

USE clinic;

-- -----------------------------------------------------
-- Table BenhNhan
-- -----------------------------------------------------
DROP TABLE IF EXISTS BenhNhan;
CREATE TABLE BenhNhan (
  MaBenhNhan    BIGINT          NOT NULL IDENTITY(1,1),
  HoTen         NVARCHAR(255)   NOT NULL,
  NamSinh       DATE            NOT NULL,
  GioiTinh      BIT             NOT NULL,
  DiaChi        NVARCHAR(255)   NULL,
  SoDienThoai   VARCHAR(15)     NOT NULL,
  CMND          VARCHAR(20)     NULL,
  PRIMARY KEY(MaBenhNhan)
);

-- -----------------------------------------------------
-- Table BacSi
-- -----------------------------------------------------
DROP TABLE IF EXISTS BacSi;
CREATE TABLE BacSi (
  MaBacSi       BIGINT        NOT NULL IDENTITY(1,1),
  HoTen         NVARCHAR(255) NOT NULL,
  NamSinh       DATE          NOT NULL,
  GioiTinh      BIT           NOT NULL,
  DiaChi        NVARCHAR(255) NOT NULL,
  SoDienThoai   VARCHAR(15)   NOT NULL,
  CMND          VARCHAR(20)   NOT NULL,
  TrinhDo       NVARCHAR(30)  NOT NULL,
  ChuyenNganh   NVARCHAR(70)  NOT NULL,
  PRIMARY KEY(MaBacSi)
);


-- -----------------------------------------------------
-- Table Benh
-- -----------------------------------------------------
DROP TABLE IF EXISTS Benh;
CREATE TABLE Benh (
  MaBenh    BIGINT        NOT NULL IDENTITY(1,1),
  TenBenh   NVARCHAR(255) NOT NULL,
  PRIMARY KEY(MaBenh)
);


-- -----------------------------------------------------
-- Table Thuoc
-- -----------------------------------------------------
DROP TABLE IF EXISTS Thuoc;
CREATE TABLE Thuoc (
  MaThuoc         BIGINT        NOT NULL IDENTITY(1,1),
  TenThuoc        NVARCHAR(45)  NOT NULL,
  HuongDanSuDung  NTEXT         NOT NULL,
  DonGia          DECIMAL(15,2) NOT NULL,
  SoLuongTon      INT           NOT NULL,
  DonViTinh       NVARCHAR(10)  NOT NULL,
  PRIMARY KEY(MaThuoc)
);


-- -----------------------------------------------------
-- Table PhieuKhamChuaBenh
-- -----------------------------------------------------
DROP TABLE IF EXISTS PhieuKhamChuaBenh;
CREATE TABLE PhieuKhamChuaBenh (
  MaPhieuKhamChuaBenh     BIGINT    NOT NULL IDENTITY(1,1),
  MaBenhNhan              BIGINT    NOT NULL,
  MaBacSi                 BIGINT    NOT NULL,
  NgayDangKy              DATETIME  NOT NULL,
  GhiChu                  NTEXT     NULL,
  FOREIGN KEY(MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(MaBacSi)    REFERENCES BacSi(MaBacSi)       ON DELETE CASCADE ON UPDATE CASCADE,
  PRIMARY KEY(MaPhieuKhamChuaBenh)
);


-- -----------------------------------------------------
-- Table ChiTietBenh
-- -----------------------------------------------------
DROP TABLE IF EXISTS ChiTietBenh;
CREATE TABLE ChiTietBenh (
  MaPhieuKhamChuaBenh   BIGINT    NOT NULL,
  MaBenh                BIGINT    NOT NULL,
  NgayChuanDoan         DATETIME  NOT NULL,
  PhuongPhapDieuTri     NTEXT     NOT NULL,
  FOREIGN KEY(MaPhieuKhamChuaBenh) REFERENCES PhieuKhamChuaBenh(MaPhieuKhamChuaBenh) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(MaBenh)              REFERENCES Benh(MaBenh)                           ON DELETE CASCADE ON UPDATE CASCADE,
  PRIMARY KEY(MaPhieuKhamChuaBenh, MaBenh)
);


-- -----------------------------------------------------
-- Table ChiTietDonThuoc
-- -----------------------------------------------------
DROP TABLE IF EXISTS ChiTietDonThuoc;
CREATE TABLE ChiTietDonThuoc (
  MaPhieuKhamChuaBenh  BIGINT         NOT NULL,
  MaThuoc              BIGINT         NOT NULL ,
  SoLuong              INT            NOT NULL,
  DonGiaHienTai        DECIMAL(15,2)  NOT NULL,
  HuongDanSuDung       NTEXT          NOT NULL,
  FOREIGN KEY(MaPhieuKhamChuaBenh) REFERENCES PhieuKhamChuaBenh(MaPhieuKhamChuaBenh) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(MaThuoc)             REFERENCES Thuoc(MaThuoc)                         ON DELETE CASCADE ON UPDATE CASCADE,
  PRIMARY KEY(MaPhieuKhamChuaBenh, MaThuoc)
);


-- -----------------------------------------------------
-- Table DichVuKhamChuaBenh
-- -----------------------------------------------------
DROP TABLE IF EXISTS DichVuKhamChuaBenh;
CREATE TABLE DichVuKhamChuaBenh (
  MaDichVuKhamChuaBenh    BIGINT        NOT NULL IDENTITY(1,1),
  TenDichVuKhamChuaBenh   NVARCHAR(255) NOT NULL,
  DonGia                  DECIMAL(15,2) NOT NULL,
  PRIMARY KEY(MaDichVuKhamChuaBenh)
);


-- -----------------------------------------------------
-- Table ThanhToan
-- -----------------------------------------------------
DROP TABLE IF EXISTS ThanhToan;
CREATE TABLE ThanhToan (
  MaThanhToan          BIGINT         NOT NULL IDENTITY(1,1),
  MaPhieuKhamChuaBenh  BIGINT         NOT NULL,
  NgayThanhToan        DATETIME       NOT NULL,
  SoTien               DECIMAL(15,2)  NOT NULL,
  GhiChu               NVARCHAR(255)  NULL,
  FOREIGN KEY(MaPhieuKhamChuaBenh) REFERENCES PhieuKhamChuaBenh(MaPhieuKhamChuaBenh) ON DELETE CASCADE ON UPDATE CASCADE,
  PRIMARY KEY(MaThanhToan)
);


-- -----------------------------------------------------
-- Table ChiTietDichVuKhamChuaBenh
-- -----------------------------------------------------
DROP TABLE IF EXISTS ChiTietDichVuKhamChuaBenh;
CREATE TABLE ChiTietDichVuKhamChuaBenh (
  MaPhieuKhamChuaBenh   BIGINT        NOT NULL,
  MaDichVuKhamChuaBenh  BIGINT        NOT NULL,
  NgayDangKy            DATETIME      NOT NULL,
  DonGiaHienTai         DECIMAL(15,2) NOT NULL,
  SoLuong               INT           NOT NULL,
  GhiChu                NTEXT         NULL,
  FOREIGN KEY(MaPhieuKhamChuaBenh)   REFERENCES PhieuKhamChuaBenh(MaPhieuKhamChuaBenh)   ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(MaDichVuKhamChuaBenh)  REFERENCES DichVuKhamChuaBenh(MaDichVuKhamChuaBenh) ON DELETE CASCADE ON UPDATE CASCADE,
  PRIMARY KEY(MaPhieuKhamChuaBenh, MaDichVuKhamChuaBenh)
);
