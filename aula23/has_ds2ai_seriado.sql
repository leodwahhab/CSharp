-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: has_ds2ai
-- ------------------------------------------------------
-- Server version	8.0.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `seriado`
--

DROP TABLE IF EXISTS `seriado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `seriado` (
  `id_seriado` int NOT NULL AUTO_INCREMENT,
  `nome_seriado` varchar(45) CHARACTER SET utf8 COLLATE utf8_swedish_ci DEFAULT NULL,
  `anolanc_seriado` varchar(4) COLLATE utf8_swedish_ci DEFAULT NULL,
  `temporada_seriado` varchar(2) COLLATE utf8_swedish_ci DEFAULT NULL,
  `descricao_seriado` varchar(450) CHARACTER SET utf8 COLLATE utf8_swedish_ci DEFAULT NULL,
  PRIMARY KEY (`id_seriado`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_swedish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seriado`
--

LOCK TABLES `seriado` WRITE;
/*!40000 ALTER TABLE `seriado` DISABLE KEYS */;
INSERT INTO `seriado` VALUES (1,'Dinastia','2018','4','A vida de uma família rica!'),(2,'Dinastia 2','2021','1','A decadência de uma familia rica!'),(3,'Dinastia 3','2021','1','A ascenção de uma família pobre!'),(4,'Dark','2020','3','Viagem no tempo!!'),(6,'teste2','2112','2','ssdf ds ãããããã'),(7,'aaaa','2023','3','dasd ad as a'),(11,'qweqe','2011','1','12'),(14,'','','',''),(15,'','','',''),(16,'','','',''),(17,'','','',''),(18,'','','',''),(19,'','','',''),(20,'','','',''),(21,'','','',''),(22,'teste','12','15','descricao'),(23,'','','',''),(24,'','','',''),(25,'ad','12','12','asda'),(26,'','','',''),(27,'','','',''),(28,'','','',''),(29,'','','',''),(30,'','','',''),(31,'','','',''),(32,'','','',''),(33,'','','',''),(34,'','','',''),(35,'','','',''),(36,'','','',''),(37,'','','',''),(38,'','','',''),(39,'','','',''),(40,'','','',''),(41,'','','',''),(42,'ae','12','12','1212'),(43,'ae','12','12','1212'),(44,'A gata e o rato','1980','1','seriado exibido na tv globo aos domingos'),(45,'A gata e o rato','1980','1','seriado exibido na tv globo aos domingos'),(46,'','','',''),(47,'','','',''),(48,'','','',''),(49,'','','',''),(50,'','','',''),(51,'teste 51','123','1','ssfsd s fsdf ds ');
/*!40000 ALTER TABLE `seriado` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-23  7:33:24
