/*
SQLyog Ultimate v8.53 
MySQL - 5.5.5-10.1.38-MariaDB : Database - ves_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`ves_db` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `ves_db`;

/*Table structure for table `announcements` */

DROP TABLE IF EXISTS `announcements`;

CREATE TABLE `announcements` (
  `announcement` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `announcements` */

insert  into `announcements`(`announcement`) values ('rex pogi :)');

/*Table structure for table `matches` */

DROP TABLE IF EXISTS `matches`;

CREATE TABLE `matches` (
  `matchid` int(6) NOT NULL AUTO_INCREMENT,
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
  `teamaname` varchar(60) DEFAULT NULL,
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
  `teambname` varchar(60) DEFAULT NULL,
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
  PRIMARY KEY (`matchid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `matches` */

insert  into `matches`(`matchid`,`matchnumber`,`refereename`,`scorername`,`linejudges1name`,`linejudges2name`,`linejudges3name`,`linejudges4name`,`division`,`matchdate`,`matchtime`,`teamaname`,`teamacoach`,`teamaset1`,`teamaset2`,`teamaset3`,`teamaset4`,`teamaset5`,`teamatimeout1`,`teamatimeout2`,`teamatimeout3`,`teamatimeout4`,`teamatimeout5`,`teamawonsets`,`teamaresult`,`teambname`,`teambcoach`,`teambset1`,`teambset2`,`teambset3`,`teambset4`,`teambset5`,`teambtimeout1`,`teambtimeout2`,`teambtimeout3`,`teambtimeout4`,`teambtimeout5`,`teambwonsets`,`teambresult`,`currentset`) values (1,'match 1','',NULL,'','','','','','','','','',4,0,0,0,0,0,0,0,0,0,0,'','','',4,0,0,0,0,0,0,0,0,0,0,'',1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
