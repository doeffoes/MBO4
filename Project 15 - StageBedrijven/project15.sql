-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 04 nov 2021 om 15:54
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
-- Database: `project15`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `bedrijven`
--

CREATE TABLE `bedrijven` (
  `bedrijfsnummer` int(3) NOT NULL,
  `bedrijfsnaam` varchar(20) NOT NULL,
  `adres` varchar(30) NOT NULL,
  `postcode` varchar(8) NOT NULL,
  `woonplaats` varchar(17) NOT NULL,
  `telefoon` int(12) NOT NULL,
  `alg_email` varchar(20) NOT NULL,
  `website` varchar(30) NOT NULL,
  `OA_Geaccriditeerd` varchar(7) NOT NULL,
  `Aantal_Stages` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `bedrijven`
--

INSERT INTO `bedrijven` (`bedrijfsnummer`, `bedrijfsnaam`, `adres`, `postcode`, `woonplaats`, `telefoon`, `alg_email`, `website`, `OA_Geaccriditeerd`, `Aantal_Stages`) VALUES
(97860, 'lalalal', 'lalallaan 81', '2918UY', 'haarlem', 605903827, 'allalal@gmail.com', 'lalalalla.nl', 'ja', 4);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `cp`
--

CREATE TABLE `cp` (
  `Cp_id` int(4) NOT NULL,
  `bedrijfsnummer` int(10) NOT NULL,
  `Cp_Voornaam` varchar(15) NOT NULL,
  `Cp_Tvgsl` varchar(7) NOT NULL,
  `Cp_Achternaam` varchar(17) NOT NULL,
  `Cp_Telefoon` int(12) NOT NULL,
  `Cp_Email` varchar(25) NOT NULL,
  `Werkzaam` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `cp`
--

INSERT INTO `cp` (`Cp_id`, `bedrijfsnummer`, `Cp_Voornaam`, `Cp_Tvgsl`, `Cp_Achternaam`, `Cp_Telefoon`, `Cp_Email`, `Werkzaam`) VALUES
(2617, 97860, 'Roy', 'De', 'Molenaar', 648272917, 'RoyMolenaar@gmail.com', 'Nee'),
(25718, 97860, 'Johny', 'van het', 'Hek', 678209278, 'JohnyvhHek@yahoo.com', 'Ja');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `stage`
--

CREATE TABLE `stage` (
  `Soort_Stage` varchar(20) NOT NULL,
  `Duur` varchar(10) NOT NULL,
  `Accreditatie_nodig` varchar(5) NOT NULL,
  `Crebo` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `stage`
--

INSERT INTO `stage` (`Soort_Stage`, `Duur`, `Accreditatie_nodig`, `Crebo`) VALUES
('Studeer Stage', '8 Maanden', 'Ja', 25189),
('Studeer Stage', '12 Maanden', 'Nee', 28791);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `stage2`
--

CREATE TABLE `stage2` (
  `Soort_Stage` varchar(15) NOT NULL,
  `Duur` varchar(10) NOT NULL,
  `Accreditatie_nodig` varchar(4) NOT NULL,
  `Crebo` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `stage2`
--

INSERT INTO `stage2` (`Soort_Stage`, `Duur`, `Accreditatie_nodig`, `Crebo`) VALUES
('Studeer Stage', '9 Maanden', 'Nee', 26781),
('Werk Stage', '16 Maanden', 'Ja', 29017);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `student`
--

CREATE TABLE `student` (
  `Voornaam` varchar(10) NOT NULL,
  `Tussenvoegsel` varchar(7) NOT NULL,
  `Achternaam` varchar(15) NOT NULL,
  `Studentnummer` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `student`
--

INSERT INTO `student` (`Voornaam`, `Tussenvoegsel`, `Achternaam`, `Studentnummer`) VALUES
('Klaasie', 'De', 'Achterband', 167098),
('Kees', 'Het', 'Hek', 169043);

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `bedrijven`
--
ALTER TABLE `bedrijven`
  ADD PRIMARY KEY (`bedrijfsnummer`);

--
-- Indexen voor tabel `cp`
--
ALTER TABLE `cp`
  ADD PRIMARY KEY (`Cp_id`);

--
-- Indexen voor tabel `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`Studentnummer`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `bedrijven`
--
ALTER TABLE `bedrijven`
  MODIFY `bedrijfsnummer` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97902;

--
-- AUTO_INCREMENT voor een tabel `cp`
--
ALTER TABLE `cp`
  MODIFY `Cp_id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25719;

--
-- AUTO_INCREMENT voor een tabel `student`
--
ALTER TABLE `student`
  MODIFY `Studentnummer` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=169044;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
