-- MariaDB dump 10.19  Distrib 10.5.12-MariaDB, for Linux (x86_64)
--
-- Host: mysql.hostinger.ro    Database: u574849695_23
-- ------------------------------------------------------
-- Server version	10.5.12-MariaDB-cll-lve

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dosen`
--

DROP TABLE IF EXISTS `dosen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dosen` (
  `nip` int(12) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `agama` varchar(20) NOT NULL,
  `alamat` text NOT NULL,
  `jenisKelamin` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dosen`
--

LOCK TABLES `dosen` WRITE;
/*!40000 ALTER TABLE `dosen` DISABLE KEYS */;
INSERT INTO `dosen` VALUES (1912011075,'Ari Willms',' Hindu','80254 Autumn Oval','P'),(1912011195,'Maiya Rolfson III','Islam','20097 Satterfield Burg','P'),(1912011187,'Sabrina Walsh Jr.',' Hindu','39371 Ryan Prairie Suite 281','L'),(1912011128,'Sigrid Armstrong',' Hindu','93439 Amani Canyon Suite 901','L'),(1912011027,'Jeromy McCullough',' Protestan','387 Norene Turnpike Apt. 429','P'),(1912011020,'Margarete Upton',' Protestan','27002 Dach Rapid','P'),(1912011014,'Jackie Kulas',' Katolik','8374 Swift Mall','L'),(1912011191,'Winston Pfeffer V',' Hindu','98697 Kautzer Lodge','P'),(1912011162,'Miss Courtney Gutkowski',' Buddha','178 Lind Courts','P'),(1912011139,'Einar Wilderman',' Hindu','04772 Onie Summit','L'),(1912011043,'Mr. Raymond Conroy I',' Hindu','8668 Zboncak Causeway Apt. 661','P'),(1912011083,'Jacynthe Rosenbaum',' Protestan','2506 Smitham Views','P'),(1912011198,'Elliot Hoeger',' Hindu','78603 Harvey Way','L'),(1912011199,'Estelle Pfannerstill',' Buddha','4550 Marc Meadow Suite 410','L'),(1912011057,'Shayne Dach',' Katolik','66051 Nash Fort Suite 496','P'),(1912011023,'Fiona Satterfield',' Hindu','34087 Elyse Manor Apt. 676','P'),(1912011013,'Mr. Heber Koelpin',' Buddha','1462 Cassin Row Suite 149','L'),(1912011100,'London Lakin',' Buddha','972 Ernestina Burg Apt. 676','P'),(1912011063,'Otto Leannon',' Hindu','2875 Schuppe Harbors','L'),(1912011053,'Maribel Carroll','Islam','41545 Newton Circle Apt. 689','L'),(1912011015,'Oral Abshire',' Buddha','63524 Tristian Points','P'),(1912011065,'Dr. Morton Schowalter II',' Hindu','677 Tod Springs','P'),(1912011061,'Arely Keeling',' Hindu','6926 Garrick Gateway','L'),(1912011180,'Webster Bradtke',' Protestan','782 Little Expressway Apt. 261','L'),(1912011130,'Prof. Bernice Donnelly','Islam','5420 Jacobi Knoll Apt. 636','P'),(1912011096,'Prof. Keeley Frami IV',' Katolik','6597 Isaiah Mountain','L'),(1912011080,'Webster Lindgren',' Protestan','7577 Madyson Via','P'),(1912011090,'Darius Bruen Jr.',' Katolik','529 Daugherty Plains Apt. 770','P'),(1912011108,'Joana Strosin',' Hindu','19315 Rosenbaum Keys','P'),(1912011150,'Roy Bosco',' Hindu','39990 Grimes Shores','L'),(1912011182,'Dr. Agnes Beier Sr.',' Hindu','715 Kari Glens Apt. 950','P'),(1912011107,'Meredith Volkman',' Hindu','303 Geraldine Fork Apt. 272','P'),(1912011058,'Cody Legros','Islam','80743 Bartell Passage','L'),(1912011003,'Mrs. Ima Powlowski MD',' Protestan','83115 Mireille Locks','L'),(1912011033,'Cary Baumbach',' Katolik','5798 Nayeli Court','P'),(1912011026,'Torey Medhurst',' Buddha','187 Mellie Radial','P'),(1912011169,'Corrine Lind',' Hindu','188 Deanna Crescent','P'),(1912011038,'Zion Hegmann',' Katolik','730 Turcotte Curve','L'),(1912011140,'Prof. Lane Mertz I',' Hindu','437 Veum Stream','L'),(1912011005,'Mr. Jarred Farrell I',' Katolik','38584 Bryce Trail','L'),(1912011133,'Mr. Talon Turner',' Protestan','4843 Drake Walks Apt. 153','P'),(1912011097,'Dr. Savion Durgan Jr.',' Hindu','6599 Chyna Squares','L'),(1912011189,'Isac Marquardt',' Katolik','65828 Gladyce Mill','L'),(1912011115,'Jaunita Farrell Jr.',' Protestan','91799 Reichert Junctions Suite 338','P'),(1912011060,'Mr. Darrick Lang',' Buddha','143 Bridie Ports Suite 076','P');
/*!40000 ALTER TABLE `dosen` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-19  7:20:42
