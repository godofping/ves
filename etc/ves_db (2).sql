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

insert  into `announcements`(`announcement`,`announcementtextfullscreen`,`announcementtype`,`announcementimage`) values ('sa kahirapan niyo kunwari hahahaha','With this utility you generate a 16 character output based on your input of numbers and upper and lower case letters.  Random strings can be unique. Used in computing, a random string generator can also be called a random character string generator. This is an important tool if. random string genera',2,'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');

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
  `matchtime` varchar(60) DEFAULT '12:00nn',
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
  `bestof` int(1) DEFAULT '3',
  PRIMARY KEY (`matchid`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

/*Data for the table `matches` */

insert  into `matches`(`matchid`,`matchnumber`,`refereename`,`scorername`,`linejudges1name`,`linejudges2name`,`linejudges3name`,`linejudges4name`,`division`,`matchdate`,`matchtime`,`teamaname`,`teamacoach`,`teamaset1`,`teamaset2`,`teamaset3`,`teamaset4`,`teamaset5`,`teamatimeout1`,`teamatimeout2`,`teamatimeout3`,`teamatimeout4`,`teamatimeout5`,`teamawonsets`,`teamaresult`,`teambname`,`teambcoach`,`teambset1`,`teambset2`,`teambset3`,`teambset4`,`teambset5`,`teambtimeout1`,`teambtimeout2`,`teambtimeout3`,`teambtimeout4`,`teambtimeout5`,`teambwonsets`,`teambresult`,`currentset`,`matchsaveddatetime`,`bestof`) values (1,'','','','','','','','','','','-','',0,0,0,0,0,0,0,0,0,0,0,'','-','',0,0,0,0,0,0,0,0,0,0,0,'',1,NULL,3),(3,'mt num','refree','scor','lj1','lj2','lj3','lj4','div','md','mt','ta na','ta coach',25,25,0,0,0,0,0,0,0,0,2,'WIN','tb name','tb coa',0,0,0,0,0,0,0,0,0,0,0,'LOSE',2,'2020-04-06 14:53:50',3),(4,'','','','','','','','','','','-','',25,25,25,0,0,0,0,0,0,0,3,'WIN','-','',0,0,0,0,0,0,0,0,0,0,0,'LOSE',3,'2020-04-07 14:57:00',5),(5,'','','','','','','','','','','-','',25,0,25,0,15,0,0,0,0,0,3,'WIN','-','',0,25,0,25,0,0,0,0,0,0,2,'LOSE',5,'2020-04-10 10:24:28',5),(6,'','','','','','','','','','','-','',25,0,15,0,0,0,0,0,0,0,2,'WIN','-','',0,25,0,0,0,0,0,0,0,0,1,'LOSE',3,'2020-04-10 10:24:50',3),(7,'','','','','','','','','','','-','',25,0,25,0,15,0,0,0,0,0,3,'WIN','-','',0,25,0,25,0,0,0,0,0,0,2,'LOSE',5,'2020-04-10 10:25:28',5),(8,'','','','','','','','','','','-','',23,25,25,0,0,0,0,0,0,0,2,'WIN','-','',25,0,0,0,0,0,0,0,0,0,1,'LOSE',3,'2020-04-18 22:06:06',3),(9,'','','','','','','','','','','-','',25,25,0,0,0,2,0,0,0,0,2,'WIN','-','',0,0,0,0,0,2,0,0,0,0,0,'LOSE',2,'2020-04-18 14:34:20',3),(10,'','','','','','','','','','','-','',25,0,0,0,0,0,0,0,0,0,1,'LOSE','-','',0,25,25,0,0,0,0,0,0,0,2,'WIN',3,'2020-04-18 14:35:17',3),(11,'','','','','','','','','','','-','',25,0,25,0,0,0,0,0,0,0,2,'WIN','-','',0,25,0,0,0,0,0,0,0,0,1,'LOSE',3,'2020-04-27 08:42:07',3),(12,'','','','','','','','','','','-','',25,0,25,25,0,0,0,0,0,0,3,'WIN','-','',0,25,0,0,0,0,0,0,0,0,1,'LOSE',4,'2020-04-27 08:42:53',5),(13,'','','','','','','','','','','-','',25,0,25,0,0,0,0,0,0,0,2,'WIN','-','',0,25,0,0,0,0,0,0,0,0,1,'LOSE',3,'2020-04-27 00:48:57',3),(14,'','','','','','','','','','','-','',25,0,25,0,15,0,0,0,0,0,3,'WIN','-','',0,25,0,25,13,0,0,0,2,0,2,'LOSE',5,'2020-05-17 01:50:44',5),(15,'','','','','','','','','05.17.2020','3:00pm','-','',25,25,0,0,0,0,0,0,0,0,2,'WIN','-','',0,16,0,0,0,0,0,0,0,0,0,'LOSE',2,'2020-05-17 09:24:40',3),(16,'matchnumber1','rex louis roncesvalles','totoy brown','line judge1','line judge 2','line judge 3','line judge 4','FEMALE','05.17.2020','12:00nn','-1','',0,0,0,0,0,0,0,0,0,0,0,'LOSE','-','',25,25,0,0,0,0,0,0,0,0,2,'WIN',2,'2020-05-17 09:45:06',3);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
