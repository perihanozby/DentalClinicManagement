Diþ Kliniði Yönetim Sistemi
Bu proje, bir diþ kliniðini yönetmek için geliþtirilmiþ bir ASP.NET Core MVC uygulamasýdýr. Doktorlarý, hastalarý, randevularý ve ürünleri yönetme iþlevselliðini içerir.
Gereksinimler

ASP.NET Core 7 veya daha yeni bir sürüm
Visual Studio 2022 veya Visual Studio Code
SQL Server (LocalDB veya tam sürüm)

Kurulum Talimatlarý

Depoyu klonlayýn:
Copygit clone https://github.com/kullaniciadin/DentalClinicManagement.git
cd DentalClinicManagement

Baðlantý dizesini güncelleyin:

appsettings.json dosyasýný açýn
DefaultConnection dizesini SQL Server örneðinize iþaret edecek þekilde güncelleyin


Veritabaný migrasyonlarýný uygulayýn:
Copydotnet ef database update

Uygulamayý çalýþtýrýn:
Copydotnet run

Bir web tarayýcýsý açýn ve https://localhost:5271 adresine gidin

Proje Yapýsý

Controllers/: MVC denetleyicilerini içerir (AppointmentController, DoctorController, HomeController, PatientController, ProductController)
Models/: Veri modellerini içerir (Appointment, Doctor, Patient, Product)
Views/: Her denetleyici için Razor görünümlerini içerir
Data/: ApplicationDbContext ve veritabaný migrasyonlarýný içerir

Özellikler

Doktorlarý yönetme (CRUD iþlemleri)
Hastalarý yönetme (CRUD iþlemleri)
Randevularý planlama ve yönetme
Diþ ürünlerini yönetme
