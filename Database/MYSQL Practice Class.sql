-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 25, 2019 at 11:08 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_practiceclass`
--
CREATE DATABASE IF NOT EXISTS `database_practiceclass` DEFAULT CHARACTER SET utf8 COLLATE utf8_persian_ci;
USE `database_practiceclass`;

-- --------------------------------------------------------

--
-- Table structure for table `table_course`
--

CREATE TABLE `table_course` (
  `idCourse` char(7) COLLATE utf8_persian_ci NOT NULL,
  `nameCourse` varchar(20) COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_course`
--

INSERT INTO `table_course` (`idCourse`, `nameCourse`) VALUES
('2', 'pishrafte'),
('3', 'sakhteman'),
('4', 'OS'),
('5', 'nazrieh');

-- --------------------------------------------------------

--
-- Table structure for table `table_practice`
--

CREATE TABLE `table_practice` (
  `idTable` int(11) NOT NULL,
  `numberPractice` smallint(6) NOT NULL,
  `partPractice` smallint(6) NOT NULL,
  `linkPractice` text COLLATE utf8_persian_ci DEFAULT NULL,
  `idUploader` char(10) COLLATE utf8_persian_ci DEFAULT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `numberYearFromStart` smallint(6) NOT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_practice`
--

INSERT INTO `table_practice` (`idTable`, `numberPractice`, `partPractice`, `linkPractice`, `idUploader`, `groupeNumberPracticeClass`, `termPracticeClass`, `numberYearFromStart`, `deleted`) VALUES
(1, 1, 1, NULL, '380395', 2, b'1', 98, 0),
(2, 2, 1, NULL, '961845126', 1, b'1', 96, 1);

--
-- Triggers `table_practice`
--
DELIMITER $$
CREATE TRIGGER `trigger_softDelete_table_practice` BEFORE UPDATE ON `table_practice` FOR EACH ROW UPDATE table_practicestudent
SET `deleted` = NEW.deleted
WHERE  numberPractice = OLD.numberPractice and partPractice = OLD.partPractice and  groupeNumberPracticeClass = OLD.groupeNumberPracticeClass AND
termPracticeClass = OLD.termPracticeClass AND numberYearFromStart = OLD.numberYearFromStart
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `table_practiceclass`
--

CREATE TABLE `table_practiceclass` (
  `idTable` int(11) NOT NULL,
  `status` bit(1) DEFAULT NULL,
  `idCourse` char(7) COLLATE utf8_persian_ci DEFAULT NULL,
  `idProfessor` char(10) COLLATE utf8_persian_ci DEFAULT NULL,
  `idTA` char(10) COLLATE utf8_persian_ci DEFAULT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `numberYearFromStart` smallint(6) NOT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_practiceclass`
--

INSERT INTO `table_practiceclass` (`idTable`, `status`, `idCourse`, `idProfessor`, `idTA`, `groupeNumberPracticeClass`, `termPracticeClass`, `numberYearFromStart`, `deleted`) VALUES
(1, NULL, '3', '380460', '222', 1, b'1', 96, 0),
(2, NULL, '2', '380491', '9418451027', 2, b'1', 98, 0);

--
-- Triggers `table_practiceclass`
--
DELIMITER $$
CREATE TRIGGER `trigger_softDelete_table_practiceClass` AFTER UPDATE ON `table_practiceclass` FOR EACH ROW BEGIN
				
UPDATE table_practice
SET `deleted` = NEW.deleted
WHERE    groupeNumberPracticeClass = OLD.groupeNumberPracticeClass AND
termPracticeClass = OLD.termPracticeClass AND
numberYearFromStart = OLD.`numberYearFromStart`
; 

UPDATE table_studentpracticeclass
SET `deleted` = NEW.deleted
WHERE    groupeNumberPracticeClass = OLD.groupeNumberPracticeClass AND
termPracticeClass = OLD.termPracticeClass AND numberYearFromStart = OLD.numberYearFromStart ; 


UPDATE table_quiz
SET `deleted` = NEW.deleted
WHERE    groupeNumberPracticeClass = OLD.groupeNumberPracticeClass AND
termPracticeClass = OLD.termPracticeClass AND numberYearFromStart = OLD.numberYearFromStart ; 



       END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `table_practicestudent`
--

CREATE TABLE `table_practicestudent` (
  `idTable` int(11) NOT NULL,
  `numberPractice` smallint(6) NOT NULL,
  `partPractice` smallint(6) NOT NULL,
  `idStudent` char(10) COLLATE utf8_persian_ci NOT NULL,
  `linkSolvedPractice` text COLLATE utf8_persian_ci NOT NULL,
  `timePracticeStudent` datetime NOT NULL,
  `checked` bit(1) NOT NULL,
  `gradePracticeStudent` smallint(6) DEFAULT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `numberYearFromStart` smallint(6) NOT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_professor`
--

CREATE TABLE `table_professor` (
  `idProfessor` char(10) COLLATE utf8_persian_ci NOT NULL,
  `isPrime` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_professor`
--

INSERT INTO `table_professor` (`idProfessor`, `isPrime`) VALUES
('380395', b'0'),
('380460', b'0'),
('380491', b'0');

-- --------------------------------------------------------

--
-- Table structure for table `table_quiz`
--

CREATE TABLE `table_quiz` (
  `idTable` int(11) NOT NULL,
  `numberQuiz` smallint(6) NOT NULL,
  `dateQuiz` date DEFAULT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `numberYearFromStart` smallint(6) NOT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_quiz`
--

INSERT INTO `table_quiz` (`idTable`, `numberQuiz`, `dateQuiz`, `groupeNumberPracticeClass`, `termPracticeClass`, `numberYearFromStart`, `deleted`) VALUES
(1, 1, '2019-12-17', 1, b'1', 96, 0),
(2, 2, '2019-12-25', 2, b'1', 98, 0);

--
-- Triggers `table_quiz`
--
DELIMITER $$
CREATE TRIGGER `trigger_softDelete_table_quiz` AFTER UPDATE ON `table_quiz` FOR EACH ROW BEGIN
				
UPDATE table_quizstudent
SET `deleted` = NEW.deleted
WHERE    groupeNumberPracticeClass = OLD.groupeNumberPracticeClass AND
termPracticeClass = OLD.termPracticeClass AND
numberYearFromStart = OLD.`numberYearFromStart` AND numberQuiz = OLD.numberQuiz
; 



       END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `table_quizstudent`
--

CREATE TABLE `table_quizstudent` (
  `idTable` int(11) NOT NULL,
  `numberQuiz` smallint(6) NOT NULL,
  `idStudent` char(10) COLLATE utf8_persian_ci NOT NULL,
  `gradeQuizStudent` smallint(6) DEFAULT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `numberYearFromStart` smallint(6) NOT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_quizstudent`
--

INSERT INTO `table_quizstudent` (`idTable`, `numberQuiz`, `idStudent`, `gradeQuizStudent`, `groupeNumberPracticeClass`, `termPracticeClass`, `numberYearFromStart`, `deleted`) VALUES
(2, 2, '222', 100, 1, b'1', 98, 0);

-- --------------------------------------------------------

--
-- Table structure for table `table_resource`
--

CREATE TABLE `table_resource` (
  `idTable` int(11) NOT NULL,
  `numberResource` smallint(6) NOT NULL,
  `nameResource` char(50) COLLATE utf8_persian_ci NOT NULL,
  `linkResource` text COLLATE utf8_persian_ci DEFAULT NULL,
  `idCourse` char(7) COLLATE utf8_persian_ci NOT NULL,
  `idProfessor` char(10) COLLATE utf8_persian_ci DEFAULT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_resource`
--

INSERT INTO `table_resource` (`idTable`, `numberResource`, `nameResource`, `linkResource`, `idCourse`, `idProfessor`, `deleted`) VALUES
(2, 2, 'book 1 - pishrafteh', NULL, '2', '380491', 1);

-- --------------------------------------------------------

--
-- Table structure for table `table_student`
--

CREATE TABLE `table_student` (
  `idStudent` char(10) COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_student`
--

INSERT INTO `table_student` (`idStudent`) VALUES
('222'),
('9418451027'),
('961845102'),
('961845126');

-- --------------------------------------------------------

--
-- Table structure for table `table_studentpracticeclass`
--

CREATE TABLE `table_studentpracticeclass` (
  `idTable` int(11) NOT NULL,
  `idStudent` char(10) COLLATE utf8_persian_ci NOT NULL,
  `gradePracticeClassStudent` float DEFAULT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `numberYearFromStart` smallint(6) NOT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT 0,
  `checked` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_studentpracticeclass`
--

INSERT INTO `table_studentpracticeclass` (`idTable`, `idStudent`, `gradePracticeClassStudent`, `groupeNumberPracticeClass`, `termPracticeClass`, `numberYearFromStart`, `deleted`, `checked`) VALUES
(2, '222', 10, 1, b'1', 96, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `table_user`
--

CREATE TABLE `table_user` (
  `idUser` char(10) COLLATE utf8_persian_ci NOT NULL,
  `firstNameUser` varchar(25) COLLATE utf8_persian_ci NOT NULL,
  `lastNameUser` varchar(25) COLLATE utf8_persian_ci NOT NULL,
  `password` varchar(30) COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `table_user`
--

INSERT INTO `table_user` (`idUser`, `firstNameUser`, `lastNameUser`, `password`) VALUES
('222', 'sss', 'ddd', ''),
('380395', 'babak', 'ranjbar', '123456'),
('380460', 'mehdi', 'enayat zare', '123456'),
('380491', 'mousa', 'mousa zadeh', '12345'),
('9418451027', 'ahmad', 'ameli', '1234'),
('961845102', 'reza', 'adibi', ''),
('961845126', 'MR', 'ameli', '1234');

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewadminlistprofessor`
-- (See below for the actual view)
--
CREATE TABLE `viewadminlistprofessor` (
`idUser` char(10)
,`firstNameUser` varchar(25)
,`lastNameUser` varchar(25)
,`password` varchar(30)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewadminliststudent`
-- (See below for the actual view)
--
CREATE TABLE `viewadminliststudent` (
`idUser` char(10)
,`firstNameUser` varchar(25)
,`lastNameUser` varchar(25)
,`password` varchar(30)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewlistclass`
-- (See below for the actual view)
--
CREATE TABLE `viewlistclass` (
`groupeNumberPracticeClass` smallint(6)
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`idProfessor` char(10)
,`prffn` varchar(25)
,`pfln` varchar(25)
,`idTA` char(10)
,`tafn` varchar(25)
,`taln` varchar(25)
,`status` bit(1)
,`nameCourse` varchar(20)
,`AVG(c.gradePracticeClassStudent)` double
,`classDel` tinyint(1)
,`stuDel` tinyint(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewlistclassmember`
-- (See below for the actual view)
--
CREATE TABLE `viewlistclassmember` (
`gradePracticeClassStudent` float
,`groupeNumberPracticeClass` smallint(6)
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`idStudent` char(10)
,`stufn` varchar(25)
,`stuln` varchar(25)
,`stuDel` tinyint(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewlistcourseresourse`
-- (See below for the actual view)
--
CREATE TABLE `viewlistcourseresourse` (
`idCourse` char(7)
,`nameCourse` varchar(20)
,`nameResource` char(50)
,`linkResource` text
,`numberResource` smallint(6)
,`deleted` tinyint(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewlistpractice`
-- (See below for the actual view)
--
CREATE TABLE `viewlistpractice` (
`partPractice` smallint(6)
,`numberPractice` smallint(6)
,`linkPractice` text
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`groupeNumberPracticeClass` smallint(6)
,`AVG(b.gradePracticeStudent)` decimal(9,4)
,`pracDel` tinyint(1)
,`pracStuDel` tinyint(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewlistpracticesolved`
-- (See below for the actual view)
--
CREATE TABLE `viewlistpracticesolved` (
`idStudent` char(10)
,`firstNameUser` varchar(25)
,`lastNameUser` varchar(25)
,`partPractice` smallint(6)
,`numberPractice` smallint(6)
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`groupeNumberPracticeClass` smallint(6)
,`gradePracticeStudent` smallint(6)
,`linkSolvedPractice` text
,`timePracticeStudent` datetime
,`checked` bit(1)
,`deleted` tinyint(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewlistquiz`
-- (See below for the actual view)
--
CREATE TABLE `viewlistquiz` (
`numberQuiz` smallint(6)
,`dateQuiz` date
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`groupeNumberPracticeClass` smallint(6)
,`avg(b.gradeQuizStudent)` decimal(9,4)
,`quizdDel` tinyint(1)
,`quizStuDel` tinyint(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewlistquizstudent`
-- (See below for the actual view)
--
CREATE TABLE `viewlistquizstudent` (
`numberQuiz` smallint(6)
,`dateQuiz` date
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`groupeNumberPracticeClass` smallint(6)
,`gradeQuizStudent` smallint(6)
,`idUser` char(10)
,`firstNameUser` varchar(25)
,`lastNameUser` varchar(25)
,`quizdDel` tinyint(1)
,`quizStuDel` tinyint(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewstudentlistclass`
-- (See below for the actual view)
--
CREATE TABLE `viewstudentlistclass` (
`gradePracticeClassStudent` float
,`groupeNumberPracticeClass` smallint(6)
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`idStudent` char(10)
,`idCourse` char(7)
,`nameCourse` varchar(20)
,`idProfessor` char(10)
,`proffnam` varchar(25)
,`proflnam` varchar(25)
,`idTA` char(10)
,`tafn` varchar(25)
,`talnm` varchar(25)
,`status` bit(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewstudentlistpractice`
-- (See below for the actual view)
--
CREATE TABLE `viewstudentlistpractice` (
`partPractice` smallint(6)
,`numberPractice` smallint(6)
,`linkPractice` text
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`groupeNumberPracticeClass` smallint(6)
,`gradePracticeStudent` smallint(6)
,`idStudent` char(10)
,`linkSolvedPractice` text
,`timePracticeStudent` datetime
,`checked` bit(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewstudentlistquiz`
-- (See below for the actual view)
--
CREATE TABLE `viewstudentlistquiz` (
`numberQuiz` smallint(6)
,`dateQuiz` date
,`termPracticeClass` bit(1)
,`numberYearFromStart` smallint(6)
,`groupeNumberPracticeClass` smallint(6)
,`idStudent` char(10)
,`gradeQuizStudent` smallint(6)
);

-- --------------------------------------------------------

--
-- Structure for view `viewadminlistprofessor`
--
DROP TABLE IF EXISTS `viewadminlistprofessor`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewadminlistprofessor`  AS  select `b`.`idUser` AS `idUser`,`b`.`firstNameUser` AS `firstNameUser`,`b`.`lastNameUser` AS `lastNameUser`,`b`.`password` AS `password` from (`table_professor` `a` join `table_user` `b` on(`a`.`idProfessor` = `b`.`idUser`)) ;

-- --------------------------------------------------------

--
-- Structure for view `viewadminliststudent`
--
DROP TABLE IF EXISTS `viewadminliststudent`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewadminliststudent`  AS  select `b`.`idUser` AS `idUser`,`b`.`firstNameUser` AS `firstNameUser`,`b`.`lastNameUser` AS `lastNameUser`,`b`.`password` AS `password` from (`table_student` `a` join `table_user` `b` on(`a`.`idStudent` = `b`.`idUser`)) ;

-- --------------------------------------------------------

--
-- Structure for view `viewlistclass`
--
DROP TABLE IF EXISTS `viewlistclass`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewlistclass`  AS  select `a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`idProfessor` AS `idProfessor`,`d`.`firstNameUser` AS `prffn`,`d`.`lastNameUser` AS `pfln`,`a`.`idTA` AS `idTA`,`e`.`firstNameUser` AS `tafn`,`e`.`lastNameUser` AS `taln`,`a`.`status` AS `status`,`b`.`nameCourse` AS `nameCourse`,avg(`c`.`gradePracticeClassStudent`) AS `AVG(c.gradePracticeClassStudent)`,`a`.`deleted` AS `classDel`,`c`.`deleted` AS `stuDel` from ((((`table_practiceclass` `a` join `table_course` `b` on(`a`.`idCourse` = `b`.`idCourse`)) join `table_studentpracticeclass` `c` on(`a`.`groupeNumberPracticeClass` = `c`.`groupeNumberPracticeClass` and `a`.`termPracticeClass` = `c`.`termPracticeClass` and `a`.`numberYearFromStart` = `c`.`numberYearFromStart`)) join `table_user` `d` on(`a`.`idProfessor` = `d`.`idUser`)) join `table_user` `e` on(`a`.`idTA` = `e`.`idUser`)) group by `a`.`groupeNumberPracticeClass`,`a`.`termPracticeClass`,`a`.`numberYearFromStart` ;

-- --------------------------------------------------------

--
-- Structure for view `viewlistclassmember`
--
DROP TABLE IF EXISTS `viewlistclassmember`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewlistclassmember`  AS  select `a`.`gradePracticeClassStudent` AS `gradePracticeClassStudent`,`a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`idStudent` AS `idStudent`,`b`.`firstNameUser` AS `stufn`,`b`.`lastNameUser` AS `stuln`,`a`.`deleted` AS `stuDel` from (`table_studentpracticeclass` `a` join `table_user` `b` on(`a`.`idStudent` = `b`.`idUser`)) ;

-- --------------------------------------------------------

--
-- Structure for view `viewlistcourseresourse`
--
DROP TABLE IF EXISTS `viewlistcourseresourse`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewlistcourseresourse`  AS  select `a`.`idCourse` AS `idCourse`,`a`.`nameCourse` AS `nameCourse`,`b`.`nameResource` AS `nameResource`,`b`.`linkResource` AS `linkResource`,`b`.`numberResource` AS `numberResource`,`b`.`deleted` AS `deleted` from (`table_course` `a` join `table_resource` `b` on(`a`.`idCourse` = `b`.`idCourse`)) ;

-- --------------------------------------------------------

--
-- Structure for view `viewlistpractice`
--
DROP TABLE IF EXISTS `viewlistpractice`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewlistpractice`  AS  select `a`.`partPractice` AS `partPractice`,`a`.`numberPractice` AS `numberPractice`,`a`.`linkPractice` AS `linkPractice`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,avg(`b`.`gradePracticeStudent`) AS `AVG(b.gradePracticeStudent)`,`a`.`deleted` AS `pracDel`,`b`.`deleted` AS `pracStuDel` from (`table_practice` `a` join `table_practicestudent` `b` on(`a`.`partPractice` = `b`.`partPractice` and `a`.`numberPractice` = `b`.`numberPractice` and `a`.`termPracticeClass` = `b`.`termPracticeClass` and `a`.`numberYearFromStart` = `b`.`numberYearFromStart` and `a`.`groupeNumberPracticeClass` = `b`.`groupeNumberPracticeClass`)) group by `a`.`groupeNumberPracticeClass`,`a`.`termPracticeClass`,`a`.`numberYearFromStart`,`a`.`partPractice`,`a`.`numberPractice` ;

-- --------------------------------------------------------

--
-- Structure for view `viewlistpracticesolved`
--
DROP TABLE IF EXISTS `viewlistpracticesolved`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewlistpracticesolved`  AS  select `a`.`idStudent` AS `idStudent`,`b`.`firstNameUser` AS `firstNameUser`,`b`.`lastNameUser` AS `lastNameUser`,`a`.`partPractice` AS `partPractice`,`a`.`numberPractice` AS `numberPractice`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,`a`.`gradePracticeStudent` AS `gradePracticeStudent`,`a`.`linkSolvedPractice` AS `linkSolvedPractice`,`a`.`timePracticeStudent` AS `timePracticeStudent`,`a`.`checked` AS `checked`,`a`.`deleted` AS `deleted` from (`table_practicestudent` `a` join `table_user` `b` on(`a`.`idStudent` = `b`.`idUser`)) ;

-- --------------------------------------------------------

--
-- Structure for view `viewlistquiz`
--
DROP TABLE IF EXISTS `viewlistquiz`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewlistquiz`  AS  select `a`.`numberQuiz` AS `numberQuiz`,`a`.`dateQuiz` AS `dateQuiz`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,avg(`b`.`gradeQuizStudent`) AS `avg(b.gradeQuizStudent)`,`a`.`deleted` AS `quizdDel`,`b`.`deleted` AS `quizStuDel` from (`table_quiz` `a` join `table_quizstudent` `b` on(`a`.`numberQuiz` = `b`.`numberQuiz` and `a`.`termPracticeClass` = `b`.`termPracticeClass` and `a`.`numberYearFromStart` = `b`.`numberYearFromStart` and `a`.`groupeNumberPracticeClass` = `b`.`groupeNumberPracticeClass`)) group by `a`.`groupeNumberPracticeClass`,`a`.`termPracticeClass`,`a`.`numberYearFromStart`,`a`.`numberQuiz` ;

-- --------------------------------------------------------

--
-- Structure for view `viewlistquizstudent`
--
DROP TABLE IF EXISTS `viewlistquizstudent`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewlistquizstudent`  AS  select `a`.`numberQuiz` AS `numberQuiz`,`a`.`dateQuiz` AS `dateQuiz`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,`b`.`gradeQuizStudent` AS `gradeQuizStudent`,`c`.`idUser` AS `idUser`,`c`.`firstNameUser` AS `firstNameUser`,`c`.`lastNameUser` AS `lastNameUser`,`a`.`deleted` AS `quizdDel`,`b`.`deleted` AS `quizStuDel` from ((`table_quiz` `a` join `table_quizstudent` `b` on(`a`.`numberQuiz` = `b`.`numberQuiz` and `a`.`termPracticeClass` = `b`.`termPracticeClass` and `a`.`numberYearFromStart` = `b`.`numberYearFromStart` and `a`.`groupeNumberPracticeClass` = `b`.`groupeNumberPracticeClass`)) join `table_user` `c` on(`b`.`idStudent` = `c`.`idUser`)) ;

-- --------------------------------------------------------

--
-- Structure for view `viewstudentlistclass`
--
DROP TABLE IF EXISTS `viewstudentlistclass`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewstudentlistclass`  AS  select `a`.`gradePracticeClassStudent` AS `gradePracticeClassStudent`,`a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`idStudent` AS `idStudent`,`b`.`idCourse` AS `idCourse`,`c`.`nameCourse` AS `nameCourse`,`b`.`idProfessor` AS `idProfessor`,`d`.`firstNameUser` AS `proffnam`,`d`.`lastNameUser` AS `proflnam`,`b`.`idTA` AS `idTA`,`e`.`firstNameUser` AS `tafn`,`e`.`lastNameUser` AS `talnm`,`b`.`status` AS `status` from ((((`table_studentpracticeclass` `a` join `table_practiceclass` `b` on(`a`.`groupeNumberPracticeClass` = `b`.`groupeNumberPracticeClass` and `a`.`termPracticeClass` = `b`.`termPracticeClass` and `a`.`numberYearFromStart` = `b`.`numberYearFromStart`)) join `table_course` `c` on(`b`.`idCourse` = `c`.`idCourse`)) join `table_user` `d` on(`d`.`idUser` = `b`.`idProfessor`)) join `table_user` `e` on(`e`.`idUser` = `b`.`idTA`)) where `b`.`deleted` = 0 ;

-- --------------------------------------------------------

--
-- Structure for view `viewstudentlistpractice`
--
DROP TABLE IF EXISTS `viewstudentlistpractice`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewstudentlistpractice`  AS  select `a`.`partPractice` AS `partPractice`,`a`.`numberPractice` AS `numberPractice`,`a`.`linkPractice` AS `linkPractice`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,`b`.`gradePracticeStudent` AS `gradePracticeStudent`,`b`.`idStudent` AS `idStudent`,`b`.`linkSolvedPractice` AS `linkSolvedPractice`,`b`.`timePracticeStudent` AS `timePracticeStudent`,`b`.`checked` AS `checked` from (`table_practicestudent` `b` left join `table_practice` `a` on(`a`.`partPractice` = `b`.`partPractice` and `a`.`numberPractice` = `b`.`numberPractice` and `a`.`termPracticeClass` = `b`.`termPracticeClass` and `a`.`groupeNumberPracticeClass` = `b`.`groupeNumberPracticeClass` and `a`.`numberYearFromStart` = `b`.`numberYearFromStart`)) where `a`.`deleted` = 0 and `b`.`deleted` = 0 ;

-- --------------------------------------------------------

--
-- Structure for view `viewstudentlistquiz`
--
DROP TABLE IF EXISTS `viewstudentlistquiz`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewstudentlistquiz`  AS  select `a`.`numberQuiz` AS `numberQuiz`,`a`.`dateQuiz` AS `dateQuiz`,`a`.`termPracticeClass` AS `termPracticeClass`,`a`.`numberYearFromStart` AS `numberYearFromStart`,`a`.`groupeNumberPracticeClass` AS `groupeNumberPracticeClass`,`b`.`idStudent` AS `idStudent`,`b`.`gradeQuizStudent` AS `gradeQuizStudent` from (`table_quiz` `a` join `table_quizstudent` `b` on(`a`.`numberQuiz` = `b`.`numberQuiz` and `a`.`termPracticeClass` = `b`.`termPracticeClass` and `a`.`numberYearFromStart` = `b`.`numberYearFromStart` and `a`.`groupeNumberPracticeClass` = `b`.`groupeNumberPracticeClass`)) where `a`.`deleted` = 0 and `b`.`deleted` = 0 ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `table_course`
--
ALTER TABLE `table_course`
  ADD PRIMARY KEY (`idCourse`);

--
-- Indexes for table `table_practice`
--
ALTER TABLE `table_practice`
  ADD PRIMARY KEY (`partPractice`,`numberPractice`,`termPracticeClass`,`numberYearFromStart`,`groupeNumberPracticeClass`),
  ADD UNIQUE KEY `idTable` (`idTable`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `numberYearFromStart` (`numberYearFromStart`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`),
  ADD KEY `partPractice` (`partPractice`),
  ADD KEY `numberPractice` (`numberPractice`),
  ADD KEY `idUploader_foreingKey` (`idUploader`);

--
-- Indexes for table `table_practiceclass`
--
ALTER TABLE `table_practiceclass`
  ADD PRIMARY KEY (`groupeNumberPracticeClass`,`termPracticeClass`,`numberYearFromStart`),
  ADD UNIQUE KEY `idTable` (`idTable`),
  ADD KEY `idProfessor` (`idProfessor`),
  ADD KEY `idTA` (`idTA`),
  ADD KEY `idCourse` (`idCourse`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `numberYearFromStart` (`numberYearFromStart`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`);

--
-- Indexes for table `table_practicestudent`
--
ALTER TABLE `table_practicestudent`
  ADD PRIMARY KEY (`idStudent`,`partPractice`,`numberPractice`,`termPracticeClass`,`numberYearFromStart`,`groupeNumberPracticeClass`),
  ADD UNIQUE KEY `idTable` (`idTable`),
  ADD KEY `partPractice` (`partPractice`),
  ADD KEY `numberPractice` (`numberPractice`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `numberYearFromStart` (`numberYearFromStart`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`);

--
-- Indexes for table `table_professor`
--
ALTER TABLE `table_professor`
  ADD PRIMARY KEY (`idProfessor`);

--
-- Indexes for table `table_quiz`
--
ALTER TABLE `table_quiz`
  ADD PRIMARY KEY (`numberQuiz`,`termPracticeClass`,`numberYearFromStart`,`groupeNumberPracticeClass`),
  ADD UNIQUE KEY `idTable` (`idTable`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `numberYearFromStart` (`numberYearFromStart`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`);

--
-- Indexes for table `table_quizstudent`
--
ALTER TABLE `table_quizstudent`
  ADD PRIMARY KEY (`numberQuiz`,`idStudent`,`termPracticeClass`,`numberYearFromStart`,`groupeNumberPracticeClass`),
  ADD UNIQUE KEY `idTable` (`idTable`),
  ADD KEY `idStudent` (`idStudent`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `numberYearFromStart` (`numberYearFromStart`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`);

--
-- Indexes for table `table_resource`
--
ALTER TABLE `table_resource`
  ADD PRIMARY KEY (`idCourse`,`numberResource`),
  ADD UNIQUE KEY `idTable` (`idTable`),
  ADD KEY `table_resource_ibfk_1` (`idProfessor`);

--
-- Indexes for table `table_student`
--
ALTER TABLE `table_student`
  ADD PRIMARY KEY (`idStudent`);

--
-- Indexes for table `table_studentpracticeclass`
--
ALTER TABLE `table_studentpracticeclass`
  ADD PRIMARY KEY (`idStudent`,`termPracticeClass`,`numberYearFromStart`,`groupeNumberPracticeClass`),
  ADD UNIQUE KEY `idTable` (`idTable`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `numberYearFromStart` (`numberYearFromStart`);

--
-- Indexes for table `table_user`
--
ALTER TABLE `table_user`
  ADD PRIMARY KEY (`idUser`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `table_practice`
--
ALTER TABLE `table_practice`
  MODIFY `idTable` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `table_practiceclass`
--
ALTER TABLE `table_practiceclass`
  MODIFY `idTable` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `table_practicestudent`
--
ALTER TABLE `table_practicestudent`
  MODIFY `idTable` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `table_quiz`
--
ALTER TABLE `table_quiz`
  MODIFY `idTable` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `table_quizstudent`
--
ALTER TABLE `table_quizstudent`
  MODIFY `idTable` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `table_resource`
--
ALTER TABLE `table_resource`
  MODIFY `idTable` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `table_studentpracticeclass`
--
ALTER TABLE `table_studentpracticeclass`
  MODIFY `idTable` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `table_practice`
--
ALTER TABLE `table_practice`
  ADD CONSTRAINT `idUploader_foreingKey` FOREIGN KEY (`idUploader`) REFERENCES `table_user` (`idUser`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practice_ibfk_1` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_practiceclass` (`termPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practice_ibfk_2` FOREIGN KEY (`numberYearFromStart`) REFERENCES `table_practiceclass` (`numberYearFromStart`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practice_ibfk_3` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_practiceclass` (`groupeNumberPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `table_practiceclass`
--
ALTER TABLE `table_practiceclass`
  ADD CONSTRAINT `fk_idProfessor2` FOREIGN KEY (`idProfessor`) REFERENCES `table_professor` (`idProfessor`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_table_practiceclass_idTA` FOREIGN KEY (`idTA`) REFERENCES `table_student` (`idStudent`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practiceclass_ibfk_3` FOREIGN KEY (`idCourse`) REFERENCES `table_course` (`idCourse`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `table_practicestudent`
--
ALTER TABLE `table_practicestudent`
  ADD CONSTRAINT `table_practicestudent_ibfk_1` FOREIGN KEY (`idStudent`) REFERENCES `table_student` (`idStudent`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practicestudent_ibfk_2` FOREIGN KEY (`partPractice`) REFERENCES `table_practice` (`partPractice`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practicestudent_ibfk_3` FOREIGN KEY (`numberPractice`) REFERENCES `table_practice` (`numberPractice`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practicestudent_ibfk_4` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_practice` (`termPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practicestudent_ibfk_5` FOREIGN KEY (`numberYearFromStart`) REFERENCES `table_practice` (`numberYearFromStart`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practicestudent_ibfk_6` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_practice` (`groupeNumberPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `table_professor`
--
ALTER TABLE `table_professor`
  ADD CONSTRAINT `table_professor_ibfk_1` FOREIGN KEY (`idProfessor`) REFERENCES `table_user` (`idUser`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `table_quiz`
--
ALTER TABLE `table_quiz`
  ADD CONSTRAINT `table_quiz_ibfk_1` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_practiceclass` (`termPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quiz_ibfk_2` FOREIGN KEY (`numberYearFromStart`) REFERENCES `table_practiceclass` (`numberYearFromStart`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quiz_ibfk_3` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_practiceclass` (`groupeNumberPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `table_quizstudent`
--
ALTER TABLE `table_quizstudent`
  ADD CONSTRAINT `table_quizstudent_ibfk_1` FOREIGN KEY (`numberQuiz`) REFERENCES `table_quiz` (`numberQuiz`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quizstudent_ibfk_2` FOREIGN KEY (`idStudent`) REFERENCES `table_student` (`idStudent`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quizstudent_ibfk_3` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_quiz` (`termPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quizstudent_ibfk_4` FOREIGN KEY (`numberYearFromStart`) REFERENCES `table_quiz` (`numberYearFromStart`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quizstudent_ibfk_5` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_quiz` (`groupeNumberPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `table_resource`
--
ALTER TABLE `table_resource`
  ADD CONSTRAINT `fk_idProfessor` FOREIGN KEY (`idProfessor`) REFERENCES `table_professor` (`idProfessor`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_resource_ibfk_2` FOREIGN KEY (`idCourse`) REFERENCES `table_course` (`idCourse`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `table_student`
--
ALTER TABLE `table_student`
  ADD CONSTRAINT `table_student_ibfk_1` FOREIGN KEY (`idStudent`) REFERENCES `table_user` (`idUser`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `table_studentpracticeclass`
--
ALTER TABLE `table_studentpracticeclass`
  ADD CONSTRAINT `table_studentpracticeclass_ibfk_1` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_practiceclass` (`groupeNumberPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_studentpracticeclass_ibfk_2` FOREIGN KEY (`idStudent`) REFERENCES `table_student` (`idStudent`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_studentpracticeclass_ibfk_3` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_practiceclass` (`termPracticeClass`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `table_studentpracticeclass_ibfk_4` FOREIGN KEY (`numberYearFromStart`) REFERENCES `table_practiceclass` (`numberYearFromStart`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
