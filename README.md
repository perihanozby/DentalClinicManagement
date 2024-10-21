**Diş Kliniği Yönetim Sistemi 
Bu proje, bir diş kliniğini yönetmek için geliştirilmiş bir ASP.NET Core MVC uygulamasıdır.
Doktorları, hastaları, randevuları ve ürünleri yönetme işlevselliğini içerir.

**Gereksinimler

*ASP.NET Core 7 veya daha yeni bir sürüm 
*Visual Studio 2022 veya Visual Studio Code 
*SQLite

**Kurulum Talimatları

*Depoyu klonlayın: Copygit clone https://github.com/perihanozby/DentalClinicManagement 
cd DentalClinicManagement

*Bağlantı dizesini güncelleyin:

appsettings.json dosyasını açın
DefaultConnection dizesini SQL Server örneğinize işaret edecek şekilde güncelleyin

*Veritabanı migrasyonlarını uygulayın: 
dotnet ef database update

*Uygulamayı çalıştırın: 
dotnet run

*Bir web tarayıcısı açın ve https://localhost:5271 adresine gidin

**Proje Yapısı

*Controllers/: MVC denetleyicilerini içerir (AppointmentController, DoctorController, HomeController, PatientController, ProductController) 
*Models/: Veri modellerini içerir (Appointment, Doctor, Patient, Product) 
*Views/: Her denetleyici için Razor görünümlerini içerir 
*Data/: ApplicationDbContext ve veritabanı migrasyonlarını içerir

**Özellikler

*Doktorları yönetme (CRUD işlemleri) 
*Hastaları yönetme (CRUD işlemleri) 
*Randevuları planlama ve yönetme 
*Diş ürün stoğunu yönetme
