<div align="center">

# 💊 Eczane Otomasyon Sistemi

<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white"/>
<img src="https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/>
<img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white"/>
<img src="https://img.shields.io/badge/Entity_Framework-512BD4?style=for-the-badge&logo=nuget&logoColor=white"/>
<img src="https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white"/>

<br/>

> Eczane personelinin **hasta**, **ilaç**, **kategori** ve **reçete** verilerini  
> kolayca yönetebileceği tam özellikli masaüstü otomasyon uygulaması.

<br/>

![GitHub repo size](https://img.shields.io/github/repo-size/KULLANICI/eczane-otomasyon?color=2CA6A4)
![GitHub last commit](https://img.shields.io/github/last-commit/KULLANICI/eczane-otomasyon?color=F5A623)
![License](https://img.shields.io/badge/license-MIT-green?style=flat)

</div>

---

## 📋 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Teknolojiler](#-teknolojiler)
- [Veritabanı Tasarımı](#-veritabanı-tasarımı)
- [Kurulum](#-kurulum)
- [Kullanım](#-kullanım)
- [Proje Yapısı](#-proje-yapısı)
- [Ekran Görüntüleri](#-ekran-görüntüleri)

---

## 🏥 Proje Hakkında

Bu proje, eczane personelinin günlük iş süreçlerini dijitalleştirmek amacıyla geliştirilmiş bir **Windows Forms masaüstü uygulamasıdır**.

Kağıt tabanlı reçete takibi, manuel stok yönetimi ve hasta kayıtlarını bilgisayar ortamına taşıyarak:

- ✅ Hızlı veri girişi ve listeleme
- ✅ Anlık ilaç stok takibi
- ✅ Hasta-ilaç ilişkisinin reçete üzerinden yönetimi
- ✅ LINQ sorguları ile gelişmiş raporlama

sağlar.

---

## ✨ Özellikler

| Modül | İşlemler | Özellik |
|-------|----------|---------|
| 👤 **Hasta Yönetimi** | Ekle / Listele / Güncelle / Sil | TC kimlik ile kayıt |
| 💊 **İlaç Yönetimi** | Ekle / Listele / Güncelle / Sil | Stok ve fiyat takibi |
| 🗂️ **Kategori Yönetimi** | Ekle / Listele / Güncelle / Sil | İlaç sınıflandırması |
| 📄 **Reçete Yönetimi** | Ekle / Listele / Sil | Hasta + ilaç birleşimi |
| 🔍 **LINQ Sorguları** | 2 adet analitik sorgu | RadioButton ile seçim |

### 🔍 LINQ Analizleri
- **Sorgu 1 →** En fazla reçetesi olan hasta
- **Sorgu 2 →** Toplam harcaması en yüksek hasta

---

## 🛠️ Teknolojiler

```
🖥️  C# Windows Forms (.NET Framework 4.x)
🗄️  Microsoft SQL Server Express
⚙️  Entity Framework 6  (Code-First / Database-First)
📦  NuGet Paket Yöneticisi
🔗  LINQ (Language Integrated Query)
```

---

## 🗄️ Veritabanı Tasarımı

### Tablolar ve İlişkiler

```
Table_Kategori          Table_Ilac
┌─────────────────┐     ┌──────────────────────┐
│ 🔑 Kategori_Id  │────►│ 🔑 Ilac_Id            │
│    Kategori_Adi │ 1:* │    Ilac_Adi           │
│    Kategori_Ack │     │    Ilac_Barkod        │
└─────────────────┘     │    Ilac_Fiyat         │
                        │    Ilac_Stok          │
                        │ 🔗 Kategori_Id (FK)   │
                        └──────────┬───────────┘
                                   │ 1:*
Table_Hasta                        ▼
┌─────────────────┐     Table_Recete (ARACI)
│ 🔑 Hasta_Id     │     ┌──────────────────────┐
│    Hasta_Ad     │     │ 🔑 Recete_Id          │
│    Hasta_Soyad  │────►│ 🔗 Hasta_Id (FK)      │
│    Hasta_TcNo   │ 1:* │ 🔗 Ilac_Id (FK)       │
│    Hasta_Telefon│     │    Recete_Tarih       │
└─────────────────┘     │    Recete_Miktar      │
                        └──────────────────────┘
```

### Entity Sınıfı İlişkileri

```csharp

public class Kategori {
    public virtual ICollection<Ilac> Ilaclar { get; set; }
}


public class Ilac {
    public virtual Kategori Kategori { get; set; }
    public virtual ICollection<Recete> Receteler { get; set; }
}


public class Recete {
    public virtual Hasta Hasta { get; set; }
    public virtual Ilac   Ilac  { get; set; }
}
```

---

## 🚀 Kurulum

### Gereksinimler
- Visual Studio 2019 veya üzeri
- .NET Framework 4.x
- SQL Server Express (veya LocalDB)

### Adımlar

**1. Repoyu klonla**
```bash
git clone https://github.com/KULLANICI/eczane-otomasyon.git
cd eczane-otomasyon
```

**2. SQL Server'da veritabanını oluştur**
```sql
-- SSMS'i aç, New Query ile çalıştır:
CREATE DATABASE Eczane_Otomasyon;
```

**3. Tabloları oluştur**
```sql
-- Eczane_SQL_Tablolar.sql dosyasını SSMS'de çalıştır
-- Sıra önemli: Kategori → Ilac → Hasta → Recete
```

**4. App.config bağlantısını güncelle**
```xml
<connectionStrings>
  <add name="EczaneDbContext"
       connectionString="Data Source=SUNUCU_ADINIZ\SQLEXPRESS;
                         Initial Catalog=Eczane_Otomasyon;
                         Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```
> ⚠️ `SUNUCU_ADINIZ` yerine SSMS'de görünen sunucu adını yaz (örn: `DESKTOP-ABC123\SQLEXPRESS`)

**5. NuGet paketini kur**
```
Visual Studio → Tools → NuGet Package Manager → 
  Search: EntityFramework → Install
```

**6. Çalıştır**
```
F5 tuşuna bas 🚀
```

---

## 📖 Kullanım

```
Ana Menü
├── 👤 Hasta İşlemleri     → 4 CRUD işlemi (Listele/Ekle/Güncelle/Sil)
├── 💊 İlaç İşlemleri      → 4 CRUD + Kategori ComboBox seçimi
├── 🗂️  Kategori İşlemleri → 4 CRUD işlemi (bağımsız/müstakil tablo)
└── 📄 Reçete İşlemleri    → 3 işlem + 2 LINQ sorgusu
```

### ⚡ Hızlı Kullanım İpuçları

> 💡 **Güncelleme için:** DataGridView'de satıra tıkla → bilgiler textbox'lara gelir → düzenle → Güncelle butonuna bas

> 💡 **Reçete eklemek için:** ComboBox'tan hasta ve ilaç seç → Ekle butonuna bas

> 💡 **LINQ sorgusu için:** Reçete formunda `rd_1` veya `rd_2` RadioButton'a tıkla → sonuç label'a yazar

---

## 📁 Proje Yapısı

```
eczane-otomasyon/
│
├── 📄 App.config                  # Veritabanı bağlantısı
│
├── 🗃️  Modeller/
│   ├── Kategori.cs                # [Table("Table_Kategori")]
│   ├── Ilac.cs                    # [Table("Table_Ilac")]
│   ├── Hasta.cs                   # [Table("Table_Hasta")]
│   ├── Recete.cs                  # [Table("Table_Recete")] — Aracı tablo
│   └── EczaneDbContext.cs         # DbContext — tüm DbSet'ler burada
│
├── 🖥️  Formlar/
│   ├── Form1.cs                   # Ana Menü
│   ├── Form2.cs / Form3.cs        # Hasta İşlemleri
│   ├── Form4.cs                   # İlaç İşlemleri
│   ├── Form5.cs                   # Kategori İşlemleri
│   └── Form6.cs                   # Reçete İşlemleri + LINQ
│
└── 🗄️  SQL/
    └── Eczane_SQL_Tablolar.sql    # Tablo oluşturma + örnek veriler
```

---

## 🧩 Entity Framework Attribute Açıklamaları

| Attribute | Anlamı |
|-----------|--------|
| `[Table("Table_Ilac")]` | C# sınıfını SQL tablosuna bağlar |
| `[Key]` | Primary Key sütununu belirtir |
| `[Required]` | NOT NULL — boş bırakılamaz |
| `[MaxLength(50)]` | NVARCHAR(50) sınırı |
| `public virtual Kategori Kategori` | Many-to-One ilişki (FK tarafı) |
| `public virtual ICollection<Ilac>` | One-to-Many ilişki (1 tarafı) |

---

## 👨‍💻 Geliştirici

<div align="center">

**YBS Otomasyon Projesi**  
C# Windows Forms + Entity Framework + SQL Server

</div>

---

<div align="center">

⭐ Bu projeyi beğendiysen yıldız vermeyi unutma!

`C#` `Windows Forms` `Entity Framework` `SQL Server` `LINQ` `CRUD` `ORM`

</div>
