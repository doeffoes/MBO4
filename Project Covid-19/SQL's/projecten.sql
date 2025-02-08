-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Machine: 127.0.0.1
-- Genereertijd: 07 apr 2014 om 16:38
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
-- Tabelstructuur voor tabel `projecten`
--

CREATE TABLE IF NOT EXISTS `projecten` (
  `proj_code` int(11) NOT NULL,
  `proj_naam` varchar(4) NOT NULL,
  `proj_plaats` varchar(20) NOT NULL,
  `proj_leider` int(11) NOT NULL,
  `startdatum` date NOT NULL,
  `budget` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `projecten`
--

INSERT INTO `projecten` (`proj_code`, `proj_naam`, `proj_plaats`, `proj_leider`, `startdatum`, `budget`) VALUES
(110, 'ITCZ', 'ROTTERDAM', 40, '1995-01-01', 100000),
(120, 'MTS', 'ROTTERDAM', 10, '1995-08-15', 145000),
(130, 'CAIA', 'AMSTERDAM', 30, '1996-10-01', 80000),
(140, 'GABD', 'UTRECHT', 60, '1996-01-01', 98000),
(150, 'ZVH', 'MAASTRICHT', 35, '1996-02-15', 112000);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
