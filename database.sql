-- T?o c? s? d? li?u
CREATE DATABASE QuanLySinhVienDB;
GO

USE QuanLySinhVienDB;
GO

-- T?o b?ng SinhVien
CREATE TABLE SinhVien (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MaSinhVien NVARCHAR(20) NOT NULL UNIQUE,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(200),
    Email NVARCHAR(100),
    SoDienThoai NVARCHAR(20),
    Lop NVARCHAR(50),
    NgayTao DATETIME DEFAULT GETDATE()
);
GO

-- Thêm d? li?u m?u
INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, Lop)
VALUES 
(N'SV001', N'Nguy?n V?n A', '2000-01-15', N'Nam', N'Hà N?i', 'nguyenvana@email.com', '0912345678', 'CNTT2020'),
(N'SV002', N'Tr?n Th? B', '2000-05-20', N'N?', N'H? Chí Minh', 'tranthib@email.com', '0987654321', 'CNTT2020'),
(N'SV003', N'Lê V?n C', '2001-08-10', N'Nam', N'?à N?ng', 'levanc@email.com', '0905123456', 'KTPM2021'),
(N'SV004', N'Ph?m Th? D', '2001-12-25', N'N?', N'C?n Th?', 'phamthid@email.com', '0912987654', 'KTPM2021'),
(N'SV005', N'Hoàng V?n E', '2000-03-30', N'Nam', N'H?i Phòng', 'hoangvane@email.com', '0931456789', 'HTTT2020');
GO

-- Xác nh?n d? li?u
SELECT * FROM SinhVien;
GO
