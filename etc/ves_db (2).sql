/*
SQLyog Ultimate v8.53 
MySQL - 5.5.5-10.1.37-MariaDB : Database - ves_db
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
  `announcement` text,
  `announcementtextfullscreen` text,
  `announcementtype` int(1) DEFAULT NULL,
  `announcementimage` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `announcements` */

insert  into `announcements`(`announcement`,`announcementtextfullscreen`,`announcementtype`,`announcementimage`) values ('sa kahirapan niyo kunwari hahahaha','a6s5d06asd56asda sda60s +as60d +6asd6 50as\r\nd .a20. as63d 50a63sd50 a\r\n3sd50 as6dasd6a5sd65a6s5d0 6as5d 60as5d6 a5s6d50 a6sd56 a0sd6 5a0sd.\r\na 5sd0\r\n 3a50sd\r\n3 5asd5sdd5d a6sd56a 5sd65a6sd5a6ds56 5a6sd 56ad56a56sd 5a6sd5 6a5sd+6 a5s+6d5 as6d54 a65sd456a 465d4a 56s4d56a 456d4a56 sd4a56 4d56a4sd 65a4s',2,'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');

/*Table structure for table `matches` */

DROP TABLE IF EXISTS `matches`;

CREATE TABLE `matches` (
  `matchid` int(6) NOT NULL AUTO_INCREMENT,
  `matchnumber` varchar(60) DEFAULT NULL,
  `refereeaname` varchar(60) DEFAULT NULL,
  `refereebname` varchar(60) DEFAULT NULL,
  `scorername` varchar(60) DEFAULT NULL,
  `linejudges1name` varchar(60) DEFAULT NULL,
  `linejudges2name` varchar(60) DEFAULT NULL,
  `linejudges3name` varchar(60) DEFAULT NULL,
  `linejudges4name` varchar(60) DEFAULT NULL,
  `division` varchar(60) DEFAULT 'Men',
  `matchdate` varchar(60) DEFAULT NULL,
  `matchtime` varchar(60) DEFAULT '12:00nn',
  `teamaname` varchar(60) DEFAULT 'TEAM A',
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
  `teambname` varchar(60) DEFAULT 'TEAM B',
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
  `bestof` int(1) DEFAULT '3',
  PRIMARY KEY (`matchid`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

/*Data for the table `matches` */

insert  into `matches`(`matchid`,`matchnumber`,`refereeaname`,`refereebname`,`scorername`,`linejudges1name`,`linejudges2name`,`linejudges3name`,`linejudges4name`,`division`,`matchdate`,`matchtime`,`teamaname`,`teamacoach`,`teamaset1`,`teamaset2`,`teamaset3`,`teamaset4`,`teamaset5`,`teamatimeout1`,`teamatimeout2`,`teamatimeout3`,`teamatimeout4`,`teamatimeout5`,`teamawonsets`,`teamaresult`,`teambname`,`teambcoach`,`teambset1`,`teambset2`,`teambset3`,`teambset4`,`teambset5`,`teambtimeout1`,`teambtimeout2`,`teambtimeout3`,`teambtimeout4`,`teambtimeout5`,`teambwonsets`,`teambresult`,`currentset`,`matchsaveddatetime`,`bestof`) values (1,'','','','','','','','','Men','2020-06-29','02:41 AM','Team A','',0,0,0,0,0,0,0,0,0,0,0,'','Team B','',0,0,0,0,0,0,0,0,0,0,0,'',1,NULL,3),(19,'asdadsas','asdasd','asdasdasdasd','sda','asdasda','as','asd','sdasdasd','Mixed','2020-06-18','11:07 AM','Team A','asdasd',25,25,0,0,0,0,0,0,0,0,2,'WIN','Team B','dasd',0,0,0,0,0,0,0,0,0,0,0,'LOSE',2,'2020-06-18 11:07:45',3),(20,'asdas','dasdasda','sdasdasdasd','asdasd','asdwasd123','asd','123','123','Mixed','2020/6/30','02:00:PM','Team A','asda6s5d6a5sd',0,0,0,0,0,0,0,0,0,0,0,'LOSE','Team B','asd6a5sd6asd',25,25,0,0,0,0,0,0,0,0,2,'WIN',2,'2020-06-29 02:41:32',3);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
