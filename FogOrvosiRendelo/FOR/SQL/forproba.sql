-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Feb 24. 11:32
-- Kiszolgáló verziója: 10.1.37-MariaDB
-- PHP verzió: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `forproba`
--
CREATE DATABASE IF NOT EXISTS `forproba` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `forproba`;

DELIMITER $$
--
-- Eljárások
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `stafflogin` (IN `username` VARCHAR(24), IN `password` VARCHAR(24))  NO SQL
SELECT COUNT(*) FROM staff WHERE username=staff.username AND password=staff.password$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `patient`
--

CREATE TABLE `patient` (
  `id` int(11) NOT NULL,
  `name` varchar(52) COLLATE utf8_hungarian_ci NOT NULL,
  `birthdate` int(8) NOT NULL,
  `tb` int(9) NOT NULL,
  `doctor_name` varchar(52) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `patient_sec`
--

CREATE TABLE `patient_sec` (
  `patient_id` int(11) NOT NULL,
  `birthplace` varchar(54) COLLATE utf8_hungarian_ci NOT NULL,
  `address` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `phone` int(15) NOT NULL,
  `email` varchar(54) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `patienweb`
--

CREATE TABLE `patienweb` (
  `patient_id` int(11) NOT NULL,
  `username` varchar(24) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(24) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `staff`
--

CREATE TABLE `staff` (
  `id` int(11) NOT NULL,
  `username` varchar(24) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(24) COLLATE utf8_hungarian_ci NOT NULL,
  `name` varchar(52) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `staff`
--

INSERT INTO `staff` (`id`, `username`, `password`, `name`) VALUES
(1, 'admin', 'admin', 'Dr. Admin Nimda'),
(2, 'asd', 'asd', 'Dr. Asd Fgh');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `tb` (`tb`);

--
-- A tábla indexei `patient_sec`
--
ALTER TABLE `patient_sec`
  ADD PRIMARY KEY (`patient_id`);

--
-- A tábla indexei `patienweb`
--
ALTER TABLE `patienweb`
  ADD PRIMARY KEY (`patient_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `patient_id` (`patient_id`);

--
-- A tábla indexei `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `name` (`name`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `patient`
--
ALTER TABLE `patient`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `patient_sec`
--
ALTER TABLE `patient_sec`
  ADD CONSTRAINT `patient_sec_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`);

--
-- Megkötések a táblához `patienweb`
--
ALTER TABLE `patienweb`
  ADD CONSTRAINT `patienweb_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
