# Aplikasi AR Edukasi Sampah

Aplikasi Augmented Reality (AR) ini dirancang untuk membantu **siswa Sekolah Dasar (SD)** memahami konsep **daur ulang sampah secara kreatif** melalui interaksi visual 3D berbasis flipbook.

Dikembangkan sebagai bagian dari penelitian oleh **Muhammad Rizeky Rahmatullah**,  
Program Studi Informatika, Universitas Mulawarman.

---

## 🌱 Tujuan
- Mengenalkan jenis sampah dan cara mendaur ulangnya secara menyenangkan
- Meningkatkan kesadaran lingkungan sejak dini
- Mengintegrasikan teknologi AR dalam pembelajaran berbasis buku flipbook

---

## 📱 Fitur Utama
- **Scan gambar** pada flipbook menggunakan kamera perangkat
- Tampilan **model 3D interaktif** dari hasil daur ulang, seperti:
  - Botol plastik → celengan
  - Kardus → rak buku
  - Sedotan → kotak pensil
  - Cangkang telur → pupuk organik
  - Daun kering → kompos
  - Kulit jeruk → pengharum alami
  - Stik es krim → bingkai foto
- Informasi edukasi singkat muncul bersama model 3D
- Mendukung pembelajaran offline

---

## 🛠️ Teknologi yang Digunakan
- **Unity Engine** (versi 2021+)
- **Vuforia Engine** (untuk deteksi image target)
- **C#** (pemrograman logika aplikasi)
- **Flipbook** sebagai trigger AR (https://heyzine.com/flip-book/f1b406a817.html)

---

## 📦 Cara Menjalankan (Untuk Developer)
1. Buka proyek ini di **Unity Hub** (pastikan versi Unity sesuai)
2. Tambahkan **Vuforia Engine** melalui Package Manager:
   - Buka **Edit > Project Settings > Package Manager**
3. Masukkan **Vuforia License Key**
   - 
4. **Build ke perangkat Android**

> Catatan: File Vuforia Engine () **tidak disertakan** karena ukurannya besar. Silakan instal ulang via Package Manager.

---

## 📁 Struktur Proyek
-  → Model 3D hasil daur ulang
-  → Gambar marker AR
-  → Database target Vuforia (, )
-  → Konfigurasi Vuforia

---

## 📄 Lisensi
Proyek ini bersifat **pembelajaran edukatif**.  
Silakan gunakan untuk keperluan pembelajaran dengan mencantumkan sumber.

© 2025 Muhammad Rizeky Rahmatullah — Universitas Mulawarman
