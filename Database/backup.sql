CREATE DATABASE  IF NOT EXISTS `librarymanagement` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `librarymanagement`;
-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: librarymanagement
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `book_archive`
--

DROP TABLE IF EXISTS `book_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_archive` (
  `archive_id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `publisher` varchar(255) NOT NULL,
  `year_published` int NOT NULL,
  `isbn` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL,
  `edition` varchar(45) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  PRIMARY KEY (`archive_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_archive`
--

LOCK TABLES `book_archive` WRITE;
/*!40000 ALTER TABLE `book_archive` DISABLE KEYS */;
INSERT INTO `book_archive` VALUES (1,'Buhay ni Harvy','Harvy Yator','STI Dasma',2026,'3217984568','Travel and Adventure','Ikauna','2024-11-28 20:34:23','2024-11-28 20:34:23'),(5,'asdasdasd','asdasdasd','asdasdasd',2020,'65465423156','asdasd','asdasdasd','2024-12-08 14:42:34','2024-12-08 14:42:34'),(6,'asdasdasd','asdasdasd','asdasdasd',2020,'321654321','asdasd','asdasdasdasd','2024-12-10 21:03:43','2024-12-10 21:03:43'),(7,'asdasdasd','asdasdasd','asdasdasd',2020,'65465423156','asdasd','asdasdasd','2024-12-10 21:03:47','2024-12-10 21:03:47');
/*!40000 ALTER TABLE `book_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `book_id` int NOT NULL AUTO_INCREMENT,
  `barcode` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `publisher` varchar(255) NOT NULL,
  `year_published` int NOT NULL,
  `isbn` varchar(255) NOT NULL,
  `category` varchar(45) NOT NULL,
  `edition` varchar(40) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  PRIMARY KEY (`book_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'2407151779','Buhay ni Harvy','asdasdasd','asdasdasd',2020,'6513216546546','Science and Nature','asdasdasd','2024-11-26 18:32:47','2024-12-08 14:23:49'),(6,'9789710856473','Harmony of Logic','Felix Montemayor','National Book Store',1993,'9710856472','STEM','Third Edition','2024-12-10 21:12:04','2024-12-10 21:13:46');
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `copies`
--

DROP TABLE IF EXISTS `copies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `copies` (
  `copy_id` int NOT NULL AUTO_INCREMENT,
  `book_id` int NOT NULL,
  `accession_number` varchar(255) NOT NULL,
  `status` varchar(45) NOT NULL,
  `created_by` datetime NOT NULL,
  `updated_by` datetime NOT NULL,
  PRIMARY KEY (`copy_id`),
  KEY `book_id_idx` (`book_id`),
  CONSTRAINT `book_id` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `copies`
--

LOCK TABLES `copies` WRITE;
/*!40000 ALTER TABLE `copies` DISABLE KEYS */;
INSERT INTO `copies` VALUES (1,1,'A00010000','Borrowed','2024-11-26 18:37:14','2024-11-26 18:37:14'),(2,1,'A00010001','Borrowed','2024-11-26 18:37:14','2024-11-26 18:37:14'),(3,1,'A00010002','Borrowed','2024-11-26 18:37:14','2024-11-26 18:37:14'),(11,6,'A00060000','Borrowed','2024-12-10 21:12:04','2024-12-10 21:12:04'),(12,6,'A00060001','Available','2024-12-10 21:13:46','2024-12-10 21:13:46');
/*!40000 ALTER TABLE `copies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `student_id` int NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `email` varchar(255) NOT NULL,
  `allowed_loan` int NOT NULL,
  `status` varchar(45) NOT NULL,
  `created_by` datetime NOT NULL,
  `updated_by` datetime NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (283125,'Ronald','Ramento','ramento.283125@dasmarinas.sti.edu.ph',10,'Active','2024-12-10 21:15:00','2024-12-10 21:15:00'),(323456,'asdasdasd','asdasdasd','asdasdasd',10,'Active','2024-12-01 15:43:20','2024-12-01 15:43:20');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transactions`
--

DROP TABLE IF EXISTS `transactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transactions` (
  `transaction_id` int NOT NULL AUTO_INCREMENT,
  `copy_id` int NOT NULL,
  `student_id` int NOT NULL,
  `borrow_date` datetime NOT NULL,
  `due_date` datetime NOT NULL,
  `return_date` datetime NOT NULL DEFAULT '1900-01-01 00:00:00',
  `status` varchar(45) NOT NULL,
  `created_by` datetime NOT NULL,
  `updated_by` datetime NOT NULL,
  PRIMARY KEY (`transaction_id`),
  KEY `copy_id_idx` (`copy_id`),
  CONSTRAINT `copy_id` FOREIGN KEY (`copy_id`) REFERENCES `copies` (`copy_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactions`
--

LOCK TABLES `transactions` WRITE;
/*!40000 ALTER TABLE `transactions` DISABLE KEYS */;
INSERT INTO `transactions` VALUES (1,2,323456,'2024-11-29 18:59:39','2024-12-13 18:59:39','1900-01-01 00:00:00','On-Going','2024-11-29 18:59:39','2024-11-29 18:59:39'),(2,3,313598,'2024-11-29 19:06:10','2024-12-13 19:06:11','1900-01-01 00:00:00','On-Going','2024-11-29 19:06:10','2024-11-29 19:06:10'),(3,3,323456,'2024-12-01 15:43:20','2024-12-15 15:43:20','1900-01-01 00:00:00','On-Going','2024-12-01 15:43:20','2024-12-01 15:43:20'),(4,11,283125,'2024-12-10 21:15:00','2024-12-24 21:15:00','1900-01-01 00:00:00','On-Going','2024-12-10 21:15:00','2024-12-10 21:15:00');
/*!40000 ALTER TABLE `transactions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_accounts`
--

DROP TABLE IF EXISTS `user_accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_accounts` (
  `user_id` int NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `user_level` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `default_password` varchar(45) NOT NULL,
  `email` varchar(100) NOT NULL,
  `created_by` datetime NOT NULL,
  `update_by` datetime NOT NULL,
  `reset` varchar(5) NOT NULL DEFAULT 'FALSE',
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_accounts`
--

LOCK TABLES `user_accounts` WRITE;
/*!40000 ALTER TABLE `user_accounts` DISABLE KEYS */;
INSERT INTO `user_accounts` VALUES (313598,'Villanueva','Jake','admin','password313598','password313598','villanueva.313598@dasmarinas.sti.edu.ph','2024-11-22 16:04:18','2024-11-22 16:04:18','FALSE'),(323456,'Yator','Harvy','librarian','password323456','password323456','yator.323456@dasmarinas.sti.edu.ph','2024-11-22 16:06:17','2024-11-22 16:06:17','FALSE');
/*!40000 ALTER TABLE `user_accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_history`
--

DROP TABLE IF EXISTS `user_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_history` (
  `history_ID` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `created_by` datetime NOT NULL,
  `updated_by` datetime NOT NULL,
  PRIMARY KEY (`history_ID`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `user_history_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user_accounts` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_history`
--

LOCK TABLES `user_history` WRITE;
/*!40000 ALTER TABLE `user_history` DISABLE KEYS */;
INSERT INTO `user_history` VALUES (1,323456,'2024-11-22 20:47:57','2024-11-22 20:47:57'),(2,323456,'2024-11-26 18:26:11','2024-11-26 18:26:11'),(3,323456,'2024-11-26 18:30:17','2024-11-26 18:30:17'),(4,323456,'2024-11-26 18:32:07','2024-11-26 18:32:07'),(5,323456,'2024-11-26 19:01:18','2024-11-26 19:01:18'),(6,323456,'2024-11-26 19:18:42','2024-11-26 19:18:42'),(7,323456,'2024-11-26 19:24:25','2024-11-26 19:24:25'),(8,323456,'2024-11-26 19:26:14','2024-11-26 19:26:14'),(9,323456,'2024-11-26 19:27:36','2024-11-26 19:27:36'),(10,323456,'2024-11-26 19:39:51','2024-11-26 19:39:51'),(11,323456,'2024-11-26 19:45:13','2024-11-26 19:45:13'),(12,323456,'2024-11-26 19:46:21','2024-11-26 19:46:21'),(13,323456,'2024-11-26 19:47:37','2024-11-26 19:47:37'),(14,323456,'2024-11-28 10:14:40','2024-11-28 10:14:40'),(15,323456,'2024-11-28 11:04:03','2024-11-28 11:04:03'),(16,323456,'2024-11-28 11:42:55','2024-11-28 11:42:55'),(17,323456,'2024-11-28 13:38:59','2024-11-28 13:38:59'),(18,323456,'2024-11-28 13:40:59','2024-11-28 13:40:59'),(19,323456,'2024-11-28 13:42:22','2024-11-28 13:42:22'),(20,323456,'2024-11-28 15:09:55','2024-11-28 15:09:55'),(21,323456,'2024-11-28 15:16:16','2024-11-28 15:16:16'),(22,323456,'2024-11-28 15:48:55','2024-11-28 15:48:55'),(23,323456,'2024-11-28 15:51:39','2024-11-28 15:51:39'),(24,323456,'2024-11-28 15:55:52','2024-11-28 15:55:52'),(25,323456,'2024-11-28 16:08:29','2024-11-28 16:08:29'),(26,323456,'2024-11-28 16:12:13','2024-11-28 16:12:13'),(27,323456,'2024-11-28 16:18:32','2024-11-28 16:18:32'),(28,323456,'2024-11-28 16:19:26','2024-11-28 16:19:26'),(29,323456,'2024-11-28 16:33:06','2024-11-28 16:33:06'),(30,323456,'2024-11-28 16:46:29','2024-11-28 16:46:29'),(31,323456,'2024-11-28 20:21:19','2024-11-28 20:21:19'),(32,323456,'2024-11-28 20:22:38','2024-11-28 20:22:38'),(33,323456,'2024-11-28 20:24:53','2024-11-28 20:24:53'),(34,323456,'2024-11-28 20:27:55','2024-11-28 20:27:55'),(35,323456,'2024-11-28 20:32:07','2024-11-28 20:32:07'),(36,323456,'2024-11-28 20:34:35','2024-11-28 20:34:35'),(37,323456,'2024-11-28 20:37:16','2024-11-28 20:37:16'),(38,323456,'2024-11-28 20:38:02','2024-11-28 20:38:02'),(39,323456,'2024-11-28 20:40:48','2024-11-28 20:40:48'),(40,323456,'2024-11-28 22:14:36','2024-11-28 22:14:36'),(41,323456,'2024-11-29 18:07:26','2024-11-29 18:07:26'),(42,323456,'2024-11-29 18:25:21','2024-11-29 18:25:21'),(43,323456,'2024-11-29 18:26:21','2024-11-29 18:26:21'),(44,323456,'2024-11-29 18:38:05','2024-11-29 18:38:05'),(45,323456,'2024-11-29 18:46:10','2024-11-29 18:46:10'),(46,323456,'2024-11-29 19:04:09','2024-11-29 19:04:09'),(47,323456,'2024-12-04 14:05:11','2024-12-04 14:05:11'),(48,323456,'2024-12-04 14:06:04','2024-12-04 14:06:04'),(49,323456,'2024-12-04 15:24:42','2024-12-04 15:24:42'),(50,323456,'2024-12-04 16:04:21','2024-12-04 16:04:21'),(51,323456,'2024-12-04 17:52:11','2024-12-04 17:52:11'),(52,323456,'2024-12-04 17:52:42','2024-12-04 17:52:42'),(53,323456,'2024-12-04 17:54:37','2024-12-04 17:54:37'),(54,323456,'2024-12-04 18:40:21','2024-12-04 18:40:21'),(55,323456,'2024-12-04 18:42:10','2024-12-04 18:42:10'),(56,323456,'2024-12-05 16:23:55','2024-12-05 16:23:55'),(57,323456,'2024-12-05 16:32:02','2024-12-05 16:32:02'),(58,323456,'2024-12-05 16:49:25','2024-12-05 16:49:25'),(59,323456,'2024-12-05 17:36:46','2024-12-05 17:36:46'),(60,323456,'2024-12-05 18:13:19','2024-12-05 18:13:19'),(61,323456,'2024-12-05 18:14:07','2024-12-05 18:14:07'),(62,323456,'2024-12-05 18:15:41','2024-12-05 18:15:41'),(63,323456,'2024-12-05 18:43:24','2024-12-05 18:43:24'),(64,323456,'2024-12-08 14:13:19','2024-12-08 14:13:19'),(65,323456,'2024-12-08 14:19:21','2024-12-08 14:19:21'),(66,323456,'2024-12-08 14:23:33','2024-12-08 14:23:33'),(67,323456,'2024-12-08 14:40:56','2024-12-08 14:40:56'),(68,323456,'2024-12-08 14:41:17','2024-12-08 14:41:17'),(69,323456,'2024-12-08 14:42:02','2024-12-08 14:42:02'),(70,323456,'2024-12-08 14:42:27','2024-12-08 14:42:27'),(71,323456,'2024-12-08 14:53:01','2024-12-08 14:53:01'),(72,323456,'2024-12-08 14:54:01','2024-12-08 14:54:01'),(73,323456,'2024-12-08 18:19:35','2024-12-08 18:19:35'),(74,323456,'2024-12-08 18:27:43','2024-12-08 18:27:43'),(75,323456,'2024-12-08 18:32:06','2024-12-08 18:32:06'),(76,323456,'2024-12-08 18:36:16','2024-12-08 18:36:16'),(77,323456,'2024-12-08 18:40:15','2024-12-08 18:40:15'),(78,323456,'2024-12-08 18:42:00','2024-12-08 18:42:00'),(79,323456,'2024-12-08 18:42:46','2024-12-08 18:42:46'),(80,323456,'2024-12-08 18:44:24','2024-12-08 18:44:24'),(81,323456,'2024-12-10 21:03:33','2024-12-10 21:03:33'),(82,323456,'2024-12-10 21:13:25','2024-12-10 21:13:25'),(83,323456,'2024-12-10 21:27:22','2024-12-10 21:27:22'),(84,323456,'2024-12-10 21:34:19','2024-12-10 21:34:19'),(85,323456,'2024-12-10 21:35:05','2024-12-10 21:35:05'),(86,323456,'2024-12-10 21:35:55','2024-12-10 21:35:55'),(87,323456,'2024-12-10 21:37:43','2024-12-10 21:37:43'),(88,323456,'2024-12-10 21:43:51','2024-12-10 21:43:51'),(89,323456,'2024-12-10 21:45:07','2024-12-10 21:45:07'),(90,323456,'2024-12-10 21:47:15','2024-12-10 21:47:15'),(91,323456,'2024-12-10 21:50:34','2024-12-10 21:50:34'),(92,323456,'2024-12-10 21:54:27','2024-12-10 21:54:27'),(93,323456,'2024-12-10 22:00:06','2024-12-10 22:00:06'),(94,323456,'2024-12-10 22:01:54','2024-12-10 22:01:54'),(95,323456,'2024-12-10 22:03:51','2024-12-10 22:03:51'),(96,323456,'2024-12-10 22:04:49','2024-12-10 22:04:49'),(97,323456,'2024-12-10 22:09:46','2024-12-10 22:09:46'),(98,323456,'2024-12-10 22:12:21','2024-12-10 22:12:21'),(99,323456,'2024-12-10 22:15:02','2024-12-10 22:15:02'),(100,323456,'2024-12-10 22:16:06','2024-12-10 22:16:06'),(101,323456,'2024-12-10 22:17:47','2024-12-10 22:17:47'),(102,323456,'2024-12-10 22:20:06','2024-12-10 22:20:06'),(103,323456,'2024-12-10 22:20:25','2024-12-10 22:20:25');
/*!40000 ALTER TABLE `user_history` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-10 22:24:32
