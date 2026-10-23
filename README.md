# Kutupoto – Library Automation

**[English](#english) | [Türkçe](#türkçe)**

---

## English

Kutupoto is a **Windows desktop library automation** application built for school and small libraries. It manages books, readers and book loans from a single place. Data is stored in a local **SQL Server** database (`KOSDb`).

### Features

#### Login and Registration
- Login screen with username and password.
- Registration screen for new users (first name, last name, username, password).
- Password rules: at least 6 characters, at least 1 uppercase and 1 lowercase letter, letters and digits only.
- Passwords are stored as a **SHA-256 hash**, not as plain text.
- All queries use parameterized SQL to protect against SQL injection.

#### Home Page
- Lists **books currently on loan** that have not been returned yet, with their due dates.
- Lists the **available books** on the shelves.
- **Live search** by book title, author or registration number.
- **Filter by genre**.
- Lists registered **readers**.
- Opens the book, reader and loan screens.

#### Book Management
- Add a book: registration no, title, author, page count, genre, publisher, publication year, cabinet no and shelf no.
- The registration number is assigned automatically.
- Update book details.
- Delete a book. After deletion, registration numbers are renumbered.

#### Reader (Member) Management
- Add a reader: first name, last name, gender, class, school no, mobile phone, address.
- Update reader details.
- Delete a reader. The record is not removed from the database; it is marked inactive.

#### Loans
- Lend a book to the selected reader. The loan period is **30 days**.
- A reader can borrow only one book at a time.
- **Extend loan**: adds 30 days to the current due date.
- **Return**: the book appears on the shelf again.
- **Late fee**: if the due date has passed, 1 TL is charged per day. Before extending or returning, the app asks whether the fee has been collected.

#### Automatic Database Setup
- On first launch the app checks whether the `KOSDb` database exists. If not, it runs `KOSDB.sql` and creates the database and tables itself.

### Tech Stack

| Area | Technology |
| --- | --- |
| Language | C# |
| Platform | .NET 6 (`net6.0-windows`) |
| UI | Windows Forms |
| Database | Microsoft SQL Server (Express) |
| Data access | ADO.NET – `System.Data.SqlClient` 4.8.5 |
| IDE | Visual Studio 2022 |

### Database Schema

`KOSDB.sql` creates four tables:

| Table | Description |
| --- | --- |
| `kullanicilar` | Users who log in to the app (passwords as SHA-256 hashes) |
| `kitaplar` | Books. `durum = 1` on the shelf, `0` on loan; `aktif` marks whether the record is valid |
| `okuyucular` | Readers (members) |
| `emanetler` | Loan records: issue, due and transaction dates |

All SQL queries used in the project are listed in `queries.sql`.

### Installation

#### Requirements
- Windows 10/11
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) (or Visual Studio 2022 with the ".NET desktop development" workload)
- [SQL Server Express](https://www.microsoft.com/sql-server/sql-server-downloads). The default instance name should be `SQLEXPRESS`.
- (Optional) SQL Server Management Studio (SSMS)

#### 1. Clone the project
```bash
git clone https://github.com/Simsek00/Kutupoto.git
cd Kutupoto
```

#### 2. Create the database

**Option A – Automatic (recommended):** Nothing to do. If the app cannot find `KOSDb` on first launch, it runs the `KOSDB.sql` file copied to the output folder and shows a "Kurulum Tamamlandı" (Setup complete) message.

**Option B – Manual (with SSMS):**
1. Open SSMS and connect to `.\SQLEXPRESS` using **Windows Authentication**.
2. Open `KOSDB.sql` via `File → Open → File...`.
3. Run it with **Execute** (F5). The script only creates `KOSDb` and the tables if they don't exist, so running it again is safe.

Or from the command line:
```bash
sqlcmd -S .\SQLEXPRESS -E -i KOSDB.sql
```

#### 3. Check the connection string

By default the app connects to the local `.\SQLEXPRESS` instance using Windows authentication. If your SQL Server instance has a different name (for example `(localdb)\MSSQLLocalDB` or `COMPUTERNAME\SQLEXPRESS`), change the connection string in **both** of these files:

| File | Variable | Used for |
| --- | --- | --- |
| `Model/IDataBase.cs` | `connectionString` | All app queries (`Database=KOSDb`) |
| `Model/DatabaseKurulum.cs` | `masterConnectionString` | First-run database check and creation (`Database=master`) |

```csharp
// Model/IDataBase.cs
public static string connectionString = "Server=.\\SQLEXPRESS; Database=KOSDb; Integrated Security=True; TrustServerCertificate=True;";
```

#### 4. Build and run

Open `Kutupoto.sln` in Visual Studio and press **F5**. Or from the command line:
```bash
dotnet run --project Kutupoto.csproj
```

#### 5. First use
1. On the login screen, create a user with **Kayıt Ol** (Register).
2. Log in with that user.
3. Add books and readers first, then lend books from the loan screen.

### Screenshots

> Screenshots will be added. Put images in `docs/screenshots/` and update the lines below.

| Login | Home |
| --- | --- |
| ![Login screen](docs/screenshots/giris.png) | ![Home page](docs/screenshots/anasayfa.png) |

| Add Book | Add Reader | Loans |
| --- | --- | --- |
| ![Add book](docs/screenshots/kitap-ekle.png) | ![Add reader](docs/screenshots/okuyucu-ekle.png) | ![Loans](docs/screenshots/kiralama.png) |

### Project Structure

```
Kutupoto/
├── Program.cs              # Entry point; database check and Giris (login) form
├── Giris.cs                # Login screen
├── Kayit.cs                # User registration screen
├── AnaSayfa.cs             # Home page: lists, search, filter
├── KitapEkle.cs            # Add / update / delete books
├── OkuyucuEkle.cs          # Add / update / delete readers
├── Kiralama.cs             # Lending, loan extension, returns, late fee
├── Model/
│   ├── IDataBase.cs        # ADO.NET helper class and connection string
│   ├── DatabaseKurulum.cs  # Automatic database setup on first launch
│   └── UserInfo.cs         # Logged-in user info
├── KOSDB.sql               # Database and table creation script
└── queries.sql             # List of queries used in the project
```

### Developers

- Mehmet Okur
- Muhammed Çağlar

---

## Türkçe

Kutupoto, okul ve küçük kütüphaneler için geliştirilmiş bir **Windows masaüstü kütüphane otomasyonu** uygulamasıdır. Kitapları, okuyucuları ve kitap emanet (ödünç/kiralama) işlemlerini tek bir yerden yönetmeyi sağlar. Veriler yerel bir **SQL Server** veritabanında (`KOSDb`) tutulur.

### Özellikler

#### Giriş ve Kayıt
- Kullanıcı adı ve şifre ile giriş ekranı.
- Yeni kullanıcı kayıt ekranı (ad, soyad, kullanıcı adı, şifre).
- Şifre kuralları: en az 6 karakter, en az 1 büyük ve 1 küçük harf, yalnızca harf ve rakam.
- Şifreler veritabanında düz metin olarak değil, **SHA-256 özeti** olarak saklanır.
- Tüm sorgularda parametreli SQL kullanılır (SQL Injection'a karşı).

#### Ana Sayfa
- Henüz iade edilmemiş **emanetteki kitapları** ve geri alınacak tarihleri listeler.
- Raftaki **mevcut kitapları** listeler.
- Kitap adı, yazar adı veya kayıt numarasına göre **anlık arama** yapılabilir.
- Kitap **türüne göre filtreleme** yapılabilir.
- Kayıtlı **okuyucuları** listeler.
- Kitap, okuyucu ve emanet ekranlarına buradan geçilir.

#### Kitap İşlemleri
- Kitap ekleme: kayıt no, kitap adı, yazar, sayfa sayısı, tür, yayınevi, basım yılı, dolap no ve raf no.
- Kayıt numarası otomatik verilir.
- Kitap bilgilerini güncelleme.
- Kitap silme. Silmeden sonra kayıt numaraları yeniden sıralanır.

#### Okuyucu (Üye) İşlemleri
- Okuyucu ekleme: ad, soyad, cinsiyet, sınıf, okul no, cep telefonu, adres.
- Okuyucu bilgilerini güncelleme.
- Okuyucu silme. Kayıt veritabanından silinmez, pasife alınır.

#### Emanet / Kiralama İşlemleri
- Seçilen okuyucuya kitap emanet etme. Teslim süresi **30 gündür**.
- Bir okuyucu aynı anda yalnızca bir kitap alabilir.
- **Süre uzatma**: mevcut teslim tarihine 30 gün eklenir.
- **Kitap iadesi (düşüm)**: kitap tekrar rafta görünür.
- **Gecikme bedeli**: teslim tarihi geçtiyse her gün için 1 TL hesaplanır. Süre uzatma ve iade öncesinde, bedelin alınıp alınmadığı sorulur.

#### Otomatik Veritabanı Kurulumu
- Uygulama ilk açılışta `KOSDb` veritabanının olup olmadığını kontrol eder. Yoksa `KOSDB.sql` dosyasını çalıştırıp veritabanını ve tabloları kendisi oluşturur.

### Kullanılan Teknolojiler

| Alan | Teknoloji |
| --- | --- |
| Dil | C# |
| Platform | .NET 6 (`net6.0-windows`) |
| Arayüz | Windows Forms |
| Veritabanı | Microsoft SQL Server (Express) |
| Veri erişimi | ADO.NET – `System.Data.SqlClient` 4.8.5 |
| IDE | Visual Studio 2022 |

### Veritabanı Yapısı

`KOSDB.sql` dört tablo oluşturur:

| Tablo | Açıklama |
| --- | --- |
| `kullanicilar` | Uygulamaya giriş yapan kullanıcılar (şifreler SHA-256 özetiyle) |
| `kitaplar` | Kitap bilgileri. `durum = 1` rafta, `0` emanette; `aktif` kaydın geçerli olup olmadığını gösterir |
| `okuyucular` | Okuyucu (üye) bilgileri |
| `emanetler` | Emanet kayıtları: veriliş, geri alma ve işlem tarihleri |

Projede kullanılan tüm SQL sorguları `queries.sql` dosyasında toplu olarak listelenmiştir.

### Kurulum

#### Gereksinimler
- Windows 10/11
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) (ya da ".NET masaüstü geliştirme" iş yükü yüklü Visual Studio 2022)
- [SQL Server Express](https://www.microsoft.com/sql-server/sql-server-downloads). Varsayılan örnek adı `SQLEXPRESS` olmalıdır.
- (İsteğe bağlı) SQL Server Management Studio (SSMS)

#### 1. Projeyi indirin
```bash
git clone https://github.com/Simsek00/Kutupoto.git
cd Kutupoto
```

#### 2. Veritabanını oluşturun

**Yöntem A – Otomatik (önerilen):** Hiçbir şey yapmanıza gerek yok. Uygulama ilk açılışta `KOSDb` veritabanını bulamazsa, çıktı klasörüne kopyalanan `KOSDB.sql` dosyasını çalıştırır ve "Kurulum Tamamlandı" mesajını gösterir.

**Yöntem B – Elle (SSMS ile):**
1. SSMS'i açıp `.\SQLEXPRESS` sunucusuna **Windows Authentication** ile bağlanın.
2. `File → Open → File...` ile `KOSDB.sql` dosyasını açın.
3. **Execute** (F5) ile çalıştırın. Script `KOSDb` veritabanını ve tabloları yalnızca yoksa oluşturur, bu yüzden tekrar çalıştırmak güvenlidir.

Komut satırından da çalıştırabilirsiniz:
```bash
sqlcmd -S .\SQLEXPRESS -E -i KOSDB.sql
```

#### 3. Bağlantı ayarını (connection string) kontrol edin

Uygulama varsayılan olarak yerel makinedeki `.\SQLEXPRESS` örneğine Windows kimlik doğrulamasıyla bağlanır. SQL Server örneğinizin adı farklıysa (örneğin `(localdb)\MSSQLLocalDB` ya da `BILGISAYARADI\SQLEXPRESS`), şu **iki dosyadaki** bağlantı cümlesini değiştirin:

| Dosya | Değişken | Kullanım |
| --- | --- | --- |
| `Model/IDataBase.cs` | `connectionString` | Uygulamanın tüm sorguları (`Database=KOSDb`) |
| `Model/DatabaseKurulum.cs` | `masterConnectionString` | İlk kurulumdaki veritabanı kontrolü ve oluşturma (`Database=master`) |

```csharp
// Model/IDataBase.cs
public static string connectionString = "Server=.\\SQLEXPRESS; Database=KOSDb; Integrated Security=True; TrustServerCertificate=True;";
```

#### 4. Derleyip çalıştırın

Visual Studio ile `Kutupoto.sln` dosyasını açıp **F5** ile başlatın. Ya da komut satırından:
```bash
dotnet run --project Kutupoto.csproj
```

#### 5. İlk kullanım
1. Giriş ekranında **Kayıt Ol** ile bir kullanıcı oluşturun.
2. Bu kullanıcıyla giriş yapın.
3. Önce kitap ve okuyucu ekleyin, sonra emanet ekranından kitap verin.

### Ekran Görüntüleri

> Ekran görüntüleri eklenecek. Görselleri `docs/screenshots/` klasörüne koyup aşağıdaki satırları güncelleyebilirsiniz.

| Giriş | Ana Sayfa |
| --- | --- |
| ![Giriş ekranı](docs/screenshots/giris.png) | ![Ana sayfa](docs/screenshots/anasayfa.png) |

| Kitap Ekle | Okuyucu Ekle | Emanet / Kiralama |
| --- | --- | --- |
| ![Kitap ekleme](docs/screenshots/kitap-ekle.png) | ![Okuyucu ekleme](docs/screenshots/okuyucu-ekle.png) | ![Kiralama](docs/screenshots/kiralama.png) |

### Proje Yapısı

```
Kutupoto/
├── Program.cs              # Giriş noktası; veritabanı kontrolü ve Giris formu
├── Giris.cs                # Giriş ekranı
├── Kayit.cs                # Kullanıcı kayıt ekranı
├── AnaSayfa.cs             # Ana sayfa: listeler, arama, filtre
├── KitapEkle.cs            # Kitap ekle / güncelle / sil
├── OkuyucuEkle.cs          # Okuyucu ekle / güncelle / sil
├── Kiralama.cs             # Emanet verme, süre uzatma, iade, gecikme bedeli
├── Model/
│   ├── IDataBase.cs        # ADO.NET yardımcı sınıfı ve connection string
│   ├── DatabaseKurulum.cs  # İlk açılışta otomatik veritabanı kurulumu
│   └── UserInfo.cs         # Oturum açan kullanıcı bilgisi
├── KOSDB.sql               # Veritabanı ve tablo oluşturma scripti
└── queries.sql             # Projede kullanılan sorguların listesi
```

### Geliştiriciler

- Mehmet Okur
- Muhammed Çağlar
