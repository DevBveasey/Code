-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 12, 2017 at 06:54 PM
-- Server version: 5.6.14
-- PHP Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `work`
--

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE IF NOT EXISTS `orders` (
  `order_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `tag` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `location` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `desc` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `fname` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `lname` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(80) COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(14) COLLATE utf8_unicode_ci NOT NULL,
  `status` enum('started','hold','complete') COLLATE utf8_unicode_ci NOT NULL,
  `complete_date` date DEFAULT NULL,
  `notes` varchar(1024) COLLATE utf8_unicode_ci DEFAULT NULL,
  `start_date` date NOT NULL,
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=9 ;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `tag`, `location`, `desc`, `fname`, `lname`, `email`, `phone`, `status`, `complete_date`, `notes`, `start_date`) VALUES
(1, '01', 'bin 1', 'possible virus needs virus scan', 'Magic', 'Mike', 'magic@mike.com', '(302)-123-4567', 'complete', '2017-11-12', 'pc scan completed and all viruses were removed', '2017-11-12'),
(2, '02', 'bin 2', 'pc is slow and is on fire some times', 'Ricky', 'Bobby', 'ricky@bobby.com', '(123)-456-7890', 'complete', NULL, 'jjjjjjjjjjj', '2017-11-12'),
(5, 'pc 04', 'bin 03', 'pc was droped and the display was no longer working.', 'jack', 'O''lantern', 'jack@me.com', '(123) 999-999', 'complete', NULL, 'hhhhhhhhhhhhhhhh`', '2017-11-12'),
(6, 'pc 06', 'bin 06', 'pc''s keyboard does not work after drink spilled.', 'lisa', 'kathrine', 'lisa@nightclub.com', '(800) 654-654', 'started', NULL, NULL, '2017-11-12'),
(7, 'pc 09', 'bin 05', 'walter put a hit on his wife and the pc is now locked by the FBI', 'jeff', 'dunham', 'Jeff.dunham@funny.net', '(555) 555-555', 'complete', '2017-11-12', 'pc', '2017-11-12'),
(8, 'AIO 1', 'bin 9', 'pc wont turn on', 'smokey', 'the bear', 'raww@bear.com', '(222) 222-222', 'complete', '2017-11-12', 'test', '2017-11-12');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
