-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2025 at 09:28 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `benice`
--

-- --------------------------------------------------------

--
-- Table structure for table `perhitungan_spt`
--

CREATE TABLE `perhitungan_spt` (
  `id_perhitungan` int(11) NOT NULL,
  `id_spt` int(11) NOT NULL COMMENT 'Foreign Key ke tabel spt_tahunan',
  `q_npwp_aktif` tinyint(1) DEFAULT NULL COMMENT 'Q1: NPWP masih aktif?',
  `q_ada_penghasilan` tinyint(1) DEFAULT NULL COMMENT 'Q2: Terima gaji/penghasilan?',
  `q_lebih_satu_sumber` tinyint(1) DEFAULT NULL COMMENT 'Q3: Lebih dari satu sumber penghasilan?',
  `q_kerja_tengah_tahun` tinyint(1) DEFAULT NULL COMMENT 'Q4: Mulai/berhenti kerja di tengah tahun?',
  `q_bonus_thr` tinyint(1) DEFAULT NULL COMMENT 'Q5: Penerima bonus besar, THR, atau kenaikan gaji mendadak?',
  `q_bukti_zakat` tinyint(1) DEFAULT NULL COMMENT 'Q6: Memiliki bukti pembayaran Zakat/sumbangan keagamaan?',
  `q_lapor_telat` tinyint(1) DEFAULT NULL COMMENT 'Q7: Lapor SPT setelah 31 Maret?',
  `status_perkawinan` varchar(5) DEFAULT NULL COMMENT 'Status Perkawinan (misal: K/TK/HB)',
  `jumlah_tanggungan` int(11) DEFAULT 0 COMMENT 'Jumlah Tanggungan',
  `deskripsi_penghasilan_lain` text DEFAULT NULL COMMENT 'Detail Penghasilan Lain yang perlu diinput',
  `total_penghasilan_setahun` decimal(15,2) NOT NULL DEFAULT 0.00 COMMENT 'Total Penghasilan Bruto Setahun',
  `ptkp` decimal(15,2) NOT NULL DEFAULT 0.00 COMMENT 'Penghasilan Tidak Kena Pajak',
  `pph_terutang` decimal(15,2) NOT NULL DEFAULT 0.00 COMMENT 'Pajak Penghasilan Terutang',
  `total_kredit_pajak` decimal(15,2) NOT NULL DEFAULT 0.00 COMMENT 'Total Kredit Pajak (Pajak yang sudah dipotong)',
  `jenis_pembayaran_akhir` enum('Kurang Bayar','Lebih Bayar','Nihil') DEFAULT NULL COMMENT 'Hasil perhitungan',
  `jumlah_kurang_lebih_bayar` decimal(15,2) NOT NULL DEFAULT 0.00 COMMENT 'Jumlah (Kurang/Lebih) Bayar',
  `kode_billing` varchar(20) DEFAULT NULL COMMENT 'Kode Billing (jika Kurang Bayar)',
  `instruksi_wp` text DEFAULT NULL COMMENT 'Instruksi Wajib Pajak (jika Lebih Bayar)'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabel detail data dan hasil perhitungan SPT';

--
-- Dumping data for table `perhitungan_spt`
--

INSERT INTO `perhitungan_spt` (`id_perhitungan`, `id_spt`, `q_npwp_aktif`, `q_ada_penghasilan`, `q_lebih_satu_sumber`, `q_kerja_tengah_tahun`, `q_bonus_thr`, `q_bukti_zakat`, `q_lapor_telat`, `status_perkawinan`, `jumlah_tanggungan`, `deskripsi_penghasilan_lain`, `total_penghasilan_setahun`, `ptkp`, `pph_terutang`, `total_kredit_pajak`, `jenis_pembayaran_akhir`, `jumlah_kurang_lebih_bayar`, `kode_billing`, `instruksi_wp`) VALUES
(1, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, 214000000.00, 54000000.00, 18000000.00, 26833333.00, '', -8833333.00, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `pk_pegawai`
--

CREATE TABLE `pk_pegawai` (
  `id_pegawai` int(11) NOT NULL,
  `id_pk` int(11) NOT NULL COMMENT 'Foreign Key ke pk_profil',
  `npwp_pegawai` varchar(20) DEFAULT NULL COMMENT 'NPWP Pegawai',
  `nama_pegawai` varchar(100) NOT NULL,
  `status_kawin` varchar(5) NOT NULL COMMENT 'Status PTKP (TK/K/HB)',
  `jumlah_tanggungan` int(11) DEFAULT 0,
  `jabatan` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Data Pegawai yang dikelola Pemberi Kerja';

--
-- Dumping data for table `pk_pegawai`
--

INSERT INTO `pk_pegawai` (`id_pegawai`, `id_pk`, `npwp_pegawai`, `nama_pegawai`, `status_kawin`, `jumlah_tanggungan`, `jabatan`) VALUES
(101, 1, '12.345.678.9-000', 'Budi Santoso', 'K/0', 0, 'Manajer Pemasaran'),
(102, 1, '98.765.432.1-000', 'Siti Aisyah', 'K/2', 2, 'Staf Keuangan'),
(103, 1, '11.223.344.5-000', 'Ahmad Pratama', 'TK/0', 0, 'Analis Sistem'),
(105, 1, '0987654321', 'Laura Al Khansa', 'TK', 0, 'Manajer Keuangan'),
(106, 1, '234567', 'Nur Nabila Amalia', 'K', 2, 'Staf'),
(107, 1, '45678908765', 'Thertiana Inki Navara', 'K', 4, 'Sekretaris');

-- --------------------------------------------------------

--
-- Table structure for table `pk_profil`
--

CREATE TABLE `pk_profil` (
  `id_pk` int(11) NOT NULL,
  `npwp_pk` varchar(20) NOT NULL COMMENT 'NPWP Pemberi Kerja',
  `pass_pk` varchar(255) NOT NULL,
  `nama_pk` varchar(150) NOT NULL COMMENT 'Nama Perusahaan/Instansi',
  `alamat_pk` text DEFAULT NULL,
  `kota_pk` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Profil Pemberi Kerja/Pemotong Pajak';

--
-- Dumping data for table `pk_profil`
--

INSERT INTO `pk_profil` (`id_pk`, `npwp_pk`, `pass_pk`, `nama_pk`, `alamat_pk`, `kota_pk`) VALUES
(1, '123456', 'hai123', 'PT Benice Solusi Teknologi', 'Jl. Merdeka No. 5', 'Jakarta');

-- --------------------------------------------------------

--
-- Table structure for table `pk_setoran`
--

CREATE TABLE `pk_setoran` (
  `id_setoran` int(11) NOT NULL,
  `id_pk` int(11) NOT NULL COMMENT 'Foreign Key ke pk_profil',
  `jenis_pajak` varchar(50) NOT NULL COMMENT 'Misal: PPh Pasal 21',
  `masa_pajak` date NOT NULL COMMENT 'Bulan dan Tahun Masa Pajak',
  `jumlah_setor` decimal(15,2) NOT NULL,
  `tanggal_setor` date NOT NULL,
  `kode_billing` varchar(20) NOT NULL,
  `ntpn` varchar(20) DEFAULT NULL COMMENT 'Nomor Transaksi Penerimaan Negara'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Data Penyetoran PPh (Pembayaran Pajak)';

-- --------------------------------------------------------

--
-- Table structure for table `pk_spt_masa`
--

CREATE TABLE `pk_spt_masa` (
  `id_spt_masa` int(11) NOT NULL,
  `id_pk` int(11) NOT NULL COMMENT 'Foreign Key ke pk_profil',
  `tahun` year(4) NOT NULL,
  `bulan` int(11) NOT NULL COMMENT 'Bulan Masa Pajak',
  `tanggal_lapor` datetime DEFAULT NULL COMMENT 'Tanggal dan Waktu Lapor',
  `status_lapor` enum('Draft','Validasi','Dilaporkan') NOT NULL,
  `jumlah_pegawai_dilaporkan` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Data Pelaporan SPT Masa PPh 21';

--
-- Dumping data for table `pk_spt_masa`
--

INSERT INTO `pk_spt_masa` (`id_spt_masa`, `id_pk`, `tahun`, `bulan`, `tanggal_lapor`, `status_lapor`, `jumlah_pegawai_dilaporkan`) VALUES
(1, 1, '2025', 1, '2025-02-15 00:00:00', 'Dilaporkan', 3),
(2, 1, '2025', 2, '2025-03-12 00:00:00', 'Dilaporkan', 3),
(3, 1, '2025', 3, '2025-04-10 00:00:00', 'Draft', 3);

-- --------------------------------------------------------

--
-- Table structure for table `pk_transaksi_gaji`
--

CREATE TABLE `pk_transaksi_gaji` (
  `id_transaksi` int(11) NOT NULL,
  `id_pegawai` int(11) NOT NULL COMMENT 'Foreign Key ke pk_pegawai',
  `tahun` year(4) NOT NULL,
  `bulan` int(11) NOT NULL COMMENT 'Bulan ke- (1-12)',
  `gaji_pokok` decimal(15,2) NOT NULL,
  `tunjangan` decimal(15,2) DEFAULT 0.00,
  `iuran_pensiun` decimal(15,2) DEFAULT 0.00,
  `pph21_dipotong` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Detail Gaji dan Pemotongan PPh 21 Bulanan';

--
-- Dumping data for table `pk_transaksi_gaji`
--

INSERT INTO `pk_transaksi_gaji` (`id_transaksi`, `id_pegawai`, `tahun`, `bulan`, `gaji_pokok`, `tunjangan`, `iuran_pensiun`, `pph21_dipotong`) VALUES
(1, 101, '2025', 10, 5000000.00, 1000000.00, 250000.00, 150000.00),
(2, 102, '2025', 10, 6500000.00, 1500000.00, 325000.00, 250000.00),
(9, 105, '2025', 12, 100000000.00, 20000000.00, 10000000.00, 26833333.33),
(10, 106, '2025', 12, 20000000.00, 1500000.00, 1700000.00, 1551250.00),
(11, 102, '2025', 12, 100000000.00, 30000000.00, 40000000.00, 20608333.33);

-- --------------------------------------------------------

--
-- Table structure for table `spt_tahunan`
--

CREATE TABLE `spt_tahunan` (
  `id_spt` int(11) NOT NULL,
  `id_wp` int(11) NOT NULL COMMENT 'Foreign Key ke tabel wp_profil',
  `tahun_pajak` year(4) NOT NULL COMMENT 'Tahun Pajak (misal: 2024)',
  `tanggal_lapor` date DEFAULT NULL COMMENT 'Tanggal pengajuan SPT (dapat NULL jika masih draft)',
  `status` enum('Kurang Bayar','Lebih Bayar','Nihil','Draft') NOT NULL COMMENT 'Status SPT (dari Histori SPT WP)',
  `jumlah_rupiah` decimal(15,2) NOT NULL DEFAULT 0.00 COMMENT 'Jumlah Kurang/Lebih Bayar'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabel riwayat pengajuan SPT Tahunan';

--
-- Dumping data for table `spt_tahunan`
--

INSERT INTO `spt_tahunan` (`id_spt`, `id_wp`, `tahun_pajak`, `tanggal_lapor`, `status`, `jumlah_rupiah`) VALUES
(1, 123, '2024', '2025-12-12', 'Nihil', 1500000.00),
(2, 123, '2023', '2024-03-20', 'Kurang Bayar', 500000.00),
(3, 123, '2022', '2023-03-31', 'Nihil', 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `wp_profil`
--

CREATE TABLE `wp_profil` (
  `id_wp` int(11) NOT NULL,
  `npwp` varchar(20) NOT NULL COMMENT 'Nomor Pokok Wajib Pajak, dari form Selamat Datang dan Edit Profil',
  `kata_sandi` varchar(255) NOT NULL COMMENT 'Kata Sandi (disimpan terenkripsi/hashed)',
  `nama` varchar(100) NOT NULL COMMENT 'Nama Wajib Pajak',
  `email` varchar(100) DEFAULT NULL COMMENT 'Alamat Email',
  `no_handphone` varchar(20) DEFAULT NULL COMMENT 'Nomor Handphone',
  `alamat` text DEFAULT NULL COMMENT 'Alamat Lengkap Wajib Pajak',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabel data profil Wajib Pajak';

--
-- Dumping data for table `wp_profil`
--

INSERT INTO `wp_profil` (`id_wp`, `npwp`, `kata_sandi`, `nama`, `email`, `no_handphone`, `alamat`, `created_at`) VALUES
(123, '0987654321', 'laura123', 'Laura Al Khansa', 'lauraalkhansa@gmail.com', '0895263166060', 'alamat', '2025-12-04 18:47:30'),
(124, '123456789012345', '0987612345', 'Budi Santosoh', 'budi.santo@contoh.com', '081234567890', 'Jl. Contoh No. 10, Jakarta Pusat', '2025-12-04 18:49:15'),
(125, '112233445566778', '4567', 'Ani Wulandari', 'ani.wulan@contoh.net', NULL, NULL, '2025-12-04 18:49:43');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `perhitungan_spt`
--
ALTER TABLE `perhitungan_spt`
  ADD PRIMARY KEY (`id_perhitungan`),
  ADD UNIQUE KEY `id_spt` (`id_spt`);

--
-- Indexes for table `pk_pegawai`
--
ALTER TABLE `pk_pegawai`
  ADD PRIMARY KEY (`id_pegawai`),
  ADD KEY `id_pk` (`id_pk`);

--
-- Indexes for table `pk_profil`
--
ALTER TABLE `pk_profil`
  ADD PRIMARY KEY (`id_pk`),
  ADD UNIQUE KEY `npwp_pk` (`npwp_pk`);

--
-- Indexes for table `pk_setoran`
--
ALTER TABLE `pk_setoran`
  ADD PRIMARY KEY (`id_setoran`),
  ADD UNIQUE KEY `kode_billing` (`kode_billing`),
  ADD UNIQUE KEY `ntpn` (`ntpn`),
  ADD KEY `id_pk` (`id_pk`);

--
-- Indexes for table `pk_spt_masa`
--
ALTER TABLE `pk_spt_masa`
  ADD PRIMARY KEY (`id_spt_masa`),
  ADD UNIQUE KEY `uk_pk_masa` (`id_pk`,`tahun`,`bulan`);

--
-- Indexes for table `pk_transaksi_gaji`
--
ALTER TABLE `pk_transaksi_gaji`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD UNIQUE KEY `uk_pegawai_bulan` (`id_pegawai`,`tahun`,`bulan`);

--
-- Indexes for table `spt_tahunan`
--
ALTER TABLE `spt_tahunan`
  ADD PRIMARY KEY (`id_spt`),
  ADD UNIQUE KEY `uk_wp_tahun` (`id_wp`,`tahun_pajak`);

--
-- Indexes for table `wp_profil`
--
ALTER TABLE `wp_profil`
  ADD PRIMARY KEY (`id_wp`),
  ADD UNIQUE KEY `npwp` (`npwp`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `perhitungan_spt`
--
ALTER TABLE `perhitungan_spt`
  MODIFY `id_perhitungan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `pk_pegawai`
--
ALTER TABLE `pk_pegawai`
  MODIFY `id_pegawai` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=108;

--
-- AUTO_INCREMENT for table `pk_profil`
--
ALTER TABLE `pk_profil`
  MODIFY `id_pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `pk_setoran`
--
ALTER TABLE `pk_setoran`
  MODIFY `id_setoran` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pk_spt_masa`
--
ALTER TABLE `pk_spt_masa`
  MODIFY `id_spt_masa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `pk_transaksi_gaji`
--
ALTER TABLE `pk_transaksi_gaji`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `spt_tahunan`
--
ALTER TABLE `spt_tahunan`
  MODIFY `id_spt` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=124;

--
-- AUTO_INCREMENT for table `wp_profil`
--
ALTER TABLE `wp_profil`
  MODIFY `id_wp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=126;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `perhitungan_spt`
--
ALTER TABLE `perhitungan_spt`
  ADD CONSTRAINT `perhitungan_spt_ibfk_1` FOREIGN KEY (`id_spt`) REFERENCES `spt_tahunan` (`id_spt`) ON DELETE CASCADE;

--
-- Constraints for table `pk_pegawai`
--
ALTER TABLE `pk_pegawai`
  ADD CONSTRAINT `pk_pegawai_ibfk_1` FOREIGN KEY (`id_pk`) REFERENCES `pk_profil` (`id_pk`) ON DELETE CASCADE;

--
-- Constraints for table `pk_setoran`
--
ALTER TABLE `pk_setoran`
  ADD CONSTRAINT `pk_setoran_ibfk_1` FOREIGN KEY (`id_pk`) REFERENCES `pk_profil` (`id_pk`) ON DELETE CASCADE;

--
-- Constraints for table `pk_spt_masa`
--
ALTER TABLE `pk_spt_masa`
  ADD CONSTRAINT `pk_spt_masa_ibfk_1` FOREIGN KEY (`id_pk`) REFERENCES `pk_profil` (`id_pk`) ON DELETE CASCADE;

--
-- Constraints for table `pk_transaksi_gaji`
--
ALTER TABLE `pk_transaksi_gaji`
  ADD CONSTRAINT `pk_transaksi_gaji_ibfk_1` FOREIGN KEY (`id_pegawai`) REFERENCES `pk_pegawai` (`id_pegawai`) ON DELETE CASCADE;

--
-- Constraints for table `spt_tahunan`
--
ALTER TABLE `spt_tahunan`
  ADD CONSTRAINT `spt_tahunan_ibfk_1` FOREIGN KEY (`id_wp`) REFERENCES `wp_profil` (`id_wp`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
