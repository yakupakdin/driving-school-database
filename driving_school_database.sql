-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 07 May 2021, 23:41:00
-- Sunucu sürümü: 10.4.17-MariaDB
-- PHP Sürümü: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `surucu_kursu`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `aday`
--

CREATE TABLE `aday` (
  `aday_id` int(11) NOT NULL,
  `tc_no` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `ad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `soyad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `ogrenim_durum` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `saglik_raporu` varchar(3) COLLATE utf8_turkish_ci NOT NULL,
  `adli_belge` varchar(3) COLLATE utf8_turkish_ci NOT NULL,
  `ehliyet_turu` varchar(5) COLLATE utf8_turkish_ci NOT NULL,
  `kayit_tarihi` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `personel_id` int(11) DEFAULT NULL,
  `arac_id` int(11) DEFAULT NULL,
  `sube_id` int(11) DEFAULT NULL,
  `sinav_id` int(11) DEFAULT NULL,
  `ucret_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `arac`
--

CREATE TABLE `arac` (
  `arac_id` int(11) NOT NULL,
  `plaka` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `arac_tipi` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `arac_marka` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `arac_model` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `vites_turu` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `sube_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `arac`
--

INSERT INTO `arac` (`arac_id`, `plaka`, `arac_tipi`, `arac_marka`, `arac_model`, `vites_turu`, `sube_id`) VALUES
(9, '35SJ5461', 'otomobil', 'Hyundai', 'Accent', 'manuel', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `nufus`
--

CREATE TABLE `nufus` (
  `tc_no` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `seri_no` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `ad` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `soyad` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `baba_adi` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `anne_adi` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `dogum_yeri` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `dogum_tarihi` date NOT NULL,
  `tel_no` varchar(13) COLLATE utf8_turkish_ci NOT NULL,
  `cinsiyet` char(1) COLLATE utf8_turkish_ci NOT NULL,
  `medeni_hal` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `kan_grubu` varchar(5) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

CREATE TABLE `personel` (
  `personel_id` int(11) NOT NULL,
  `tc_no` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `ad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `soyad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `gorev` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `sube_id` int(11) DEFAULT NULL,
  `arac_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sinavlar`
--

CREATE TABLE `sinavlar` (
  `not_id` int(11) NOT NULL,
  `tc_no` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `yazili_tarihi` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `yazili_not` varchar(3) COLLATE utf8_turkish_ci DEFAULT NULL,
  `drks_tarihi` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `drks_durum` varchar(5) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sube`
--

CREATE TABLE `sube` (
  `sube_id` int(11) NOT NULL,
  `ad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `tel_no` varchar(13) COLLATE utf8_turkish_ci NOT NULL,
  `adres` varchar(200) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sube`
--

INSERT INTO `sube` (`sube_id`, `ad`, `tel_no`, `adres`) VALUES
(1, 'AlparslanSürücüKursu', '05396548745', 'İzmir-Buca');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucret`
--

CREATE TABLE `ucret` (
  `odeme_id` int(11) NOT NULL,
  `tc_no` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `odeme_tarihi` varchar(50) COLLATE utf8_turkish_ci DEFAULT NULL,
  `toplam_borc` int(25) DEFAULT NULL,
  `kalan_borc` int(25) DEFAULT NULL,
  `odeme_sekli` varchar(10) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `aday`
--
ALTER TABLE `aday`
  ADD PRIMARY KEY (`aday_id`),
  ADD KEY `tc_no` (`tc_no`),
  ADD KEY `personel_id` (`personel_id`),
  ADD KEY `arac_id` (`arac_id`),
  ADD KEY `sube_id` (`sube_id`),
  ADD KEY `sinav_id` (`sinav_id`),
  ADD KEY `ucret_id` (`ucret_id`);

--
-- Tablo için indeksler `arac`
--
ALTER TABLE `arac`
  ADD PRIMARY KEY (`arac_id`),
  ADD UNIQUE KEY `plaka` (`plaka`),
  ADD KEY `sube_id` (`sube_id`);

--
-- Tablo için indeksler `nufus`
--
ALTER TABLE `nufus`
  ADD PRIMARY KEY (`tc_no`);

--
-- Tablo için indeksler `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`personel_id`),
  ADD KEY `tc_no` (`tc_no`),
  ADD KEY `arac_id` (`arac_id`),
  ADD KEY `sube_id` (`sube_id`);

--
-- Tablo için indeksler `sinavlar`
--
ALTER TABLE `sinavlar`
  ADD PRIMARY KEY (`not_id`),
  ADD UNIQUE KEY `tc_no` (`tc_no`),
  ADD UNIQUE KEY `not_id` (`not_id`);

--
-- Tablo için indeksler `sube`
--
ALTER TABLE `sube`
  ADD PRIMARY KEY (`sube_id`);

--
-- Tablo için indeksler `ucret`
--
ALTER TABLE `ucret`
  ADD PRIMARY KEY (`odeme_id`),
  ADD UNIQUE KEY `tc_no` (`tc_no`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `aday`
--
ALTER TABLE `aday`
  MODIFY `aday_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=96;

--
-- Tablo için AUTO_INCREMENT değeri `arac`
--
ALTER TABLE `arac`
  MODIFY `arac_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Tablo için AUTO_INCREMENT değeri `personel`
--
ALTER TABLE `personel`
  MODIFY `personel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `sinavlar`
--
ALTER TABLE `sinavlar`
  MODIFY `not_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

--
-- Tablo için AUTO_INCREMENT değeri `ucret`
--
ALTER TABLE `ucret`
  MODIFY `odeme_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `aday`
--
ALTER TABLE `aday`
  ADD CONSTRAINT `aday_ibfk_1` FOREIGN KEY (`tc_no`) REFERENCES `nufus` (`tc_no`),
  ADD CONSTRAINT `aday_ibfk_2` FOREIGN KEY (`personel_id`) REFERENCES `personel` (`personel_id`),
  ADD CONSTRAINT `aday_ibfk_3` FOREIGN KEY (`arac_id`) REFERENCES `arac` (`arac_id`),
  ADD CONSTRAINT `aday_ibfk_4` FOREIGN KEY (`sube_id`) REFERENCES `sube` (`sube_id`),
  ADD CONSTRAINT `aday_ibfk_5` FOREIGN KEY (`sinav_id`) REFERENCES `sinavlar` (`not_id`),
  ADD CONSTRAINT `aday_ibfk_6` FOREIGN KEY (`ucret_id`) REFERENCES `ucret` (`odeme_id`);

--
-- Tablo kısıtlamaları `arac`
--
ALTER TABLE `arac`
  ADD CONSTRAINT `arac_ibfk_1` FOREIGN KEY (`sube_id`) REFERENCES `sube` (`sube_id`);

--
-- Tablo kısıtlamaları `personel`
--
ALTER TABLE `personel`
  ADD CONSTRAINT `personel_ibfk_1` FOREIGN KEY (`tc_no`) REFERENCES `nufus` (`tc_no`),
  ADD CONSTRAINT `personel_ibfk_2` FOREIGN KEY (`arac_id`) REFERENCES `arac` (`arac_id`),
  ADD CONSTRAINT `personel_ibfk_3` FOREIGN KEY (`sube_id`) REFERENCES `sube` (`sube_id`);

--
-- Tablo kısıtlamaları `sinavlar`
--
ALTER TABLE `sinavlar`
  ADD CONSTRAINT `sinavlar_ibfk_1` FOREIGN KEY (`tc_no`) REFERENCES `nufus` (`tc_no`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `ucret`
--
ALTER TABLE `ucret`
  ADD CONSTRAINT `ucret_ibfk_1` FOREIGN KEY (`tc_no`) REFERENCES `nufus` (`tc_no`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
