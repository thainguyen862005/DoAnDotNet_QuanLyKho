using QuanLyKho.Components;
using Microsoft.EntityFrameworkCore;
using QuanLyKho.Data;
using QuanLyKho.Services; // Đảm bảo có dòng này để nhận diện IProductService
using Microsoft.AspNetCore.Components.Authorization;
using QuanLyKho.Auth;

var builder = WebApplication.CreateBuilder(args);

// 1. Thêm các dịch vụ Razor Components và Interactive Server
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// 2. Cấu hình kết nối SQL Server
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")),
    ServiceLifetime.Transient 
);    


// Cấu hình kết nối SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Không tìm thấy chuỗi kết nối 'DefaultConnection'.");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// 3. ĐĂNG KÝ SERVICES (Quan trọng nhất - Thiếu cái này trang Product sẽ lỗi)
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

// 4. Đăng ký IWebHostEnvironment (Nếu cần dùng cho Upload ảnh)
// Lưu ý: IWebHostEnvironment đã được builder mặc định đăng ký sẵn

var app = builder.Build();

// 5. Cấu hình Pipeline xử lý HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found");
app.UseHttpsRedirection();

// Cho phép truy cập các file trong thư mục wwwroot (như ảnh sản phẩm)
app.UseStaticFiles(); 
 
app.UseStaticFiles();  
 

app.UseAntiforgery();

// 6. Cấu hình Routing cho Blazor
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();