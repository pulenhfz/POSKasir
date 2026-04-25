<div align="center">

# 🛒 POSKasir

### Aplikasi Point of Sale Desktop — Sederhana, Cepat, dan Andal

<br/>

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Windows](https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-LocalDB-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Visual Studio](https://img.shields.io/badge/IDE-Visual_Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)

<br/>

> Aplikasi kasir berbasis desktop yang dibangun dengan **C# Windows Forms** dan **SQL Server LocalDB**.
> Dirancang untuk membantu pengelolaan penjualan toko kecil hingga menengah — mulai dari manajemen produk,
> proses transaksi, hingga laporan harian.

</div>

---

## 📋 Daftar Isi

- [Tentang Aplikasi](#-tentang-aplikasi)
- [Fitur Utama](#-fitur-utama)
- [Teknologi](#-teknologi)
- [Struktur Project](#-struktur-project)
- [Skema Database](#-skema-database)
- [Prasyarat](#-prasyarat)
- [Instalasi & Konfigurasi](#-instalasi--konfigurasi)
- [Menjalankan Aplikasi](#-menjalankan-aplikasi)
- [Akun Default](#-akun-default)
- [Panduan Penggunaan](#-panduan-penggunaan)
- [Alur Aplikasi](#-alur-aplikasi)
- [Arsitektur](#-arsitektur)
- [Keamanan](#-keamanan)
- [Kontribusi](#-kontribusi)
- [Lisensi](#-lisensi)

---

## 🧾 Tentang Aplikasi

**POSKasir** adalah aplikasi *Point of Sale* (POS) berbasis desktop yang dikembangkan sebagai proyek akademik di **Universitas Amikom Purwokerto**. Aplikasi ini menyediakan solusi kasir yang ringan dan mudah digunakan tanpa memerlukan koneksi internet maupun server eksternal.

### Mengapa POSKasir?

| Keunggulan | Keterangan |
|---|---|
| 🚀 **Ringan** | Berjalan langsung di Windows tanpa instalasi server tambahan |
| 🔒 **Aman** | Semua query menggunakan parameterized SQL — bebas SQL Injection |
| 👥 **Multi-role** | Hak akses berbeda untuk Admin dan Kasir |
| 📦 **Manajemen Stok** | Stok produk otomatis berkurang setiap transaksi |
| 📊 **Laporan Harian** | Filter transaksi berdasarkan rentang tanggal |
| 🛠️ **Mudah Dikembangkan** | Kode terstruktur dan mudah dipahami |

---

## ✨ Fitur Utama

### 🔐 Autentikasi
- Login dengan username dan password
- Validasi input sebelum dikirim ke database
- Dukungan tekan `Enter` untuk langsung login
- Pesan error yang informatif saat login gagal

### 📦 Manajemen Produk *(khusus Admin)*
- Tampilkan seluruh daftar produk dalam tabel
- **Pencarian real-time** berdasarkan nama produk
- Tambah produk baru dengan form input tervalidasi
- Edit data produk yang sudah ada
- Hapus produk dengan konfirmasi dialog

### 🛒 Transaksi Penjualan
- Pilih produk dari dropdown (hanya produk stok > 0)
- Keranjang belanja dinamis — produk yang sama otomatis digabung
- Kalkulasi total harga secara real-time
- Stok produk otomatis berkurang setelah transaksi berhasil

### 📊 Laporan Transaksi
- Filter transaksi berdasarkan rentang tanggal
- Tampilkan ID, tanggal, nama kasir, dan total per transaksi

### 👤 Kontrol Akses Berbasis Role
| Fitur | Admin | Kasir |
|---|:---:|:---:|
| Lihat daftar produk | ✅ | ✅ |
| Tambah produk | ✅ | ❌ |
| Edit produk | ✅ | ❌ |
| Hapus produk | ✅ | ❌ |
| Proses transaksi | ✅ | ✅ |
| Lihat laporan | ✅ | ✅ |

---

## 🛠️ Teknologi

| Komponen | Teknologi | Versi |
|---|---|---|
| Bahasa Pemrograman | C# | — |
| Framework | .NET Framework | 4.8 |
| UI Framework | Windows Forms (WinForms) | — |
| Database | Microsoft SQL Server LocalDB | — |
| Akses Data | ADO.NET | — |
| IDE | Visual Studio | 2019 / 2022 |

---

## 📁 Struktur Project

```
POSKasir/
│
├── 📄 POSKasir.sln
├── 📄 README.md
├── 📄 .gitignore
│
├── 📂 Database/
│   └── 📄 schema.sql
│
└── 📂 POSKasir/
    ├── 📄 POSKasir.csproj
    ├── 📄 App.config
    ├── 📄 Program.cs
    ├── 📄 DBHelper.cs
    ├── 📄 FormLogin.cs / .Designer.cs / .resx
    ├── 📄 FormDataProduk.cs / .Designer.cs / .resx
    ├── 📄 FormInputProduk.cs / .Designer.cs / .resx
    └── 📄 FormTransaksi.cs / .Designer.cs / .resx
```

---

## 🗄️ Skema Database

Database bernama **`POSKasirDB`** terdiri dari 4 tabel yang saling berelasi.

### Diagram Relasi (ERD)

```
┌─────────────┐       ┌──────────────────┐       ┌──────────────────────┐
│    Users    │       │   Transactions   │       │  TransactionDetails  │
├─────────────┤       ├──────────────────┤       ├──────────────────────┤
│ UserID  (PK)│──1:N──│ TransactionID(PK)│──1:N──│ DetailID        (PK) │
│ Username    │       │ UserID       (FK)│       │ TransactionID   (FK) │
│ Password    │       │ TransDate        │       │ ProductID       (FK) │
│ Role        │       │ TotalAmount      │       │ Qty / SubTotal       │
└─────────────┘       └──────────────────┘       └──────────┬───────────┘
                                                             │ N:1
                                                  ┌──────────┴───────────┐
                                                  │       Products       │
                                                  ├──────────────────────┤
                                                  │ ProductID       (PK) │
                                                  │ ProductName          │
                                                  │ Price / Stock        │
                                                  │ Category             │
                                                  └──────────────────────┘
```

### Tabel `Users`
| Kolom | Tipe | Constraint |
|---|---|---|
| `UserID` | `INT` | `PK, IDENTITY` |
| `Username` | `NVARCHAR(50)` | `NOT NULL, UNIQUE` |
| `Password` | `NVARCHAR(100)` | `NOT NULL` |
| `Role` | `NVARCHAR(20)` | `DEFAULT 'kasir'` |

### Tabel `Products`
| Kolom | Tipe | Constraint |
|---|---|---|
| `ProductID` | `INT` | `PK, IDENTITY` |
| `ProductName` | `NVARCHAR(100)` | `NOT NULL` |
| `Price` | `DECIMAL(10,2)` | `NOT NULL` |
| `Stock` | `INT` | `DEFAULT 0` |
| `Category` | `NVARCHAR(50)` | `NOT NULL` |

### Tabel `Transactions`
| Kolom | Tipe | Constraint |
|---|---|---|
| `TransactionID` | `INT` | `PK, IDENTITY` |
| `UserID` | `INT` | `FK → Users` |
| `TransDate` | `DATETIME` | `DEFAULT GETDATE()` |
| `TotalAmount` | `DECIMAL(10,2)` | `NOT NULL` |

### Tabel `TransactionDetails`
| Kolom | Tipe | Constraint |
|---|---|---|
| `DetailID` | `INT` | `PK, IDENTITY` |
| `TransactionID` | `INT` | `FK → Transactions` |
| `ProductID` | `INT` | `FK → Products` |
| `Qty` | `INT` | `NOT NULL` |
| `SubTotal` | `DECIMAL(10,2)` | `NOT NULL` |

---

## ✅ Prasyarat

| Komponen | Versi Minimum | Keterangan |
|---|---|---|
| **Visual Studio** | 2019 atau 2022 | Community Edition sudah cukup |
| **.NET Framework** | 4.8 | Sudah terinstal di Windows 10/11 |
| **SQL Server LocalDB** | — | Termasuk dalam instalasi Visual Studio |
| **SSMS** *(opsional)* | — | Untuk mengelola database secara visual |

> 💡 Saat menginstal Visual Studio, centang workload **".NET desktop development"** — sudah menyertakan .NET 4.8 dan LocalDB.

---

## 🚀 Instalasi & Konfigurasi

### Langkah 1 — Clone Project

```bash
git clone https://github.com/pulenhfz/POSKasir.git
```

### Langkah 2 — Buat Database

Jalankan script `Database/schema.sql` di SSMS atau SQL Server Object Explorer di Visual Studio.

### Langkah 3 — Buka Solution

Buka file `POSKasir.sln` dengan Visual Studio.

### Langkah 4 — Verifikasi Connection String

Pastikan `POSKasir/App.config` sesuai dengan instance LocalDB kamu:

```xml
<connectionStrings>
  <add name="POSKasirDB"
       connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=POSKasirDB;Integrated Security=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Cek instance LocalDB yang tersedia:
```bash
sqllocaldb info
```

---

## ▶️ Menjalankan Aplikasi

- Tekan **`F5`** di Visual Studio untuk run dengan debugger
- Tekan **`Ctrl+F5`** untuk run tanpa debugger
- Atau jalankan langsung `POSKasir/bin/Debug/POSKasir.exe`

---

## 🔑 Akun Default

| Username | Password | Role | Hak Akses |
|---|---|---|---|
| `admin` | `admin123` | Admin | Kelola produk + transaksi + laporan |
| `kasir` | `kasir123` | Kasir | Transaksi + laporan (produk read-only) |

> ⚠️ Ganti password default sebelum digunakan di lingkungan produksi.

---

## 📖 Panduan Penggunaan

### 1. 🔐 Form Login

```
┌─────────────────────────────────────────────────────────┐
│  🛒 POS Kasir          │  Selamat Datang!               │
│  Sistem Kasir          │  USERNAME  [ ............... ] │
│  Sederhana             │  PASSWORD  [ * * * * * * * * ] │
│                        │  [         MASUK             ] │
│  v1.0 - Amikom         │     Keluar dari Aplikasi        │
└─────────────────────────────────────────────────────────┘
```

Masukkan username & password lalu klik **MASUK** atau tekan `Enter`.

### 2. 📦 Form Data Produk

Dashboard utama setelah login. Menampilkan daftar produk dengan fitur pencarian real-time.

| Tombol | Fungsi | Role |
|---|---|---|
| `+ Tambah` | Tambah produk baru | Admin |
| `✎ Edit` | Edit produk terpilih | Admin |
| `✕ Hapus` | Hapus produk terpilih | Admin |
| `Transaksi` | Buka form transaksi | Semua |
| `Logout` | Kembali ke login | Semua |

### 3. ✏️ Form Input Produk

Form dialog tambah/edit produk. Field: Nama, Harga (digit only), Stok (digit only), Kategori (dropdown: Makanan / Minuman / Snack / Lainnya).

### 4. 🛒 Form Transaksi

**Keranjang:** Pilih produk → isi Qty → klik `+ Tambah` → ulangi → klik `Simpan Transaksi`.

**Laporan:** Pilih rentang tanggal → klik `Cari` → lihat daftar transaksi.

---

## 🔄 Alur Aplikasi

```
[Start] --> [FormLogin] --> (berhasil) --> [FormDataProduk]
                                                 |
                              +------------------+------------------+
                              |                                     |
                     [FormInputProduk]                     [FormTransaksi]
                      (Tambah/Edit)                      (Jual + Laporan)
                              |                                     |
                         Simpan --> kembali               Simpan --> stok berkurang
```

---

## 🏗️ Arsitektur

```
+------------------------------------------+
|          Presentation Layer              |
|  FormLogin | FormDataProduk | FormInput  |
|              FormTransaksi               |
+--------------------+---------------------+
                     | calls
                     v
+------------------------------------------+
|          Data Access Layer               |
|              DBHelper.cs                 |
|   ExecuteQuery() | ExecuteNonQuery()     |
+--------------------+---------------------+
                     | ADO.NET
                     v
+------------------------------------------+
|           SQL Server LocalDB             |
|  Users | Products | Transactions | ...  |
+------------------------------------------+
```

| Komponen | Peran |
|---|---|
| **Form Classes** | UI + logika bisnis langsung |
| **DBHelper** | Satu-satunya titik akses ke database |
| **App.config** | Connection string terpusat |
| **Program.cs** | Entry point + global error handler |

---

## 🔒 Keamanan

### Parameterized Query — Anti SQL Injection

```csharp
// AMAN - menggunakan SqlParameter
DataTable dt = DBHelper.ExecuteQuery(
    "SELECT * FROM Users WHERE Username=@user AND Password=@pass",
    new SqlParameter("@user", txtUsername.Text),
    new SqlParameter("@pass", txtPassword.Text));
```

### Role-Based Access Control (RBAC)
- `admin` — akses penuh ke semua fitur
- `kasir` — hanya transaksi & laporan, tombol kelola produk dinonaktifkan otomatis

### Global Exception Handler
Error yang tidak tertangani ditangkap di `Program.cs` dan ditampilkan sebagai dialog.

> ⚠️ Password disimpan sebagai *plain text*. Untuk produksi, gunakan hashing (`SHA-256 + salt` atau `bcrypt`).

---

## 🤝 Kontribusi

```bash
git checkout -b fitur/nama-fitur
git commit -m "feat: deskripsi fitur"
git push origin fitur/nama-fitur
# lalu buat Pull Request ke main
```

### Ide Pengembangan
- [ ] 🔐 Hashing password
- [ ] 🖨️ Cetak struk transaksi
- [ ] 📈 Grafik laporan penjualan
- [ ] 🔍 Filter produk per kategori
- [ ] 💾 Backup & restore database
- [ ] 🌐 Versi web dengan ASP.NET Core

---

## 📄 Lisensi

Project ini dibuat untuk keperluan akademik di **Universitas Amikom Purwokerto**.
Bebas digunakan dan dimodifikasi untuk tujuan pembelajaran — MIT License.

---

<div align="center">

Dibuat dengan ❤️ untuk keperluan akademik

**Universitas Amikom Purwokerto**

⭐ Jangan lupa beri bintang jika project ini membantu kamu!

</div>
