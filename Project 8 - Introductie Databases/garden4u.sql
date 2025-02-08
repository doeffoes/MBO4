-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 29 mrt 2021 om 15:00
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
-- Database: `garden4u`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `klanten`
--

CREATE TABLE `klanten` (
  `Nr` int(20) NOT NULL,
  `Gebruikersnaam` varchar(15) NOT NULL,
  `Wachtwoord` varchar(11) NOT NULL,
  `Voornaam` varchar(25) NOT NULL,
  `Achternaam` varchar(40) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Adres` varchar(50) NOT NULL,
  `Woonplaats` varchar(20) NOT NULL,
  `Postcode` varchar(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `klanten`
--

INSERT INTO `klanten` (`Nr`, `Gebruikersnaam`, `Wachtwoord`, `Voornaam`, `Achternaam`, `Email`, `Adres`, `Woonplaats`, `Postcode`) VALUES
(7, 'Nick', '12345', 'Nick', 'van Bakel', 'nickvanbakel@gmail.com', 'Irene Vorrinklaan', 'Hoofddorp', '2135SZ'),
(8, 'Kees', '12345', 'Kees', 'van Bakel', 'kvanbakel@vanbakeladviesgroep.nl', 'Hoofdstraat ', 'Hoofddorp', '2132EA');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `orders`
--

CREATE TABLE `orders` (
  `Ordernr` int(10) NOT NULL,
  `Productnr` int(10) NOT NULL,
  `Klantnr` int(10) NOT NULL,
  `Aantal` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `producten`
--

CREATE TABLE `producten` (
  `Productnr` int(10) NOT NULL,
  `Naam product` text NOT NULL,
  `Leverancier` text NOT NULL,
  `Inkoopprijs` int(5) NOT NULL,
  `Verkoopprijs` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `producten`
--

INSERT INTO `producten` (`Productnr`, `Naam product`, `Leverancier`, `Inkoopprijs`, `Verkoopprijs`) VALUES
(10510, 'Gaming Mouse', 'Razer', 30, 95),
(98710, 'Corsair Gaming Mouse', 'Corsair', 15, 50);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tblproduct`
--

CREATE TABLE `tblproduct` (
  `id` int(8) NOT NULL,
  `name` varchar(255) NOT NULL,
  `code` varchar(255) NOT NULL,
  `image` text NOT NULL,
  `price` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tblproduct`
--

INSERT INTO `tblproduct` (`id`, `name`, `code`, `image`, `price`) VALUES
(2, 'Bankstel', '12431', 'images/bankset.jpg', 120.00),
(3, 'Barbeque', '4', 'images/barbeque.jpg', 120.00),
(4, 'Water standbeeld ', '8', 'images/beeldje.jpg', 120.00),
(5, 'Peeing lady', '321', 'images/beeldje2.jpg', 120.00),
(6, 'Tuinkar', '3211', 'images/tuinkar.jpg', 120.00);

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `klanten`
--
ALTER TABLE `klanten`
  ADD PRIMARY KEY (`Nr`);

--
-- Indexen voor tabel `producten`
--
ALTER TABLE `producten`
  ADD PRIMARY KEY (`Productnr`);

--
-- Indexen voor tabel `tblproduct`
--
ALTER TABLE `tblproduct`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `product_code` (`code`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `klanten`
--
ALTER TABLE `klanten`
  MODIFY `Nr` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT voor een tabel `producten`
--
ALTER TABLE `producten`
  MODIFY `Productnr` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98711;

--
-- AUTO_INCREMENT voor een tabel `tblproduct`
--
ALTER TABLE `tblproduct`
  MODIFY `id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
