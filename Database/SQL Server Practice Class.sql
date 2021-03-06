USE [master]
GO
/****** Object:  Database [database_PracticeClass]    Script Date: 24/08/1398 05:46:15 ب.ظ ******/
CREATE DATABASE [database_PracticeClass]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DataBasePracticeClass', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DataBasePracticeClass.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DataBasePracticeClass_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DataBasePracticeClass_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [database_PracticeClass] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [database_PracticeClass].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [database_PracticeClass] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [database_PracticeClass] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [database_PracticeClass] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [database_PracticeClass] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [database_PracticeClass] SET ARITHABORT OFF 
GO
ALTER DATABASE [database_PracticeClass] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [database_PracticeClass] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [database_PracticeClass] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [database_PracticeClass] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [database_PracticeClass] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [database_PracticeClass] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [database_PracticeClass] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [database_PracticeClass] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [database_PracticeClass] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [database_PracticeClass] SET  DISABLE_BROKER 
GO
ALTER DATABASE [database_PracticeClass] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [database_PracticeClass] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [database_PracticeClass] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [database_PracticeClass] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [database_PracticeClass] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [database_PracticeClass] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [database_PracticeClass] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [database_PracticeClass] SET RECOVERY FULL 
GO
ALTER DATABASE [database_PracticeClass] SET  MULTI_USER 
GO
ALTER DATABASE [database_PracticeClass] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [database_PracticeClass] SET DB_CHAINING OFF 
GO
ALTER DATABASE [database_PracticeClass] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [database_PracticeClass] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [database_PracticeClass] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'database_PracticeClass', N'ON'
GO
ALTER DATABASE [database_PracticeClass] SET QUERY_STORE = OFF
GO
USE [database_PracticeClass]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [database_PracticeClass]
GO
/****** Object:  Table [dbo].[table_Course]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_Course](
	[idCourse] [char](7) NOT NULL,
	[nameCourse] [varchar](25) NOT NULL,
 CONSTRAINT [PK_table_Course] PRIMARY KEY CLUSTERED 
(
	[idCourse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_Practice]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_Practice](
	[partPractice] [smallint] NOT NULL,
	[numberPractice] [smallint] NOT NULL,
	[linkPractice] [text] NULL,
	[termPracticeClass] [bit] NOT NULL,
	[yearYearPracticeClass] [char](5) NOT NULL,
	[groupeNumberPracticeClass] [smallint] NOT NULL,
	[idUploader] [char](10) NULL,
 CONSTRAINT [PK_table_Practice] PRIMARY KEY CLUSTERED 
(
	[partPractice] ASC,
	[numberPractice] ASC,
	[termPracticeClass] ASC,
	[yearYearPracticeClass] ASC,
	[groupeNumberPracticeClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_PracticeClass]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_PracticeClass](
	[groupeNumberPracticeClass] [smallint] NOT NULL,
	[termPracticeClass] [bit] NOT NULL,
	[yearYearPracticeClass] [char](5) NOT NULL,
	[idCourse] [char](7) NULL,
	[idProfessor] [char](10) NULL,
	[idTA] [char](10) NULL,
 CONSTRAINT [PK_table_PracticeClass] PRIMARY KEY CLUSTERED 
(
	[groupeNumberPracticeClass] ASC,
	[yearYearPracticeClass] ASC,
	[termPracticeClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_PracticeStudent]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_PracticeStudent](
	[idStudent] [char](10) NOT NULL,
	[partPractice] [smallint] NOT NULL,
	[numberPractice] [smallint] NOT NULL,
	[termPracticeClass] [bit] NOT NULL,
	[yearYearPracticeClass] [char](5) NOT NULL,
	[groupeNumberPracticeClass] [smallint] NOT NULL,
	[gradePracticeStudent] [smallint] NULL,
	[linkSolvedPractice] [text] NOT NULL,
	[checkISchecked] [bit] NULL,
	[timePracticeStudent] [datetime] NOT NULL,
 CONSTRAINT [PK_table_PracticeStudent] PRIMARY KEY CLUSTERED 
(
	[idStudent] ASC,
	[partPractice] ASC,
	[numberPractice] ASC,
	[termPracticeClass] ASC,
	[yearYearPracticeClass] ASC,
	[groupeNumberPracticeClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_Professor]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_Professor](
	[idProfessor] [char](10) NOT NULL,
	[connectionInfo] [text] NULL,
 CONSTRAINT [PK_table_Professor] PRIMARY KEY CLUSTERED 
(
	[idProfessor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_Quiz]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_Quiz](
	[numberQuiz] [smallint] NOT NULL,
	[dateQuiz] [date] NULL,
	[termPracticeClass] [bit] NOT NULL,
	[yearYearPracticeClass] [char](5) NOT NULL,
	[groupeNumberPracticeClass] [smallint] NOT NULL,
 CONSTRAINT [PK_table_Quiz] PRIMARY KEY CLUSTERED 
(
	[numberQuiz] ASC,
	[termPracticeClass] ASC,
	[yearYearPracticeClass] ASC,
	[groupeNumberPracticeClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_QuizStudent]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_QuizStudent](
	[numberQuiz] [smallint] NOT NULL,
	[idStudent] [char](10) NOT NULL,
	[grade] [smallint] NULL,
	[termPracticeClass] [bit] NOT NULL,
	[yearYearPracticeClass] [char](5) NOT NULL,
	[groupeNumberPracticeClass] [smallint] NOT NULL,
 CONSTRAINT [PK_table_QuizStudent] PRIMARY KEY CLUSTERED 
(
	[numberQuiz] ASC,
	[idStudent] ASC,
	[termPracticeClass] ASC,
	[yearYearPracticeClass] ASC,
	[groupeNumberPracticeClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_Resource]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_Resource](
	[nameResource] [varchar](25) NULL,
	[linkResource] [text] NULL,
	[idCourse] [char](7) NOT NULL,
	[idProfessor] [char](10) NULL,
	[numberResource] [smallint] NOT NULL,
 CONSTRAINT [PK_table_Resource] PRIMARY KEY CLUSTERED 
(
	[idCourse] ASC,
	[numberResource] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_Student]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_Student](
	[idStudent] [char](10) NOT NULL,
 CONSTRAINT [PK_tableStudent] PRIMARY KEY CLUSTERED 
(
	[idStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_StudentPracticeClass]    Script Date: 24/08/1398 05:46:16 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_StudentPracticeClass](
	[grade] [smallint] NULL,
	[termPracticeClass] [bit] NOT NULL,
	[yearYearPracticeClass] [char](5) NOT NULL,
	[groupeNumberPracticeClass] [smallint] NOT NULL,
	[idStudent] [char](10) NOT NULL,
 CONSTRAINT [PK_table_StudentPracticeClass] PRIMARY KEY CLUSTERED 
(
	[termPracticeClass] ASC,
	[yearYearPracticeClass] ASC,
	[groupeNumberPracticeClass] ASC,
	[idStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_User]    Script Date: 24/08/1398 05:46:17 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_User](
	[idUser] [char](10) NOT NULL,
	[firstNameUser] [varchar](25) NOT NULL,
	[lastNameUser] [varchar](25) NOT NULL,
	[password] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tableUser] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__tableUse__6E2DBEDEA81C8942] UNIQUE NONCLUSTERED 
(
	[password] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[table_User] ADD  CONSTRAINT [DF_table_User_lastNameUser]  DEFAULT ('') FOR [lastNameUser]
GO
ALTER TABLE [dbo].[table_Practice]  WITH CHECK ADD  CONSTRAINT [relationship_PracticeClassPractice] FOREIGN KEY([groupeNumberPracticeClass], [yearYearPracticeClass], [termPracticeClass])
REFERENCES [dbo].[table_PracticeClass] ([groupeNumberPracticeClass], [yearYearPracticeClass], [termPracticeClass])
GO
ALTER TABLE [dbo].[table_Practice] CHECK CONSTRAINT [relationship_PracticeClassPractice]
GO
ALTER TABLE [dbo].[table_Practice]  WITH CHECK ADD  CONSTRAINT [relationship_UserPractice] FOREIGN KEY([idUploader])
REFERENCES [dbo].[table_User] ([idUser])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_Practice] CHECK CONSTRAINT [relationship_UserPractice]
GO
ALTER TABLE [dbo].[table_PracticeClass]  WITH CHECK ADD  CONSTRAINT [relationship_CoursePracticeClass] FOREIGN KEY([idCourse])
REFERENCES [dbo].[table_Course] ([idCourse])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_PracticeClass] CHECK CONSTRAINT [relationship_CoursePracticeClass]
GO
ALTER TABLE [dbo].[table_PracticeClass]  WITH CHECK ADD  CONSTRAINT [relationship_ProfessorPracticeClass] FOREIGN KEY([idProfessor])
REFERENCES [dbo].[table_Professor] ([idProfessor])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_PracticeClass] CHECK CONSTRAINT [relationship_ProfessorPracticeClass]
GO
ALTER TABLE [dbo].[table_PracticeClass]  WITH CHECK ADD  CONSTRAINT [relationship_StudentPracticeClass] FOREIGN KEY([idTA])
REFERENCES [dbo].[table_Student] ([idStudent])
GO
ALTER TABLE [dbo].[table_PracticeClass] CHECK CONSTRAINT [relationship_StudentPracticeClass]
GO
ALTER TABLE [dbo].[table_PracticeStudent]  WITH CHECK ADD  CONSTRAINT [relationship_PracticePracticeStudent] FOREIGN KEY([partPractice], [numberPractice], [termPracticeClass], [yearYearPracticeClass], [groupeNumberPracticeClass])
REFERENCES [dbo].[table_Practice] ([partPractice], [numberPractice], [termPracticeClass], [yearYearPracticeClass], [groupeNumberPracticeClass])
GO
ALTER TABLE [dbo].[table_PracticeStudent] CHECK CONSTRAINT [relationship_PracticePracticeStudent]
GO
ALTER TABLE [dbo].[table_PracticeStudent]  WITH CHECK ADD  CONSTRAINT [relationship_StudentPracticeStudent] FOREIGN KEY([idStudent])
REFERENCES [dbo].[table_Student] ([idStudent])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_PracticeStudent] CHECK CONSTRAINT [relationship_StudentPracticeStudent]
GO
ALTER TABLE [dbo].[table_Professor]  WITH CHECK ADD  CONSTRAINT [relationship_UserProfessor] FOREIGN KEY([idProfessor])
REFERENCES [dbo].[table_User] ([idUser])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_Professor] CHECK CONSTRAINT [relationship_UserProfessor]
GO
ALTER TABLE [dbo].[table_Quiz]  WITH CHECK ADD  CONSTRAINT [relationship_QuizPracticeClass] FOREIGN KEY([groupeNumberPracticeClass], [yearYearPracticeClass], [termPracticeClass])
REFERENCES [dbo].[table_PracticeClass] ([groupeNumberPracticeClass], [yearYearPracticeClass], [termPracticeClass])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_Quiz] CHECK CONSTRAINT [relationship_QuizPracticeClass]
GO
ALTER TABLE [dbo].[table_QuizStudent]  WITH CHECK ADD  CONSTRAINT [relationship_QuizStudentQuiz] FOREIGN KEY([numberQuiz], [termPracticeClass], [yearYearPracticeClass], [groupeNumberPracticeClass])
REFERENCES [dbo].[table_Quiz] ([numberQuiz], [termPracticeClass], [yearYearPracticeClass], [groupeNumberPracticeClass])
GO
ALTER TABLE [dbo].[table_QuizStudent] CHECK CONSTRAINT [relationship_QuizStudentQuiz]
GO
ALTER TABLE [dbo].[table_QuizStudent]  WITH CHECK ADD  CONSTRAINT [relationship_QuizStudentStudent] FOREIGN KEY([idStudent])
REFERENCES [dbo].[table_Student] ([idStudent])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_QuizStudent] CHECK CONSTRAINT [relationship_QuizStudentStudent]
GO
ALTER TABLE [dbo].[table_Resource]  WITH CHECK ADD  CONSTRAINT [relationship_CourseResource] FOREIGN KEY([idCourse])
REFERENCES [dbo].[table_Course] ([idCourse])
GO
ALTER TABLE [dbo].[table_Resource] CHECK CONSTRAINT [relationship_CourseResource]
GO
ALTER TABLE [dbo].[table_Resource]  WITH CHECK ADD  CONSTRAINT [relationship_ResourceProfessor] FOREIGN KEY([idProfessor])
REFERENCES [dbo].[table_Professor] ([idProfessor])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_Resource] CHECK CONSTRAINT [relationship_ResourceProfessor]
GO
ALTER TABLE [dbo].[table_Student]  WITH CHECK ADD  CONSTRAINT [relationship_Userstudent] FOREIGN KEY([idStudent])
REFERENCES [dbo].[table_User] ([idUser])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[table_Student] CHECK CONSTRAINT [relationship_Userstudent]
GO
ALTER TABLE [dbo].[table_StudentPracticeClass]  WITH CHECK ADD  CONSTRAINT [relationship_PracticeClassStudentPracticeClass] FOREIGN KEY([groupeNumberPracticeClass], [yearYearPracticeClass], [termPracticeClass])
REFERENCES [dbo].[table_PracticeClass] ([groupeNumberPracticeClass], [yearYearPracticeClass], [termPracticeClass])
GO
ALTER TABLE [dbo].[table_StudentPracticeClass] CHECK CONSTRAINT [relationship_PracticeClassStudentPracticeClass]
GO
ALTER TABLE [dbo].[table_StudentPracticeClass]  WITH CHECK ADD  CONSTRAINT [relationship_StudentStudentPracticeClass] FOREIGN KEY([idStudent])
REFERENCES [dbo].[table_Student] ([idStudent])
GO
ALTER TABLE [dbo].[table_StudentPracticeClass] CHECK CONSTRAINT [relationship_StudentStudentPracticeClass]
GO
ALTER TABLE [dbo].[table_PracticeClass]  WITH CHECK ADD CHECK  (([termPracticeClass]=(0) OR [termPracticeClass]=(1)))
GO
ALTER TABLE [dbo].[table_PracticeClass]  WITH CHECK ADD CHECK  (([yearyearpracticeclass] like '__-__'))
GO
ALTER TABLE [dbo].[table_QuizStudent]  WITH CHECK ADD CHECK  (([grade]>=(0) AND [grade]<=(100)))
GO
ALTER TABLE [dbo].[table_StudentPracticeClass]  WITH CHECK ADD CHECK  (([grade]>=(0) AND [grade]<=(100)))
GO
ALTER TABLE [dbo].[table_User]  WITH CHECK ADD  CONSTRAINT [CK__table_Use__passw__5BE2A6F2] CHECK  (([password] like '________%'))
GO
ALTER TABLE [dbo].[table_User] CHECK CONSTRAINT [CK__table_Use__passw__5BE2A6F2]
GO
USE [master]
GO
ALTER DATABASE [database_PracticeClass] SET  READ_WRITE 
GO
