-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Már 20. 16:34
-- Kiszolgáló verziója: 10.1.38-MariaDB
-- PHP verzió: 7.3.2

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
  `birthdate` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `tb` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `patient`
--

INSERT INTO `patient` (`id`, `name`, `birthdate`, `tb`) VALUES
(1, 'Kala Pál', '19880410', 444555666),
(2, 'Para Zita ', '19990330', 111222333),
(18, 'Tari Béla', '19840705', 875844623),
(19, 'Horváth Máté', '19790615', 733832682),
(22, 'Ipsz Ilonka', '19860618', 986334112),
(28, 'Bármi Áron', '19750611', 111777666),
(29, 'Elektrom Ágnes', '20170405', 224876567),
(30, 'Riz Otto', '19441205', 887544554),
(31, 'Gipsz Jakab', '19581030', 778556544),
(32, 'Pat Tamás', '20140130', 776566366),
(34, 'Csipet Tímea', '19540722', 765884235),
(56, 'Horváth Béla', '20000622', 336877587),
(57, 'Szabó Kálmán', '20080630', 354113345),
(58, 'Villám Júlia', '19441026', 312554330),
(59, 'Kasza Blanka', '19540715', 577376448);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `patient_sec`
--

CREATE TABLE `patient_sec` (
  `patient_id` int(11) NOT NULL,
  `birthplace` varchar(54) COLLATE utf8_hungarian_ci NOT NULL,
  `address` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `phone` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(54) COLLATE utf8_hungarian_ci NOT NULL,
  `mother_name` varchar(52) COLLATE utf8_hungarian_ci NOT NULL,
  `comment` text COLLATE utf8_hungarian_ci NOT NULL,
  `birth_name` varchar(52) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `patient_sec`
--

INSERT INTO `patient_sec` (`patient_id`, `birthplace`, `address`, `phone`, `email`, `mother_name`, `comment`, `birth_name`) VALUES
(1, 'Kalocsa', '2341 Kiskunhalas, Pacsirta köz 3', '30554778', 'kalap@gmail.com', 'Kele Mónika', 'Nincs semmi érdemleges', 'Kala Pál'),
(2, 'Paks', '3252 Paks, Atom utca 56.', '702233445', 'pazi1@citromail.hu', 'Kis Mária', '', 'Para Zita '),
(18, 'Kisújszállás', '3321 Szigetszentmiklós, Dunai sor 231..', '06705551234', 'tari@bela.hu', 'Bori Éva', '', ' Tari Béla'),
(19, 'Kiskundorozsma', '6720 Szeged, Földvári utca 14..', '06704563234', 'horv.m@gmol.hu', 'Nagy Erzsébet', '', ' Horváth Máté'),
(22, 'Kisújszállás', '5312 Nyíregyháza, Vasút utca 3. e3 a3.', '06 70 344 33 11', 'ilokna@gmail.com', 'Kis Borbála', '', 'Iksz Ilonka'),
(28, 'Kistarcsa', '1177 Nagytarcsa, Halas utca 88.', '0680337744', 'aron@barmi.hu', 'Tóth Emese', '', 'Semmi Benjamin'),
(29, 'Pécs', '8876 Vértesnádasd, Tölgy utca 1..', '06708876663', '', 'Vol Tamara', '', ''),
(30, 'Szeged', '6720 Szeged, Kecske utca 12..', '0670-553-22-33', '', 'Locsolók Anna', '', ''),
(31, 'Pilipósszörcsög', '7623 Mosonmagyaróvár, Rézfasor út 43A.', '06709986743', '', 'Nagy Eszter', '', ''),
(32, 'Gyor', '8877 Debrecen, Szegedi köz 1..', '064445533', '', 'Kis Emese', '', ''),
(34, 'Budapest', '3423 Zalaegerszeg, Noszirom utca 54..', '063678321', '', 'Juhar Virág', '', ''),
(56, 'Prága', '6720 Szeged, Tulipán 33..', '0670337743', '', 'Kis Viola', '', ''),
(57, 'Gyor', '7722 Pécs, Jakabos tér 77.', '05663342', '', 'Nagy Eleonóra', '', ''),
(58, 'Szeged', '6720 Szeged, Makó sugárút 177.', '0683776555', '', 'Felho Eszter', '', ''),
(59, 'Ankara', '5633 Eger, Török utca 21..', '06708882277', 'kabi@szan.ka', 'Villa Vilma', 'Kasza Blanka Ankarában született és a Casablanca a kedvenc filmje', '');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `patient_visits`
--

CREATE TABLE `patient_visits` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `staff_id` int(11) DEFAULT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `text` varchar(10000) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `patient_visits`
--

INSERT INTO `patient_visits` (`id`, `patient_id`, `staff_id`, `date`, `text`) VALUES
(1, 1, 1, '2019-03-14 15:53:49', 'Elso bejegyzés 15:53kor, teszt szándekkal hgyo valóban menti e az üzenetet'),
(3, 28, 1, '2019-03-14 16:38:37', 'Áronnak fájt a foga, ezért kihúztuk.'),
(4, 28, 2, '2019-03-14 16:38:54', 'Kapott egy új fogimplantátumot!'),
(6, 19, 3, '2019-03-15 21:54:37', 'asdasd'),
(7, 32, 2, '2019-03-15 21:54:54', 'asdasdasdasdasd'),
(8, 28, 2, '2019-03-16 10:51:39', 'Még egy fogát kihúztuk, de még maradt így is épp elég.'),
(12, 1, 2, '2019-03-16 18:59:05', 'Pál második esélye!');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `patient_web`
--

CREATE TABLE `patient_web` (
  `patient_id` int(11) NOT NULL,
  `username` varchar(24) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(256) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `patient_web`
--

INSERT INTO `patient_web` (`patient_id`, `username`, `password`) VALUES
(1, 'kala', 'kala'),
(2, 'asd', 'asd'),
(18, '875844623', '19840705'),
(19, '733832682', '19790615'),
(22, '986334221', '19860618'),
(28, 'aaa', '$2a$07$BpiDrwlua0VrYaj0nKc9mOioy0urOOrDUGV4vauWJ7xebF9BGfBFa'),
(29, '224876567', '$2a$06$lW.lX7cQ.8MdSU6ZR0D0dOXDNLm4Xq0Br6xdUmpvrOVCdd5YVZ/w.'),
(30, '887544554', '$2a$06$cdQvk.tU.My3hadV7jS3Xu7yew8q3MMZcOFbeXfSlaFoG0b5vovNG'),
(32, '776566366', '$2a$06$Pous5H3aOQMhI1agkcT4eeRMlxMNAJD9XOE3vFzhF.Mh.HiZKIgMC'),
(34, '765884235', '$2a$06$M4SACK2dXCuJHMNnKQHW4.v57xkw.SbAp.5jKR8KcInxW4JDfxtdq'),
(56, '336877587', '$2a$06$ySvAIVHBnllvwZhq6nXVOuBTQONNuMsaeyNtukvPHKoHE6hpCfEnK'),
(57, '354113345', '$2a$06$c2ZKHu3CrGFw388N1o4AaOfF0eCUdkgXsQu89LK0OS1U2X/tw5LpK'),
(58, '312554330', '$2y$10$YBUsjASEx23Kl1DeFEliqeixlPDL.rqvX3uot6/FtwsuJloHr0sJy'),
(59, '577376448', '$2a$07$KZyFZSlv5dHkQzEBlyUXxOgJSxMCO5JRGKJeuctuppnttQlATkpa6');

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
(2, 'asd', 'asd', 'Dr. Asd Fgh'),
(3, 'kv', 'kv', 'Dr. Kós Viktória');

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
-- A tábla indexei `patient_visits`
--
ALTER TABLE `patient_visits`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`),
  ADD KEY `staff_id` (`staff_id`);

--
-- A tábla indexei `patient_web`
--
ALTER TABLE `patient_web`
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;

--
-- AUTO_INCREMENT a táblához `patient_visits`
--
ALTER TABLE `patient_visits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT a táblához `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `patient_sec`
--
ALTER TABLE `patient_sec`
  ADD CONSTRAINT `patient_sec_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `patient_visits`
--
ALTER TABLE `patient_visits`
  ADD CONSTRAINT `patient_visits_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `patient_visits_ibfk_2` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Megkötések a táblához `patient_web`
--
ALTER TABLE `patient_web`
  ADD CONSTRAINT `patient_web_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
