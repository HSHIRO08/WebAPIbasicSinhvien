# H??ng D?n Truy C?p ?ng D?ng

## ?? L?i 404: /SinhVien/Index

B?n ?ang g?p l?i vì truy c?p URL sai.

### ? URL Sai (404)
```
http://localhost:XXXX/SinhVien/Index
```

### ? URL ?úng
Có 2 trang b?n có th? truy c?p:

#### 1. Trang Danh Sách Sinh Viên (Khuy?n Ngh?)
```
http://localhost:XXXX/SinhVienMVC
http://localhost:XXXX/SinhVienMVC/Index
```
Trang này có ??y ?? tính n?ng CRUD v?i giao di?n ??p.

#### 2. Trang Ch?
```
http://localhost:XXXX/
http://localhost:XXXX/Home/Index
```
T? trang ch?, nh?n nút **"B?t ??u"** ho?c menu **"Danh Sách Sinh Viên"** ?? vào trang qu?n lý.

## ?? C?u Trúc Controllers

| Controller | Lo?i | Route | Ch?c N?ng |
|-----------|------|-------|-----------|
| `HomeController` | MVC | `/` ho?c `/Home` | Trang ch? |
| `SinhVienMVCController` | MVC | `/SinhVienMVC` | Giao di?n CRUD sinh viên |
| `SinhVienApiController` | API | `/api/sinhvienapi` | RESTful API |

## ?? API Endpoints

N?u b?n mu?n test API tr?c ti?p:

```
GET    /api/sinhvienapi         ? L?y danh sách
GET    /api/sinhvienapi/{id}    ? L?y 1 sinh viên
POST   /api/sinhvienapi         ? Thêm m?i
PUT    /api/sinhvienapi/{id}    ? C?p nh?t
DELETE /api/sinhvienapi/{id}    ? Xóa
```

## ?? ?ã Fix

1. ? API Controller ?ã ???c ??i tên thành `SinhVienApiController`
2. ? API endpoint ?ã ???c c?p nh?t: `/api/sinhvienapi`
3. ? JavaScript ?ã ???c c?p nh?t ?? g?i ?úng API
4. ? Database ?ã ???c k?t n?i (ADO.NET)

## ?? Cách S? D?ng

1. Nh?n **F5** ?? ch?y ?ng d?ng
2. Trình duy?t s? m? trang ch? (`/` ho?c `/Home/Index`)
3. Nh?n **"B?t ??u"** ho?c menu **"Danh Sách Sinh Viên"**
4. B?n s? ???c chuy?n ??n `/SinhVienMVC/Index`

## ?? L?u Ý

- **Không** truy c?p `/SinhVien` tr?c ti?p (s? l?i 404)
- S? d?ng `/SinhVienMVC` thay th?
- N?u mu?n thay ??i, c?n t?o thêm controller m?i

---

**?ã Hoàn Thành**: ?ng d?ng s?n sàng s? d?ng v?i database SQL Server! ??
