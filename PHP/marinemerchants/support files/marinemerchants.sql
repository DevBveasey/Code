-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2017 at 08:53 PM
-- Server version: 5.6.14
-- PHP Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `marinemerchants`
--

-- --------------------------------------------------------

--
-- Table structure for table `catagorys`
--

CREATE TABLE IF NOT EXISTS `catagorys` (
  `catagory_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `catagory_name` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`catagory_id`),
  KEY `catagory_name` (`catagory_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `catagorys`
--

INSERT INTO `catagorys` (`catagory_id`, `catagory_name`) VALUES
(4, 'Anchor'),
(3, 'Apparel'),
(5, 'Docking'),
(1, 'Hardware'),
(2, 'Safety');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE IF NOT EXISTS `customers` (
  `cust_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `first_name` varchar(35) COLLATE utf8_unicode_ci NOT NULL,
  `last_name` varchar(35) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `address1` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `address2` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `city` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `state` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `zip` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `phone` varchar(14) COLLATE utf8_unicode_ci DEFAULT NULL,
  `reg_date` date NOT NULL,
  `activation` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `user_level` int(10) unsigned NOT NULL DEFAULT '0' COMMENT 'two users 0=basic, 1=admin',
  PRIMARY KEY (`cust_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=11 ;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`cust_id`, `first_name`, `last_name`, `email`, `password`, `address1`, `address2`, `city`, `state`, `zip`, `phone`, `reg_date`, `activation`, `user_level`) VALUES
(2, 'Brandon', 'Veasey', 'veasey@live.com', 'a94a8fe5ccb19ba61c4c0873d391e987982fbbd3', '26014 morris mill rd', 'NULL', 'Millsboro', 'DE', '19966', '(302) 500-2183', '2017-11-19', NULL, 1),
(3, 'jeff', 'dunham', 'dunham@jeff.com', '7bd1a907a1ec4630d93ee9312f8964776fc659e5', '556 island', 'slip 5a', 'BVI', 'British Virgin Island', '00000', '(000) 000-1234', '2017-11-19', NULL, 0),
(5, 'mike', 'dugless', 'mike@me.com', '84beb18831cfaa4ea409293c56cd049686703ea3', '23 party st', 'NULL', 'partyvill', 'maryland', '201588', '(333) 333-4444', '2017-11-19', NULL, 0),
(6, 'Bill', 'Mathis', 'bill@me.com', '9e05e6832caffca519722b608570b8ff4935b94d', '123 money ln', 'NULL', 'Milton', 'Delaware', '19956', '(600) 878-9999', '2017-11-22', NULL, 0),
(7, 'chad', 'bennet', 'chad@me.com', 'c34c009102e60d77975598e1f414f8a701c22d0b', '9888864 bennet dr', 'unit 56', 'chadsford', 'PA', '187865', '(369) 258-1479', '2017-11-22', 'caeea2cc4829dcb23ecb5dff17d0aac1', 0),
(8, 'scott', 'allen', 'scott@me.com', 'a044876ad43e3c0fdf09abd66c47b6bfb0a55ecb', '6693 street dr', 'NULL', 'milville', 'DE', '19966', '(302) 333-6666', '2017-11-22', NULL, 0),
(9, 'test', 'admin', 'admin@password.com', 'd033e22ae348aeb5660fc2140aec35850c4da997', '789 that st', 'NULL', 'townplace', 'delaware', '19947', '(654) 321-7412', '2017-12-01', NULL, 1),
(10, 'dave', 'CAMPER', 'camper@me.com', '58885d39875f67d0c8a1f21b51c16ccbc11be2b6', 'NULL', 'NULL', 'NULL', 'NULL', 'NULL', 'NULL', '2017-12-01', 'cf986e7c7afb0b9bb56cb214c9c896b1', 0);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE IF NOT EXISTS `orders` (
  `order_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cust_id` int(10) unsigned NOT NULL,
  `total` decimal(6,2) NOT NULL,
  `order_date` date NOT NULL,
  `shipping_total` decimal(6,2) NOT NULL,
  `carrier` enum('USPS','UPS','FedEx') COLLATE utf8_unicode_ci NOT NULL,
  `status` enum('Not Shipped','Shipped') COLLATE utf8_unicode_ci NOT NULL DEFAULT 'Not Shipped',
  `address` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(14) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`order_id`),
  KEY `cust_id` (`cust_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=24 ;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `cust_id`, `total`, `order_date`, `shipping_total`, `carrier`, `status`, `address`, `phone`) VALUES
(15, 2, '28.94', '0000-00-00', '19.99', 'FedEx', 'Not Shipped', '26014 morris mill rdNULLMillsboro, DE19966', '(302) 500-2183'),
(17, 2, '486.62', '0000-00-00', '29.99', 'USPS', 'Not Shipped', '26014 morris mill rdMillsboro, DE19966', '(302) 500-2183'),
(18, 2, '304.04', '2017-12-04', '29.99', 'USPS', 'Not Shipped', '26014 morris mill rd Millsboro, DE 19966', '(302) 500-2183'),
(19, 2, '446.41', '2017-12-04', '19.99', 'FedEx', 'Not Shipped', '26014 morris mill rd Millsboro, DE 19966', '(302) 500-2183'),
(20, 2, '446.41', '2017-12-04', '19.99', 'FedEx', 'Not Shipped', '26014 morris mill rd Millsboro, DE 19966', '(302) 500-2183'),
(21, 2, '446.41', '2017-12-04', '19.99', 'FedEx', 'Not Shipped', '26014 morris mill rd Millsboro, DE 19966', '(302) 500-2183'),
(22, 2, '375.30', '2017-12-04', '19.99', 'FedEx', 'Not Shipped', '26014 morris mill rd Millsboro, DE 19966', '(302) 500-2183'),
(23, 2, '357.73', '2017-12-04', '19.99', 'FedEx', 'Not Shipped', '26014 morris mill rd Millsboro, DE 19966', '(302) 500-2183');

-- --------------------------------------------------------

--
-- Table structure for table `order_contents`
--

CREATE TABLE IF NOT EXISTS `order_contents` (
  `oc_ic` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `order_id` int(10) unsigned NOT NULL,
  `item_id` int(10) unsigned NOT NULL,
  `quantity` tinyint(3) NOT NULL,
  `price` decimal(6,2) NOT NULL,
  `ship_date` datetime DEFAULT NULL,
  PRIMARY KEY (`oc_ic`),
  KEY `order_id` (`order_id`,`item_id`),
  KEY `item_id` (`item_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=23 ;

--
-- Dumping data for table `order_contents`
--

INSERT INTO `order_contents` (`oc_ic`, `order_id`, `item_id`, `quantity`, `price`, `ship_date`) VALUES
(5, 15, 65, 1, '8.95', NULL),
(6, 18, 73, 20, '6.99', NULL),
(7, 18, 65, 15, '8.95', NULL),
(8, 19, 66, 1, '8.91', NULL),
(9, 19, 63, 1, '25.00', NULL),
(10, 19, 64, 1, '146.63', NULL),
(11, 19, 92, 1, '31.88', NULL),
(12, 19, 90, 1, '55.00', NULL),
(13, 19, 102, 1, '159.00', NULL),
(14, 22, 65, 1, '8.95', NULL),
(15, 22, 88, 1, '69.00', NULL),
(16, 22, 89, 1, '50.00', NULL),
(17, 22, 76, 5, '34.99', NULL),
(18, 22, 62, 1, '27.41', NULL),
(19, 22, 63, 1, '25.00', NULL),
(20, 23, 65, 25, '8.95', NULL),
(21, 23, 88, 1, '69.00', NULL),
(22, 23, 75, 1, '44.99', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `productincategory`
--

CREATE TABLE IF NOT EXISTS `productincategory` (
  `item_id` int(10) unsigned NOT NULL,
  `category_id` int(10) unsigned NOT NULL,
  KEY `category_id` (`category_id`),
  KEY `item_id` (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='this table links products that have multiple category';

--
-- Dumping data for table `productincategory`
--

INSERT INTO `productincategory` (`item_id`, `category_id`) VALUES
(61, 4),
(62, 4),
(63, 4),
(64, 4),
(65, 1),
(65, 4),
(66, 1),
(66, 4),
(67, 2),
(68, 2),
(69, 2),
(70, 2),
(71, 2),
(72, 2),
(73, 1),
(73, 4),
(74, 1),
(74, 4),
(75, 2),
(75, 5),
(76, 2),
(76, 5),
(77, 5),
(78, 1),
(78, 5),
(79, 1),
(79, 5),
(80, 1),
(80, 5),
(81, 1),
(81, 5),
(82, 2),
(82, 5),
(83, 2),
(83, 5),
(84, 5),
(85, 2),
(85, 3),
(86, 2),
(87, 2),
(88, 3),
(89, 3),
(90, 3),
(91, 3),
(92, 3),
(93, 1),
(94, 1),
(95, 1),
(96, 1),
(97, 1),
(98, 1),
(99, 1),
(100, 1),
(101, 2),
(101, 3),
(102, 2),
(102, 3),
(105, 3);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `item_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `product_name` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `description` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `on_hand` int(10) unsigned NOT NULL DEFAULT '0',
  `sold` int(11) NOT NULL DEFAULT '0',
  `price` decimal(6,2) NOT NULL,
  `image_name` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=106 ;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`item_id`, `product_name`, `description`, `on_hand`, `sold`, `price`, `image_name`) VALUES
(61, '10Lb Black Mushroom Anchor', '10 Lb Black Anchor', 0, 0, '18.88', 'G:\\xampp\\tmp\\php8B8F.tmp'),
(62, '15Lb Mushroom Anchor', 'Silver mushroom anchor', 52, 0, '27.41', 'G:\\xampp\\tmp\\phpF25E.tmp'),
(63, 'Fluke Anchor', NULL, 56, 0, '25.00', 'G:\\xampp\\tmp\\phpF617.tmp'),
(64, '14 Lbs Delta Anchor', NULL, 58, 0, '146.63', 'G:\\xampp\\tmp\\php1EBD.tmp'),
(65, '3/8" Anchor Shackle', 'Work Load: 520\r\nBreak Strength: 2600\r\nShank Opening: 3/4"', 86, 0, '8.95', 'G:\\xampp\\tmp\\php61F5.tmp'),
(66, '5/16" Anchor Shackle', 'Work Load: 520\r\nBreak Strength: 2600\r\nShank Opening: 1/2"', 75, 0, '8.91', 'G:\\xampp\\tmp\\phpCBDF.tmp'),
(67, 'Marine Emergency Survival Whistle', 'Pea-Less Whistle Blows Wet Or Dry\r\nBright Orange Color\r\nIncludes Neck Lanyard', 60, 0, '2.02', 'G:\\xampp\\tmp\\php49D6.tmp'),
(68, '354 Piece Wall Mountable First Aid Kit', 'Tilt tray for easy access to supplies. Slide latches to securely close the kit\r\nCompliant with ANSI standards and meets or exceeds Federal OSHA Regulations\r\nFirst aid Booklet offers help and guidance\r\nKit is wall mountable\r\nContains 354 total pieces', 15, 0, '33.98', 'G:\\xampp\\tmp\\phpE8C.tmp'),
(69, 'Waterproof LED Light & Strobe', 'Provides 28 lumens of flashing strobe light for up to 44 hours; ideal as a personal locator light for boating, camping, backpacking, hunting, and more\r\nVisible up to 2.7 miles (4.3 km) on a dark, clear night; exceeds US Coast Guard (USCG) requirements of ', 22, 0, '12.36', 'G:\\xampp\\tmp\\php87A2.tmp'),
(70, 'Type II Adult Life Jackets with Clear Storage Bag', 'Type II lifejacket\r\nSize: Adult\r\nFoam filled\r\nColor: orange\r\nFour lifejackets in stowage bag', 16, 0, '43.99', 'G:\\xampp\\tmp\\php2B03.tmp'),
(71, 'Type IV Throwable Flotation', 'Satisfies US Coast Guard requirments for boats over 16 feet\r\nWebbed throw handles\r\nFunctional and comfortable PE foam\r\nStrong, durable outer shell withstands abrasions\r\nMeasures 16 x 14-3/8 inch', 33, 0, '19.99', 'G:\\xampp\\tmp\\php5E34.tmp'),
(72, 'Telescoping Paddle', 'It''s 20 3/4" collapsed, telescopes out to 42"\r\nHas a corrosion-resistant aluminum shaft and high-impact plastic blade\r\nWeighs just 1 lb., 5 ozs', 21, 0, '13.38', 'G:\\xampp\\tmp\\php5ABC.tmp'),
(73, '3/8" Galvanized Chain (Sold by the foot)', 'Maximum Working Load 5,400lb.\r\nBreaking Strength 16,200lb.', 361, 0, '6.99', 'G:\\xampp\\tmp\\php871A.tmp'),
(74, '1/2"  Galvanized Chain (Sold by the foot)', 'Maximum Working Load (MWL) 9,200lb.	\r\nBreaking Strength 27,600lb.', 461, 0, '10.99', 'G:\\xampp\\tmp\\php2904.tmp'),
(75, 'Boarding Ladder', 'Quick to deploy ladder retrieves overboard passengers quickly\r\nBright orange rungs are easy to see\r\nFold to compact size for easy storage\r\nSupports up to 300 lbs.\r\n3'' 2" length is compatible with a variety of hullside configurations', 5, 0, '44.99', 'G:\\xampp\\tmp\\php9EE0.tmp'),
(76, 'Floating & Telescoping Boat Hook', 'Material: Anodized aluminum tubing; glass-filled nylon head with nonscratching tip\r\nLength: Telescopes 36"-84"\r\nOperation: Twist-locks securely\r\nWeight: 1 1/2 lb.\r\nDiameter: 1 1/4"', 34, 0, '34.99', 'G:\\xampp\\tmp\\php7E37.tmp'),
(77, 'Premium Side Guard 10'' Coil, White', NULL, 15, 0, '69.99', 'G:\\xampp\\tmp\\phpAB70.tmp'),
(78, 'Stainless Steel Cleat 10"', NULL, 42, 0, '69.99', 'G:\\xampp\\tmp\\php9F5.tmp'),
(79, '12" Stainless Steel Cleat', NULL, 32, 0, '99.99', 'G:\\xampp\\tmp\\php90D1.tmp'),
(80, '8'' Stainless Steel Cleat', NULL, 25, 0, '37.99', 'G:\\xampp\\tmp\\php6FA.tmp'),
(81, '5" Stainless Steel Cleat', NULL, 23, 0, '16.99', 'G:\\xampp\\tmp\\phpB2E3.tmp'),
(82, '6 1/2" X 22" Fender 2-Pack, White', NULL, 62, 0, '89.99', 'G:\\xampp\\tmp\\phpF3DA.tmp'),
(83, '4-Step Ladder Fender, White', NULL, 24, 0, '109.99', 'G:\\xampp\\tmp\\phpF293.tmp'),
(84, '15" X 15" Fender Cushion', NULL, 23, 0, '104.99', 'G:\\xampp\\tmp\\php53A7.tmp'),
(85, 'Men''s ProDry Bib', 'storage pockets: 2 top-load thigh pockets with pliers sleeves, & zippered chest storage pocket\r\nLower leg hem lifter adjusts leg length to prevent cuff/heel drag', 12, 0, '449.95', 'G:\\xampp\\tmp\\phpE01E.tmp'),
(86, '12-Gauge High-Performance Alerter Basic 4-Flare Kit', '12-gauge safety launcher with lifetime warranty\r\nBandolier holds up to six high-performance signals\r\nIncludes four red 12-gauge high-performance aerial flares\r\nFlares burn at 16,000 candela for seven seconds\r\nFlares reach maximum elevation of 500''\r\nUSCG-a', 152, 0, '49.99', 'G:\\xampp\\tmp\\php24F.tmp'),
(87, 'Handheld Red Locator Flares, 4-Pack', 'Signal Type: Red handheld flare\r\nLight Output: 700 candela\r\nBurn Time: Three minutes\r\nDeployment Method: Match strike ignitor\r\nType Approval: USCG Day/Night\r\nReplacement Interval: 42 months from manufacture date\r\nHow Sold: Four pack', 162, 0, '34.99', 'G:\\xampp\\tmp\\phpBA68.tmp'),
(88, 'Men''s SHARSKIN™ Board Shorts', 'our-way super-stretch sharkskin-dobby fabric\r\nComplete with side Velcro pocket and back zipper pocket\r\nReinforced utility/pliers pocket\r\nCell phone pocket\r\n92% Polyester/8% Spandex\r\nQuick Drying technology', 23, 0, '69.00', 'G:\\xampp\\tmp\\phpE791.tmp'),
(89, 'Small Men''s Quick Dry Icon Print Surf Shirt', NULL, 62, 0, '50.00', 'G:\\xampp\\tmp\\php2685.tmp'),
(90, 'Men''s Microtek Board Shorts', 'Ultra-lightweight and super comfortable fabric\r\nTreated with Quick-Dry and anti-microbial solutions\r\nSide Velcro pocket, a back zipper pocket, reinforced pliers pocket\r\nMade of 100% polyester', 55, 0, '55.00', 'G:\\xampp\\tmp\\phpF643.tmp'),
(91, 'Men''s Lawai Board Shorts', NULL, 65, 0, '64.00', 'G:\\xampp\\tmp\\phpB5F9.tmp'),
(92, 'Men''s Beerpong Scallop 24-7 Board Shorts', 'Material  89% Polyester/11% Elastane', 29, 0, '31.88', 'G:\\xampp\\tmp\\phpE37.tmp'),
(93, 'Streamlined Collar Zinc Anodes', 'Zinc 1 1/2" Shaft x 2 1/2"dia. x 2 1/2"L', 92, 0, '21.99', 'G:\\xampp\\tmp\\php1B33.tmp'),
(94, '40mm Carbo Air® Single Block', 'Stainless steel swivel shackle\r\nSheave Diameter: 1 9/16" (40 mm)\r\nMax. Line Diameter: 3/8" (10 mm)\r\nMax. Working Load (MWL): 485 lb. (220 kg) \r\nBreaking Load: 1620 lb. (735 kg)\r\nWeight: 1.6 oz. (44 g)\r\nLength: 3 3/8" (86 mm)', 32, 0, '29.99', 'G:\\xampp\\tmp\\phpAF1A.tmp'),
(95, '72mm Synchro Single Block', NULL, 64, 0, '44.99', 'G:\\xampp\\tmp\\phpB37E.tmp'),
(96, '40mm Carbo Ratchet Triple Block with Becket and Cam', 'Hardkote-anodized aluminum sheaves\r\nStainless steel swivel shackle\r\nSheave Diameter: 1 9/16" (40 mm)\r\nMax. Line Diameter: 3/16" (5 mm) \r\nMax. Working Load (MWL): 900 lb. (408 kg)   \r\nBreaking Load: 1800 lb. (816 kg)\r\nWeight: 8.6 oz. (245 g)\r\nLength: 4 5/1', 24, 0, '187.99', 'G:\\xampp\\tmp\\php9F63.tmp'),
(97, '80mm High-Load Double Racing Footblock', 'Diameter	9/16 Inch or 14 mm\r\nDirection	Any\r\nIntegral Cleat	No Integral Cleat\r\nMount Type	Mechanical Fasteners\r\nRatchet	Non Ratcheting\r\nSafe Working Load	5280 Pounds\r\nSheave Diameter	80 mm\r\nType	Double Cheek/Foot\r\nWeight	17.7 Ounces', 74, 0, '589.99', 'G:\\xampp\\tmp\\phpA5DA.tmp'),
(98, '6.5T Aluminum V Block', 'MWL: 14,300 lbs.\r\nWeight: 14.11 oz.', 6, 0, '1710.00', 'G:\\xampp\\tmp\\phpA53F.tmp'),
(99, '15T High-Load Snatch Block', 'Diameter	1 3/16 Inch or 30 mm\r\nDirection	Any\r\nIntegral Cleat	No Integral Cleat\r\nLength	7 Inches\r\nMount Type	Rope/Webbing\r\nRatchet	Non Ratcheting\r\nSafe Working Load	33060 Pounds\r\nSheave Diameter	125 mm\r\nType	Snatch Block\r\nWeight	64.51 Ounces', 4, 0, '1794.99', 'G:\\xampp\\tmp\\php58B6.tmp'),
(100, '6.5T Carbon V Block', 'MWL: 14,300 lbs.\r\nWeight: 12.83 oz.', 94, 0, '2280.00', 'G:\\xampp\\tmp\\php8707.tmp'),
(101, 'Shark Bite Polarized Sunglasses', 'ive-layer anti-reflective coating eliminates distracting bounce-back reflections\r\nOleophobic coating repels sweat, sunscreen and skin oils\r\nHydrophobic coating for rain, dirt and dust resistance\r\nMulti-layer anti-scratch hard coating for lens protection\r\n', 16, 0, '159.00', 'G:\\xampp\\tmp\\php6D51.tmp'),
(102, 'Shark Bite Polarized Sunglasses', 'ive-layer anti-reflective coating eliminates distracting bounce-back reflections\r\nOleophobic coating repels sweat, sunscreen and skin oils\r\nHydrophobic coating for rain, dirt and dust resistance\r\nMulti-layer anti-scratch hard coating for lens protection\r\n', 16, 0, '159.00', 'G:\\xampp\\tmp\\php48E1.tmp'),
(105, 'chips', 'this item is out of stock', 0, 0, '3.99', 'G:\\xampp\\tmp\\phpE070.tmp');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `order_contents`
--
ALTER TABLE `order_contents`
  ADD CONSTRAINT `order_contents_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `order_contents_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `products` (`item_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `productincategory`
--
ALTER TABLE `productincategory`
  ADD CONSTRAINT `productincategory_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `products` (`item_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `productincategory_ibfk_2` FOREIGN KEY (`category_id`) REFERENCES `catagorys` (`catagory_id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
