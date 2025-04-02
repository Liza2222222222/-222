-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: salon222
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services` (
  `id` int NOT NULL,
  `description` varchar(100) NOT NULL,
  `price` varchar(45) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (1,'Маникюр без покрытия','1000руб','Маникюр'),(2,'Однотонный(без дизайна)','1800руб','Маникюр'),(3,'С дизайном','2000руб','Маникюр'),(4,'Наращивание(без дизайна)','2600руб','Маникюр'),(5,'Наращивание(с дизайном)','2800руб','Маникюр'),(6,'Педикюр без покрытия','1000руб','Педикюр'),(7,'Педикюр с покрытием','1300руб','Педикюр'),(8,'Массаж лица классический','2000руб','Массаж лица'),(9,'Узнавать в салоне','от 3100руб','Пилинг лица'),(10,'Чистка лица ручная','3250руб','Чистка лица'),(11,'Чистка лица ультразвуковая','3500руб','Чистка лица'),(12,'Узнавать в салоне','от 2000руб','Увлажняющие и питательные маски для лица'),(13,'Узнавать в салоне','от 1500руб','Обёртывания'),(14,'Удаление волосков и придание формы','800руб','Коррекция бровей'),(15,'Входит ламинирование,коррекция и уход','1300руб','Ламинирование бровей'),(16,'Входит ламинирование,окрашивание,коррекция и уход','1500руб','Ламинирование бровей'),(17,'Входит окрашивание и уход','1700руб','Ламинирование ресниц'),(18,'Входит окрашивание и уход','2200руб','Ламинирование верхних и нижних ресниц'),(19,'Окрашивание ресниц','800руб','Ресницы');
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-02  8:39:44
