-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: librarysystem22
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `book`
--

DROP TABLE IF EXISTS `book`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book` (
  `Id` varchar(50) NOT NULL,
  `Title` varchar(50) DEFAULT NULL,
  `Author` varchar(50) DEFAULT NULL,
  `Version` varchar(50) DEFAULT NULL,
  `Copies` int DEFAULT NULL,
  `IsDeleted` int DEFAULT NULL,
  `DeletedBy` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book`
--

LOCK TABLES `book` WRITE;
/*!40000 ALTER TABLE `book` DISABLE KEYS */;
INSERT INTO `book` VALUES ('02','cooking skills','zainab','10',4,0,NULL),('1dc021a1-2970-48a5-86fa-6c0f49ed52bb','forensic','blemish','9',20,NULL,NULL),('dc08ac65-f1cb-4f35-a022-0c1ac40e00d7','story time','babajide story','3',11,NULL,NULL);
/*!40000 ALTER TABLE `book` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lender`
--

DROP TABLE IF EXISTS `lender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lender` (
  `Id` varchar(50) NOT NULL,
  `ProfileId` varchar(50) DEFAULT NULL,
  `RefNumber` varchar(50) DEFAULT NULL,
  `BookId` varchar(50) DEFAULT NULL,
  `DateBorrowed` datetime DEFAULT NULL,
  `IsDeleted` int DEFAULT NULL,
  `DeletedBy` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lender`
--

LOCK TABLES `lender` WRITE;
/*!40000 ALTER TABLE `lender` DISABLE KEYS */;
INSERT INTO `lender` VALUES ('0317a531-b86c-4300-b2df-b79b214bdb9d','6362f412-92ed-40be-be70-ccbf57026e58','CLH/2023/175','01','2023-11-21 16:03:07',NULL,NULL),('0b45b7ad-a653-4684-94d7-d019e1125a0e','947ac5de-82ab-498c-9467-f13917543fe6','CLH/2023/462','02','2023-12-06 09:47:03',NULL,NULL),('1cb99df9-981a-4e5c-b452-7edfca131b9d','4d50a624-3ffa-4f80-af42-68fbe3fb5b68','CLH/2023/154','02','2023-12-13 12:07:09',NULL,NULL),('24a2101b-438d-4a3c-b3b0-1202db5a33d5','87c06dbd-5de2-4146-b2ce-02ea3feb7ad0','CLH/2023/981','1dc021a1-2970-48a5-86fa-6c0f49ed52bb','2023-12-06 10:05:17',NULL,NULL),('2b525fac-a7df-4260-bb61-7185ed4a4112','a4f9cf5f-55db-4ba5-adcb-814ad86c0cf3','CLH/2023/701','01','2023-11-22 11:34:43',NULL,NULL),('304e3c14-5974-46e3-97e2-ce96263c7dd8','a6649266-072c-4b82-a72b-3d7f72314559','CLH/2023/900','02','2023-12-13 12:05:41',NULL,NULL),('449909d2-1be4-416c-809b-b2e4399a886b','014f5478-9773-40b5-b14a-f53188a6961e','CLH/2023/178','02','2023-12-13 11:48:30',NULL,NULL),('50b521dd-15fa-4c29-a28a-49b0d216f2b2','82574428-80ba-4458-b219-46c4cfe6ff65','CLH/2023/531','02','2023-12-13 11:49:54',NULL,NULL),('55f0b419-0e14-4a0a-876c-561792458884','2a5c6760-2440-4297-a6fb-6205dce62274','CLH/2023/603','02','2023-12-13 12:07:21',NULL,NULL),('695a81c8-48ad-4399-8145-0fc429c9f4c3','19f2bee7-3834-4eed-a5df-e2c27a3f08b2','CLH/2023/401','02','2023-12-06 14:12:16',NULL,NULL),('795ced84-6ec7-4227-bb75-2311c6c20662','75ff8a67-f5a7-4f3d-8be8-49ac58e0ee14','CLH/2023/279','02','2023-12-13 12:03:37',NULL,NULL),('7ccd3425-1772-47eb-bf34-d5bc5d182294','770f9fc4-a9f1-48c8-9b6e-8d9dbb025868','CLH/2023/956','02','2023-12-13 12:03:08',NULL,NULL),('7e5cb110-ab20-4a09-9b25-2de3029c81a7','4d12d91b-1675-49f1-ba6e-f5de4536989f','CLH/2023/638','1dc021a1-2970-48a5-86fa-6c0f49ed52bb','2023-12-07 10:17:41',NULL,NULL),('80791c5a-ad67-4bc2-a7fb-396eb832deb2','23cda028-9956-4b84-9d31-9228a83f2c7f','CLH/2023/522','02','2023-12-06 14:11:42',NULL,NULL),('8d344162-d0fb-41dd-aa5d-e419b9277b39','2b768cae-7caf-4326-a425-20ef1b0ea982','CLH/2023/930','02','2023-12-06 09:48:08',NULL,NULL),('8d83f1dd-4fd9-411e-aa88-7fd8d96be128','f7360a3f-6f42-4357-99d6-84b8f1a6af2b','CLH/2023/617','1','2023-12-06 09:55:28',NULL,NULL),('9a1d303e-2517-4444-bd86-1e16571864e9','4b446d7f-f71e-4e9b-a766-2bfe226f87f0','CLH/2023/563','1dc021a1-2970-48a5-86fa-6c0f49ed52bb','2023-12-06 10:04:14',NULL,NULL),('a2b3aef1-6f1a-4cbd-8854-54741a6c024a','6220999f-a90e-4e9f-aaae-253163d23e2e','CLH/2023/362','02','2023-12-13 12:05:11',NULL,NULL),('b26ca93f-f768-454e-a924-e64367b6b517','a9c1bf86-6dce-4c1b-90f2-9b06f942c7e1','CLH/2023/771','02','2023-11-22 11:37:52',NULL,NULL),('ba7814ed-5af6-4346-a1fe-472e5d1e5562','1ab0a5ac-16dd-4ec4-b74e-cb3a686a077e','CLH/2023/700','yes','2023-12-06 09:55:51',NULL,NULL),('c7ac33b3-d720-4a17-abec-27be6f27e1c4','72a8c736-7616-496b-9400-53eec7823e9d','CLH/2023/667','01','2023-12-06 09:00:58',NULL,NULL),('cbe75085-7d1a-4e24-bcb4-d888ba98347d','96c0fa25-6790-4410-aab5-31f74a4f5174','CLH/2023/248','02','2023-12-06 09:01:32',NULL,NULL),('d133a411-10be-42f1-924b-0e79f1745f58','11531c17-9bdf-4223-aa78-a52c97721821','CLH/2023/442','1dc021a1-2970-48a5-86fa-6c0f49ed52bb','2023-12-07 10:12:34',NULL,NULL),('dd0bbc3b-a54b-418a-bc0a-43d760bef352','d3e4fcdd-ecd1-4ca2-956d-b0cc446e251b','CLH/2023/675','02','2023-12-06 09:52:33',NULL,NULL),('deaaed3f-2c70-45a7-843b-44c7b9ba392e','90d2b5f5-b094-4358-b9d1-496a07f25c89','CLH/2023/479','02','2023-12-13 12:06:18',NULL,NULL),('df4f02a0-9bd4-40b4-8939-39236de36fb9','5bd2f07e-3b14-49e6-a56c-d8955ab1e90d','CLH/2023/737','01','2023-12-06 09:45:52',NULL,NULL),('f95f7b93-f8a9-4a17-ac08-02d505bef92d','0b07eb9e-2158-417f-b5a0-920a7ffea955','CLH/2023/228','02','2023-12-06 14:12:06',NULL,NULL);
/*!40000 ALTER TABLE `lender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `librarydirector`
--

DROP TABLE IF EXISTS `librarydirector`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `librarydirector` (
  `Id` varchar(50) NOT NULL,
  `StaffNumber` varchar(50) DEFAULT NULL,
  `ProfileId` varchar(50) DEFAULT NULL,
  `IsDeleted` int DEFAULT NULL,
  `DeletedBy` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  UNIQUE KEY `StaffNumber` (`StaffNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `librarydirector`
--

LOCK TABLES `librarydirector` WRITE;
/*!40000 ALTER TABLE `librarydirector` DISABLE KEYS */;
INSERT INTO `librarydirector` VALUES ('0025','CLH/01/788','1',0,NULL);
/*!40000 ALTER TABLE `librarydirector` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profile`
--

DROP TABLE IF EXISTS `profile`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profile` (
  `Id` varchar(50) NOT NULL,
  `Firstname` varchar(50) DEFAULT NULL,
  `Lastname` varchar(50) DEFAULT NULL,
  `PhoneNumber` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `UserId` varchar(50) DEFAULT NULL,
  `IsDeleted` int DEFAULT NULL,
  `DeletedBy` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profile`
--

LOCK TABLES `profile` WRITE;
/*!40000 ALTER TABLE `profile` DISABLE KEYS */;
INSERT INTO `profile` VALUES ('1','bayo','mutui','6009900','bayo street','011',0,NULL),('4ffbb70b-b312-4eae-8ca6-9b734cf5caa8','biodun','brown','12876','brown junction','270fc699-1b6b-457d-a28e-41aa454605af',NULL,NULL),('56e87333-1d60-43a8-9d5e-261188a95a3c','banji','lounge','0908877','banjistreet','090a45d6-62be-4b62-96e0-24ba565749e4',NULL,NULL),('5aefaad6-3668-4a71-91b2-cfd7f47f1075','biodun','browm','56446','brown street','df60c878-d878-47a5-a7fe-674e9220e2c7',NULL,NULL),('a0f15759-016b-4c1a-b278-560a096c3378','helen','biggie','6677','helen street','b6301762-a9af-4f8c-bc94-fdb958911bc8',NULL,NULL);
/*!40000 ALTER TABLE `profile` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `Id` varchar(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Description` varchar(50) DEFAULT NULL,
  `IsDeleted` int DEFAULT NULL,
  `DeletedBy` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `Id` varchar(50) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `Rolename` varchar(50) DEFAULT NULL,
  `IsDeleted` int DEFAULT NULL,
  `DeletedBy` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('011','b@yahoo.com','1111','Director',0,NULL),('090a45d6-62be-4b62-96e0-24ba565749e4','banji@yahoo.com','1345','',NULL,NULL),('270fc699-1b6b-457d-a28e-41aa454605af','brown@yahoo.com','8888','',NULL,NULL),('b6301762-a9af-4f8c-bc94-fdb958911bc8','helen@yahoo.com','1789','',NULL,NULL),('df60c878-d878-47a5-a7fe-674e9220e2c7','brwon@yahoo.com','5555','',NULL,NULL);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-13 12:40:12
