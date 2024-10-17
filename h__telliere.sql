-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2024 at 10:31 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hôtelliere`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_AccountLogIn` (IN `p_username` VARCHAR(45), IN `p_password` VARCHAR(45))   Select Count(*) from tblaccount WHERE username=p_username and PASSWORD=p_password$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_AccountSignUp` (IN `p_username` VARCHAR(40), IN `p_password` VARCHAR(40), IN `p_email` VARCHAR(60), IN `p_address` VARCHAR(100), IN `p_firstname` VARCHAR(40), IN `p_lastname` VARCHAR(40), IN `p_birthdate` DATE, IN `p_gender` VARCHAR(15), IN `p_image` VARCHAR(40))   insert into tblaccount(username, password, email, address, firstname, lastname,birthdate,gender,image) values(p_username, p_password, p_email, p_address, p_firstname, p_lastname, p_birthdate, p_gender, p_image)$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblaccount`
--

CREATE TABLE `tblaccount` (
  `id` int(11) NOT NULL,
  `username` varchar(40) NOT NULL,
  `password` varchar(40) NOT NULL,
  `email` varchar(60) NOT NULL,
  `address` varchar(100) NOT NULL,
  `firstname` varchar(40) NOT NULL,
  `lastname` varchar(40) NOT NULL,
  `birthdate` date NOT NULL,
  `gender` varchar(15) NOT NULL,
  `image` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblaccount`
--

INSERT INTO `tblaccount` (`id`, `username`, `password`, `email`, `address`, `firstname`, `lastname`, `birthdate`, `gender`, `image`) VALUES
(1, 'd', 'e', 'slashysirus@gmail.com', 'Tagum City', 'Dan Steve', 'Bermejo', '2002-06-12', 'Male', 'Alice.png'),
(2, 'k', 'a', 'kyrelle', 'kyrelle@gmail.com', 'kyrelle', 'aquino', '2074-07-05', 'Male', 'Eudora.png');

-- --------------------------------------------------------

--
-- Table structure for table `tbladd-ons`
--

CREATE TABLE `tbladd-ons` (
  `id` int(11) NOT NULL,
  `add-on` varchar(40) NOT NULL,
  `price` double NOT NULL,
  `description` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbladd-ons_promo`
--

CREATE TABLE `tbladd-ons_promo` (
  `id` int(11) NOT NULL,
  `promoid` int(11) NOT NULL,
  `add-onsid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblbooking`
--

CREATE TABLE `tblbooking` (
  `id` int(11) NOT NULL,
  `tenantid` int(11) NOT NULL,
  `bookingstatus` varchar(30) NOT NULL,
  `hotelroomid` int(11) NOT NULL,
  `add-ons_promoid` int(11) NOT NULL,
  `bookingdate` int(11) NOT NULL,
  `numberofdays` int(11) NOT NULL,
  `totalprice` double NOT NULL,
  `payment` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblhotel`
--

CREATE TABLE `tblhotel` (
  `id` int(11) NOT NULL,
  `location` varchar(60) NOT NULL,
  `image` varchar(45) NOT NULL,
  `description` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblhotelroom`
--

CREATE TABLE `tblhotelroom` (
  `id` int(11) NOT NULL,
  `roomname` varchar(50) NOT NULL,
  `type` varchar(30) NOT NULL,
  `status` varchar(30) NOT NULL,
  `description` varchar(200) NOT NULL,
  `initialpriceperday` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblpersonnel`
--

CREATE TABLE `tblpersonnel` (
  `id` int(11) NOT NULL,
  `accountid` int(11) NOT NULL,
  `privilege` varchar(30) NOT NULL,
  `workshift` varchar(45) NOT NULL,
  `workname` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblpromo`
--

CREATE TABLE `tblpromo` (
  `id` int(11) NOT NULL,
  `promoname` varchar(50) NOT NULL,
  `description` varchar(200) NOT NULL,
  `percentagediscount` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblreservation`
--

CREATE TABLE `tblreservation` (
  `id` int(11) NOT NULL,
  `bookingid` int(11) NOT NULL,
  `invoicenumber` varchar(100) NOT NULL,
  `reservationstatus` varchar(50) NOT NULL,
  `balance` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbltenant`
--

CREATE TABLE `tbltenant` (
  `id` int(11) NOT NULL,
  `accountid` int(11) NOT NULL,
  `membership` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblaccount`
--
ALTER TABLE `tblaccount`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbladd-ons`
--
ALTER TABLE `tbladd-ons`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbladd-ons_promo`
--
ALTER TABLE `tbladd-ons_promo`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_add-ons` (`add-onsid`),
  ADD KEY `fk_promo` (`promoid`);

--
-- Indexes for table `tblbooking`
--
ALTER TABLE `tblbooking`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_hotelroom` (`hotelroomid`),
  ADD KEY `fk_tenant` (`tenantid`),
  ADD KEY `fk_add-ons_promo` (`add-ons_promoid`);

--
-- Indexes for table `tblhotel`
--
ALTER TABLE `tblhotel`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblhotelroom`
--
ALTER TABLE `tblhotelroom`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblpersonnel`
--
ALTER TABLE `tblpersonnel`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_accountpersonnel` (`accountid`);

--
-- Indexes for table `tblpromo`
--
ALTER TABLE `tblpromo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblreservation`
--
ALTER TABLE `tblreservation`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_booking` (`bookingid`);

--
-- Indexes for table `tbltenant`
--
ALTER TABLE `tbltenant`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_account` (`accountid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblaccount`
--
ALTER TABLE `tblaccount`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbladd-ons`
--
ALTER TABLE `tbladd-ons`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbladd-ons_promo`
--
ALTER TABLE `tbladd-ons_promo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblbooking`
--
ALTER TABLE `tblbooking`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblhotel`
--
ALTER TABLE `tblhotel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblhotelroom`
--
ALTER TABLE `tblhotelroom`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblpersonnel`
--
ALTER TABLE `tblpersonnel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblpromo`
--
ALTER TABLE `tblpromo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblreservation`
--
ALTER TABLE `tblreservation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbltenant`
--
ALTER TABLE `tbltenant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbladd-ons_promo`
--
ALTER TABLE `tbladd-ons_promo`
  ADD CONSTRAINT `fk_add-ons` FOREIGN KEY (`add-onsid`) REFERENCES `tbladd-ons` (`id`),
  ADD CONSTRAINT `fk_promo` FOREIGN KEY (`promoid`) REFERENCES `tblpromo` (`id`);

--
-- Constraints for table `tblbooking`
--
ALTER TABLE `tblbooking`
  ADD CONSTRAINT `fk_add-ons_promo` FOREIGN KEY (`add-ons_promoid`) REFERENCES `tbladd-ons_promo` (`id`),
  ADD CONSTRAINT `fk_hotelroom` FOREIGN KEY (`hotelroomid`) REFERENCES `tblhotelroom` (`id`),
  ADD CONSTRAINT `fk_tenant` FOREIGN KEY (`tenantid`) REFERENCES `tbltenant` (`id`);

--
-- Constraints for table `tblpersonnel`
--
ALTER TABLE `tblpersonnel`
  ADD CONSTRAINT `fk_accountpersonnel` FOREIGN KEY (`accountid`) REFERENCES `tblaccount` (`id`);

--
-- Constraints for table `tblreservation`
--
ALTER TABLE `tblreservation`
  ADD CONSTRAINT `fk_booking` FOREIGN KEY (`bookingid`) REFERENCES `tblbooking` (`id`);

--
-- Constraints for table `tbltenant`
--
ALTER TABLE `tbltenant`
  ADD CONSTRAINT `fk_account` FOREIGN KEY (`accountid`) REFERENCES `tblaccount` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
