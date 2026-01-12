# H??ng D?n Kích Ho?t Swagger UI

Swagger UI giúp b?n xem tài li?u API và test API tr?c quan. Do môi tr??ng hi?n t?i thi?u các th? vi?n (DLL) c?n thi?t, b?n c?n th?c hi?n các b??c sau ?? kích ho?t Swagger.

## B??c 1: Cài ??t NuGet Packages

M? **Package Manager Console** trong Visual Studio và ch?y l?nh sau:

```powershell
Install-Package Swashbuckle -Version 5.6.0
```

L?nh này s? cài ??t `Swashbuckle` và `Swashbuckle.Core` cùng các dependency nh? `WebActivatorEx`.

## B??c 2: Kích ho?t code c?u hình

1. M? file `App_Start/SwaggerConfig.cs`
2. B? comment (Uncomment) kh?i code trong ph??ng th?c `Register`:

```csharp
public static void Register(HttpConfiguration config)
{
    var thisAssembly = typeof(SwaggerConfig).Assembly;

    config
        .EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "Quanlysinhvien");
                c.IncludeXmlComments(GetXmlCommentsPath());
            })
        .EnableSwaggerUi(c =>
            {
            });
}
```

3. M? file `Global.asax.cs`
4. B? comment dòng ??ng ký Swagger:

```csharp
protected void Application_Start()
{
    AreaRegistration.RegisterAllAreas();
    GlobalConfiguration.Configure(WebApiConfig.Register);
    GlobalConfiguration.Configure(SwaggerConfig.Register); // <--- B? comment dòng này
    // ...
}
```

## B??c 3: T?o File XML Documentation (Tùy ch?n)

?? hi?n th? chú thích API trên Swagger:
1. Chu?t ph?i vào Project **Quanlysinhvien** > **Properties**
2. Ch?n tab **Build**
3. Tích vào **XML documentation file**
4. ??t ???ng d?n là: `bin\Quanlysinhvien.xml`

## B??c 4: Ch?y và Ki?m tra

1. Nh?n **F5** ?? ch?y ?ng d?ng.
2. Trên thanh menu, nh?n vào **Swagger API** ho?c truy c?p ???ng d?n `/swagger`.
3. B?n s? th?y giao di?n li?t kê các API c?a SinhVienController.

## Liên k?t d? li?u

Swagger s? t? ??ng quét các Controller API c?a b?n.
- **GET /api/sinhvien**: L?y danh sách
- **POST /api/sinhvien**: Thêm m?i (Copy m?u JSON t? Swagger ?? test)
- **PUT /api/sinhvien/{id}**: C?p nh?t
