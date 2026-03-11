# 🚀 Üniversite Spor Tesisleri Rezervasyon Sistemi

![C#](https://img.shields.io/badge/Dil-C%23-blue)
![Framework](https://img.shields.io/badge/Framework-Windows%20Forms-green)
![Veritabanı](https://img.shields.io/badge/Database-MS%20SQL%20Server-red)
![NoSQL](https://img.shields.io/badge/NoSQL-MongoDB-brightgreen)
![Mimari](https://img.shields.io/badge/Mimari-Hybrid%20SQL%20%2B%20NoSQL-orange)

> Üniversite bünyesindeki spor tesislerinin yönetimini, saha rezervasyonlarını ve personel takibini dijitalleştiren; ilişkisel (SQL) ve doküman tabanlı (NoSQL) veritabanı mimarisini birleştiren hibrit bir yönetim sistemi.

Bu proje, **Endüstri Mühendisliği perspektifiyle** tesis yönetim süreçlerini optimize etmek ve **veri bütünlüğünü en üst seviyede sağlamak** amacıyla geliştirilmiş bir **Proof of Concept (PoC)** çalışmasıdır.

---

# 🖼️ Kullanıcı Arayüzü (WinForms)

Sistem **C# Windows Forms** kullanılarak geliştirilmiş **kullanıcı dostu bir yönetim paneline** sahiptir.

Yönetim arayüzü üzerinden kullanıcılar:

* Üyelik işlemlerini yönetebilir
* Tesis uygunluk durumlarını kontrol edebilir
* Rezervasyonları takip edebilir
* Finansal raporları görüntüleyebilir

Arayüz, spor tesisi yönetiminde operasyonel süreçleri kolaylaştırmak amacıyla tasarlanmıştır.

---

# 📋 İçindekiler

* Ana Özellikler
* Veritabanı Mimarisi
* Teknoloji Altyapısı
* Proje Yapısı
* Kurulum ve Çalıştırma
* Proje Ekibi

---

# 🎯 Ana Özellikler

## 🏗️ Gelişmiş Veritabanı Tasarımı

* Veritabanı **3. Normal Form (3NF)** kurallarına göre tasarlanmıştır.
* Veri tekrarını (redundancy) ortadan kaldırır.
* İlişkisel veri bütünlüğünü güçlü şekilde korur.

## 🤖 Tetikleyiciler ile Akıllı Otomasyon

Veritabanı seviyesinde otomatik kontroller sağlayan **Triggers** kullanılmıştır:

* **Bakım Kontrolü:** Bir saha "Bakımda" veya "Kapalı" durumundaysa rezervasyon yapılmasını otomatik olarak engeller.
* **Validasyon Kuralları:** Bitiş tarihinin başlangıçtan önce olması gibi hatalı rezervasyon girişlerini önler.

## ⚙️ Stored Procedure ile İş Mantığı Yönetimi

Sistem içerisinde kritik iş süreçlerini yöneten özel prosedürler geliştirilmiştir:

* **Maaş Analiz Sistemi**
  Personel maaş takibi ve zam planlama simülasyonları yapılabilir.

* **VIP Üyelik Kampanyası**
  Üyelerin harcama alışkanlıklarını analiz ederek otomatik olarak **VIP statüsü** tanımlar.

## 🔄 Hibrit Veri Mimarisi

Sistem hem **Relational Database** hem de **NoSQL** mimarisini birlikte kullanır.

* Operasyonel veriler **MS SQL Server** üzerinde tutulur
* Seçili veri setleri **MongoDB (JSON)** formatına aktarılır

Bu hibrit yapı sayesinde:

* Yüksek performanslı sorgular
* Esnek veri saklama
* Ölçeklenebilir veri erişimi

sağlanmaktadır.

---

# 🔬 Veritabanı Nesneleri (Teknik Detaylar)

## Scalar Functions

* **fn_SeansBelirle**
  Giriş saatine göre otomatik tarife belirler.

* **UyelikKalanGunSayisi**
  Üyelik paketlerinin kalan süresini gerçek zamanlı hesaplar.

## Stored Procedures

* **EkipmanKiralama**
  Stok kontrollü ekipman kiralama sürecini yönetir.

* **prc_UyeKayitEkleme**
  Hata kontrollü ve validasyonlu yeni üye kaydı oluşturur.

## Views ve Karmaşık Join Yapıları

Optimize edilmiş sorgu görünümleri kullanılmıştır:

* Üye hareketleri raporları
* Ödeme analizleri
* Rezervasyon takip sistemi

---

# 🛠️ Teknoloji Altyapısı

* **C#**
* **.NET Framework**
* **Windows Forms**
* **Microsoft SQL Server**
* **MongoDB**
* **Visual Studio**

---

# 📂 Proje Yapısı

```
Sports_Facility_Management/

├── Database/
│   ├── Schema.sql
│   └── Normalization.docx

├── NoSQL/
│   └── Collections/

├── Documentation/
│   ├── ER_Diagram.pdf
│   └── UML_Diagram.png

└── SourceCode/
    └── WindowsFormsApp2/
```

### Klasör Açıklamaları

**Database/**

* SQL tablo yapıları
* Trigger tanımları
* Stored Procedure scriptleri

**NoSQL/**

* MongoDB JSON koleksiyon çıktıları

**Documentation/**

* ER Diyagramı
* UML diyagramları

**SourceCode/**

* C# WinForms uygulamasının tüm kaynak kodları

---

# 🚀 Kurulum ve Çalıştırma

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin.

## 1️⃣ Repoyu Klonlayın

```
git clone https://github.com/KULLANICI_ADINIZ/Sports_Facility_Management.git
cd Sports_Facility_Management
```

## 2️⃣ Veritabanını Kurun

Aşağıdaki SQL scriptini çalıştırın:

```
Database/Schema.sql
```

Scripti **Microsoft SQL Server Management Studio (SSMS)** üzerinde çalıştırarak veritabanı şemasını oluşturabilirsiniz.

Bu işlem:

* tabloları
* triggerları
* stored procedureleri
* ilişkileri

oluşturacaktır.

## 3️⃣ Uygulamayı Açın

Visual Studio kullanarak aşağıdaki solution dosyasını açın:

```
SourceCode/WindowsFormsApp2.sln
```

## 4️⃣ Veritabanı Bağlantısını Güncelleyin

Aşağıdaki dosyada bulunan **Connection String** ayarlarını kendi yerel veritabanı bilgilerinize göre güncelleyin:

```
App.config
```

## 5️⃣ Uygulamayı Çalıştırın

Visual Studio üzerinden projeyi derleyip çalıştırın:

```
Build → Start Debugging
```

Uygulama çalıştığında **Spor Tesisleri Rezervasyon Sistemi** aktif hale gelecektir.

---

# 👥 Proje Ekibi

| İsim          | Bölüm                 |
| ------------- | --------------------- |
| Tunahan Yanık | Endüstri Mühendisliği |
| Ceren Akça    | Endüstri Mühendisliği |
| Beliz Kaplan  | Endüstri Mühendisliği |

---

# 📌 Projenin Amacı

Bu proje, **veritabanı mühendisliği**, **hibrit veri mimarisi** ve **masaüstü yazılım geliştirme** yaklaşımlarının bir araya getirilerek **üniversite spor tesislerinin yönetim süreçlerinin dijitalleştirilmesini** göstermektedir.

Aynı zamanda proje, **Endüstri Mühendisliği prensiplerinin yazılım sistemleri ve operasyonel yönetim süreçlerinde nasıl uygulanabileceğini** göstermeyi amaçlamaktadır.
