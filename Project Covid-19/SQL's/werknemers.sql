-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 12, 2013 at 09:06 AM
-- Server version: 5.5.32
-- PHP Version: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `werknemers`
--

-- --------------------------------------------------------

--
-- Table structure for table `werknemers`
--

CREATE TABLE IF NOT EXISTS `werknemers` (
  `Code` int(11) NOT NULL,
  `Voorletters` varchar(10) NOT NULL,
  `Voorvoegsel` varchar(7) NOT NULL,
  `Naam` varchar(20) NOT NULL,
  `Adres` varchar(50) NOT NULL,
  `Postcode` varchar(8) NOT NULL,
  `Woonplaats` varchar(20) NOT NULL,
  `Telefoon` varchar(20) NOT NULL,
  `Datum_in_d` date NOT NULL,
  `Salaris` int(11) NOT NULL,
  `Chef` int(11) NOT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `werknemers`
--

INSERT INTO `werknemers` (`Code`, `Voorletters`, `Voorvoegsel`, `Naam`, `Adres`, `Postcode`, `Woonplaats`, `Telefoon`, `Datum_in_d`, `Salaris`, `Chef`) VALUES
(10, 'A.P.', 'DE', 'BUCK', 'LINDELAAN 2', '1055 PP', 'AMSTERDAM', '020-6768087', '1980-01-01', 4567, 99),
(12, 'K.J.', '', 'BRASSER', 'KINDELAAN 18', '1055 PP', 'AMSTERDAM', '020-9874386', '1995-10-12', 2149, 20),
(16, 'I.H.', '', 'LIEVENSE', 'HOOFDSTRAAT 3', '8948 KK', 'LEEUWARDEN', '058-8916534', '1995-10-14', 3148, 30),
(18, 'P.', 'VAN', 'VLIET', 'KADE 34', '1056 KM', 'AMSTERDAM', '020-9321072', '1985-09-28', 2638, 20),
(19, 'M.M.', '', 'UMBGROVE', 'TALMALAAN 3', '4351 JG', 'VLISSINGEN', '0118-439816', '1987-11-13', 2988, 30),
(20, 'L.C.', '', 'MAAS', 'BOSJESLAAN 3', '3085 HG', 'ROTTERDAM', '010-9859526', '1984-02-01', 3332, 10),
(25, 'G.', 'DE', 'NEVE', 'PRINSENGRACHT 20', '1048 GP', 'AMSTERDAM', '020-9865743', '1991-05-15', 3148, 40),
(26, 'J.M.G.', 'VAN', 'GEEL', 'PLEIN 43', '3568 JL', 'UTRECHT', '030-7385195', '1988-12-01', 1921, 30),
(28, 'A.J.', 'DE', 'ZEEUW', 'JULIANASTRAAT 6', '5610 JP', 'EINDHOVEN', '040-5932182', '1986-08-12', 2981, 35),
(30, 'J.', '', 'MERK', 'EIKENLAAN 12', '3086 KK', 'ROTTERDAM', '010-9734733', '1986-03-01', 4749, 40),
(31, 'G.M.', '', 'PAREE', 'KADE 44', '1056 KM', 'AMSTERDAM', '020-9753264', '1990-03-25', 2745, 35),
(35, 'L.M.', 'DE', 'JONGE', 'GRACHT 11', '6222 AG', 'MAASTRICHT', '043-3324785', '1995-06-30', 2118, 40),
(40, 'W.M.', 'VAN', 'WIILLEGEN', 'BEUKENLAAN 12', '3088 LM', 'ROTTERDAM', '010-9865843', '1978-03-01', 4988, 99),
(45, 'G.C.', '', 'JOBSE', 'SINGEL 128', '3088 JP', 'ROTTERDAM', '010-9434785', '1986-07-15', 4716, 40),
(47, 'L.M.', '', 'JANSMA', 'SINGEL 48', '1038 JG', 'AMSTERDAM', '020-4343210', '1984-04-14', 2144, 35),
(48, 'P.', '', 'BOS', 'BEUKENLAAN 18', '3088 LM', 'ROTTERDAM', '010-9324321', '1987-11-28', 2357, 60),
(50, 'J.G.', 'DE', 'LOOF', 'PLEIN 12', '3568 JL', 'UTRECHT', '030-9678765', '1986-08-01', 4328, 10),
(52, 'M.C.', 'VAN DER', 'MAAS', 'HOGEWEG 12', '3078 KL', 'ROTTERDAM', '010-3544567', '1986-12-12', 2849, 60),
(60, 'P.C.', 'VAN DER', 'VLIET', 'ORANJEPLEIN 3', '5655 BG', 'EINDHOVEN', '040-9143421', '1979-04-01', 3848, 10),
(99, 'C.', 'DE', 'KONING', 'SINGEL 2', '3088 JK', 'ROTTERDAM', '010-6493214', '1980-01-01', 5624, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
