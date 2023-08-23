using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CrystalClarityEyewearWebApp.Areas.Identity.Data;
using System.Configuration;
using CrystalClarityEyewearWebApp.Services;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppContextConnection") ?? throw new InvalidOperationException("Connection string 'AppContextConnection' not found.");

builder.Services.AddDbContext<CrystalClarityEyewearWebApp.Areas.Identity.Data.AppContext>(options => options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<CrystalClarityEyewearWebApp.Areas.Identity.Data.AppContext>();
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<CrystalClarityEyewearWebApp.Areas.Identity.Data.AppContext>()
    .AddDefaultTokenProviders();

//builder.Services.AddDefaultIdentity<ApplicationUser>()
//    .AddEntityFrameworkStores<CrystalClarityEyewearWebApp.Areas.Identity.Data.AppContext>()
//    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddOptions();                                        // Kích hoạt Options
var mailsettings = builder.Configuration.GetSection("MailSettings");  // đọc config
builder.Services.Configure<MailSettings>(mailsettings);               // đăng ký để Inject

builder.Services.AddTransient<IEmailSender, SendMailService>();       // Đăng ký dịch vụ Mail

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login/";
    options.LogoutPath = "/logout/";
    options.AccessDeniedPath = "/khong-duoc-truy-cap.html";
});

builder.Services.AddAuthentication()
    .AddGoogle(options =>
    {
        var ggconfig = builder.Configuration.GetSection("Authentication:Google");
        options.ClientId = ggconfig["ClientId"];
        options.ClientSecret = ggconfig["ClientSecret"];
        //https://localhost:7117/dang-nhap-tu-google
        options.CallbackPath = "/dang-nhap-tu-google";
    })
    .AddFacebook(options =>
    {
        var fconfig = builder.Configuration.GetSection("Authentication:Facebook");
        options.ClientId = fconfig["AppId"];
        options.ClientSecret = fconfig["AppSecret"];
        //https://localhost:7117/dang-nhap-tu-facebook
        options.CallbackPath = "/dang-nhap-tu-facebook";
    });

builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options => {
    // Thiết lập về Password
    options.Password.RequireDigit = false; // Không bắt phải có số
    options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
    options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
    options.Password.RequireUppercase = false; // Không bắt buộc chữ in
    options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
    options.Password.RequiredUniqueChars = 0; // Số ký tự riêng biệt

    // Cấu hình Lockout - khóa user
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2); // Khóa 2 phút
    options.Lockout.MaxFailedAccessAttempts = 3; // Thất bại 3 lần thì khóa
    options.Lockout.AllowedForNewUsers = true;

    // Cấu hình về User.
    options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true; // Email là duy nhất

    // Cấu hình đăng nhập.
    options.SignIn.RequireConfirmedEmail = true; // Cấu hình xác thực địa chỉ email (email phải tồn tại)
    options.SignIn.RequireConfirmedPhoneNumber = false; // Xác thực số điện thoại
    options.SignIn.RequireConfirmedEmail = false; // Phải xác nhận email mới đăng nhập được

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
