                                                                                  **Üniversite Spor Tesisleri Rezervasyon Sistemi**


  -Bu proje, bir üniversite bünyesindeki spor tesislerinin (merkez, doğu vb.) yönetimini, saha rezervasyonlarını, üyelik paketlerini ve personel takibini dijitalleştirmek amacıyla geliştirilmiş hibrit bir veritabanı yönetim sistemidir.
  -Proje, ilişkisel veritabanı (SQL) ile doküman tabanlı veritabanı (NoSQL) mantığını birleştirerek kapsamlı bir çözüm sunar.
  -Öne Çıkan ÖzelliklerGelişmiş Veritabanı Mimarisi: Veriler, veri bütünlüğünü sağlamak adına 3. Normal Form (3NF) kurallarına göre normalize edilmiştir.
  -Otomasyon ve Kontrol (Triggers): \* Saha durumu "Bakımda" veya "Kapalı" ise rezervasyon yapılmasını engelleyen otomatik kontrol mekanizması.Hatalı tarih girişlerini (bitiş tarihinin başlangıçtan önce olması gibi) önleyen validasyon tetikleyicileri.İş Mantığı Yönetimi (Stored Procedures): \* Personel maaş analizi ve zam planlama simülasyonları.Üye harcama limitlerine göre otomatik "VIP" kampanya tanımlama sistemi.Hibrit Veri Modeli: SQL Server üzerindeki ilişkisel veriler, yüksek performanslı okuma ve esnek dökümantasyon için MongoDB (JSON) formatına başarılı bir şekilde migrate edilmiştir.



 -- **Teknik StackDil:** C# (.NET Framework 4.7.2)UI: Windows Forms (WinForms)Veritabanı (RDBMS): MS SQL ServerVeritabanı (NoSQL): MongoDBTasarım: ER Diyagramları, UML Sınıf Diyagramları) --



**Proje Yapısı Plaintext**

├── Database/
│   ├── Schema.sql          # Tablo oluşturma, Trigger ve SP scriptleri
│   └── Normalization.docx   # 1NF, 2NF, 3NF raporları
├── NoSQL/
│   └── Collections/        # MongoDB JSON çıktıları (Üye, Tesis, Rezervasyon vb.)
├── Documentation/
│   ├── ER\_Diagram.pdf      # Varlık-İlişki diyagramı
│   └── UML\_Diagram.png     # Sistem sınıf diyagramı
└── SourceCode/
&nbsp;   └── WindowsFormsApp2/   # C# Proje kaynak kodları



-------Veritabanı Nesneleri (Teknik Detay)Proje içerisinde yer alan bazı kritik SQL nesneleri şunlardır-------

1-)Scalar Functions: fn\_SeansBelirle (saate göre tarife belirleme),

2-)UyelikKalanGunSayisi (paket takibi).
3-)Stored Procedures: EkipmanKiralama (stok kontrollü kiralama),
4-)prc\_UyeKayitEkleme (hata kontrollü kayıt).
5-)Views \& Joins: Karmaşık üye ve ödeme raporları için optimize edilmiş sorgular.

------Kurulum--------

1-)Database/ klasöründeki .sql dosyasını MS SQL Server üzerinde çalıştırarak veritabanı şemasını oluşturun.
2-)Visual Studio ile SourceCode/ altındaki .sln dosyasını açın.
3-)App.config dosyasındaki bağlantı dizelerini (Connection Strings) kendi yerel sunucunuza göre güncelleyin.
4-)Projeyi derleyin ve çalıştırın.


### 👥 Proje Sahipleri

| İsim Soyisim | Bölüm |
| :--- | :--- |
| **Tunahan Yanık** | Endüstri Mühendisliği |
| **Ceren Akça** | Endüstri Mühendisliği |
| **Beliz Kaplan** | Endüstri Mühendisliği |


## 📁 Klasör Yapısı
- **SourceCode/**: C# Windows Forms uygulama kodları.
- **Database/**: SQL Normalizasyon raporu ve veri tabanı şemaları.
- **Documentation/**: E-R ve UML diyagramları.
- **Json/**: NoSQL (MongoDB/JSON) yapısına uygun veri setleri.
