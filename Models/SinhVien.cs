using System;

namespace Quanlysinhvien.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string Lop { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
