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
-- Tabelstructuur voor tabel `werk`
--

CREATE TABLE IF NOT EXISTS `werk` (
  `proj_code` int(11) NOT NULL,
  `code` int(11) NOT NULL,
  `uren` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `werk`
--

INSERT INTO `werk` (`proj_code`, `code`, `uren`) VALUES
(110, 40, 120),
(110, 25, 48),
(110, 45, 90),
(110, 26, 28),
(110, 10, 12),
(120, 10, 80),
(120, 50, 76),
(120, 20, 18),
(120, 12, 63),
(120, 26, 18),
(120, 40, 38),
(130, 30, 26),
(130, 26, 70),
(140, 60, 50),
(140, 48, 81),
(140, 26, 26),
(150, 35, 90),
(150, 47, 22),
(150, 28, 10),
(150, 26, 18);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
