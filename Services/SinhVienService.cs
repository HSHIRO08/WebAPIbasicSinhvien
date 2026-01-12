using System;
using System.Collections.Generic;
using System.Linq;
using Quanlysinhvien.Models;

namespace Quanlysinhvien.Services
{
    public interface ISinhVienService
    {
        List<SinhVien> GetAllSinhVien();
        SinhVien GetSinhVienById(int id);
        SinhVien CreateSinhVien(SinhVien sinhVien);
        bool UpdateSinhVien(int id, SinhVien sinhVien);
        bool DeleteSinhVien(int id);
    }

    public class SinhVienService : ISinhVienService
    {
        private static List<SinhVien> danhSachSinhVien = new List<SinhVien>
        {
            new SinhVien
            {
                Id = 1,
                MaSinhVien = "SV001",
                HoTen = "Nguyễn Văn A",
                NgaySinh = new DateTime(2000, 1, 15),
                GioiTinh = "Nam",
                DiaChi = "Hà Nội",
                Email = "nguyenvana@email.com",
                SoDienThoai = "0912345678",
                Lop = "CNTT2020",
                NgayTao = DateTime.Now
            },
            new SinhVien
            {
                Id = 2,
                MaSinhVien = "SV002",
                HoTen = "Trần Thị B",
                NgaySinh = new DateTime(2000, 5, 20),
                GioiTinh = "Nữ",
                DiaChi = "H? Chí Minh",
                Email = "tranthib@email.com",
                SoDienThoai = "0987654321",
                Lop = "CNTT2020",
                NgayTao = DateTime.Now
            }
        };

        public List<SinhVien> GetAllSinhVien()
        {
            return danhSachSinhVien;
        }

        public SinhVien GetSinhVienById(int id)
        {
            return danhSachSinhVien.FirstOrDefault(s => s.Id == id);
        }

        public SinhVien CreateSinhVien(SinhVien sinhVien)
        {
            if (sinhVien == null)
                return null;

            sinhVien.Id = danhSachSinhVien.Count > 0 ? danhSachSinhVien.Max(s => s.Id) + 1 : 1;
            sinhVien.NgayTao = DateTime.Now;
            danhSachSinhVien.Add(sinhVien);
            return sinhVien;
        }

        public bool UpdateSinhVien(int id, SinhVien sinhVien)
        {
            var existingSinhVien = danhSachSinhVien.FirstOrDefault(s => s.Id == id);
            if (existingSinhVien == null)
                return false;

            existingSinhVien.MaSinhVien = sinhVien.MaSinhVien;
            existingSinhVien.HoTen = sinhVien.HoTen;
            existingSinhVien.NgaySinh = sinhVien.NgaySinh;
            existingSinhVien.GioiTinh = sinhVien.GioiTinh;
            existingSinhVien.DiaChi = sinhVien.DiaChi;
            existingSinhVien.Email = sinhVien.Email;
            existingSinhVien.SoDienThoai = sinhVien.SoDienThoai;
            existingSinhVien.Lop = sinhVien.Lop;

            return true;
        }

        public bool DeleteSinhVien(int id)
        {
            var sinhVien = danhSachSinhVien.FirstOrDefault(s => s.Id == id);
            if (sinhVien == null)
                return false;

            danhSachSinhVien.Remove(sinhVien);
            return true;
        }
    }
}
