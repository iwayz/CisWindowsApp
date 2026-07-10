### Daftar Isi

[TOC]

---

## 1. Gambaran Umum Sistem

Sebelum masuk ke masing-masing layar, bab ini memberi gambaran besar terlebih dahulu: bagaimana semua bagian dari modul Manajemen Stok saling terhubung, dari data produk sampai laporan yang Anda lihat setiap hari.

<div style="page-break-before: always;"></div>

### Alur Besar

Setiap transaksi stok — apa pun jenisnya — selalu mengikuti jalur yang sama: data produk disiapkan lebih dulu, transaksi diposting, tercatat sebagai jejak audit, memperbarui posisi stok, lalu bisa dilihat kembali lewat laporan.

![Gambaran umum alur sistem CIS, dari master data produk hingga laporan](C:/Projects/CisWindowsApp/docs/manual/media/00-overview-pipeline.png)

1. **Master data produk** — setiap produk didaftarkan beserta kemasannya (mis. Box = 100 tablet). Data ini dipakai setiap kali ada transaksi yang melibatkan produk tersebut (lihat Bab 4).
2. **Transaksi stok** — dokumen seperti Pembelian, Penjualan, Retur, Transfer, atau Penyesuaian dibuat dan diposting oleh staf.
3. **Stock movement** — begitu diposting/dikonfirmasi, sistem otomatis mencatat setiap perubahan (masuk/keluar) sebagai satu baris jejak audit yang tidak bisa diubah.
4. **Stock card** — dari kumpulan jejak audit itu, sistem menghitung posisi stok terkini (QtyOnHand) untuk setiap produk dan batch.
5. **Laporan & kartu stok** — posisi dan riwayat stok ini yang ditampilkan kembali ke pengguna untuk pengecekan sehari-hari maupun audit.

> **Intinya:** Anda tidak pernah mengubah angka stok secara langsung. Stok selalu berubah sebagai **akibat** dari sebuah dokumen yang diposting — itulah mengapa setiap dokumen yang salah harus dibatalkan (Void/Cancel), bukan dihapus atau diedit, agar jejak audit tetap benar.

### Empat Kelompok Transaksi

Bagian "Transaksi stok" di atas sebenarnya terdiri dari empat kelompok, dibedakan berdasarkan efeknya terhadap stok:

![Rincian kelompok transaksi stok: Pembelian, Penjualan, Retur & Transfer, Opname & Penyesuaian](C:/Projects/CisWindowsApp/docs/manual/media/00-transaction-categories.png)

| Kelompok | Efek ke Stok | Bab |
|---|---|---|
| **Pembelian** | Menambah stok (barang masuk dari supplier) | Bab 5 |
| **Penjualan** | Mengurangi stok (barang keluar ke pelanggan), hanya pada tahap Post | Bab 6 |
| **Retur & Transfer** | Retur Pembelian mengurangi, Retur Penjualan menambah, Transfer bisa menambah/mengurangi tergantung arah | Bab 7, 8, 9 |
| **Opname & Penyesuaian** | Mengoreksi stok agar sesuai kondisi fisik atau alasan tertentu (rusak, hilang, dll) — Opname selalu menghasilkan Penyesuaian secara otomatis | Bab 10, 11 |

Keempat kelompok ini semuanya bermuara ke **Stock Movement** yang sama — sehingga siapa pun bisa menelusuri riwayat stok suatu produk dari satu tempat, apa pun jenis transaksinya (lihat Bab 13).

---

## 2. Pendahuluan

Manual ini menjelaskan cara menggunakan **Modul Manajemen Stok** pada aplikasi CIS (Capung Inventory and Sales), yaitu bagian dari sistem yang mengatur pembelian barang dari supplier, retur barang, pindah stok antar cabang, opname fisik, dan penyesuaian stok.

Manual ini ditujukan untuk staf gudang, staf pembelian, dan admin cabang yang menggunakan aplikasi sehari-hari. Setiap bab menjelaskan satu layar (form), lengkap dengan penjelasan field, langkah-langkah penggunaan, dan dampaknya terhadap stok.

> **Catatan:** Setiap cabang memiliki basis data sendiri-sendiri. Transaksi stok yang dilakukan di satu cabang tidak memengaruhi stok cabang lain, kecuali melalui transaksi **Pindah Stok** yang dicatat secara terpisah di kedua sisi (lihat Bab 9).

`[SCREENSHOT: Tampilan Dashboard utama aplikasi CIS]`

### Struktur Menu

Modul manajemen stok dapat diakses dari dua dashboard utama:

| Dashboard | Menu di dalamnya |
|---|---|
| **Transaksi** | Pembelian, Penjualan, Retur Pembelian, Retur Penjualan |
| **Inventory** | Stok Opname, Pindah Stok, Penyesuaian Stok |

Layar **Kartu Stok** dan **Riwayat Pergerakan Stok** untuk melihat posisi dan histori stok dapat diakses dari menu **Inventory** atau **Reporting**.

`[SCREENSHOT: Dashboard Transaksi dan Dashboard Inventory berdampingan]`

---

## 3. Konsep Dasar: Status Dokumen

Semua dokumen stok (Pembelian, Retur, Pindah Stok, Opname, Penyesuaian) mengikuti konsep status yang sama. Memahami konsep ini penting agar tidak bingung mengapa sebuah tombol tidak bisa diklik.

### Status Umum

| Status | Arti | Bisa diedit/dihapus? | Sudah memengaruhi stok? |
|---|---|---|---|
| **Draft** | Dokumen baru dibuat, belum final | Ya | Tidak |
| **Posted / Confirmed / Received** | Dokumen sudah difinalisasi | Tidak | Ya, stok sudah berubah |
| **Cancelled** | Dokumen dibatalkan setelah Posted | Tidak | Sudah dibalik (reversed) |

### Alur Umum

```
Draft  ->  Posted/Confirmed/Received  ->  (boleh) Cancelled
```

- Selama **Draft**, Anda bebas mengubah header dan baris barang, menyimpan (Save), atau menghapus (Delete) dokumen.
- Setelah **Posted/Confirmed/Received**, dokumen terkunci — semua isian menjadi tampilan saja (read-only). Ini adalah titik dimana stok benar-benar berubah.
- Jika terjadi kesalahan setelah dokumen di-Posting, **jangan** mengedit dokumen secara manual. Gunakan tombol **Void / Cancel** untuk membatalkan — sistem akan otomatis membalik (reverse) perubahan stok yang sudah terjadi.
- Tidak ada cara untuk mengembalikan dokumen yang sudah Cancelled menjadi Draft kembali. Jika transaksi masih diperlukan, buat dokumen baru.

> **Penting:** Purchase Order memiliki tahapan status yang sedikit berbeda dan lebih panjang: **Draft -> Confirmed -> Received -> (boleh) Cancelled**. Stok baru bertambah pada tahap **Received**, bukan saat Confirmed. Lihat Bab 5.

> **Penting:** Sales Order (Penjualan) juga punya tahapan tiga langkah: **Draft -> Invoice -> Posted -> (boleh) Cancelled**, tapi tidak seperti dokumen lain, tahap **Invoice** tetap menyentuh Stock Card — bukan mengurangi **Qty Onhand**, melainkan menambah **Qty Reserved** (lihat Bab 12). Baru pada tahap **Post**, barang benar-benar keluar: **Qty Onhand** berkurang dan reservasinya dilepas. Lihat Bab 6.

### Tombol Aksi yang Umum Ditemui

| Tombol | Fungsi |
|---|---|
| **Add** | Membuat dokumen baru (form dikosongkan, siap diisi) |
| **Save** | Menyimpan dokumen dalam status Draft |
| **Delete** | Menghapus dokumen (hanya jika masih Draft) |
| **Post / Confirm / Receive** | Memfinalisasi dokumen — stok berubah sesuai jenis transaksi |
| **Void / Cancel** | Membatalkan dokumen yang sudah Posted — stok dikembalikan otomatis |
| **Reload** | Memuat ulang data dari database |
| **Cari (Search)** | Mencari dokumen berdasarkan nomor/kata kunci |
| **\|<  <  >  >\|** | Navigasi ke dokumen pertama / sebelumnya / berikutnya / terakhir |

---

## 4. Menyiapkan Kemasan Produk (Product Packaging)

### Tujuan

Barang farmasi biasanya diterima dari supplier dalam satuan besar (misalnya **karton/box**), tetapi stok dan penjualan dihitung dalam satuan kecil (misalnya **tablet/pcs**). Fitur **Kemasan Produk** memungkinkan Anda mendaftarkan faktor konversi antar satuan untuk setiap produk, sehingga saat entri barang masuk Anda cukup memasukkan jumlah dalam satuan besar — sistem otomatis menghitung jumlah dalam satuan dasar.

### Cara Mengakses

Buka **Master Data -> Produk**, pilih produk yang ingin diatur, lalu klik tombol untuk membuka layar **Kemasan Produk**. Tombol ini hanya aktif jika produk sudah tersimpan.

`[SCREENSHOT: Tombol Kemasan Produk pada form Produk]`

### Penjelasan Layar

| Field/Elemen | Keterangan |
|---|---|
| Nama Produk | Ditampilkan otomatis, hanya untuk informasi |
| Satuan dasar | Satuan terkecil produk (mis. "tablet"), ditampilkan otomatis, tidak bisa diubah di layar ini |
| **Kemasan** (dropdown satuan) | Pilih satuan kemasan baru yang ingin didaftarkan. Satuan yang sudah terdaftar atau satuan dasar tidak akan muncul lagi di daftar ini |
| **Isi (dlm satuan dasar)** | Masukkan berapa banyak satuan dasar yang terkandung dalam 1 satuan kemasan ini. Contoh: 1 **box** = 100 **tablet** -> isi angka `100` |
| Tabel daftar kemasan | Menampilkan semua kemasan yang sudah didaftarkan untuk produk ini: Kode Kemasan, Isi, dan Satuan Dasar |

`[SCREENSHOT: Layar Kemasan Produk dengan beberapa baris kemasan terisi]`

### Langkah-Langkah

1. Buka produk yang ingin diatur kemasannya dari **Master Data -> Produk**.
2. Klik tombol untuk membuka layar **Kemasan Produk**.
3. Pilih satuan pada dropdown **Kemasan** (mis. "Box").
4. Isi jumlah konversi pada **Isi (dlm satuan dasar)** (mis. `100` jika 1 box = 100 tablet).
5. Klik **+ Tambah**. Baris baru akan langsung muncul di tabel.
6. Ulangi langkah 3–5 jika produk memiliki lebih dari satu jenis kemasan (mis. Box dan Karton).
7. Untuk menghapus kemasan yang salah, pilih baris di tabel lalu klik **- Hapus**, kemudian konfirmasi penghapusan.

> **Catatan:** Data kemasan langsung tersimpan ke database begitu Anda klik **+ Tambah** atau **- Hapus** — tidak perlu tombol Save terpisah.

> **Perhatian:** Aturlah kemasan produk **sebelum** membuat dokumen Pembelian (Purchase Order) untuk produk tersebut, agar pilihan satuan sudah tersedia saat entri barang.

---

## 5. Pembelian (Purchase Order)

### Tujuan

Mencatat pemesanan dan penerimaan barang dari supplier (Principal), termasuk kalkulator konversi kemasan agar staf tidak perlu menghitung manual dari karton ke satuan kecil.

### Cara Mengakses

**Dashboard Transaksi -> Pembelian**

`[SCREENSHOT: Form Pembelian (PEMBELIAN) kosong]`

### Penjelasan Field — Header

| Field | Keterangan |
|---|---|
| **Principal / Supplier** | Pilih supplier dari dropdown pencarian. Wajib diisi |
| **Tanggal PO** | Tanggal pembuatan pesanan |
| **Estimasi Tiba** | Perkiraan tanggal barang akan tiba |
| **Alamat Supplier**, **Telepon** | Terisi otomatis dari data supplier, tidak bisa diubah |
| **Catatan** | Catatan bebas terkait pesanan |
| **Tgl. Terima** | Terisi otomatis saat barang diterima (status Received) |

### Penjelasan Field — Entri Barang

| Field | Keterangan |
|---|---|
| **Barang** | Pilih produk dari dropdown pencarian |
| **Batch** | Nomor batch/lot barang (isi manual sesuai kemasan fisik) |
| **Exp. Date** | Tanggal kadaluarsa barang |
| **Qty** | Jumlah barang **dalam satuan kemasan yang dipilih** |
| **Kemasan** | Pilih satuan (mis. "Box" atau satuan dasar seperti "tablet") |
| **Qty Preview** | Menampilkan hasil konversi otomatis ke satuan dasar, contoh: `= 10 box -> 1000 tablet` |
| **Harga** | Harga beli per satuan kemasan yang dipilih |
| **Disc %** | Diskon dalam persen (opsional) |

Kolom pada tabel barang: **Kode Barang, Nama Barang, Batch, Exp., Qty, Sat (satuan), Harga, Disc%, Subtotal**.

Bagian bawah form menampilkan **Subtotal**, **PPN (11%)**, dan **TOTAL**.

### Langkah-Langkah

1. Klik **Add** untuk membuat PO baru.
2. Pilih **Principal / Supplier**, isi **Tanggal PO** dan **Estimasi Tiba**.
3. Pada bagian entri barang: pilih **Barang**, isi **Batch** dan **Exp. Date**, isi **Qty**.
4. Pilih **Kemasan** — perhatikan **Qty Preview** untuk memastikan hasil konversi ke satuan dasar sudah benar.
5. Isi **Harga** dan **Disc %** jika ada.
6. Klik **+ Tambah** untuk memasukkan barang ke tabel. Ulangi untuk barang lainnya.
7. Klik **Save** untuk menyimpan PO sebagai Draft.
8. Setelah PO disetujui/dikirim ke supplier, klik **Confirm** (status berubah menjadi Confirmed). Pada tahap ini stok **belum** berubah.
9. Saat barang fisik tiba di gudang, buka kembali PO tersebut dan klik **Receive**. Pada tahap ini **stok bertambah** sesuai qty (dalam satuan dasar) untuk setiap barang.
10. Jika PO batal (sebelum atau sesudah diterima), klik **Cancel**. Jika PO sudah Received, sistem otomatis mengurangi kembali stok yang sudah bertambah.

`[SCREENSHOT: Contoh Qty Preview menampilkan hasil konversi]`

### Dampak terhadap Stok

| Aksi | Status Berubah | Efek Stok |
|---|---|---|
| Confirm | Draft -> Confirmed | Tidak ada |
| Receive | Confirmed -> Received | **Stok bertambah** (masuk) |
| Cancel (dari Received) | Received -> Cancelled | Stok dikurangi kembali (dibalik) |
| Cancel (dari Draft/Confirmed) | -> Cancelled | Tidak ada efek stok (belum pernah bertambah) |

### Perhatian / Kesalahan Umum

- Barang tidak bisa ditambahkan ke tabel jika **Supplier** belum dipilih.
- Pastikan memilih **Kemasan** yang benar sebelum menambahkan baris — kesalahan satuan akan menyebabkan jumlah stok yang tercatat salah (walaupun sudah dibalik saat Cancel, akan lebih rapi jika benar sejak awal).
- Setelah status **Confirmed**, header dan barang tidak bisa lagi diubah. Jika ada revisi, batalkan (Cancel) dan buat PO baru.

---

## 6. Penjualan (Sales Order)

### Tujuan

Mencatat penjualan barang ke pelanggan, mulai dari draft faktur, penerbitan invoice, hingga posting yang benar-benar mengurangi stok gudang.

### Cara Mengakses

**Dashboard Transaksi -> Penjualan**

`[SCREENSHOT: Form Penjualan (PENJUALAN) kosong]`

### Penjelasan Field — Header

| Field | Keterangan |
|---|---|
| **Kode Pelanggan** | Pilih pelanggan dari dropdown pencarian. Wajib diisi |
| **Salesman** | Wajib diisi |
| **Term of Payment** | Wajib diisi |
| **Tgl. Faktur** | Tanggal transaksi penjualan |
| **Tgl. Jatuh Tempo** | Batas waktu pembayaran sesuai Term of Payment |
| **Alamat Kirim** | Alamat pengiriman barang. Wajib diisi |
| **Provinsi**, **Kabupaten/Kota** | Lokasi pengiriman. Provinsi wajib diisi |
| **Sales Area** | Wajib diisi |
| **Penanggung Jawab** | Wajib diisi — dipilih dari user dengan role PIC (Apoteker Penanggung Jawab); nomor SIPA-nya otomatis ikut tercatat di faktur |

### Penjelasan Field — Entri Barang

| Field | Keterangan |
|---|---|
| **Barang** | Pilih produk dari dropdown pencarian |
| **Batch** | Nomor batch/lot barang |
| **Exp. Date** | Tanggal kadaluarsa barang |
| **Qty** | Jumlah barang **dalam satuan kemasan yang dipilih** |
| **Kemasan** | Pilih satuan (sama seperti Pembelian — mis. "Box" atau satuan dasar seperti "tablet"), dikonversi otomatis ke satuan dasar |
| **Qty Preview** | Menampilkan hasil konversi ke satuan dasar, sama seperti pada Pembelian (lihat Bab 4) |
| **Harga (HNA)** | Harga jual per satuan kemasan yang dipilih |
| **Disc.(%)** | Diskon per item, maksimal 100% |

Kolom pada tabel barang ("DAFTAR ITEM FAKTUR"): **Kode Brg, Nama Barang, Batch, Exp. Date, Qty, Sat, Harga, Diskon, Jml. Harga**.

Bagian bawah form menampilkan **Total Harga**, **Ekstra Diskon**, **Total DPP**, **PPN 11%**, dan **TOTAL TAGIHAN**.

### Langkah-Langkah

1. Klik **Add** untuk membuat faktur penjualan baru.
2. Isi **Kode Pelanggan**, **Salesman**, **Term of Payment**, **Tgl. Faktur**, dan **Tgl. Jatuh Tempo**.
3. Isi **Alamat Kirim**, **Provinsi**, **Kabupaten/Kota**, dan **Sales Area**.
4. Pilih **Penanggung Jawab**.
5. Pada bagian entri barang: pilih **Barang**, isi **Batch**, **Exp. Date**, **Qty**, dan **Kemasan** — perhatikan **Qty Preview** untuk memastikan hasil konversi sudah benar.
6. Isi **Harga (HNA)** dan **Disc.(%)** jika ada, klik **+ Tambah**. Ulangi untuk barang lain.
7. Klik **Save** untuk menyimpan sebagai Draft.
8. Klik **Invoice** untuk menerbitkan faktur (status berubah menjadi Invoice). Barang **belum keluar gudang**, tapi qty-nya langsung **direservasi** (lihat Bab 12) agar tidak bisa ikut dijual di faktur lain.
9. Setelah barang benar-benar dikirim/diserahkan ke pelanggan, klik **Post**. Pada tahap inilah **Qty Onhand berkurang** sesuai qty (dalam satuan dasar) untuk setiap barang, dan reservasinya dilepas.
10. Jika faktur batal, klik **Cancel**. Sistem otomatis melepas reservasi (jika masih status Invoice) atau mengembalikan stok (jika sudah Posted).

`[SCREENSHOT: Form Penjualan dengan status INVOICE]`

### Dampak terhadap Stok

| Aksi | Status Berubah | Qty Onhand | Qty Reserved |
|---|---|---|---|
| Invoice | Draft -> Invoice | Tidak berubah | **Bertambah** (direservasi) |
| Post | Invoice -> Posted | **Berkurang** (keluar ke pelanggan) | Berkurang (reservasi dilepas) |
| Cancel (dari Invoice) | -> Cancelled | Tidak berubah | Berkurang (reservasi dilepas) |
| Cancel (dari Posted) | -> Cancelled | Bertambah (dikembalikan) | Tidak berubah |

> **Catatan:** Pola ini mirip dengan Purchase Order (Bab 5) — ada satu tahap administratif (**Invoice**/Confirm) sebelum tahap yang benar-benar mengurangi **Qty Onhand** (**Post**/Receive). Bedanya, pada Penjualan tahap Invoice tidak sepenuhnya "tanpa efek" — ia memindahkan qty dari tersedia (**Qty Available**) ke tercadang (**Qty Reserved**), supaya barang yang sudah difakturkan tidak bisa ikut terjual ke pelanggan lain sebelum benar-benar dikirim.

### Perhatian / Kesalahan Umum

- Barang tidak bisa ditambahkan ke tabel jika **Pelanggan** atau **Barang** belum dipilih, atau **Qty** masih kosong/nol.
- Tombol **Post** hanya aktif jika faktur berstatus **Invoice** — faktur yang masih Draft harus di-**Invoice** dulu sebelum bisa di-**Post**.
- **Invoice** akan gagal jika **Qty Available** (Onhand dikurangi Reserved) lebih sedikit dari qty yang difakturkan — artinya barang sudah habis atau sudah direservasi faktur lain. Cek **Kartu Stok** (Bab 12) bila ragu.
- **Post** akan gagal jika **Qty Onhand** fisik lebih sedikit dari qty yang difakturkan, meski sudah lolos tahap Invoice (mis. karena stok berkurang drastis akibat penyesuaian di antara waktu Invoice dan Post).
- **Tgl. Faktur** tidak boleh diubah ke bulan yang berbeda dari bulan saat faktur pertama kali dibuat (nomor faktur mengandung kode bulan) — jika tanggalnya salah, hapus dan buat faktur baru dengan tanggal yang benar.
- Faktur yang sudah **Posted** menjadi acuan untuk **Retur Penjualan** (Bab 8) — retur hanya bisa dibuat dari faktur yang sudah di-Post.

---

## 7. Retur Pembelian (Purchase Return)

### Tujuan

Mencatat pengembalian barang ke supplier, misalnya karena barang rusak atau tidak sesuai pesanan.

### Cara Mengakses

**Dashboard Transaksi -> Retur Pembelian**

`[SCREENSHOT: Form Retur Pembelian]`

### Penjelasan Field

| Field | Keterangan |
|---|---|
| **Principal / Supplier** | Wajib diisi |
| **Pilih PO** | Menampilkan daftar PO milik supplier tersebut yang **sudah berstatus Received**. PO yang belum diterima tidak akan muncul |
| **Tgl. Return** | Tanggal retur dibuat |
| **Alasan** | Alasan retur (teks bebas) |

Setelah memilih PO, dropdown **Barang** hanya menampilkan produk yang ada pada PO tersebut. Tabel barang menggunakan kolom yang sama seperti form Pembelian.

### Langkah-Langkah

1. Klik **Add** untuk membuat retur baru.
2. Pilih **Principal / Supplier**.
3. Pilih **PO** yang menjadi acuan retur (hanya PO berstatus Received yang tersedia).
4. Isi **Tgl. Return** dan **Alasan**.
5. Pilih barang dan jumlah yang ingin diretur, klik **+ Tambah**.
6. Klik **Save** untuk menyimpan sebagai Draft.
7. Klik **Post** untuk memfinalisasi retur. **Stok akan berkurang** sejumlah barang yang diretur.
8. Jika retur salah/dibatalkan, klik **Void** — stok akan dikembalikan (ditambahkan kembali).

### Dampak terhadap Stok

| Aksi | Efek Stok |
|---|---|
| Post | **Stok berkurang** (keluar ke supplier) |
| Void (setelah Posted) | Stok dikembalikan (dibalik) |

### Perhatian

- Retur tidak bisa di-Post jika stok yang tersedia lebih sedikit dari jumlah yang diretur — sistem akan menampilkan galat (error).
- Hanya PO dengan status **Received** yang bisa dijadikan acuan retur.

---

## 8. Retur Penjualan (Sales Return)

### Tujuan

Mencatat barang yang dikembalikan oleh pelanggan (customer) ke gudang. Retur hanya bisa dibuat dari faktur Penjualan yang sudah berstatus **Posted** (lihat Bab 6).

### Cara Mengakses

**Dashboard Transaksi -> Retur Penjualan**

`[SCREENSHOT: Form Retur Penjualan]`

### Penjelasan Field

| Field | Keterangan |
|---|---|
| **Pelanggan** | Wajib diisi |
| **Pilih SO** | Menampilkan daftar Sales Order milik pelanggan tersebut yang **sudah berstatus Posted**. SO yang belum di-posting tidak akan muncul |
| **Tgl. Return** | Tanggal retur dibuat |
| **Alasan** | Alasan retur (teks bebas) |

Setelah memilih SO, dropdown **Barang** hanya menampilkan produk yang ada pada SO tersebut.

### Langkah-Langkah

1. Klik **Add** untuk membuat retur baru.
2. Pilih **Pelanggan**.
3. Pilih **SO** yang menjadi acuan retur (hanya SO berstatus Posted yang tersedia).
4. Isi **Tgl. Return** dan **Alasan**.
5. Pilih barang dan jumlah yang dikembalikan, klik **+ Tambah**.
6. Klik **Save**, lalu **Post** untuk memfinalisasi. **Stok akan bertambah** kembali sejumlah barang yang diretur.
7. Jika retur salah, klik **Void** — stok akan dikurangi kembali (dibalik).

### Dampak terhadap Stok

| Aksi | Efek Stok |
|---|---|
| Post | **Stok bertambah** (barang kembali ke gudang) |
| Void (setelah Posted) | Stok dikurangi kembali (dibalik) |

---

## 9. Pindah Stok (Stock Transfer)

### Tujuan

Mencatat perpindahan barang antar cabang. Karena setiap cabang memiliki database sendiri, pindah stok dicatat **secara terpisah** di masing-masing cabang: cabang pengirim membuat transfer **Keluar (Out)**, dan cabang penerima membuat transfer **Masuk (In)**.

### Cara Mengakses

**Dashboard Inventory -> Pindah Stok**

`[SCREENSHOT: Form Pindah Stok]`

### Penjelasan Field

| Field | Keterangan |
|---|---|
| **Tipe Transfer** | Pilih **Transfer Keluar (Out)** jika cabang ini mengirim barang, atau **Transfer Masuk (In)** jika cabang ini menerima barang |
| **Nama Cabang** | Nama cabang tujuan (jika Out) atau cabang asal (jika In). **Wajib diisi** |
| **Tgl. Transfer** | Tanggal transfer |
| **Catatan** | Catatan bebas |
| **Barang** | Pilih produk |
| **Batch** | Hanya menampilkan batch yang memiliki stok tersedia |
| **Qty** | Jumlah yang dipindahkan |

### Langkah-Langkah

1. Klik **Add**.
2. Pilih **Tipe Transfer** (Out atau In) sesuai peran cabang Anda dalam transaksi ini.
3. Isi **Nama Cabang** lawan transaksi.
4. Isi **Tgl. Transfer** dan **Catatan** jika perlu.
5. Pilih **Barang**, **Batch**, dan **Qty**, klik **+ Tambah**. Ulangi untuk barang lain.
6. Klik **Save**, lalu **Post**.
   - Jika **Transfer Keluar**: stok di cabang ini **berkurang**.
   - Jika **Transfer Masuk**: stok di cabang ini **bertambah**.
7. Jika transfer salah, klik **Void** untuk membatalkan — stok dibalik sesuai tipe transfer aslinya.

### Dampak terhadap Stok

| Tipe Transfer | Efek Stok saat Post |
|---|---|
| Keluar (Out) | Stok cabang ini **berkurang** |
| Masuk (In) | Stok cabang ini **bertambah** |

### Perhatian

- **Nama Cabang wajib diisi** — dokumen tidak bisa disimpan/di-post tanpa ini, karena digunakan sebagai catatan asal/tujuan barang.
- Transfer Keluar tidak bisa di-Post jika stok tidak mencukupi.
- Pastikan kedua cabang (pengirim dan penerima) sama-sama mencatat transaksinya masing-masing — sistem tidak melakukan sinkronisasi otomatis antar database cabang.

---

## 10. Stok Opname

### Tujuan

Mencocokkan catatan stok di sistem dengan jumlah fisik hasil hitung di gudang. Selisih yang ditemukan akan **otomatis** menghasilkan dokumen Penyesuaian Stok (Stock Adjustment).

### Cara Mengakses

**Dashboard Inventory -> Stok Opname**

`[SCREENSHOT: Form Stok Opname dengan tabel Qty Sistem vs Qty Fisik]`

### Penjelasan Field

| Field | Keterangan |
|---|---|
| **Tipe Opname** | **Physical Count** (opname rutin, boleh berkali-kali) atau **Opening Stock** (stok awal saat pertama kali implementasi sistem — hanya boleh dibuat **satu kali**) |
| **Tgl. Opname** | Tanggal pelaksanaan opname |
| **Catatan** | Catatan bebas |
| **Load Products** | Tombol untuk memuat semua produk ke tabel sekaligus |

Kolom tabel: **Kode Barang, Nama Barang, Batch, Satuan, Qty Sistem** (otomatis, tidak bisa diubah), **Qty Fisik** (diisi manual sesuai hasil hitung), **Selisih** (dihitung otomatis = Qty Fisik - Qty Sistem, berwarna hijau jika lebih, merah jika kurang).

### Langkah-Langkah

1. Klik **Add**, pilih **Tipe Opname**.
2. Klik **Load Products** untuk memuat seluruh produk (akan muncul konfirmasi karena akan mengganti data yang sudah ada di tabel).
3. Untuk setiap baris, isi **Qty Fisik** sesuai hasil hitung fisik di gudang. Kolom **Selisih** akan terisi otomatis.
4. Klik **Save** untuk menyimpan sebagai Draft (bisa dilanjutkan nanti jika opname belum selesai dihitung).
5. Setelah semua barang selesai dihitung, klik **Post**.
   - Sistem otomatis membuat dokumen **Penyesuaian Stok** untuk setiap barang yang memiliki selisih.
   - Stok langsung disesuaikan agar sama dengan **Qty Fisik**.

`[SCREENSHOT: Kolom Selisih berwarna hijau/merah]`

### Dampak terhadap Stok

Setiap barang dengan selisih != 0 akan menghasilkan penyesuaian otomatis:
- Selisih **positif** (Qty Fisik > Qty Sistem) -> stok **bertambah**
- Selisih **negatif** (Qty Fisik < Qty Sistem) -> stok **berkurang**

### Perhatian

- **Opening Stock** hanya bisa dibuat satu kali — sistem akan menolak jika sudah pernah ada.
- Setelah di-**Post**, opname tidak bisa diedit. Dokumen Penyesuaian Stok yang dihasilkan juga otomatis berstatus Posted, tercatat dengan alasan "Stock Opname".
- Pastikan penghitungan fisik benar-benar akurat sebelum Post, karena ini akan langsung mengubah stok resmi di sistem.

---

## 11. Penyesuaian Stok (Stock Adjustment)

### Tujuan

Menyesuaikan stok secara manual di luar proses opname, misalnya karena barang rusak, hilang, kadaluarsa, atau koreksi kesalahan input sebelumnya.

### Cara Mengakses

**Dashboard Inventory -> Penyesuaian Stok**

`[SCREENSHOT: Form Penyesuaian Stok]`

### Penjelasan Field

| Field | Keterangan |
|---|---|
| **Alasan** | Pilih salah satu: **Kerusakan**, **Kehilangan**, **Kadaluarsa**, **Koreksi**, **Lainnya** (alasan "Stock Opname" khusus untuk penyesuaian otomatis dari Bab 10, tidak dipilih manual) |
| **Tgl. Penyesuaian** | Tanggal penyesuaian |
| **Catatan** | Catatan bebas |
| **Barang**, **Batch** | Pilih produk dan batch yang akan disesuaikan (hanya batch dengan stok yang tersedia) |
| **Qty Sebelum** | Terisi otomatis sesuai stok saat ini, tidak bisa diubah |
| **Arah** | Pilih **In** (menambah stok) atau **Out** (mengurangi stok) |
| **Qty Penyesuaian** | Jumlah yang ditambah/dikurangi |

Kolom tabel: **Kode Barang, Nama Barang, Batch, Satuan, Qty Sebelum, Arah, Qty Adj, Qty Sesudah** (dihitung otomatis).

### Langkah-Langkah

1. Klik **Add**, pilih **Alasan** penyesuaian.
2. Isi **Tgl. Penyesuaian** dan **Catatan**.
3. Pilih **Barang** dan **Batch** — **Qty Sebelum** akan terisi otomatis.
4. Pilih **Arah** (In/Out) dan isi **Qty Penyesuaian**.
5. Klik **+ Tambah**. Ulangi untuk barang lain jika perlu.
6. Klik **Save**, lalu **Post** untuk memfinalisasi. Stok berubah sesuai arah yang dipilih.
7. Jika salah, klik **Void** untuk membatalkan — stok dibalik ke posisi semula.

### Dampak terhadap Stok

| Arah | Efek Stok saat Post |
|---|---|
| In | Stok **bertambah** |
| Out | Stok **berkurang** (ditolak jika stok tidak mencukupi) |

---

## 12. Kartu Stok (Stock Card)

### Tujuan

Melihat posisi stok terkini per produk dan per batch — berapa yang ada di gudang, berapa yang sudah dialokasikan (reserved), dan berapa yang benar-benar tersedia untuk dijual.

### Cara Mengakses

Menu **Inventory** atau **Reporting -> Kartu Stok**

`[SCREENSHOT: Layar Kartu Stok dengan daftar produk]`

### Penjelasan Field

| Field | Keterangan |
|---|---|
| **Search** | Cari berdasarkan kode barang, nama barang, atau nomor batch |
| **Hide Zero Stock** | Centang untuk menyembunyikan barang yang stoknya kosong (0) |
| **Qty Onhand** | Jumlah fisik di gudang (merah jika minus, oranye jika nol) |
| **Qty Reserved** | Jumlah yang sudah dicadangkan oleh faktur Penjualan berstatus **Invoice** yang belum di-Post (lihat Bab 6) — barang belum keluar gudang, tapi sudah "dipesan" sehingga tidak bisa dijual dobel |
| **Qty Available** | Sisa yang benar-benar bisa dijual (= Onhand - Reserved) |

Bagian bawah menampilkan ringkasan: total baris, jumlah stok negatif, dan jumlah barang habis.

### Langkah-Langkah

1. Buka layar Kartu Stok.
2. Gunakan kotak **Search** untuk mencari produk tertentu, atau centang **Hide Zero Stock** untuk fokus pada barang yang masih ada stoknya.
3. Klik **Refresh** untuk memuat data terbaru.
4. Klik **Print** untuk mencetak/preview laporan Kartu Stok dalam format PDF.

---

## 13. Riwayat Pergerakan Stok (Stock Movement)

### Tujuan

Melihat jejak audit (audit trail) seluruh transaksi yang memengaruhi stok — berguna untuk menelusuri mengapa stok suatu produk berubah pada tanggal tertentu.

### Cara Mengakses

Menu **Inventory** atau **Reporting -> Riwayat Pergerakan Stok**

`[SCREENSHOT: Layar Riwayat Pergerakan Stok dengan filter tanggal]`

### Penjelasan Field

| Field | Keterangan |
|---|---|
| **Dari Tanggal / Sampai Tanggal** | Rentang tanggal yang ingin ditelusuri |
| **Search** | Cari berdasarkan kode/nama barang |
| Kolom hasil | Tanggal, Jenis Pergerakan, Arah (In/Out), Kode & Nama Barang, Batch, Satuan, Qty, Jenis Dokumen Sumber, Nomor Dokumen, Catatan |

### Jenis Pergerakan Stok

| Jenis | Arah | Sumber |
|---|---|---|
| Stok Awal (Opening Stock) | Masuk | Stok Opname (Opening Stock) |
| Penerimaan Pembelian | Masuk | Pembelian (Receive) |
| Penjualan | Keluar | Sales Order (Posted) |
| Retur Penjualan | Masuk | Retur Penjualan (Post) |
| Retur Pembelian | Keluar | Retur Pembelian (Post) |
| Transfer Keluar | Keluar | Pindah Stok (Out, Post) |
| Transfer Masuk | Masuk | Pindah Stok (In, Post) |
| Penyesuaian Masuk | Masuk | Penyesuaian Stok (In, Post) |
| Penyesuaian Keluar | Keluar | Penyesuaian Stok (Out, Post) |

### Langkah-Langkah

1. Buka layar Riwayat Pergerakan Stok.
2. Tentukan **Dari Tanggal** dan **Sampai Tanggal**.
3. (Opsional) Ketik kata kunci di **Search** untuk fokus pada produk tertentu.
4. Klik **Refresh** untuk memuat data.
5. Klik **Print** untuk mencetak/preview laporan dalam format PDF.

---

## 14. Tanya Jawab & Pemecahan Masalah

**T: Saya sudah klik Post tapi tombol Save/Delete tidak bisa diklik lagi. Kenapa?**
J: Ini normal. Setelah dokumen berstatus Posted/Confirmed/Received, dokumen terkunci agar riwayat stok tetap akurat. Gunakan tombol **Void/Cancel** jika perlu membatalkan.

**T: Saya salah memasukkan jumlah barang setelah dokumen di-Post. Bagaimana cara memperbaikinya?**
J: Jangan mengedit dokumen lama. Klik **Void/Cancel** pada dokumen tersebut (stok akan otomatis dikembalikan ke posisi semula), lalu buat dokumen baru dengan data yang benar.

**T: Kenapa dropdown Kemasan pada Pembelian tidak menampilkan satuan "Box"?**
J: Kemasan produk belum didaftarkan. Buka **Master Data -> Produk**, pilih produk tersebut, lalu tambahkan kemasan "Box" beserta faktor konversinya di layar **Kemasan Produk** (lihat Bab 4).

**T: Kenapa Retur Pembelian tidak menemukan PO yang saya cari di dropdown "Pilih PO"?**
J: Hanya PO dengan status **Received** yang muncul di daftar. Jika PO masih Draft atau Confirmed (barang belum diterima), retur belum bisa dibuat untuk PO tersebut.

**T: Kenapa saat Post Transfer/Retur/Penyesuaian keluar, muncul pesan error terkait stok?**
J: Sistem menolak transaksi yang membuat stok menjadi negatif. Periksa kembali **Kartu Stok** (Bab 12) untuk melihat jumlah yang benar-benar tersedia sebelum mencoba Post ulang.

**T: Apakah stok Opening Stock bisa dibuat ulang jika salah input?**
J: Tidak bisa dibuat dua kali dari menu Stok Opname. Jika Opening Stock yang sudah Posted salah, gunakan **Penyesuaian Stok** (Bab 11, alasan "Koreksi") untuk membetulkan selisihnya.

**T: Apakah Pindah Stok otomatis tercatat di kedua cabang?**
J: Tidak. Karena tiap cabang punya database sendiri, kedua cabang harus **masing-masing** mencatat transaksinya sendiri — cabang pengirim membuat Transfer **Out**, cabang penerima membuat Transfer **In**.

---

*Dokumen ini adalah bagian dari manual penggunaan aplikasi CIS. Untuk pertanyaan lebih lanjut, hubungi tim IT PT. Capung Indah Sentosa.*
