Di� Klini�i Y�netim Sistemi
Bu proje, bir di� klini�ini y�netmek i�in geli�tirilmi� bir ASP.NET Core MVC uygulamas�d�r. Doktorlar�, hastalar�, randevular� ve �r�nleri y�netme i�levselli�ini i�erir.
Gereksinimler

ASP.NET Core 7 veya daha yeni bir s�r�m
Visual Studio 2022 veya Visual Studio Code
SQL Server (LocalDB veya tam s�r�m)

Kurulum Talimatlar�

Depoyu klonlay�n:
Copygit clone https://github.com/kullaniciadin/DentalClinicManagement.git
cd DentalClinicManagement

Ba�lant� dizesini g�ncelleyin:

appsettings.json dosyas�n� a��n
DefaultConnection dizesini SQL Server �rne�inize i�aret edecek �ekilde g�ncelleyin


Veritaban� migrasyonlar�n� uygulay�n:
Copydotnet ef database update

Uygulamay� �al��t�r�n:
Copydotnet run

Bir web taray�c�s� a��n ve https://localhost:5271 adresine gidin

Proje Yap�s�

Controllers/: MVC denetleyicilerini i�erir (AppointmentController, DoctorController, HomeController, PatientController, ProductController)
Models/: Veri modellerini i�erir (Appointment, Doctor, Patient, Product)
Views/: Her denetleyici i�in Razor g�r�n�mlerini i�erir
Data/: ApplicationDbContext ve veritaban� migrasyonlar�n� i�erir

�zellikler

Doktorlar� y�netme (CRUD i�lemleri)
Hastalar� y�netme (CRUD i�lemleri)
Randevular� planlama ve y�netme
Di� �r�nlerini y�netme
