-- phpMyAdmin SQL Dump
-- version 4.1.5
-- http://www.phpmyadmin.net
--
-- Host: db4free.net:3306
-- Generation Time: Jan 26, 2014 at 04:40 PM
-- Server version: 5.6.15
-- PHP Version: 5.3.10-1ubuntu3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Database: `twtmaker`
--

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user` varchar(40) NOT NULL,
  `pass` varchar(40) NOT NULL,
  `nama` varchar(60) NOT NULL,
  `hak` varchar(30) NOT NULL,
  `status` varchar(40) NOT NULL,
  `twitter` varchar(40) NOT NULL,
  `tgldaftar` varchar(50) NOT NULL,
  `tglexpire` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`id`, `user`, `pass`, `nama`, `hak`, `status`, `twitter`, `tgldaftar`, `tglexpire`) VALUES
(1, 'ferdhika31', 'bandung0', 'Ferdhika Yudira', 'Premium', 'Aktif', 'FerdhikaYudira', '31 Agustus 2013', '31 Agustus 2016'),
(2, 'trial', 'trial', 'Langit Developer', 'Trial', 'Aktif', 'LangitDeveloper', '23 Januari 2014', '28 Januari 2014'),
(3, 'blu3l1me', 'bandung0', 'Ferdhika', 'Biasa', 'Aktif', 'RPL4rt', '23 Januari 2014', '28 Januari 2014'),
(4, '140212', '140212', 'Rizky Bayu', 'Trial', 'Aktif', 'RIIBAY', '26 Januari 2014', '31 Januari 2014'),
(12, 'biasa', 'biasa', 'Ferdhika Ganteng', 'Biasa', 'Aktif', 'MaskAnon_BDG', '26 Januari 2014', '28 Januari 2014'),
(13, 'premium', 'premium', 'Cimahi Blackhat', 'Premium', 'Aktif', 'MaskAnon_BDG', '26 Januari 2014', '28 Januari 2014');
