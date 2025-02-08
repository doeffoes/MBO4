-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 01 apr 2021 om 14:38
-- Serverversie: 10.4.14-MariaDB
-- PHP-versie: 7.2.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project 8 - olvg database`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `olvg`
--

CREATE TABLE `olvg` (
  `Voornaam` text NOT NULL,
  `Tussenvoegsel` text NOT NULL,
  `Achternaam` text NOT NULL,
  `Postcode` text NOT NULL,
  `GZ-Medewerker` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `olvg`
--

INSERT INTO `olvg` (`Voornaam`, `Tussenvoegsel`, `Achternaam`, `Postcode`, `GZ-Medewerker`) VALUES
('Herre', '', 'Reesing', '1008 DG', 'Ja, Werkzaam buiten Amsterdam'),
('Joris  ', 'H.', 'Janssen', '1011 AC', 'Nee'),
('Paul', '', 'Bresser', '1011 AH', 'Ja, Werkzaam buiten Amsterdam'),
('Daan', '', 'Dohmen', '1011 BS', 'Ja, Werkzaam bij OLVG'),
('Maurits', '', 'Kaptein', '1011 BL', 'Ja, Werkzaam in Amsterdam'),
('Maurice', 'Van Den', 'Bosch', '1011 BK', 'Ja, Werkzaam bij OLVG'),
('Omid', '', 'Golzarian', '3811 EX', 'Nee');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
