🚀 Üniversite Spor Tesisleri Rezervasyon Sistemi

Üniversite bünyesindeki spor tesislerinin yönetimini, saha rezervasyonlarını ve personel takibini dijitalleştiren, ilişkisel (SQL) ve doküman tabanlı (NoSQL) veritabanı mantığını birleştiren hibrit bir yönetim sistemi.

Bu proje, karmaşık tesis yönetim süreçlerini optimize etmek ve veri bütünlüğünü en üst seviyede tutmak amacıyla bir Endüstri Mühendisliği perspektifiyle geliştirilmiş kapsamlı bir PoC (Kavram Kanıtı) çalışmasıdır.

🖼️ Kullanıcı Arayüzü (WinForms)

Sistem, C# Windows Forms üzerinde geliştirilmiş, kullanıcı dostu ve fonksiyonel bir arayüze sahiptir. Yönetim paneli üzerinden üyelik işlemleri, tesis durum kontrolleri ve finansal raporlamalar anlık olarak takip edilebilir.

📋 İçindekiler

Ana Özellikler

Veritabanı Nesneleri ve Mantığı

Teknoloji Mimarisi

Proje Yapısı

Kurulum ve Çalıştırma

Proje Sahipleri

🎯 Ana Özellikler

Bu sistemin temel yetenekleri ve mühendislik çözümleri şunlardır:

🏗️ Gelişmiş Veritabanı Mimarisi: - Veriler, veri bütünlüğünü ve performansını optimize etmek adına 3. Normal Form (3NF) kurallarına göre normalize edilmiştir.

Gereksiz veri tekrarı önlenmiş ve ilişkisel bağlar sağlam temellere oturtulmuştur.

🤖 Akıllı Otomasyon ve Kontroller (Triggers):

Bakım Kontrolü: Saha durumu "Bakımda" veya "Kapalı" ise sistem otomatik olarak rezervasyon girişini engeller.

Validasyon: Hatalı tarih girişlerini (bitişin başlangıçtan önce olması gibi) veritabanı seviyesinde önleyen tetikleyiciler.

⚙️ İş Mantığı Yönetimi (Stored Procedures):

Maaş Analizi: Personel maaş takibi ve zam planlama simülasyonları için özel prosedürler.

VIP Kampanya Sistemi: Üye harcama limitlerini analiz ederek otomatik olarak "VIP" statüsü tanımlayan akıllı algoritmalar.

🔄 Hibrit Veri Modeli: - MS SQL Server üzerindeki ilişkisel veriler, yüksek performanslı okuma ve esnek dökümantasyon ihtiyaçları için MongoDB (JSON) formatına migrate edilerek hibrit bir yapı kurulmuştur.

🔬 Veritabanı Nesneleri (Teknik Detay)

Proje içerisinde yer alan bazı kritik SQL nesneleri ve işlevleri:

Scalar Functions: * fn_SeansBelirle: Giriş saatine göre otomatik tarife hesaplar.

UyelikKalanGunSayisi: Üyelik paketlerinin kalan süresini gerçek zamanlı takip eder.

Stored Procedures: * EkipmanKiralama: Stok kontrollü ekipman kiralama süreci.

prc_UyeKayitEkleme: Hata kontrollü ve validasyonlu yeni üye kaydı.

Views & Joins: Karmaşık üye hareketleri ve ödeme raporları için optimize edilmiş, yüksek performanslı sorgu görünümleri.

🛠️ Teknoloji Mimarisi

📂 Proje Yapısı

Proje, yönetimi kolay ve modüler bir klasör hiyerarşisine sahiptir:

Sports_Facility_Management/
├── Database/
│   ├── Schema.sql           # Tablo oluşturma, Trigger ve SP scriptleri
│   └── Normalization.docx   # 1NF, 2NF, 3NF raporları ve tasarım kararları
├── NoSQL/
│   └── Collections/         # MongoDB JSON çıktıları (Üye, Tesis, Rezervasyon vb.)
├── Documentation/
│   ├── ER_Diagram.pdf       # Varlık-İlişki (E-R) diyagramı
│   └── UML_Diagram.png      # Sistem sınıf diyagramı
└── SourceCode/
    └── WindowsFormsApp2/    # C# WinForms proje kaynak kodları ve Solution (.sln)


🚀 Kurulum ve Çalıştırma

Projeyi yerel ortamınızda ayağa kaldırmak için şu adımları izleyin:

Veritabanı Kurulumu: Database/ klasöründeki .sql dosyasını MS SQL Server Management Studio (SSMS) üzerinde çalıştırarak şemayı oluşturun.

IDE Hazırlığı: Visual Studio ile SourceCode/ altındaki .sln dosyasını açın.

Bağlantı Ayarları: App.config dosyasındaki Connection Strings (Bağlantı Dizeleri) bölümünü kendi yerel SQL Server ve MongoDB sunucu bilgilerinizle güncelleyin.

Derleme: Projeyi Build (Derle) yaptıktan sonra Start diyerek uygulamayı başlatabilirsiniz.

👥 Proje Sahipleri

Bu çalışma, bir ekip projesi olarak aşağıdaki üyeler tarafından geliştirilmiştir:

İsim Soyisim

Bölüm

Tunahan Yanık

Endüstri Mühendisliği

Ceren Akça

Endüstri Mühendisliği

Beliz Kaplan

Endüstri Mühendisliği

Bu proje, üniversite tesis yönetimi süreçlerinin dijital dönüşümüne katkı sağlamak amacıyla geliştirilmiştir.
