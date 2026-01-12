# H??ng D?n Hoàn T?t K?t N?i Database

## ? ?ã Hoàn Thành
1. ? S?a `SinhVienService.cs` ?? s? d?ng ADO.NET k?t n?i SQL Server
2. ? Thêm chu?i k?t n?i `QuanLySinhVienConnection` vào `Web.config`
3. ? Comment code Entity Framework c? (không dùng)
4. ? Build thành công

## ?? Các B??c Ti?p Theo

### B??c 1: T?o Database
M? **SQL Server Management Studio** (SSMS) và ch?y file `database.sql`:

```sql
-- File này s? t?o:
-- 1. Database: QuanLySinhVienDB
-- 2. Table: SinhVien
-- 3. 5 dòng d? li?u m?u
```

**Cách ch?y:**
1. M? SSMS
2. K?t n?i ??n server `MaiHoang08\SQLEXPRESS` (ho?c server c?a b?n)
3. File ? Open ? File ? Ch?n `database.sql`
4. Nh?n **Execute** (F5)
5. Ki?m tra: Refresh "Databases" folder, b?n s? th?y `QuanLySinhVienDB`

### B??c 2: Ki?m Tra Connection String
M? file `Web.config` và xác nh?n chu?i k?t n?i ?úng:

```xml
<connectionStrings>
  <add name="QuanLySinhVienConnection" 
       connectionString="Data Source=MaiHoang08\SQLEXPRESS;Initial Catalog=QuanLySinhVienDB;Integrated Security=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

**N?u server name c?a b?n khác:**
- M? SSMS, xem tên server ? góc trên bên trái
- Thay th? `MaiHoang08\SQLEXPRESS` b?ng tên server c?a b?n

### B??c 3: Ch?y ?ng D?ng
1. Nh?n **F5** trong Visual Studio
2. Truy c?p `/SinhVienMVC`
3. B?n s? th?y 5 sinh viên m?u t? database

### B??c 4: Test CRUD Operations
- **Thêm**: Nh?n "+ Thêm Sinh Viên" ? ?i?n form ? L?u
- **Xem**: Danh sách t? ??ng load t? database
- **S?a**: Nh?n nút "S?a" ? Ch?nh s?a ? L?u
- **Xóa**: Nh?n nút "Xóa" ? Xác nh?n

## ?? X? Lý L?i

### L?i: "Cannot open database 'QuanLySinhVienDB'"
**Nguyên nhân**: Database ch?a ???c t?o  
**Gi?i pháp**: Ch?y file `database.sql` trong SSMS (xem B??c 1)

### L?i: "Login failed for user..."
**Nguyên nhân**: Connection string không ?úng  
**Gi?i pháp**: 
1. Ki?m tra tên server trong SSMS
2. C?p nh?t `Data Source=...` trong Web.config

### L?i: "A network-related error occurred"
**Nguyên nhân**: SQL Server service không ch?y  
**Gi?i pháp**: 
1. M? "Services" (Windows + R ? `services.msc`)
2. Tìm "SQL Server (SQLEXPRESS)"
3. Nh?n chu?t ph?i ? Start

### D? li?u không hi?n th?
**Gi?i pháp**:
1. M? browser Console (F12)
2. Ki?m tra logs: "API Response:", "Data received:"
3. Ki?m tra SQL Server: 
   ```sql
   USE QuanLySinhVienDB;
   SELECT * FROM SinhVien;
   ```

## ?? C?u Trúc Database

```
QuanLySinhVienDB
??? SinhVien (Table)
    ??? Id (INT, PRIMARY KEY, IDENTITY)
    ??? MaSinhVien (NVARCHAR(20), UNIQUE)
    ??? HoTen (NVARCHAR(100))
    ??? NgaySinh (DATE)
    ??? GioiTinh (NVARCHAR(10))
    ??? DiaChi (NVARCHAR(200))
    ??? Email (NVARCHAR(100))
    ??? SoDienThoai (NVARCHAR(20))
    ??? Lop (NVARCHAR(50))
    ??? NgayTao (DATETIME, DEFAULT GETDATE())
```

## ?? API Endpoints

T?t c? d? li?u gi? ???c l?u vào SQL Server:

```
GET    /api/sinhvien         ? L?y danh sách (t? DB)
GET    /api/sinhvien/{id}    ? L?y 1 sinh viên (t? DB)
POST   /api/sinhvien         ? Thêm m?i (vào DB)
PUT    /api/sinhvien/{id}    ? C?p nh?t (trong DB)
DELETE /api/sinhvien/{id}    ? Xóa (kh?i DB)
```

## ?? Ki?m Tra K?t N?i

M? SQL Server Profiler (n?u có) ho?c xem trong SSMS:

```sql
-- Xem query log
USE QuanLySinhVienDB;
GO

-- Ki?m tra s? l??ng
SELECT COUNT(*) AS TotalRecords FROM SinhVien;

-- Xem t?t c? d? li?u
SELECT * FROM SinhVien ORDER BY NgayTao DESC;
```

## ?? L?u Ý

1. **Backup**: Database ?ang dùng In-Memory trong SQL Server (không persist khi restart server). N?u c?n persist, ??m b?o database file (.mdf) ???c l?u ?úng n?i.

2. **Performance**: N?u có nhi?u d? li?u (>10000 records), nên thêm indexes:
   ```sql
   CREATE INDEX IX_MaSinhVien ON SinhVien(MaSinhVien);
   CREATE INDEX IX_Lop ON SinhVien(Lop);
   ```

3. **Security**: Connection string hi?n dùng `Integrated Security=True` (Windows Authentication). N?u deploy lên server, có th? c?n SQL Authentication.

---

**Version**: 1.0 (v?i Database Integration)  
**Database**: SQL Server  
**ORM**: ADO.NET (SqlConnection)
