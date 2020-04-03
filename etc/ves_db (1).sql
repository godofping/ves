-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2020 at 04:26 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ves_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `announcements`
--

CREATE TABLE `announcements` (
  `announcement` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `announcements`
--

INSERT INTO `announcements` (`announcement`) VALUES
('test announcement');

-- --------------------------------------------------------

--
-- Table structure for table `matches`
--

CREATE TABLE `matches` (
  `matchid` int(6) NOT NULL,
  `matchnumber` varchar(60) DEFAULT NULL,
  `refereename` varchar(60) DEFAULT NULL,
  `scorername` varchar(60) DEFAULT NULL,
  `linejudges1name` varchar(60) DEFAULT NULL,
  `linejudges2name` varchar(60) DEFAULT NULL,
  `linejudges3name` varchar(60) DEFAULT NULL,
  `linejudges4name` varchar(60) DEFAULT NULL,
  `division` varchar(60) DEFAULT NULL,
  `matchdate` varchar(60) DEFAULT NULL,
  `matchtime` varchar(60) DEFAULT NULL,
  `teamaname` varchar(60) DEFAULT '-',
  `teamacoach` varchar(60) DEFAULT NULL,
  `teamaset1` int(2) DEFAULT '0',
  `teamaset2` int(2) DEFAULT '0',
  `teamaset3` int(2) DEFAULT '0',
  `teamaset4` int(2) DEFAULT '0',
  `teamaset5` int(2) DEFAULT '0',
  `teamatimeout1` int(2) DEFAULT '0',
  `teamatimeout2` int(2) DEFAULT '0',
  `teamatimeout3` int(2) DEFAULT '0',
  `teamatimeout4` int(2) DEFAULT '0',
  `teamatimeout5` int(2) DEFAULT '0',
  `teamawonsets` int(1) DEFAULT '0',
  `teamaresult` varchar(60) DEFAULT NULL,
  `teambname` varchar(60) DEFAULT '-',
  `teambcoach` varchar(60) DEFAULT NULL,
  `teambset1` int(2) DEFAULT '0',
  `teambset2` int(2) DEFAULT '0',
  `teambset3` int(2) DEFAULT '0',
  `teambset4` int(2) DEFAULT '0',
  `teambset5` int(2) DEFAULT '0',
  `teambtimeout1` int(2) DEFAULT '0',
  `teambtimeout2` int(2) DEFAULT '0',
  `teambtimeout3` int(2) DEFAULT '0',
  `teambtimeout4` int(2) DEFAULT '0',
  `teambtimeout5` int(2) DEFAULT '0',
  `teambwonsets` int(2) DEFAULT '0',
  `teambresult` varchar(60) DEFAULT NULL,
  `currentset` int(1) DEFAULT '1',
  `matchsaveddatetime` datetime DEFAULT NULL,
  `bestof` int(1) DEFAULT '3'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `matches`
--

INSERT INTO `matches` (`matchid`, `matchnumber`, `refereename`, `scorername`, `linejudges1name`, `linejudges2name`, `linejudges3name`, `linejudges4name`, `division`, `matchdate`, `matchtime`, `teamaname`, `teamacoach`, `teamaset1`, `teamaset2`, `teamaset3`, `teamaset4`, `teamaset5`, `teamatimeout1`, `teamatimeout2`, `teamatimeout3`, `teamatimeout4`, `teamatimeout5`, `teamawonsets`, `teamaresult`, `teambname`, `teambcoach`, `teambset1`, `teambset2`, `teambset3`, `teambset4`, `teambset5`, `teambtimeout1`, `teambtimeout2`, `teambtimeout3`, `teambtimeout4`, `teambtimeout5`, `teambwonsets`, `teambresult`, `currentset`, `matchsaveddatetime`, `bestof`) VALUES
(1, '', '', '', '', '', '', '', '', '', '', '-', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '-', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 1, NULL, 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `matches`
--
ALTER TABLE `matches`
  ADD PRIMARY KEY (`matchid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `matches`
--
ALTER TABLE `matches`
  MODIFY `matchid` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
