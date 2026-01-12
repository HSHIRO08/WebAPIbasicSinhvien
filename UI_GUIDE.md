# H? Th?ng Qu?n Lý Sinh Viên - Giao Di?n Ng??i Dùng

## ?? T?ng Quan

?ây là ?ng d?ng Web qu?n lý sinh viên ???c xây d?ng b?ng ASP.NET Web API 4.7.2 và Bootstrap 5. ?ng d?ng cung c?p giao di?n tr?c quan ?? qu?n lý thông tin sinh viên.

## ?? Các Tính N?ng

### 1. **Danh Sách Sinh Viên** (`/SinhVienMVC`)
   - Hi?n th? b?ng danh sách t?t c? sinh viên
   - Tìm ki?m theo tên sinh viên ho?c mã sinh viên
   - L?c theo l?p h?c
   - S?p x?p c?t (click vào tiêu ?? c?t)

### 2. **Thêm Sinh Viên M?i**
   - Nút "+ Thêm Sinh Viên" ? góc trên ph?i
   - M? modal form ?? nh?p thông tin
   - Validation d? li?u tr??c khi l?u
   - T? ??ng t?o ID sinh viên

### 3. **Ch?nh S?a Sinh Viên**
   - Nh?n nút "S?a" trong b?ng
   - ?i?n l?i thông tin trong form modal
   - L?u thay ??i

### 4. **Xóa Sinh Viên**
   - Nh?n nút "Xóa" trong b?ng
   - Xác nh?n tr??c khi xóa
   - Xóa t?c thì t? danh sách

## ?? Giao Di?n Responsive

- **Desktop**: Hi?n th? ??y ?? b?ng d? li?u v?i t?t c? c?t
- **Tablet**: B?ng co l?i, nút ?i?u khi?n hi?n th? ??y ??
- **Mobile**: Giao di?n vertical, d? s? d?ng trên ?i?n tho?i

## ??? C?u Trúc Giao Di?n

```
Views/
??? Shared/
?   ??? _Layout.cshtml          # Layout chính cho t?t c? trang
??? Home/
?   ??? Index.cshtml            # Trang ch?
??? SinhVien/
    ??? Index.cshtml            # Danh sách sinh viên

Content/
??? style.css                   # CSS tùy ch?nh
??? site.js                     # Các utility JS chung
??? sinhvien.js                 # JS cho trang sinh viên

Controllers/
??? SinhVienMVCController.cs    # Controller MVC cho giao di?n
```

## ?? Thi?t K? Visual

### Màu S?c
- **Xanh d??ng (Primary)**: `#0d6efd` - Các nút chính, header
- **?en (Dark)**: `#212529` - Text chính, navigation
- **Xám (Secondary)**: `#6c757d` - Text ph?, badges
- **Xanh lá (Success)**: `#198754` - Hành ??ng thành công
- **?? (Danger)**: `#dc3545` - Hành ??ng nguy hi?m (xóa)
- **Cyan (Info)**: `#0dcaf0` - Thông tin

### Fonts
- **Primary**: Segoe UI, Tahoma, Geneva
- **Size**: 14px (body), 16px (label), 32px (heading)

## ?? Các Tr??ng Thông Tin

| Tr??ng | Ki?u | B?t Bu?c | Mô T? |
|--------|------|---------|-------|
| Mã Sinh Viên | Text | ? | VD: SV001 |
| H? Tên | Text | ? | Tên ??y ?? |
| Ngày Sinh | Date | ? | DD/MM/YYYY |
| Gi?i Tính | Select | ? | Nam/N?/Khác |
| L?p | Text | ? | VD: CNTT2020 |
| ??a Ch? | Text | ? | ??a ch? th??ng trú |
| Email | Email | ? | Email h?p l? |
| S? ?i?n Tho?i | Text | ? | 10-11 ch? s? |

## ?? Lu?ng Thao Tác

### Thêm Sinh Viên
1. Nh?n "+ Thêm Sinh Viên"
2. Modal m? lên, form tr?ng
3. ?i?n các tr??ng b?t bu?c
4. Nh?n "L?u"
5. Thông báo thành công
6. Danh sách c?p nh?t t?c thì

### S?a Sinh Viên
1. Tìm sinh viên trong danh sách
2. Nh?n nút "S?a" c?a dòng ?ó
3. Modal m? lên, form có d? li?u c?
4. Ch?nh s?a thông tin
5. Nh?n "L?u"
6. Danh sách c?p nh?t

### Xóa Sinh Viên
1. Tìm sinh viên trong danh sách
2. Nh?n nút "Xóa" c?a dòng ?ó
3. H?p tho?i xác nh?n hi?n lên
4. Ch?n "OK" ?? xác nh?n
5. Sinh viên b? xóa kh?i danh sách

## ?? Cách S? D?ng

### Ch?y ?ng D?ng
```
1. M? Solution trong Visual Studio
2. Nh?n F5 ho?c Ctrl+F5
3. Trình duy?t m? trang ch?
4. Nh?n "Qu?n Lý Sinh Viên" ho?c "Danh Sách Sinh Viên"
```

### API Endpoints
```
GET    /api/sinhvien              - L?y danh sách t?t c?
GET    /api/sinhvien/{id}         - L?y chi ti?t m?t sinh viên
POST   /api/sinhvien              - Thêm sinh viên m?i
PUT    /api/sinhvien/{id}         - C?p nh?t sinh viên
DELETE /api/sinhvien/{id}         - Xóa sinh viên
```

## ?? D? Li?u M?u

H? th?ng ?i kèm 2 sinh viên m?u:
1. **Nguy?n V?n A** (SV001) - CNTT2020
2. **Tr?n Th? B** (SV002) - CNTT2020

## ?? C?u Hình

### Dependencies
- ASP.NET Web API 2.2
- Bootstrap 5
- jQuery 3.x
- Modernizr

### Supported Browsers
- Chrome 90+
- Firefox 88+
- Safari 14+
- Edge 90+

## ?? X? Lý L?i

### Các thông báo l?i chung:
- "D? li?u không h?p l?" - Form có l?i validation
- "Sinh viên không t?n t?i" - ID không tìm th?y
- "L?i khi t?i danh sách" - Server error

### Ki?m Tra
- Nh?p email sai ??nh d?ng ?? th?y validate
- ?? tr?ng tr??ng b?t bu?c ?? th?y l?i
- Nh?n xóa mà không xác nh?n ?? h?y

## ?? Mobile Optimization

- Responsive design t? ??ng adjust
- Touch-friendly buttons (44px minimum)
- B?ng cu?n ngang trên mobile
- Modal form ??y ?? màn hình trên mobile

## ?? Security

- CSRF Token validation (ASP.NET MVC)
- Input validation both client & server
- Confirm dialog tr??c khi xóa
- Error messages không ti?t l? chi ti?t h? th?ng

## ?? C?i Ti?n T??ng Lai

- [ ] Thêm phân trang (Pagination)
- [ ] Export danh sách ra Excel
- [ ] In báo cáo
- [ ] Tìm ki?m nâng cao (Advanced Search)
- [ ] Sort c?t trong b?ng
- [ ] Upload ?nh ??i di?n
- [ ] Báo cáo th?ng kê
- [ ] Authentication & Authorization

## ?? H? Tr?

?? báo cáo l?i ho?c ?? xu?t tính n?ng, vui lòng liên h? administrator.

---

**Version**: 1.0  
**Last Updated**: 2024  
**Framework**: ASP.NET Web API 4.7.2  
**Status**: Active ?
