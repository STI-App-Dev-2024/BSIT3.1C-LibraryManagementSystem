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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_archive`
--

LOCK TABLES `book_archive` WRITE;
/*!40000 ALTER TABLE `book_archive` DISABLE KEYS */;
INSERT INTO `book_archive` VALUES (1,'Buhay ni Harvy','Harvy Yator','STI Dasma',2026,'3217984568','Travel and Adventure','Ikauna','2024-11-28 20:34:23','2024-11-28 20:34:23');
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'2407151779','asdasdasd','asdasdasd','asdasdasd',2020,'6513216546546','asdasd','asdasdasd','2024-11-26 18:32:47','2024-11-26 18:32:47'),(2,'2407151779','asdasdasd','asdasdasd','asdasdasd',2020,'321654321','asdasd','asdasdasdasd','2024-11-26 18:34:54','2024-11-26 18:34:54'),(3,'2407151779','asdasdasd','asdasdasd','asdasdasd',2020,'65465423156','asdasd','asdasdasd','2024-11-26 18:35:46','2024-11-26 18:35:46'),(4,'2407151779','asdasdasd','asdasdasd','asdasdasd',2020,'65465423156','asdasd','asdasdasd','2024-11-26 18:37:14','2024-11-26 18:37:14');
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `copies`
--

LOCK TABLES `copies` WRITE;
/*!40000 ALTER TABLE `copies` DISABLE KEYS */;
INSERT INTO `copies` VALUES (1,1,'A00010000','Available','2024-11-26 18:37:14','2024-11-26 18:37:14'),(2,1,'A00010001','Available','2024-11-26 18:37:14','2024-11-26 18:37:14'),(3,1,'A00010002','Available','2024-11-26 18:37:14','2024-11-26 18:37:14');
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
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transactions`
--

DROP TABLE IF EXISTS `transactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transactions` (
  `transaction_id` int NOT NULL,
  `copy_id` int NOT NULL,
  `student_id` int NOT NULL,
  `borrow_date` date NOT NULL,
  `due_date` date NOT NULL,
  `return_date` datetime NOT NULL,
  `status` varchar(45) NOT NULL,
  `created_by` datetime NOT NULL,
  `updated_by` datetime NOT NULL,
  PRIMARY KEY (`transaction_id`),
  KEY `student_id_idx` (`student_id`),
  KEY `copy_id_idx` (`copy_id`),
  CONSTRAINT `copy_id` FOREIGN KEY (`copy_id`) REFERENCES `copies` (`copy_id`),
  CONSTRAINT `student_id` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactions`
--

LOCK TABLES `transactions` WRITE;
/*!40000 ALTER TABLE `transactions` DISABLE KEYS */;
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
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_accounts`
--

LOCK TABLES `user_accounts` WRITE;
/*!40000 ALTER TABLE `user_accounts` DISABLE KEYS */;
INSERT INTO `user_accounts` VALUES (313598,'Villanueva','Jake','admin','password313598','password313598','villanueva.313598@dasmarinas.sti.edu.ph','2024-11-22 16:04:18','2024-11-22 16:04:18'),(323456,'Yator','Harvy','librarian','password323456','password323456','yator.323456@dasmarinas.sti.edu.ph','2024-11-22 16:06:17','2024-11-22 16:06:17');
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
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_history`
--

LOCK TABLES `user_history` WRITE;
/*!40000 ALTER TABLE `user_history` DISABLE KEYS */;
INSERT INTO `user_history` VALUES (1,323456,'2024-11-22 20:47:57','2024-11-22 20:47:57'),(2,323456,'2024-11-26 18:26:11','2024-11-26 18:26:11'),(3,323456,'2024-11-26 18:30:17','2024-11-26 18:30:17'),(4,323456,'2024-11-26 18:32:07','2024-11-26 18:32:07'),(5,323456,'2024-11-26 19:01:18','2024-11-26 19:01:18'),(6,323456,'2024-11-26 19:18:42','2024-11-26 19:18:42'),(7,323456,'2024-11-26 19:24:25','2024-11-26 19:24:25'),(8,323456,'2024-11-26 19:26:14','2024-11-26 19:26:14'),(9,323456,'2024-11-26 19:27:36','2024-11-26 19:27:36'),(10,323456,'2024-11-26 19:39:51','2024-11-26 19:39:51'),(11,323456,'2024-11-26 19:45:13','2024-11-26 19:45:13'),(12,323456,'2024-11-26 19:46:21','2024-11-26 19:46:21'),(13,323456,'2024-11-26 19:47:37','2024-11-26 19:47:37'),(14,323456,'2024-11-28 10:14:40','2024-11-28 10:14:40'),(15,323456,'2024-11-28 11:04:03','2024-11-28 11:04:03'),(16,323456,'2024-11-28 11:42:55','2024-11-28 11:42:55'),(17,323456,'2024-11-28 13:38:59','2024-11-28 13:38:59'),(18,323456,'2024-11-28 13:40:59','2024-11-28 13:40:59'),(19,323456,'2024-11-28 13:42:22','2024-11-28 13:42:22'),(20,323456,'2024-11-28 15:09:55','2024-11-28 15:09:55'),(21,323456,'2024-11-28 15:16:16','2024-11-28 15:16:16'),(22,323456,'2024-11-28 15:48:55','2024-11-28 15:48:55'),(23,323456,'2024-11-28 15:51:39','2024-11-28 15:51:39'),(24,323456,'2024-11-28 15:55:52','2024-11-28 15:55:52'),(25,323456,'2024-11-28 16:08:29','2024-11-28 16:08:29'),(26,323456,'2024-11-28 16:12:13','2024-11-28 16:12:13'),(27,323456,'2024-11-28 16:18:32','2024-11-28 16:18:32'),(28,323456,'2024-11-28 16:19:26','2024-11-28 16:19:26'),(29,323456,'2024-11-28 16:33:06','2024-11-28 16:33:06'),(30,323456,'2024-11-28 16:46:29','2024-11-28 16:46:29'),(31,323456,'2024-11-28 20:21:19','2024-11-28 20:21:19'),(32,323456,'2024-11-28 20:22:38','2024-11-28 20:22:38'),(33,323456,'2024-11-28 20:24:53','2024-11-28 20:24:53'),(34,323456,'2024-11-28 20:27:55','2024-11-28 20:27:55'),(35,323456,'2024-11-28 20:32:07','2024-11-28 20:32:07'),(36,323456,'2024-11-28 20:34:35','2024-11-28 20:34:35'),(37,323456,'2024-11-28 20:37:16','2024-11-28 20:37:16'),(38,323456,'2024-11-28 20:38:02','2024-11-28 20:38:02'),(39,323456,'2024-11-28 20:40:48','2024-11-28 20:40:48'),(40,323456,'2024-11-28 22:14:36','2024-11-28 22:14:36');
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

-- Dump completed on 2024-11-28 22:15:16
