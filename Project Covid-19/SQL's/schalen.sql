-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Machine: 127.0.0.1
-- Genereertijd: 07 apr 2014 om 17:01
-- Serverversie: 5.5.32
-- PHP-versie: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `sql`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `schalen`
--

CREATE TABLE IF NOT EXISTS `schalen` (
  `schaal` int(11) NOT NULL,
  `laagste` decimal(8,2) NOT NULL,
  `hoogste` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `schalen`
--

INSERT INTO `schalen` (`schaal`, `laagste`, `hoogste`) VALUES
(1, '1600.00', '1999.99'),
(2, '2000.00', '2299.99'),
(3, '2300.00', '2599.99'),
(4, '2600.00', '2899.99'),
(5, '2900.00', '3199.99'),
(6, '3200.00', '3499.99'),
(7, '3500.00', '3799.99'),
(8, '3800.00', '4099.99'),
(9, '4100.00', '4499.99'),
(10, '4500.00', '4999.99'),
(11, '5000.00', '5499.99'),
(12, '5500.00', '5999.99'),
(13, '6000.00', '6499.99'),
(14, '6500.00', '9999.99');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
