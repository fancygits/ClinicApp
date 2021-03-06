USE [master]
GO
/****** Object:  Database [CS6232-g1]    Script Date: 4/29/2019 9:20:05 PM ******/
CREATE DATABASE [CS6232-g1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CS6232-g1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CS6232-g1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CS6232-g1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CS6232-g1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CS6232-g1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CS6232-g1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CS6232-g1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CS6232-g1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CS6232-g1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CS6232-g1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CS6232-g1] SET ARITHABORT OFF 
GO
ALTER DATABASE [CS6232-g1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CS6232-g1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CS6232-g1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CS6232-g1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CS6232-g1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CS6232-g1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CS6232-g1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CS6232-g1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CS6232-g1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CS6232-g1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CS6232-g1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CS6232-g1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CS6232-g1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CS6232-g1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CS6232-g1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CS6232-g1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CS6232-g1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CS6232-g1] SET RECOVERY FULL 
GO
ALTER DATABASE [CS6232-g1] SET  MULTI_USER 
GO
ALTER DATABASE [CS6232-g1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CS6232-g1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CS6232-g1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CS6232-g1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CS6232-g1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CS6232-g1] SET QUERY_STORE = OFF
GO
USE [CS6232-g1]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 4/29/2019 9:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[administratorID] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[administratorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[appointmentID] [int] IDENTITY(1,1) NOT NULL,
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[apptDatetime] [datetime] NOT NULL,
	[reasonForVisit] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credential]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credential](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[role] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Credentials] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[doctorID] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorSpecialty]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorSpecialty](
	[doctorID] [int] NOT NULL,
	[specialtyName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DoctorSpecialty] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC,
	[specialtyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTest]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTest](
	[testCode] [int] IDENTITY(1,1) NOT NULL,
	[testName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LabTest] PRIMARY KEY CLUSTERED 
(
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[nurseID] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_Nurse] PRIMARY KEY CLUSTERED 
(
	[nurseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[patientID] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[personID] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[birthDate] [date] NOT NULL,
	[SSN] [char](11) NOT NULL,
	[gender] [char](1) NOT NULL,
	[streetAddress] [varchar](200) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[state] [char](2) NOT NULL,
	[postCode] [varchar](10) NOT NULL,
	[phoneNumber] [char](10) NOT NULL,
	[username] [varchar](50) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestOrdered]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestOrdered](
	[appointmentID] [int] NOT NULL,
	[testCode] [int] NOT NULL,
	[testDate] [datetime] NOT NULL,
	[result] [bit] NULL,
	[resultDetails] [varchar](200) NULL,
 CONSTRAINT [PK_TestOrdered] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC,
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[appointmentID] [int] NOT NULL,
	[weight] [decimal](5, 2) NOT NULL,
	[systolicBP] [int] NOT NULL,
	[diastolicBP] [int] NOT NULL,
	[temperature] [decimal](5, 2) NOT NULL,
	[pulse] [int] NOT NULL,
	[symptoms] [varchar](200) NOT NULL,
	[initialDiagnosis] [varchar](200) NOT NULL,
	[finalDiagnosis] [varchar](200) NULL,
	[nurseID] [int] NOT NULL,
 CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (1, 1)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (3, 5)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (4, 12)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (5, 14)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (6, 20)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (7, 25)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (8, 26)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (9, 29)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (10, 32)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (11, 37)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (12, 39)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (13, 44)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (14, 47)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (15, 49)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (16, 51)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (17, 59)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (18, 60)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (19, 63)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (20, 64)
INSERT [dbo].[Administrator] ([administratorID], [personID]) VALUES (21, 68)
SET IDENTITY_INSERT [dbo].[Administrator] OFF
SET IDENTITY_INSERT [dbo].[Appointment] ON 

INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (1, 20, 3, CAST(N'2018-12-31T09:54:41.000' AS DateTime), N'High blood pressure')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (2, 67, 17, CAST(N'2018-05-05T15:47:13.000' AS DateTime), N'My abdomen hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (3, 93, 27, CAST(N'2018-09-12T08:36:59.000' AS DateTime), N'I feel Nauseated ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (4, 56, 2, CAST(N'2018-09-24T05:07:46.000' AS DateTime), N'I can''t Remember normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (5, 29, 9, CAST(N'2018-07-27T22:58:08.000' AS DateTime), N'Upper respiratory conditions')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (6, 127, 22, CAST(N'2018-10-12T08:38:45.000' AS DateTime), N'I feel Nauseated ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (7, 47, 13, CAST(N'2018-09-07T16:37:45.000' AS DateTime), N'Anxiety')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (8, 13, 8, CAST(N'2018-02-02T15:04:04.000' AS DateTime), N'I feel like I have to vomit ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (9, 132, 19, CAST(N'2018-10-14T10:50:21.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (10, 114, 22, CAST(N'2019-01-16T07:19:57.000' AS DateTime), N'Osteoarthritis')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (11, 76, 9, CAST(N'2018-04-09T02:08:48.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (12, 110, 12, CAST(N'2018-06-02T12:07:28.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (13, 72, 11, CAST(N'2019-01-26T05:23:57.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (14, 138, 11, CAST(N'2019-01-26T08:37:51.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (15, 69, 7, CAST(N'2018-04-18T04:43:21.000' AS DateTime), N'My abdomen hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (16, 51, 16, CAST(N'2018-01-25T19:51:39.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (17, 99, 25, CAST(N'2018-04-22T15:48:28.000' AS DateTime), N'I feel like I have to vomit ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (18, 5, 9, CAST(N'2019-01-22T12:22:27.000' AS DateTime), N'I can''t Hear normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (19, 127, 17, CAST(N'2018-02-15T03:08:36.000' AS DateTime), N'I can''t Swallow normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (20, 19, 3, CAST(N'2018-03-31T23:52:51.000' AS DateTime), N'I feel Sleepy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (21, 24, 17, CAST(N'2018-03-29T07:52:10.000' AS DateTime), N'I feel Sweaty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (22, 113, 15, CAST(N'2018-11-07T08:06:30.000' AS DateTime), N'Skin disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (23, 104, 22, CAST(N'2018-11-14T12:47:25.000' AS DateTime), N'My abdomen hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (24, 30, 14, CAST(N'2018-03-11T16:57:12.000' AS DateTime), N'I feel Sleepy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (25, 46, 5, CAST(N'2018-08-11T00:51:13.000' AS DateTime), N'I feel Dizzy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (26, 29, 9, CAST(N'2018-12-15T11:42:47.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (27, 125, 18, CAST(N'2018-02-01T00:27:01.000' AS DateTime), N'I feel like I have the flu ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (28, 102, 17, CAST(N'2018-06-19T17:15:33.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (29, 61, 29, CAST(N'2018-02-15T19:13:56.000' AS DateTime), N'My ear hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (30, 23, 30, CAST(N'2018-01-22T20:19:22.000' AS DateTime), N'Joint disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (31, 74, 19, CAST(N'2018-08-21T10:46:00.000' AS DateTime), N'I can''t See properly ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (32, 128, 21, CAST(N'2018-08-02T06:33:21.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (33, 105, 29, CAST(N'2018-04-28T03:00:12.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (34, 89, 3, CAST(N'2018-02-19T12:51:09.000' AS DateTime), N'Back problems')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (35, 43, 4, CAST(N'2018-02-24T02:56:43.000' AS DateTime), N'My extremities hurt')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (36, 68, 13, CAST(N'2018-12-31T13:56:31.000' AS DateTime), N'I can''t Breathe normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (37, 74, 1, CAST(N'2018-01-09T17:13:45.000' AS DateTime), N'High blood pressure')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (38, 126, 19, CAST(N'2018-06-18T08:26:37.000' AS DateTime), N'I feel Weak ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (39, 10, 11, CAST(N'2018-10-18T16:39:21.000' AS DateTime), N'Anxiety')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (40, 32, 24, CAST(N'2018-03-27T20:59:46.000' AS DateTime), N'Cholesterol problems')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (41, 97, 4, CAST(N'2018-09-22T11:46:59.000' AS DateTime), N'My ear hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (42, 17, 30, CAST(N'2018-04-16T02:38:20.000' AS DateTime), N'I can''t Move one side – arm and/or leg ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (43, 43, 22, CAST(N'2018-07-09T17:44:15.000' AS DateTime), N'Osteoarthritis')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (44, 13, 10, CAST(N'2018-12-23T16:54:36.000' AS DateTime), N'Chronic neurologic disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (45, 50, 3, CAST(N'2018-11-04T10:56:41.000' AS DateTime), N'Asthma')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (46, 107, 24, CAST(N'2018-05-06T01:27:57.000' AS DateTime), N'I can''t See properly ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (47, 48, 9, CAST(N'2018-02-06T23:14:25.000' AS DateTime), N'Joint disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (48, 37, 8, CAST(N'2018-09-14T00:44:26.000' AS DateTime), N'My skin hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (49, 119, 28, CAST(N'2018-06-22T13:37:40.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (50, 120, 3, CAST(N'2019-01-26T14:01:57.000' AS DateTime), N'I can''t Breathe normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (51, 102, 15, CAST(N'2018-02-21T16:03:02.000' AS DateTime), N'My Vagina hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (52, 37, 1, CAST(N'2018-08-12T17:33:51.000' AS DateTime), N'I feel Weak ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (53, 4, 11, CAST(N'2018-12-23T19:09:47.000' AS DateTime), N'My back hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (54, 91, 23, CAST(N'2018-02-05T01:49:30.000' AS DateTime), N'I can''t Remember normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (55, 2, 15, CAST(N'2018-02-13T12:05:50.000' AS DateTime), N'Upper respiratory conditions')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (56, 130, 12, CAST(N'2018-10-26T08:50:13.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (57, 119, 4, CAST(N'2018-10-24T18:43:55.000' AS DateTime), N'I can''t Stop scratching ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (58, 108, 27, CAST(N'2018-07-16T23:42:59.000' AS DateTime), N'My ear hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (59, 78, 3, CAST(N'2018-06-24T22:19:50.000' AS DateTime), N'I can''t Remember normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (60, 111, 16, CAST(N'2018-08-16T23:45:24.000' AS DateTime), N'My ear hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (61, 47, 19, CAST(N'2019-03-05T08:52:59.000' AS DateTime), N'Joint disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (62, 49, 21, CAST(N'2018-06-13T22:00:54.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (63, 39, 23, CAST(N'2019-02-07T15:19:00.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (64, 85, 28, CAST(N'2018-05-15T17:55:41.000' AS DateTime), N'Joint disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (65, 40, 14, CAST(N'2018-02-09T04:22:20.000' AS DateTime), N'I can''t Remember normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (66, 8, 20, CAST(N'2018-11-05T05:43:28.000' AS DateTime), N'I can''t Speak normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (67, 48, 28, CAST(N'2018-12-14T09:26:23.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (68, 90, 23, CAST(N'2018-10-26T16:23:03.000' AS DateTime), N'I can''t Hear normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (69, 102, 6, CAST(N'2018-08-22T16:05:29.000' AS DateTime), N'Migraines')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (70, 129, 28, CAST(N'2018-10-05T22:57:12.000' AS DateTime), N'I feel numbness ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (71, 24, 13, CAST(N'2019-03-05T21:33:58.000' AS DateTime), N'I feel Nauseated ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (72, 48, 29, CAST(N'2018-06-22T14:51:51.000' AS DateTime), N'Osteoarthritis')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (73, 131, 12, CAST(N'2018-06-06T15:51:12.000' AS DateTime), N'My chest hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (74, 94, 22, CAST(N'2019-01-10T01:22:06.000' AS DateTime), N'I feel Sweaty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (75, 6, 29, CAST(N'2018-10-21T21:41:51.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (76, 85, 22, CAST(N'2018-01-27T16:28:04.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (77, 2, 1, CAST(N'2018-12-15T10:01:55.000' AS DateTime), N'I feel like I have to vomit ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (78, 99, 28, CAST(N'2018-01-13T08:08:47.000' AS DateTime), N'I feel Short of breath ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (79, 35, 2, CAST(N'2018-12-03T14:42:01.000' AS DateTime), N'I feel Sleepy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (80, 131, 5, CAST(N'2018-06-04T07:41:02.000' AS DateTime), N'I feel Weak ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (81, 97, 8, CAST(N'2018-12-16T15:26:44.000' AS DateTime), N'I can''t Breathe normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (82, 35, 23, CAST(N'2018-11-12T00:15:03.000' AS DateTime), N'I feel Weak ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (83, 72, 17, CAST(N'2018-10-30T09:10:23.000' AS DateTime), N'I can''t Pass a bowel action normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (84, 54, 9, CAST(N'2018-11-24T02:36:19.000' AS DateTime), N'I can''t Sleep normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (85, 118, 13, CAST(N'2018-09-05T11:41:21.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (86, 30, 22, CAST(N'2018-07-18T05:03:43.000' AS DateTime), N'My back hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (87, 138, 16, CAST(N'2018-09-11T13:01:06.000' AS DateTime), N'I feel Chills ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (88, 102, 25, CAST(N'2018-09-29T15:36:41.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (89, 48, 12, CAST(N'2018-12-02T00:29:43.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (90, 32, 20, CAST(N'2019-01-29T15:37:08.000' AS DateTime), N'I can''t Pass urine normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (91, 107, 28, CAST(N'2018-07-11T06:10:04.000' AS DateTime), N'Bipolar disorder')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (92, 76, 28, CAST(N'2018-02-02T20:03:47.000' AS DateTime), N'I can''t Stop passing watery bowel actions ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (93, 72, 20, CAST(N'2018-01-18T00:49:33.000' AS DateTime), N'Chronic neurologic disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (94, 91, 2, CAST(N'2018-06-14T16:39:31.000' AS DateTime), N'Bipolar disorder')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (95, 48, 25, CAST(N'2018-03-02T07:51:46.000' AS DateTime), N'Headaches')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (96, 29, 27, CAST(N'2019-01-27T19:03:46.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (97, 127, 16, CAST(N'2018-05-13T13:53:37.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (98, 89, 8, CAST(N'2018-04-01T05:01:16.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (99, 112, 25, CAST(N'2018-07-07T23:09:56.000' AS DateTime), N'Migraines')
GO
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (100, 42, 19, CAST(N'2018-07-12T20:01:22.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (101, 113, 25, CAST(N'2018-10-15T09:56:08.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (102, 134, 3, CAST(N'2018-01-16T20:11:09.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (103, 106, 29, CAST(N'2018-02-26T18:11:49.000' AS DateTime), N'My ear hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (104, 117, 20, CAST(N'2019-02-13T01:31:58.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (105, 39, 30, CAST(N'2018-12-20T22:39:13.000' AS DateTime), N'I feel Sleepy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (106, 7, 28, CAST(N'2018-06-28T01:29:18.000' AS DateTime), N'I can''t Stop sweating ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (107, 18, 26, CAST(N'2018-01-28T11:09:02.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (108, 66, 17, CAST(N'2018-12-20T21:06:12.000' AS DateTime), N'I can''t Remember normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (109, 17, 10, CAST(N'2018-01-19T07:24:34.000' AS DateTime), N'Bipolar disorder')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (110, 36, 20, CAST(N'2018-01-05T15:57:03.000' AS DateTime), N'Anxiety')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (111, 118, 24, CAST(N'2019-03-02T10:55:57.000' AS DateTime), N'I can''t Move one side – arm and/or leg ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (112, 71, 30, CAST(N'2018-04-18T05:09:00.000' AS DateTime), N'My pelvis hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (113, 127, 17, CAST(N'2018-08-31T18:33:51.000' AS DateTime), N'My rectum hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (114, 60, 13, CAST(N'2018-04-07T03:42:07.000' AS DateTime), N'Migraines')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (115, 9, 24, CAST(N'2018-08-16T12:50:08.000' AS DateTime), N'I can''t Pass a bowel action normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (116, 113, 6, CAST(N'2018-05-09T02:51:48.000' AS DateTime), N'I feel Short of breath ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (117, 45, 9, CAST(N'2018-11-27T15:37:38.000' AS DateTime), N'Chronic neurologic disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (118, 25, 7, CAST(N'2018-07-07T11:42:44.000' AS DateTime), N'I can''t Pass a bowel action normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (119, 58, 15, CAST(N'2018-04-29T14:35:53.000' AS DateTime), N'Headaches')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (120, 105, 19, CAST(N'2019-02-28T12:59:19.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (121, 80, 25, CAST(N'2018-06-09T19:48:16.000' AS DateTime), N'Upper respiratory conditions')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (122, 133, 18, CAST(N'2018-10-17T11:36:52.000' AS DateTime), N'My ear hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (123, 76, 11, CAST(N'2018-08-08T01:36:18.000' AS DateTime), N'I can''t Taste properly ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (124, 139, 11, CAST(N'2018-11-24T08:01:20.000' AS DateTime), N'I feel Chills ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (125, 17, 10, CAST(N'2018-06-29T15:07:08.000' AS DateTime), N'My back hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (126, 22, 1, CAST(N'2018-06-12T10:58:53.000' AS DateTime), N'I can''t Sleep normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (127, 45, 27, CAST(N'2018-04-17T09:51:23.000' AS DateTime), N'I feel Sleepy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (128, 133, 12, CAST(N'2018-12-15T19:53:58.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (129, 58, 23, CAST(N'2018-12-09T00:30:49.000' AS DateTime), N'I can''t Pass urine normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (130, 1, 25, CAST(N'2018-02-20T04:20:07.000' AS DateTime), N'Osteoarthritis')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (131, 132, 26, CAST(N'2018-07-10T04:35:30.000' AS DateTime), N'I can''t Swallow normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (132, 17, 30, CAST(N'2018-06-15T02:38:01.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (133, 17, 3, CAST(N'2019-01-24T05:20:38.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (134, 99, 11, CAST(N'2018-10-21T17:44:24.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (135, 66, 15, CAST(N'2018-11-08T22:49:19.000' AS DateTime), N'My abdomen hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (136, 14, 5, CAST(N'2018-11-03T18:15:21.000' AS DateTime), N'Upper respiratory conditions')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (137, 44, 14, CAST(N'2019-02-14T21:18:07.000' AS DateTime), N'I can''t Stop sweating ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (138, 86, 11, CAST(N'2018-06-29T17:48:52.000' AS DateTime), N'I feel Fever ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (139, 32, 21, CAST(N'2018-02-23T23:18:09.000' AS DateTime), N'I feel Chills ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (140, 132, 14, CAST(N'2018-11-28T06:57:45.000' AS DateTime), N'I can''t Swallow normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (141, 34, 16, CAST(N'2019-03-08T23:12:57.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (142, 38, 5, CAST(N'2018-10-13T01:06:24.000' AS DateTime), N'I feel Thirsty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (143, 133, 24, CAST(N'2018-09-24T06:32:34.000' AS DateTime), N'I can''t Hear normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (144, 116, 8, CAST(N'2018-05-07T04:44:39.000' AS DateTime), N'Bipolar disorder')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (145, 96, 1, CAST(N'2018-10-04T13:19:33.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (146, 52, 8, CAST(N'2018-04-11T12:10:20.000' AS DateTime), N'I can''t Pass a bowel action normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (147, 126, 9, CAST(N'2018-12-18T08:51:17.000' AS DateTime), N'I can''t Pass a bowel action normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (148, 137, 7, CAST(N'2019-01-05T18:13:09.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (149, 97, 30, CAST(N'2018-12-31T20:05:41.000' AS DateTime), N'I can''t Stop passing watery bowel actions ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (150, 27, 17, CAST(N'2019-01-11T19:08:23.000' AS DateTime), N'I feel Sleepy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (151, 34, 11, CAST(N'2019-01-26T00:24:29.000' AS DateTime), N'My chest hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (152, 45, 11, CAST(N'2018-09-09T01:32:32.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (153, 92, 15, CAST(N'2018-07-17T07:11:18.000' AS DateTime), N'Headaches')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (154, 92, 13, CAST(N'2019-02-19T05:33:05.000' AS DateTime), N'Bipolar disorder')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (155, 123, 26, CAST(N'2018-06-16T03:44:35.000' AS DateTime), N'I can''t Stop sweating ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (156, 60, 17, CAST(N'2018-12-26T01:00:45.000' AS DateTime), N'I can''t Taste properly ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (157, 78, 27, CAST(N'2019-02-27T21:41:56.000' AS DateTime), N'I feel numbness ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (158, 48, 10, CAST(N'2018-07-14T09:05:54.000' AS DateTime), N'I can''t Hear normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (159, 42, 18, CAST(N'2018-03-18T23:40:51.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (160, 117, 17, CAST(N'2018-03-13T18:33:37.000' AS DateTime), N'Upper respiratory conditions')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (161, 17, 12, CAST(N'2018-07-23T05:53:11.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (162, 13, 15, CAST(N'2018-06-07T07:41:31.000' AS DateTime), N'I feel Nauseated ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (163, 57, 26, CAST(N'2018-05-05T00:56:17.000' AS DateTime), N'I feel Thirsty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (164, 79, 6, CAST(N'2018-01-16T09:36:26.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (165, 57, 25, CAST(N'2018-10-27T04:53:58.000' AS DateTime), N'I feel Nauseated ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (166, 99, 8, CAST(N'2019-01-09T12:35:00.000' AS DateTime), N'My extremities hurt')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (167, 70, 16, CAST(N'2019-02-09T07:16:14.000' AS DateTime), N'My skin hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (168, 8, 1, CAST(N'2018-07-09T15:51:11.000' AS DateTime), N'Skin disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (169, 121, 11, CAST(N'2018-11-25T02:18:24.000' AS DateTime), N'Osteoarthritis')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (170, 64, 24, CAST(N'2018-06-14T16:38:27.000' AS DateTime), N'I feel Sick ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (171, 118, 13, CAST(N'2018-11-15T19:39:46.000' AS DateTime), N'I feel tingling ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (172, 45, 23, CAST(N'2018-08-03T17:40:15.000' AS DateTime), N'Depression')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (173, 39, 16, CAST(N'2018-04-28T02:17:44.000' AS DateTime), N'Depression')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (174, 118, 24, CAST(N'2018-06-20T05:51:26.000' AS DateTime), N'I can''t Breathe normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (175, 81, 17, CAST(N'2018-10-16T20:38:01.000' AS DateTime), N'High blood pressure')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (176, 133, 24, CAST(N'2018-05-25T13:32:23.000' AS DateTime), N'My chest hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (177, 88, 2, CAST(N'2018-05-30T02:05:55.000' AS DateTime), N'Headaches')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (178, 15, 15, CAST(N'2018-04-28T08:58:47.000' AS DateTime), N'I feel Light-headed ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (179, 115, 26, CAST(N'2018-12-29T11:16:16.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (180, 62, 24, CAST(N'2018-02-23T10:54:59.000' AS DateTime), N'I feel Thirsty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (181, 123, 22, CAST(N'2018-01-14T10:04:25.000' AS DateTime), N'My pelvis hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (182, 118, 26, CAST(N'2018-11-25T10:27:22.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (183, 98, 25, CAST(N'2018-01-22T01:45:54.000' AS DateTime), N'High blood pressure')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (184, 71, 13, CAST(N'2018-10-14T23:45:37.000' AS DateTime), N'I can''t Stop sweating ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (185, 14, 11, CAST(N'2018-08-02T10:21:51.000' AS DateTime), N'I feel my mouth is dry ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (186, 82, 17, CAST(N'2018-05-25T14:48:04.000' AS DateTime), N'I feel Sick ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (187, 58, 3, CAST(N'2018-11-14T23:53:39.000' AS DateTime), N'I feel Sweaty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (188, 7, 5, CAST(N'2018-11-14T00:18:00.000' AS DateTime), N'I feel numbness ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (189, 13, 13, CAST(N'2019-02-22T08:53:29.000' AS DateTime), N'I feel Sleepy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (190, 35, 1, CAST(N'2018-04-16T08:51:31.000' AS DateTime), N'I feel Fever ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (191, 140, 12, CAST(N'2018-03-20T07:51:53.000' AS DateTime), N'I feel Dizzy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (192, 1, 24, CAST(N'2018-06-05T16:06:20.000' AS DateTime), N'My extremities hurt')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (193, 27, 2, CAST(N'2018-02-11T19:03:36.000' AS DateTime), N'Headaches')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (194, 54, 18, CAST(N'2018-12-30T23:26:22.000' AS DateTime), N'I can''t Sleep normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (195, 72, 11, CAST(N'2018-05-14T17:50:18.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (196, 72, 22, CAST(N'2018-02-27T00:11:09.000' AS DateTime), N'My back hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (197, 43, 13, CAST(N'2018-06-04T14:16:34.000' AS DateTime), N'My tooth hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (198, 66, 22, CAST(N'2018-11-13T10:04:09.000' AS DateTime), N'My rectum hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (199, 126, 14, CAST(N'2019-01-01T14:41:03.000' AS DateTime), N'Anxiety')
GO
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (200, 82, 9, CAST(N'2018-01-20T19:37:56.000' AS DateTime), N'My rectum hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (201, 120, 10, CAST(N'2018-04-02T15:45:49.000' AS DateTime), N'I can''t Stop sweating ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (202, 97, 23, CAST(N'2018-10-02T04:35:48.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (203, 108, 25, CAST(N'2018-10-07T04:43:44.000' AS DateTime), N'My pelvis hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (204, 111, 20, CAST(N'2018-08-25T03:15:26.000' AS DateTime), N'I feel Sick ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (205, 43, 16, CAST(N'2018-06-05T01:33:10.000' AS DateTime), N'I feel Sweaty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (206, 41, 3, CAST(N'2018-07-13T02:53:10.000' AS DateTime), N'I feel Fever ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (207, 116, 28, CAST(N'2018-07-20T14:31:01.000' AS DateTime), N'I feel Fever ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (208, 125, 12, CAST(N'2018-03-11T04:35:56.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (209, 41, 30, CAST(N'2019-01-13T17:03:48.000' AS DateTime), N'My rectum hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (210, 42, 21, CAST(N'2018-03-19T09:53:18.000' AS DateTime), N'Bipolar disorder')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (211, 102, 8, CAST(N'2018-06-27T03:28:13.000' AS DateTime), N'I can''t Move one side – arm and/or leg ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (212, 96, 5, CAST(N'2019-01-17T20:18:45.000' AS DateTime), N'I can''t Hear normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (213, 123, 19, CAST(N'2018-10-10T14:54:57.000' AS DateTime), N'I feel like I have the flu ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (214, 72, 22, CAST(N'2018-05-22T00:59:28.000' AS DateTime), N'I feel Light-headed ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (215, 41, 22, CAST(N'2018-12-30T15:02:28.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (216, 57, 20, CAST(N'2018-07-27T21:46:37.000' AS DateTime), N'I can''t Speak normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (217, 125, 19, CAST(N'2018-06-08T23:59:02.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (218, 137, 29, CAST(N'2018-08-15T09:39:09.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (219, 28, 20, CAST(N'2018-09-03T22:29:21.000' AS DateTime), N'Osteoarthritis')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (220, 9, 27, CAST(N'2018-10-19T08:14:19.000' AS DateTime), N'I feel Sweaty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (221, 102, 19, CAST(N'2018-02-10T02:24:30.000' AS DateTime), N'I feel Light-headed ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (222, 96, 8, CAST(N'2019-02-01T18:57:14.000' AS DateTime), N'My rectum hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (223, 31, 15, CAST(N'2018-11-17T12:42:45.000' AS DateTime), N'I feel Tired ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (224, 64, 6, CAST(N'2018-02-15T11:45:22.000' AS DateTime), N'I can''t Stop scratching ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (225, 121, 8, CAST(N'2019-01-24T22:39:05.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (226, 105, 12, CAST(N'2018-06-10T21:14:24.000' AS DateTime), N'I feel Sick ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (227, 51, 24, CAST(N'2019-01-20T02:27:43.000' AS DateTime), N'I feel Light-headed ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (228, 4, 6, CAST(N'2019-02-19T07:37:01.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (229, 8, 1, CAST(N'2018-10-27T01:07:14.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (230, 76, 9, CAST(N'2018-12-14T02:51:38.000' AS DateTime), N'I can''t Smell things normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (231, 12, 26, CAST(N'2018-06-17T20:08:17.000' AS DateTime), N'High blood pressure')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (232, 62, 27, CAST(N'2018-08-02T09:44:20.000' AS DateTime), N'Migraines')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (233, 128, 19, CAST(N'2018-07-01T00:55:20.000' AS DateTime), N'I feel Short of breath ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (234, 137, 5, CAST(N'2018-03-26T02:59:28.000' AS DateTime), N'I can''t Pass a bowel action normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (235, 53, 26, CAST(N'2018-10-07T14:04:02.000' AS DateTime), N'My tooth hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (236, 120, 2, CAST(N'2018-11-02T16:38:12.000' AS DateTime), N'My pelvis hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (237, 99, 16, CAST(N'2018-03-16T02:57:55.000' AS DateTime), N'I feel Sick ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (238, 108, 8, CAST(N'2019-01-03T13:01:33.000' AS DateTime), N'I can''t See properly ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (239, 55, 5, CAST(N'2018-11-25T19:43:35.000' AS DateTime), N'Headaches')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (240, 132, 21, CAST(N'2018-02-02T08:23:26.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (241, 48, 15, CAST(N'2018-02-19T04:58:29.000' AS DateTime), N'I feel Dizzy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (242, 63, 23, CAST(N'2018-04-11T04:53:06.000' AS DateTime), N'I feel Thirsty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (243, 97, 6, CAST(N'2018-10-28T00:10:22.000' AS DateTime), N'I can''t Stop sweating ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (244, 80, 27, CAST(N'2018-09-01T23:25:03.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (245, 8, 3, CAST(N'2018-04-05T19:30:52.000' AS DateTime), N'I can''t Stop scratching ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (246, 51, 8, CAST(N'2018-07-09T17:50:20.000' AS DateTime), N'Depression')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (247, 98, 25, CAST(N'2019-03-09T11:07:55.000' AS DateTime), N'I feel Tired ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (248, 34, 3, CAST(N'2018-12-11T14:34:18.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (249, 81, 8, CAST(N'2018-11-20T15:24:02.000' AS DateTime), N'Osteoarthritis')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (250, 118, 14, CAST(N'2018-11-27T02:18:02.000' AS DateTime), N'I feel Short of breath ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (251, 107, 8, CAST(N'2018-08-16T19:50:42.000' AS DateTime), N'My abdomen hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (252, 43, 28, CAST(N'2018-07-31T07:00:10.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (253, 89, 20, CAST(N'2018-09-30T11:23:18.000' AS DateTime), N'My tooth hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (254, 109, 18, CAST(N'2018-10-26T06:19:14.000' AS DateTime), N'I can''t Stop scratching ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (255, 15, 29, CAST(N'2018-06-11T05:47:48.000' AS DateTime), N'My chest hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (256, 128, 28, CAST(N'2018-05-22T04:48:15.000' AS DateTime), N'I feel numbness ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (257, 101, 20, CAST(N'2018-12-26T18:24:31.000' AS DateTime), N'My chest hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (258, 1, 6, CAST(N'2018-01-08T14:07:40.000' AS DateTime), N'My skin hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (259, 102, 8, CAST(N'2018-07-12T17:05:26.000' AS DateTime), N'I can''t Stop scratching ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (260, 117, 16, CAST(N'2018-05-04T14:58:39.000' AS DateTime), N'I can''t Stop scratching ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (261, 76, 12, CAST(N'2018-06-05T21:10:01.000' AS DateTime), N'Osteoarthritis')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (262, 34, 25, CAST(N'2018-07-22T17:52:18.000' AS DateTime), N'I feel like I have to vomit ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (263, 37, 24, CAST(N'2019-02-14T21:57:57.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (264, 8, 1, CAST(N'2018-11-26T13:09:51.000' AS DateTime), N'My extremities hurt')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (265, 5, 2, CAST(N'2019-03-08T19:26:16.000' AS DateTime), N'Joint disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (266, 39, 26, CAST(N'2018-10-16T21:56:24.000' AS DateTime), N'I feel Sweaty ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (267, 43, 17, CAST(N'2019-02-07T16:47:15.000' AS DateTime), N'I can''t Hear normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (268, 98, 21, CAST(N'2018-03-07T06:57:43.000' AS DateTime), N'I can''t Swallow normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (269, 5, 3, CAST(N'2018-11-22T10:56:46.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (270, 119, 12, CAST(N'2018-03-06T03:37:15.000' AS DateTime), N'I can''t Swallow normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (271, 91, 16, CAST(N'2018-02-22T16:40:38.000' AS DateTime), N'I can''t See properly ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (272, 106, 10, CAST(N'2018-09-08T22:24:48.000' AS DateTime), N'I feel Chills ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (273, 109, 22, CAST(N'2018-05-23T10:44:22.000' AS DateTime), N'I can''t Walk normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (274, 60, 29, CAST(N'2018-01-26T20:54:39.000' AS DateTime), N'I can''t Remember normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (275, 114, 14, CAST(N'2018-07-22T00:02:28.000' AS DateTime), N'Cholesterol problems')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (276, 40, 25, CAST(N'2018-05-28T10:54:26.000' AS DateTime), N'Diabetes')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (277, 131, 17, CAST(N'2018-10-06T11:58:49.000' AS DateTime), N'I feel Sleepy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (278, 32, 13, CAST(N'2018-03-21T21:18:21.000' AS DateTime), N'Skin disorders')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (279, 107, 28, CAST(N'2018-04-06T09:27:11.000' AS DateTime), N'My skin hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (280, 85, 7, CAST(N'2018-01-06T00:14:48.000' AS DateTime), N'Headaches')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (281, 22, 12, CAST(N'2018-01-28T09:28:19.000' AS DateTime), N'My pelvis hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (282, 7, 30, CAST(N'2018-07-31T06:55:59.000' AS DateTime), N'I feel Chills ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (283, 29, 22, CAST(N'2018-07-11T10:59:42.000' AS DateTime), N'I feel Dizzy ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (284, 113, 24, CAST(N'2018-07-01T10:40:07.000' AS DateTime), N'I feel Short of breath ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (285, 22, 17, CAST(N'2018-03-01T12:24:57.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (286, 98, 2, CAST(N'2018-11-02T20:52:29.000' AS DateTime), N'I feel Chronic pain ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (287, 27, 6, CAST(N'2018-12-11T06:26:30.000' AS DateTime), N'I feel tingling ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (288, 65, 10, CAST(N'2018-08-09T20:14:03.000' AS DateTime), N'My back hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (289, 2, 26, CAST(N'2018-12-07T01:15:07.000' AS DateTime), N'I can''t Sleep normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (290, 66, 19, CAST(N'2018-02-01T22:04:07.000' AS DateTime), N'I feel Sick ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (291, 126, 17, CAST(N'2018-02-05T10:47:12.000' AS DateTime), N'High blood pressure')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (292, 50, 26, CAST(N'2018-11-16T20:23:28.000' AS DateTime), N'I feel like I have the flu ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (293, 18, 21, CAST(N'2018-04-01T13:54:12.000' AS DateTime), N'I feel tingling ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (294, 111, 27, CAST(N'2018-11-15T13:42:46.000' AS DateTime), N'I can''t Write normally ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (295, 29, 15, CAST(N'2019-01-24T12:31:25.000' AS DateTime), N'I can''t See properly ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (296, 140, 30, CAST(N'2018-10-15T18:35:32.000' AS DateTime), N'My rectum hurts')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (297, 87, 26, CAST(N'2019-02-01T22:24:57.000' AS DateTime), N'I feel Tired ')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (298, 43, 9, CAST(N'2018-01-10T18:07:01.000' AS DateTime), N'Headaches')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (299, 55, 1, CAST(N'2018-09-27T08:30:31.000' AS DateTime), N'My rectum hurts')
GO
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [apptDatetime], [reasonForVisit]) VALUES (300, 35, 1, CAST(N'2018-03-16T06:01:20.000' AS DateTime), N'Osteoarthritis')
SET IDENTITY_INSERT [dbo].[Appointment] OFF
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'abanvillep', N'5D0FB868F3561D31CDECEAA25DC50E1F17991231', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'administrator', N'5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'adresserm', N'D2EBBA808B0181BF25B0729351BBDD344A63807A', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'ahardinge2', N'E94ACF28150A1722B262E9033CA5BB5ADBE5FB88', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'apottage1q', N'364CA850DB39235F9A443AB56500352DA9A43A5B', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'bcarloni1o', N'13DB01C16E1A042926B7BB380293895873F738BD', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'bdaulby1i', N'A5BD6DBD5099C5446119A73757D9F80C23A97ED3', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'bliddonk', N'7BE085FD65E4427E5BE675BA9A1183D2952F7EB7', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'bodonegan1l', N'C5756555E8252FF6BDA755F354DE96938ABF4865', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'browledge1n', N'752B27122AE1BF28995438D35E5FBB680A31273A', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'bslayton13', N'29D53E740447B1D5C1090C24708382CB8CCE2881', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'coby7', N'AEDD22271666325FD84686B17539537DB416D1AD', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'conolan1t', N'75D697B263F448539F8CFC1315A5162ACE6E0669', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'dallakerb', N'E2ED67FEF119E175D34D24B4CD6E29648B98B4F8', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'dbloan4', N'2434D54A8D4AF5290FF36E4C459C451F9E57E6D0', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'dcoathupl', N'503E4A7043057969E5AD40BE3BA9B7F11B205B26', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'dmattheusf', N'A45EED4AC1BF2DD9D58EAC96F38ABCF0B28872F2', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'dtoll1u', N'90FA7AA9CA323C66A98528EA0D7822FE58D39568', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'dtuplinga', N'F5884CD8B09F9336717170295675D380CEE91EF1', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'ebambrughz', N'D290F8BB143736AB1B51B5FB1219C4153C0A9BFE', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'eelliss1d', N'11DD9384A9DC2BB015B50081EEA1B24321BC8C65', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'egarlic1g', N'CC2E3D1C761D573D8B46AE4CEFA14E6CA9C8FE0A', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'erobenss', N'57E1444EF7C51496D5402B60DA583E7076B2E3FF', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'fgregs1a', N'1F7844FC5C9E2DCC24390DCE0DDA51B3D27F2499', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'fkitchinghan17', N'CFEF149B797E937F175E9E6FDFF2568C4BDE8C5E', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'fwatts15', N'6C2C91A6389A1B114111D148A850EFB64EE3AED7', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'ghoudhury5', N'5AD45773267EA0AA462D321B75CD611B238F26A9', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'gjoberng', N'7FE854F7406286D34BF9D59AC13F1DCE7AF70D54', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'gmander11', N'8298EC402A7BFAA37592D919AFDB4C793272AD5D', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'gminet1j', N'C55BAEA23C9023E24CC222F58120E6C2CAC6D739', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'hsillimanu', N'9B5C38D07D64742517BFEF71B9A8098DE0551A64', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'ibolino1c', N'A142B4FCB6FEFDE085881B91BBF374E191ADBDBB', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'jbraffertonc', N'CC79DCC1EBBE5CEB4BE87F9FF601321E45F0BB7A', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'jcoggon1b', N'02DF6F47C8B663454B262A554497EB8E60269156', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'jcunradi1s', N'D6344167CD62C17CDAB9E3FB3ADF4490A756246D', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'jgennerichd', N'521F2E25079E6D58C97F02C285BC9EBD4E753E9F', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'jsubhan1h', N'16203BCD374D3D448D8789372C50F684854415F4', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'jtideswell2', N'EDE7285C53267E0E52C529846F2E7C3FA1BAD799', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'kcoulthart1p', N'5B6318BA4638A7071435B1FB726794B76EF57F37', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'lcrissil1k', N'2BB7D8AAA1ED0D5D41AE38300DB7DD67392F0F0E', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'lfrancish', N'D040030DFE155825355258BAEDFFB784EB13A1B4', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'lgibliny', N'55DE3107677AE81C162FCD1265AF083EB554775E', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'lharse14', N'378EB56D610FA8450BA3205D8F0EBDA9E69C16F7', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'lkadwallider1', N'7903F5C4876964482678E3B1854306103A5EB445', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'llaviellee', N'DFCD42D62587247FB6C2B7CBE29A4E70ABA4F90D', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'lwyner', N'1C641F0CB43B840040175CF4DC2C19B088E14E0C', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'mdeetlof1w', N'520406ABDB67FEE98DD2BDF3D4CC315D1D018253', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'mduchart1m', N'003880871695A68D58105A1E9F7028A55327C0A9', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'menston1r', N'8BBB63A51BCA01936EBF6708F2B9E5A327D5E346', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'ncolleyo', N'B21C75B0CFC624B163D61AF146177F85891EE46C', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'nleger12', N'39ED30272DBD887A6E975B1EA2842EDECFA6048A', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'nthame9', N'FEEFE66E5775D59A102710BC7C3CB74D266605FE', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'nurse', N'5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'obroun1f', N'7CBA3FF91C48B56577056A18323C12483750ADED', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'pbowie1e', N'362BB50662E5ACB3D8A865A7D70E3FDB4D9DBCBA', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'pdunthornx', N'AD3604786CABF613E3118052483859BE8D08FF96', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'pgutmann', N'9026DE5607DE206F0D3F3F6C9E9E265A6575BA63', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'plarcher3', N'C7754C787132AE4EFFF2D84EE07CB4BB627FB67C', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'rklassmann19', N'CA9AA7C177FBA17A53BBC3CE5EB2C4BFA9D996F3', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'rloinsq', N'16DD5FB4BD2674474871B6CB858FC9C7EE6E844E', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'rtamblingw', N'91653460CC03951FAC65F06F867A527279DEF9DD', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'sbadinit', N'0A2AB858610926791685359FB7521B64AF063B5E', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'sbunhill6', N'5C8476232F29A7EB6948122341C4C8EA057856CB', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'skubickai', N'E40300C3622AEE85723BF7EC40817715013131FE', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'sleighfield1v', N'456CA3EC5775C3799403105D4D435250EA2EA196', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'tjoint18', N'7FC103FE59EB28A3812A14737C5F5E8BD9729879', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'tstaning10', N'BA3803498BF11B6C8F84C9E5CA6C581B2B25AAE4', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'tvanns1x', N'3B33B7DF8E26072E702C71A38FF76DC29535E28A', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'vcheelj', N'649BAF20F1859E76B20B048D80585EA2014A1363', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'vkobpav', N'B82258DCF3150C227C0EEAB022F4552234A8233E', N'administrator')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'vorrett8', N'847D2C4FDFA7AD3DB598A29AF6DA670B4369771E', N'nurse')
INSERT [dbo].[Credential] ([username], [password], [role]) VALUES (N'whelbeck16', N'B2ABB724B1A59AE8F8AFD58DCBF5BB6F6BD62BAD', N'nurse')
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (1, 70)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (2, 71)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (3, 72)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (4, 73)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (5, 74)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (6, 75)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (7, 76)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (8, 77)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (9, 78)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (10, 79)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (11, 80)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (12, 81)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (13, 82)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (14, 83)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (15, 84)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (16, 85)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (17, 86)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (18, 87)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (19, 88)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (20, 89)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (21, 90)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (22, 91)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (23, 92)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (24, 93)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (25, 94)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (26, 95)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (27, 96)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (28, 97)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (29, 98)
INSERT [dbo].[Doctor] ([doctorID], [personID]) VALUES (30, 99)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (1, N'Family medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (2, N'Family medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (2, N'Gastroenterology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (2, N'Physician')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (2, N'Psychiatry')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (3, N'Internal medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (3, N'Pediatrics')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (4, N'Family medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (4, N'Obstetrician/gynecologist')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (5, N'Emergency medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (6, N'Physician')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (7, N'Dermatology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (7, N'Otolaryngology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (8, N'Orthopedic surgery')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (8, N'Radiology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (9, N'Pediatrics')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (10, N'Dermatology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (10, N'Radiology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (10, N'Urgent care')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (11, N'Gastroenterology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (12, N'Pulmonology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (13, N'Cardiology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (13, N'Neurology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (13, N'Psychiatry')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (14, N'Emergency medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (14, N'Orthopedic surgery')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (15, N'Internal medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (15, N'Neurology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (16, N'General surgery')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (17, N'Anesthesiology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (18, N'Otolaryngology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (19, N'Cardiology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (19, N'Family medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (20, N'Psychiatry')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (21, N'Anesthesiology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (21, N'Internal medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (21, N'Urgent care')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (22, N'Obstetrician/gynecologist')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (23, N'Emergency medicine')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (23, N'General surgery')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (24, N'Obstetrician/gynecologist')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (24, N'Physician')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (25, N'Dermatology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (26, N'Radiology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (27, N'Pediatrics')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (28, N'Pulmonology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (28, N'Urgent care')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (29, N'Gastroenterology')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (30, N'Psychiatry')
INSERT [dbo].[DoctorSpecialty] ([doctorID], [specialtyName]) VALUES (30, N'Pulmonology')
SET IDENTITY_INSERT [dbo].[LabTest] ON 

INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (9, N'Arterial Blood Gas (ABG)')
INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (5, N'Chem 7')
INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (7, N'Coagulation Panel (PT, PTT & INR)')
INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (6, N'Complete Blood Count (CBC)')
INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (3, N'hepatitis A test')
INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (4, N'hepatitis B test')
INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (8, N'Liver Enzymes')
INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (2, N'Low Density Lipoproteins (LDL)')
INSERT [dbo].[LabTest] ([testCode], [testName]) VALUES (1, N'White blood cell (WBC)')
SET IDENTITY_INSERT [dbo].[LabTest] OFF
SET IDENTITY_INSERT [dbo].[Nurse] ON 

INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (1, 2, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (2, 3, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (3, 4, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (4, 6, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (5, 7, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (6, 8, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (7, 9, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (8, 10, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (9, 11, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (10, 13, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (11, 15, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (12, 16, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (13, 17, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (14, 18, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (15, 19, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (16, 21, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (17, 22, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (18, 23, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (19, 24, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (20, 27, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (21, 28, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (22, 30, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (23, 31, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (24, 33, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (25, 34, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (26, 35, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (27, 36, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (28, 38, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (29, 40, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (30, 41, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (31, 42, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (32, 43, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (33, 45, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (34, 46, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (35, 48, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (36, 50, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (37, 52, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (38, 53, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (39, 54, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (40, 55, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (41, 56, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (42, 57, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (43, 58, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (44, 61, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (45, 62, 0)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (46, 65, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (47, 66, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (48, 67, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (49, 69, 1)
INSERT [dbo].[Nurse] ([nurseID], [personID], [active]) VALUES (50, 70, 1)
SET IDENTITY_INSERT [dbo].[Nurse] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (1, 4)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (2, 5)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (3, 10)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (4, 11)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (5, 13)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (6, 15)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (7, 18)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (8, 25)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (9, 26)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (10, 28)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (11, 30)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (12, 32)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (13, 38)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (14, 40)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (15, 41)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (16, 44)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (17, 45)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (18, 46)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (19, 47)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (20, 48)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (21, 51)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (22, 52)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (23, 53)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (24, 55)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (25, 57)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (26, 63)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (27, 65)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (28, 70)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (29, 71)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (30, 73)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (31, 74)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (32, 77)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (33, 82)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (34, 83)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (35, 88)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (36, 94)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (37, 95)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (38, 97)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (39, 99)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (40, 100)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (41, 101)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (42, 102)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (43, 103)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (44, 104)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (45, 105)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (46, 106)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (47, 107)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (48, 108)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (49, 109)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (50, 110)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (51, 111)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (52, 112)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (53, 113)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (54, 114)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (55, 115)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (56, 116)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (57, 117)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (58, 118)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (59, 119)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (60, 120)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (61, 121)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (62, 122)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (63, 123)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (64, 124)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (65, 125)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (66, 126)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (67, 127)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (68, 128)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (69, 129)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (70, 130)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (71, 131)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (72, 132)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (73, 133)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (74, 134)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (75, 135)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (76, 136)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (77, 137)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (78, 138)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (79, 139)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (80, 140)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (81, 141)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (82, 142)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (83, 143)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (84, 144)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (85, 145)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (86, 146)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (87, 147)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (88, 148)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (89, 149)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (90, 150)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (91, 151)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (92, 152)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (93, 153)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (94, 154)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (95, 155)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (96, 156)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (97, 157)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (98, 158)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (99, 159)
GO
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (100, 160)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (101, 161)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (102, 162)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (103, 163)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (104, 164)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (105, 165)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (106, 166)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (107, 167)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (108, 168)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (109, 169)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (110, 170)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (111, 171)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (112, 172)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (113, 173)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (114, 174)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (115, 175)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (116, 176)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (117, 177)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (118, 178)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (119, 179)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (120, 180)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (121, 181)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (122, 182)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (123, 183)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (124, 184)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (125, 185)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (126, 186)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (127, 187)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (128, 188)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (129, 189)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (130, 190)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (131, 191)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (132, 192)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (133, 193)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (134, 194)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (135, 195)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (136, 196)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (137, 197)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (138, 198)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (139, 199)
INSERT [dbo].[Patient] ([patientID], [personID]) VALUES (140, 200)
SET IDENTITY_INSERT [dbo].[Patient] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (1, N'Kadwallider', N'Laurianne', CAST(N'1961-10-14' AS Date), N'153-97-6259', N'F', N'9563 Schurz Way', N'Baltimore', N'MD', N'21282', N'4105144837', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (2, N'Tideswell', N'Jenni', CAST(N'1955-03-22' AS Date), N'791-69-9934', N'F', N'6417 4th Pass', N'San Diego', N'CA', N'92121', N'7606535303', N'jtideswell2')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (3, N'Hardinge', N'Albina', CAST(N'1973-01-08' AS Date), N'481-78-3378', N'F', N'31167 Tony Hill', N'Denver', N'CO', N'80279', N'3039492657', N'ahardinge2')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (4, N'Larcher', N'Patrice', CAST(N'1984-05-13' AS Date), N'647-28-5909', N'M', N'773 Harbort Circle', N'Washington', N'DC', N'20231', N'2028704679', N'plarcher3')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (5, N'Bloan', N'Dud', CAST(N'1986-01-10' AS Date), N'434-77-9699', N'M', N'40515 Cherokee Parkway', N'Bronx', N'NY', N'10469', N'3474982094', N'dbloan4')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (6, N'Houdhury', N'Granthem', CAST(N'1990-07-29' AS Date), N'210-17-0725', N'M', N'7 Novick Place', N'San Francisco', N'CA', N'94169', N'4156929735', N'ghoudhury5')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (7, N'Bunhill', N'Samara', CAST(N'1977-05-31' AS Date), N'122-97-3101', N'F', N'783 Northridge Center', N'Miami', N'FL', N'33164', N'7867882318', N'sbunhill6')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (8, N'Oby', N'Clementius', CAST(N'1992-11-14' AS Date), N'823-34-2197', N'M', N'976 Summit Road', N'Wichita', N'KS', N'67220', N'3165866859', N'coby7')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (9, N'Orrett', N'Vinita', CAST(N'1987-10-28' AS Date), N'653-41-1286', N'F', N'01663 Briar Crest Terrace', N'Gaithersburg', N'MD', N'20883', N'2409832904', N'vorrett8')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (10, N'Thame', N'Noel', CAST(N'1960-06-19' AS Date), N'209-72-3984', N'M', N'30 Scott Drive', N'Austin', N'TX', N'78732', N'5124844879', N'nthame9')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (11, N'Tupling', N'Dalli', CAST(N'1993-03-02' AS Date), N'268-34-0711', N'M', N'20333 Jenifer Plaza', N'Toledo', N'OH', N'43615', N'4197484459', N'dtuplinga')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (12, N'Allaker', N'Delcine', CAST(N'1979-02-02' AS Date), N'707-94-4940', N'F', N'561 Superior Center', N'Kansas City', N'MO', N'64160', N'8164449957', N'dallakerb')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (13, N'Brafferton', N'Jacquelyn', CAST(N'1956-11-30' AS Date), N'686-75-2727', N'F', N'7835 Corscot Lane', N'Fairbanks', N'AK', N'99790', N'9078844350', N'jbraffertonc')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (14, N'Gennerich', N'Joice', CAST(N'1974-01-17' AS Date), N'854-09-9052', N'F', N'7 High Crossing Court', N'Daytona Beach', N'FL', N'32128', N'3861855220', N'jgennerichd')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (15, N'Lavielle', N'Livia', CAST(N'1980-12-29' AS Date), N'302-51-8419', N'F', N'204 Northland Junction', N'Miami', N'FL', N'33185', N'3051329143', N'llaviellee')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (16, N'Mattheus', N'Dulciana', CAST(N'1981-07-30' AS Date), N'270-61-0553', N'F', N'6774 Harper Avenue', N'San Francisco', N'CA', N'94164', N'4158066385', N'dmattheusf')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (17, N'Jobern', N'Gunter', CAST(N'1966-01-18' AS Date), N'352-86-0472', N'M', N'0635 Londonderry Trail', N'Des Moines', N'IA', N'50936', N'5152622846', N'gjoberng')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (18, N'Francis', N'Lazarus', CAST(N'1995-11-16' AS Date), N'176-59-7395', N'M', N'10 Lillian Lane', N'New York City', N'NY', N'10014', N'2122103448', N'lfrancish')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (19, N'Kubicka', N'Salim', CAST(N'1964-05-27' AS Date), N'274-01-8290', N'M', N'93032 Valley Edge Crossing', N'Waterbury', N'CT', N'06726', N'2037933668', N'skubickai')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (20, N'Cheel', N'Vidovic', CAST(N'1976-03-31' AS Date), N'586-26-0065', N'M', N'844 Saint Paul Lane', N'Fresno', N'CA', N'93726', N'2093169563', N'vcheelj')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (21, N'Liddon', N'Bathsheba', CAST(N'1971-10-12' AS Date), N'208-25-6483', N'F', N'8 Saint Paul Pass', N'Woburn', N'MA', N'01813', N'3397618253', N'bliddonk')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (22, N'Coathup', N'Demott', CAST(N'1958-12-19' AS Date), N'369-01-7758', N'M', N'70383 Spenser Junction', N'Cincinnati', N'OH', N'45238', N'5139209290', N'dcoathupl')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (23, N'Dresser', N'Alfy', CAST(N'1977-05-20' AS Date), N'386-42-4261', N'F', N'887 Clyde Gallagher Terrace', N'Raleigh', N'NC', N'27635', N'9195511069', N'adresserm')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (24, N'Gutman', N'Papageno', CAST(N'1967-04-22' AS Date), N'264-14-3848', N'M', N'139 Tomscot Crossing', N'Pasadena', N'CA', N'91109', N'8185932338', N'pgutmann')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (25, N'Colley', N'Nathanial', CAST(N'1993-12-31' AS Date), N'777-68-8892', N'M', N'5600 Nelson Plaza', N'Washington', N'DC', N'20099', N'2027629350', N'ncolleyo')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (26, N'Banville', N'Adlai', CAST(N'1983-05-24' AS Date), N'841-57-0479', N'M', N'8195 Bay Terrace', N'Fayetteville', N'NC', N'28314', N'9105254709', N'abanvillep')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (27, N'Loins', N'Rosa', CAST(N'1960-10-14' AS Date), N'396-73-4171', N'F', N'56419 Manitowish Parkway', N'Dallas', N'TX', N'75226', N'9722520588', N'rloinsq')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (28, N'Wyne', N'Lewiss', CAST(N'1993-07-17' AS Date), N'437-95-9489', N'M', N'18 Sommers Pass', N'Fairbanks', N'AK', N'99709', N'9073426396', N'lwyner')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (29, N'Robens', N'Eunice', CAST(N'1975-08-25' AS Date), N'681-98-0076', N'F', N'1389 Clove Drive', N'South Lake Tahoe', N'CA', N'96154', N'5306983720', N'erobenss')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (30, N'Badini', N'Sheppard', CAST(N'1972-12-30' AS Date), N'514-05-8225', N'M', N'31 Laurel Point', N'Denver', N'CO', N'80241', N'3036181551', N'sbadinit')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (31, N'Silliman', N'Helsa', CAST(N'1985-10-14' AS Date), N'491-86-2162', N'F', N'535 Scoville Terrace', N'Las Vegas', N'NV', N'89160', N'7024112412', N'hsillimanu')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (32, N'Kobpa', N'Vonny', CAST(N'1975-09-08' AS Date), N'751-47-0926', N'F', N'67 Dunning Place', N'Seattle', N'WA', N'98133', N'4253961001', N'vkobpav')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (33, N'Tambling', N'Reynold', CAST(N'1993-10-06' AS Date), N'652-19-1240', N'M', N'18722 Brickson Park Avenue', N'Columbus', N'OH', N'43226', N'6144618237', N'rtamblingw')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (34, N'Dunthorn', N'Patrice', CAST(N'1983-08-21' AS Date), N'509-84-7941', N'M', N'10 Novick Drive', N'Albany', N'GA', N'31704', N'2294089313', N'pdunthornx')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (35, N'Giblin', N'Lyda', CAST(N'1961-02-15' AS Date), N'841-83-3336', N'F', N'11644 Pond Road', N'Carson City', N'NV', N'89714', N'7755950905', N'lgibliny')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (36, N'Bambrugh', N'Eugine', CAST(N'1963-11-28' AS Date), N'803-69-8716', N'F', N'09544 Oak Valley Lane', N'Pompano Beach', N'FL', N'33069', N'7547449092', N'ebambrughz')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (37, N'Staning', N'Torre', CAST(N'1988-04-10' AS Date), N'780-03-8037', N'M', N'02937 Bartillon Crossing', N'Salem', N'OR', N'97312', N'9715464369', N'tstaning10')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (38, N'Mander', N'Germana', CAST(N'1982-05-13' AS Date), N'663-76-6829', N'F', N'2968 Lotheville Court', N'San Francisco', N'CA', N'94126', N'4155668269', N'gmander11')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (39, N'Leger', N'Nealy', CAST(N'1997-09-05' AS Date), N'142-80-8015', N'M', N'2 Blaine Place', N'Atlanta', N'GA', N'30328', N'4046644182', N'nleger12')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (40, N'Slayton', N'Bunnie', CAST(N'1970-03-01' AS Date), N'813-12-4902', N'F', N'819 Fuller Point', N'Oklahoma City', N'OK', N'73157', N'4058447162', N'bslayton13')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (41, N'Harse', N'Lucio', CAST(N'1998-05-28' AS Date), N'130-79-5722', N'M', N'55 Boyd Park', N'Atlanta', N'GA', N'30368', N'4049346308', N'lharse14')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (42, N'Watts', N'Freddie', CAST(N'1982-10-07' AS Date), N'249-79-3382', N'F', N'77265 Forster Pass', N'Columbus', N'OH', N'43284', N'6148190547', N'fwatts15')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (43, N'Helbeck', N'Wilden', CAST(N'1966-01-14' AS Date), N'101-45-8776', N'M', N'1 Fallview Junction', N'Saint Paul', N'MN', N'55114', N'6512302592', N'whelbeck16')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (44, N'Kitchinghan', N'Felicdad', CAST(N'1981-12-08' AS Date), N'352-39-7356', N'F', N'8726 Hudson Center', N'Northridge', N'CA', N'91328', N'8181542452', N'fkitchinghan17')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (45, N'Joint', N'Tanitansy', CAST(N'1975-05-28' AS Date), N'631-48-5192', N'F', N'10 Rockefeller Crossing', N'Boston', N'MA', N'02216', N'6176232457', N'tjoint18')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (46, N'Klassmann', N'Raimondo', CAST(N'1955-11-02' AS Date), N'224-71-0374', N'M', N'6 Walton Alley', N'Dayton', N'OH', N'45426', N'9373337848', N'rklassmann19')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (47, N'Gregs', N'Fanechka', CAST(N'1966-04-01' AS Date), N'461-79-2429', N'F', N'22 Mosinee Lane', N'Tampa', N'FL', N'33694', N'8131583474', N'fgregs1a')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (48, N'Coggon', N'Jana', CAST(N'1996-03-24' AS Date), N'291-45-1521', N'F', N'1 Karstens Parkway', N'Waco', N'TX', N'76705', N'2544946900', N'jcoggon1b')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (49, N'Bolino', N'Isidora', CAST(N'1979-05-18' AS Date), N'509-74-1237', N'F', N'5427 Lawn Street', N'Chandler', N'AZ', N'85246', N'6029051755', N'ibolino1c')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (50, N'Elliss', N'Eward', CAST(N'1968-08-22' AS Date), N'645-30-3698', N'M', N'6 Hagan Drive', N'Washington', N'DC', N'20414', N'2026182342', N'eelliss1d')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (51, N'Bowie', N'Phyllida', CAST(N'1957-12-18' AS Date), N'214-68-1774', N'F', N'53 Bay Street', N'Amarillo', N'TX', N'79176', N'8069868097', N'pbowie1e')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (52, N'Broun', N'Ogden', CAST(N'1962-08-28' AS Date), N'222-12-2289', N'M', N'62 Acker Circle', N'Charleston', N'WV', N'25362', N'3046493343', N'obroun1f')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (53, N'Garlic', N'Elsey', CAST(N'1978-10-22' AS Date), N'390-28-6391', N'F', N'8 Mcbride Drive', N'Roanoke', N'VA', N'24004', N'5401357511', N'egarlic1g')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (54, N'Subhan', N'Jase', CAST(N'1989-10-14' AS Date), N'740-87-6007', N'M', N'0 Hintze Way', N'Sioux Falls', N'SD', N'57110', N'6058547683', N'jsubhan1h')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (55, N'D''Aulby', N'Berty', CAST(N'1969-10-16' AS Date), N'765-62-1675', N'M', N'79208 Schurz Circle', N'Boston', N'MA', N'02203', N'6177568983', N'bdaulby1i')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (56, N'Minet', N'Garrick', CAST(N'1961-11-08' AS Date), N'576-90-4907', N'M', N'3 Montana Point', N'Miami', N'FL', N'33180', N'7866756428', N'gminet1j')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (57, N'Crissil', N'Lark', CAST(N'1981-11-23' AS Date), N'891-16-7972', N'F', N'56723 Morningstar Center', N'Van Nuys', N'CA', N'91499', N'2134273297', N'lcrissil1k')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (58, N'O''Donegan', N'Bern', CAST(N'1981-08-10' AS Date), N'426-86-6082', N'M', N'0 Prentice Road', N'Hartford', N'CT', N'06183', N'8606712004', N'bodonegan1l')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (59, N'Duchart', N'Marcelo', CAST(N'1957-08-16' AS Date), N'644-16-0521', N'M', N'12 Everett Place', N'Boston', N'MA', N'02216', N'6173823329', N'mduchart1m')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (60, N'Rowledge', N'Bobette', CAST(N'1982-11-21' AS Date), N'300-42-6359', N'F', N'79802 Helena Point', N'Beaverton', N'OR', N'97075', N'5036971370', N'browledge1n')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (61, N'Carloni', N'Brenna', CAST(N'1971-10-03' AS Date), N'661-12-6332', N'F', N'91 Vermont Circle', N'Evanston', N'IL', N'60208', N'8471733392', N'bcarloni1o')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (62, N'Coulthart', N'Kaile', CAST(N'1969-10-07' AS Date), N'428-55-6063', N'F', N'123 Clarendon Street', N'Saint Paul', N'MN', N'55123', N'6126678250', N'kcoulthart1p')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (63, N'Pottage', N'Alina', CAST(N'1987-02-04' AS Date), N'772-59-4749', N'F', N'772 Holmberg Terrace', N'Jersey City', N'NJ', N'07305', N'2016382964', N'apottage1q')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (64, N'Enston', N'Maxi', CAST(N'1974-08-12' AS Date), N'103-61-9587', N'F', N'9050 Amoth Plaza', N'Arlington', N'VA', N'22225', N'5718758227', N'menston1r')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (65, N'Cunradi', N'Jennette', CAST(N'1990-12-23' AS Date), N'531-89-5176', N'F', N'517 Derek Alley', N'Hicksville', N'NY', N'11854', N'5161236192', N'jcunradi1s')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (66, N'O''Nolan', N'Cissy', CAST(N'1996-03-16' AS Date), N'424-13-6393', N'F', N'0451 Forest Run Road', N'Grand Junction', N'CO', N'81505', N'9702046303', N'conolan1t')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (67, N'Toll', N'Dulcinea', CAST(N'1987-04-26' AS Date), N'686-05-8937', N'F', N'265 Warbler Center', N'Seminole', N'FL', N'34642', N'9415859850', N'dtoll1u')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (68, N'Leighfield', N'Shane', CAST(N'1980-08-15' AS Date), N'268-68-8419', N'M', N'77 Kim Way', N'Scranton', N'PA', N'18505', N'5706884108', N'sleighfield1v')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (69, N'Deetlof', N'Masha', CAST(N'1982-07-18' AS Date), N'766-82-3853', N'F', N'62 Norway Maple Crossing', N'Birmingham', N'AL', N'35220', N'2054598037', N'mdeetlof1w')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (70, N'Vanns', N'Torie', CAST(N'1982-06-30' AS Date), N'748-98-3658', N'F', N'009 Rockefeller Crossing', N'Boston', N'MA', N'02283', N'9786266050', N'tvanns1x')
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (71, N'Burl', N'Red', CAST(N'1967-03-27' AS Date), N'217-50-9767', N'M', N'95265 Raven Parkway', N'Harrisburg', N'PA', N'17126', N'7175936211', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (72, N'Klampk', N'Ariel', CAST(N'1963-12-24' AS Date), N'610-57-5903', N'M', N'86 Parkside Trail', N'Kansas City', N'MO', N'64187', N'8168992228', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (73, N'Kirkam', N'Tiertza', CAST(N'1958-10-28' AS Date), N'106-42-5875', N'F', N'9267 Dapin Crossing', N'Santa Fe', N'NM', N'87592', N'5055373149', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (74, N'Stiegar', N'Petronilla', CAST(N'1959-10-02' AS Date), N'643-03-6868', N'F', N'1 Lunder Park', N'Miami', N'FL', N'33124', N'7867796568', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (75, N'Gerdes', N'Jami', CAST(N'1959-06-18' AS Date), N'786-90-3578', N'F', N'5073 Barby Junction', N'Kansas City', N'MO', N'64125', N'8168866173', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (76, N'Lummis', N'Hersh', CAST(N'1976-03-26' AS Date), N'286-83-1670', N'M', N'22 Graceland Drive', N'Virginia Beach', N'VA', N'23464', N'7577991805', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (77, N'Ebertz', N'Frieda', CAST(N'1983-12-24' AS Date), N'377-97-9078', N'F', N'6753 Vermont Avenue', N'Waco', N'TX', N'76711', N'2549720796', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (78, N'Lapish', N'Lanae', CAST(N'1974-04-21' AS Date), N'186-23-5255', N'F', N'8 Kennedy Center', N'Johnstown', N'PA', N'15906', N'8149194991', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (79, N'Farrier', N'Reagan', CAST(N'1992-07-13' AS Date), N'382-14-9404', N'M', N'25 Pleasure Junction', N'Spokane', N'WA', N'99220', N'5093770527', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (80, N'Littleton', N'Arlana', CAST(N'1999-01-02' AS Date), N'250-98-8091', N'F', N'987 Toban Crossing', N'Jamaica', N'NY', N'11499', N'2122267355', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (81, N'Germann', N'Petey', CAST(N'1958-09-07' AS Date), N'840-08-4199', N'M', N'0 Graedel Junction', N'Chicago', N'IL', N'60697', N'3124352106', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (82, N'Millership', N'Sanson', CAST(N'1985-06-04' AS Date), N'807-65-2702', N'M', N'33579 Helena Avenue', N'Boise', N'ID', N'83711', N'2085072218', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (83, N'Ottiwill', N'Temp', CAST(N'1998-03-13' AS Date), N'344-47-4585', N'M', N'19355 Delaware Trail', N'San Antonio', N'TX', N'78240', N'2106658471', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (84, N'Jakov', N'Donaugh', CAST(N'1990-09-12' AS Date), N'884-94-7887', N'M', N'012 Westridge Road', N'Jackson', N'MS', N'39210', N'6014839268', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (85, N'Woolmer', N'Borden', CAST(N'1957-08-28' AS Date), N'244-75-2955', N'M', N'44294 Bellgrove Place', N'Seattle', N'WA', N'98109', N'4255366937', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (86, N'Gillinghams', N'Lelia', CAST(N'1995-12-14' AS Date), N'402-15-5176', N'F', N'4 Clarendon Lane', N'Lexington', N'KY', N'40510', N'8599070446', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (87, N'Scholtis', N'Xavier', CAST(N'1994-03-24' AS Date), N'363-40-6914', N'M', N'89 American Terrace', N'Cleveland', N'OH', N'44177', N'2165836939', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (88, N'Cozzi', N'Norman', CAST(N'1956-06-27' AS Date), N'499-26-9887', N'M', N'39 Stephen Way', N'Detroit', N'MI', N'48217', N'3137842413', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (89, N'Hagstone', N'Vanya', CAST(N'1982-01-07' AS Date), N'361-80-4007', N'M', N'84302 8th Crossing', N'Monticello', N'MN', N'55565', N'7632733175', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (90, N'Orpin', N'Colas', CAST(N'1971-10-05' AS Date), N'521-02-1613', N'M', N'7398 Harper Point', N'Omaha', N'NE', N'68110', N'4023828239', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (91, N'Genders', N'Morena', CAST(N'1973-05-07' AS Date), N'421-49-6656', N'F', N'17707 Havey Point', N'Louisville', N'KY', N'40233', N'5024055809', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (92, N'Erwin', N'Ingemar', CAST(N'1979-12-15' AS Date), N'752-88-8217', N'M', N'5944 Del Mar Hill', N'Oklahoma City', N'OK', N'73109', N'4059901198', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (93, N'Heugel', N'Harmony', CAST(N'1982-12-29' AS Date), N'786-55-7019', N'F', N'12 Gerald Parkway', N'Sioux City', N'IA', N'51105', N'7121034699', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (94, N'Noice', N'Ninon', CAST(N'1990-05-10' AS Date), N'413-41-5912', N'F', N'87001 Superior Point', N'Jackson', N'MS', N'39216', N'6017323985', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (95, N'De Zamudio', N'Alic', CAST(N'1983-10-29' AS Date), N'566-90-1784', N'M', N'921 Hanson Hill', N'Salt Lake City', N'UT', N'84199', N'8012220221', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (96, N'Voelker', N'Cleon', CAST(N'1996-12-15' AS Date), N'235-26-2739', N'M', N'56 Melrose Park', N'Round Rock', N'TX', N'78682', N'5129608352', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (97, N'Cashmore', N'Freemon', CAST(N'1991-11-12' AS Date), N'847-99-4993', N'M', N'1 Miller Lane', N'Minneapolis', N'MN', N'55470', N'6125417826', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (98, N'Flecknoe', N'Wadsworth', CAST(N'1990-03-06' AS Date), N'597-32-1452', N'M', N'330 Scofield Way', N'Jacksonville', N'FL', N'32215', N'9043955938', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (99, N'Bourthoumieux', N'Sydelle', CAST(N'1968-11-28' AS Date), N'301-63-1156', N'F', N'878 Arkansas Point', N'White Plains', N'NY', N'10606', N'8451060767', NULL)
GO
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (100, N'Rammell', N'Andrej', CAST(N'1992-10-20' AS Date), N'682-41-7501', N'M', N'8 Milwaukee Trail', N'Saint Petersburg', N'FL', N'33710', N'7278457968', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (101, N'Ewings', N'Nara', CAST(N'1955-04-07' AS Date), N'695-24-6249', N'F', N'355 Bluestem Plaza', N'Baltimore', N'MD', N'21216', N'4103201120', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (102, N'Pechan', N'Adrianna', CAST(N'1962-06-10' AS Date), N'881-31-1635', N'F', N'581 Killdeer Junction', N'Baltimore', N'MD', N'21229', N'4434390782', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (103, N'Gasparro', N'Wilton', CAST(N'1970-04-23' AS Date), N'127-41-3064', N'M', N'98950 Charing Cross Junction', N'Austin', N'TX', N'78710', N'5128665301', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (104, N'Methley', N'Donetta', CAST(N'1962-05-29' AS Date), N'858-53-5454', N'F', N'77256 John Wall Center', N'West Hartford', N'CT', N'06127', N'8601680433', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (105, N'Calender', N'Nikos', CAST(N'1959-03-21' AS Date), N'552-51-9579', N'M', N'7823 Katie Trail', N'Baton Rouge', N'LA', N'70815', N'2255500945', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (106, N'Gosz', N'Barbe', CAST(N'1994-02-06' AS Date), N'369-48-3529', N'F', N'12068 Granby Parkway', N'Montgomery', N'AL', N'36114', N'3349800847', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (107, N'Cotgrave', N'Justino', CAST(N'1957-01-24' AS Date), N'452-94-5077', N'M', N'8243 Clemons Pass', N'Littleton', N'CO', N'80161', N'7204671233', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (108, N'Presnail', N'Josee', CAST(N'1994-08-18' AS Date), N'141-37-1311', N'F', N'5 Sunbrook Alley', N'South Bend', N'IN', N'46634', N'5746712119', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (109, N'Bosson', N'Cristiano', CAST(N'1997-02-16' AS Date), N'479-27-1920', N'M', N'5726 Jenifer Road', N'Palo Alto', N'CA', N'94302', N'6505354682', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (110, N'Craister', N'Ilysa', CAST(N'1974-01-24' AS Date), N'619-87-8415', N'F', N'5 Hayes Point', N'Myrtle Beach', N'SC', N'29579', N'8437910286', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (111, N'Rodway', N'Tiler', CAST(N'1967-02-15' AS Date), N'805-21-6707', N'M', N'0 Annamark Center', N'Washington', N'DC', N'20456', N'2022025325', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (112, N'Caroll', N'Louise', CAST(N'1981-04-18' AS Date), N'382-01-6478', N'F', N'049 Mandrake Center', N'Shawnee Mission', N'KS', N'66225', N'9133064240', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (113, N'Clear', N'Aubrey', CAST(N'1982-06-28' AS Date), N'438-11-1812', N'F', N'56 Bonner Hill', N'Seminole', N'FL', N'34642', N'9411855779', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (114, N'Redborn', N'Annaliese', CAST(N'1977-10-25' AS Date), N'466-57-6944', N'F', N'4676 Leroy Point', N'Paterson', N'NJ', N'07522', N'9735057485', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (115, N'Utley', N'Sandi', CAST(N'1989-04-15' AS Date), N'380-98-0330', N'F', N'41 Fair Oaks Lane', N'Huntington', N'WV', N'25705', N'3041645400', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (116, N'Clampin', N'Orelee', CAST(N'1974-12-02' AS Date), N'333-80-1642', N'F', N'35846 Coolidge Circle', N'Houston', N'TX', N'77095', N'7132127809', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (117, N'Bernuzzi', N'Gunther', CAST(N'1979-12-03' AS Date), N'146-98-5975', N'M', N'2631 Anderson Street', N'Racine', N'WI', N'53405', N'2625954043', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (118, N'Ayris', N'Chery', CAST(N'1973-08-26' AS Date), N'667-34-1057', N'F', N'99 Amoth Trail', N'Omaha', N'NE', N'68164', N'4028858744', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (119, N'Lobb', N'Laurie', CAST(N'1969-06-20' AS Date), N'315-50-3811', N'F', N'637 Oakridge Trail', N'Tampa', N'FL', N'33647', N'8136839190', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (120, N'Weekes', N'Brantley', CAST(N'1957-08-17' AS Date), N'777-29-1770', N'M', N'0388 Walton Park', N'Columbia', N'MO', N'65211', N'5739082429', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (121, N'Woodwin', N'Meggy', CAST(N'1987-03-17' AS Date), N'795-45-2709', N'F', N'2 Mandrake Drive', N'Los Angeles', N'CA', N'90094', N'3233088342', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (122, N'Ailsbury', N'Sanson', CAST(N'1974-11-25' AS Date), N'662-15-5161', N'M', N'933 Browning Terrace', N'Lubbock', N'TX', N'79415', N'8064869641', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (123, N'Symson', N'Elyssa', CAST(N'1986-08-28' AS Date), N'329-89-1748', N'F', N'20322 Arapahoe Lane', N'Billings', N'MT', N'59112', N'4063594702', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (124, N'Tolomio', N'Bertrand', CAST(N'1976-04-08' AS Date), N'171-75-9167', N'M', N'8 Saint Paul Crossing', N'Fairbanks', N'AK', N'99709', N'9078694259', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (125, N'Klaff', N'Gaby', CAST(N'1991-08-08' AS Date), N'730-36-0924', N'M', N'4220 Sunbrook Street', N'Anchorage', N'AK', N'99599', N'9073818442', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (126, N'Lorne', N'Alard', CAST(N'1968-05-13' AS Date), N'711-61-3040', N'M', N'8818 Bartelt Terrace', N'Seattle', N'WA', N'98185', N'2069382442', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (127, N'Pledge', N'Ricoriki', CAST(N'1958-03-16' AS Date), N'413-02-7345', N'M', N'491 Vera Crossing', N'Montgomery', N'AL', N'36177', N'3343763005', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (128, N'Ewbank', N'Gaylord', CAST(N'1967-12-02' AS Date), N'549-35-4208', N'M', N'367 Algoma Trail', N'Longview', N'TX', N'75605', N'9031746643', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (129, N'Haldene', N'Coriss', CAST(N'1978-08-25' AS Date), N'311-48-4387', N'F', N'859 Aberg Parkway', N'Irvine', N'CA', N'92710', N'7144094553', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (130, N'Benny', N'Lawton', CAST(N'1977-06-30' AS Date), N'623-36-3587', N'M', N'4852 Continental Street', N'Pasadena', N'CA', N'91103', N'3231940821', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (131, N'Ten Broek', N'Peder', CAST(N'1996-08-29' AS Date), N'421-96-7175', N'M', N'8466 Porter Road', N'Chattanooga', N'TN', N'37450', N'4239592624', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (132, N'Woolpert', N'Dominique', CAST(N'1981-01-20' AS Date), N'898-32-3841', N'F', N'2 Maryland Lane', N'New York City', N'NY', N'10184', N'2127976769', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (133, N'Deex', N'Blair', CAST(N'1997-04-16' AS Date), N'391-66-9063', N'M', N'68321 Anzinger Plaza', N'Clearwater', N'FL', N'33758', N'8136576619', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (134, N'Coytes', N'Catherina', CAST(N'1972-07-02' AS Date), N'586-79-5523', N'F', N'891 Crest Line Pass', N'Pompano Beach', N'FL', N'33069', N'9549342142', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (135, N'Orman', N'Reidar', CAST(N'1985-01-12' AS Date), N'238-26-4245', N'M', N'8027 Shopko Circle', N'Denver', N'CO', N'80262', N'3039932364', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (136, N'Edmondson', N'Golda', CAST(N'1978-10-13' AS Date), N'407-70-6018', N'F', N'6 Ridgeview Hill', N'Houston', N'TX', N'77299', N'7137860108', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (137, N'Lucas', N'Raddy', CAST(N'1996-04-29' AS Date), N'784-33-1492', N'M', N'9475 Algoma Parkway', N'Honolulu', N'HI', N'96835', N'8089663199', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (138, N'Canada', N'Cathe', CAST(N'1972-03-04' AS Date), N'854-94-4267', N'F', N'12 Starling Pass', N'Washington', N'DC', N'20205', N'2029886968', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (139, N'Hurst', N'Mahmoud', CAST(N'1974-03-02' AS Date), N'340-79-7795', N'M', N'834 Declaration Parkway', N'Winter Haven', N'FL', N'33884', N'8633280076', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (140, N'Baldelli', N'Pryce', CAST(N'1958-11-16' AS Date), N'320-16-4135', N'M', N'724 Red Cloud Trail', N'Charleston', N'WV', N'25362', N'3045300753', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (141, N'Kiddye', N'Linnea', CAST(N'1963-01-24' AS Date), N'774-88-9846', N'F', N'6 Pawling Alley', N'Denver', N'CO', N'80204', N'3039282908', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (142, N'Tankard', N'Rickard', CAST(N'1987-10-11' AS Date), N'615-93-5983', N'M', N'2179 Derek Center', N'Los Angeles', N'CA', N'90045', N'3101158052', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (143, N'Forty', N'Claus', CAST(N'1990-04-16' AS Date), N'887-87-5307', N'M', N'5525 Center Avenue', N'Greensboro', N'NC', N'27499', N'3361824224', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (144, N'Bennoe', N'Benedict', CAST(N'1993-09-10' AS Date), N'820-97-9865', N'M', N'7 Cherokee Circle', N'Sacramento', N'CA', N'94250', N'9164393958', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (145, N'Shird', N'Hortensia', CAST(N'1997-01-12' AS Date), N'485-12-3335', N'F', N'735 Surrey Circle', N'San Rafael', N'CA', N'94913', N'4153387933', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (146, N'Ritchard', N'Juieta', CAST(N'1991-09-22' AS Date), N'876-40-4751', N'F', N'1 Shelley Plaza', N'Sacramento', N'CA', N'95828', N'9161688106', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (147, N'Sehorsch', N'Gallard', CAST(N'1957-07-07' AS Date), N'440-19-1608', N'M', N'864 Hudson Center', N'Tacoma', N'WA', N'98481', N'2538578001', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (148, N'Almak', N'Agustin', CAST(N'1978-11-10' AS Date), N'613-78-4826', N'M', N'824 Trailsway Alley', N'Oklahoma City', N'OK', N'73109', N'4056616265', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (149, N'Bubbins', N'Isac', CAST(N'1977-09-29' AS Date), N'112-55-5064', N'M', N'91268 Portage Trail', N'Anaheim', N'CA', N'92812', N'7141819381', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (150, N'Kerin', N'Arch', CAST(N'1969-08-19' AS Date), N'510-25-9007', N'M', N'74212 Clarendon Circle', N'Wilkes Barre', N'PA', N'18763', N'5705502445', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (151, N'Sacaze', N'Sig', CAST(N'1980-10-31' AS Date), N'287-57-1042', N'M', N'544 Bobwhite Pass', N'Harrisburg', N'PA', N'17126', N'7171594244', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (152, N'Matushenko', N'Tomaso', CAST(N'1988-12-01' AS Date), N'614-69-3549', N'M', N'08654 Mariners Cove Avenue', N'Sacramento', N'CA', N'95894', N'9167097721', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (153, N'Ingham', N'Larisa', CAST(N'1959-07-11' AS Date), N'497-25-6795', N'F', N'282 Eastlawn Way', N'Stamford', N'CT', N'06922', N'2034044804', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (154, N'Karpol', N'Sylas', CAST(N'1980-04-09' AS Date), N'722-22-9099', N'M', N'78264 Bartillon Parkway', N'Evansville', N'IN', N'47725', N'8128246531', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (155, N'Macvain', N'Maritsa', CAST(N'1955-05-03' AS Date), N'176-64-4680', N'F', N'99325 Linden Way', N'Chula Vista', N'CA', N'91913', N'6194813827', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (156, N'Allpress', N'Eziechiele', CAST(N'1971-11-03' AS Date), N'470-37-6964', N'M', N'0 Southridge Center', N'Baltimore', N'MD', N'21203', N'4105090955', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (157, N'Pharaoh', N'Boot', CAST(N'1979-03-18' AS Date), N'889-65-8128', N'M', N'2 Anzinger Avenue', N'Albany', N'NY', N'12247', N'5183293641', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (158, N'Hanlin', N'Brien', CAST(N'1967-01-21' AS Date), N'502-20-8764', N'M', N'91 Declaration Lane', N'Austin', N'TX', N'78726', N'5127811295', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (159, N'Woollam', N'Nicoli', CAST(N'1974-12-11' AS Date), N'638-24-5453', N'F', N'4 Killdeer Lane', N'Washington', N'DC', N'20470', N'2028655748', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (160, N'Fort', N'Jerrine', CAST(N'1997-12-02' AS Date), N'804-72-3012', N'F', N'5 Saint Paul Way', N'Baltimore', N'MD', N'21216', N'4105584270', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (161, N'Sarre', N'Shaw', CAST(N'1991-04-14' AS Date), N'660-50-3226', N'M', N'2648 North Junction', N'Orlando', N'FL', N'32868', N'4073981690', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (162, N'Lodge', N'Gae', CAST(N'1998-12-26' AS Date), N'454-47-2498', N'F', N'4672 Pennsylvania Avenue', N'Miami', N'FL', N'33245', N'7864570913', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (163, N'Bowller', N'Astrix', CAST(N'1986-03-12' AS Date), N'761-12-5355', N'F', N'6569 Lakewood Way', N'Newark', N'NJ', N'07112', N'9732423726', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (164, N'Simoes', N'Jessie', CAST(N'1993-04-21' AS Date), N'448-70-2661', N'M', N'4 Lakewood Center', N'Rochester', N'NY', N'14683', N'5856936877', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (165, N'Gookey', N'Trey', CAST(N'1965-02-05' AS Date), N'763-94-2039', N'M', N'233 Merchant Junction', N'Orlando', N'FL', N'32891', N'4076082346', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (166, N'Halshaw', N'Jeffrey', CAST(N'1995-11-04' AS Date), N'316-98-0054', N'M', N'207 Morningstar Center', N'Corpus Christi', N'TX', N'78465', N'3611752400', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (167, N'Labbett', N'Sonny', CAST(N'1993-02-12' AS Date), N'489-20-9784', N'F', N'1 Main Way', N'Lancaster', N'PA', N'17605', N'7173400298', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (168, N'Almey', N'Seamus', CAST(N'1970-02-06' AS Date), N'261-25-8680', N'M', N'92 Namekagon Point', N'Oklahoma City', N'OK', N'73167', N'4051098052', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (169, N'Sante', N'Glenna', CAST(N'1993-04-13' AS Date), N'440-53-2476', N'F', N'6 Hazelcrest Center', N'Evansville', N'IN', N'47712', N'8121665716', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (170, N'Bert', N'Nichole', CAST(N'1982-08-04' AS Date), N'243-76-1212', N'M', N'5351 Nancy Way', N'Jeffersonville', N'IN', N'47134', N'8124195031', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (171, N'Kennicott', N'Vivien', CAST(N'1966-07-31' AS Date), N'355-17-9751', N'F', N'96 Stuart Pass', N'Kalamazoo', N'MI', N'49048', N'2698535307', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (172, N'Giraldon', N'Osborne', CAST(N'1985-10-19' AS Date), N'803-40-9667', N'M', N'54 Nelson Trail', N'Huntington', N'WV', N'25726', N'3045792895', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (173, N'Southwood', N'Cyndia', CAST(N'1980-09-12' AS Date), N'448-71-1653', N'F', N'6 Canary Alley', N'Fargo', N'ND', N'58106', N'7019265334', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (174, N'Abbets', N'Osbert', CAST(N'1977-11-23' AS Date), N'316-09-0934', N'M', N'867 5th Lane', N'Charlotte', N'NC', N'28235', N'7047549752', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (175, N'Arthy', N'Rock', CAST(N'1980-03-27' AS Date), N'389-69-6319', N'M', N'2535 Lighthouse Bay Lane', N'Anaheim', N'CA', N'92812', N'7146280775', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (176, N'Kupka', N'Hernando', CAST(N'1988-03-17' AS Date), N'117-88-6545', N'M', N'0100 Gale Hill', N'Phoenix', N'AZ', N'85035', N'6024633723', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (177, N'Juggings', N'Gussy', CAST(N'1973-09-08' AS Date), N'390-11-1863', N'F', N'39966 Schmedeman Terrace', N'Duluth', N'GA', N'30195', N'7702879142', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (178, N'Sone', N'Vevay', CAST(N'1987-11-07' AS Date), N'570-40-3968', N'F', N'399 Novick Place', N'White Plains', N'NY', N'10606', N'8453510694', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (179, N'Tewes', N'Gussy', CAST(N'1986-01-26' AS Date), N'373-52-9821', N'F', N'31 Namekagon Road', N'Austin', N'TX', N'78783', N'5127810785', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (180, N'Cussins', N'Elfrieda', CAST(N'1966-06-18' AS Date), N'418-10-4323', N'F', N'7 Moose Plaza', N'Northridge', N'CA', N'91328', N'8187782684', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (181, N'Liepins', N'Rhetta', CAST(N'1997-03-15' AS Date), N'298-05-7918', N'F', N'75 Manitowish Pass', N'Cincinnati', N'OH', N'45271', N'5138464418', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (182, N'Kippie', N'Friederike', CAST(N'1970-12-22' AS Date), N'658-65-7567', N'F', N'2314 Division Road', N'Chicago', N'IL', N'60652', N'3125195762', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (183, N'De Benedictis', N'Harley', CAST(N'1976-12-08' AS Date), N'528-19-6715', N'F', N'08 Old Shore Junction', N'Irvine', N'CA', N'92717', N'7149217817', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (184, N'Yelding', N'Basilio', CAST(N'1971-08-25' AS Date), N'225-17-2191', N'M', N'872 Golf View Lane', N'Dallas', N'TX', N'75260', N'2149459320', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (185, N'Mucci', N'Zorana', CAST(N'1970-05-19' AS Date), N'273-70-4998', N'F', N'1244 Scott Circle', N'Fresno', N'CA', N'93715', N'2095932769', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (186, N'McInnes', N'Freedman', CAST(N'1987-11-09' AS Date), N'795-41-7311', N'M', N'2979 Moulton Drive', N'New York City', N'NY', N'10060', N'6465487942', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (187, N'Kondrat', N'Briney', CAST(N'1978-05-01' AS Date), N'326-68-1568', N'F', N'5139 Linden Parkway', N'Huntsville', N'AL', N'35805', N'2566256326', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (188, N'Vedeniktov', N'Sella', CAST(N'1986-08-09' AS Date), N'320-42-9297', N'F', N'9 Lighthouse Bay Center', N'Philadelphia', N'PA', N'19115', N'2675838497', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (189, N'Cressingham', N'Dianne', CAST(N'1989-02-05' AS Date), N'395-28-9430', N'F', N'87 Nevada Drive', N'Scranton', N'PA', N'18514', N'5707505126', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (190, N'Fardon', N'Aridatha', CAST(N'1981-04-27' AS Date), N'634-26-5917', N'F', N'8 Farmco Alley', N'Miami', N'FL', N'33185', N'3054433724', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (191, N'Logan', N'Thomasina', CAST(N'1979-08-13' AS Date), N'884-79-5480', N'F', N'67 Karstens Place', N'Cleveland', N'OH', N'44191', N'2165184609', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (192, N'Cumbridge', N'Jewel', CAST(N'1979-05-18' AS Date), N'279-54-5827', N'F', N'20 Summer Ridge Plaza', N'New Orleans', N'LA', N'70165', N'5041441191', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (193, N'Josum', N'Godard', CAST(N'1997-06-25' AS Date), N'596-53-2874', N'M', N'90649 Warbler Alley', N'Las Vegas', N'NV', N'89178', N'7024277990', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (194, N'Croyden', N'Jewell', CAST(N'1995-07-20' AS Date), N'877-73-3681', N'F', N'60 Florence Drive', N'Corpus Christi', N'TX', N'78410', N'3617961423', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (195, N'Pyburn', N'Nixie', CAST(N'1966-03-26' AS Date), N'781-21-6135', N'F', N'6134 Oakridge Street', N'Indianapolis', N'IN', N'46231', N'3176851865', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (196, N'O'' Loughran', N'Lizabeth', CAST(N'1986-07-03' AS Date), N'893-28-0640', N'F', N'30 Porter Plaza', N'Corona', N'CA', N'92883', N'6269745017', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (197, N'Mc Trusty', N'Misti', CAST(N'1961-08-08' AS Date), N'495-72-5271', N'F', N'694 Morning Way', N'Phoenix', N'AZ', N'85020', N'6029249138', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (198, N'Antonnikov', N'Carmine', CAST(N'1991-05-04' AS Date), N'425-26-2769', N'M', N'87252 Roxbury Way', N'Schaumburg', N'IL', N'60193', N'3128677354', NULL)
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (199, N'Hukins', N'Dom', CAST(N'1967-03-12' AS Date), N'834-86-1004', N'M', N'09674 Grover Alley', N'Nashville', N'TN', N'37210', N'6156019886', NULL)
GO
INSERT [dbo].[Person] ([personID], [lastName], [firstName], [birthDate], [SSN], [gender], [streetAddress], [city], [state], [postCode], [phoneNumber], [username]) VALUES (200, N'Gogerty', N'Neille', CAST(N'1972-07-13' AS Date), N'395-51-2381', N'F', N'8 Golf Course Point', N'Mobile', N'AL', N'36610', N'2514541033', NULL)
SET IDENTITY_INSERT [dbo].[Person] OFF
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (1, 4, CAST(N'2019-01-01T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (4, 6, CAST(N'2018-11-21T00:00:00.000' AS DateTime), 0, N'Embryonic cyst of cervix')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (4, 7, CAST(N'2018-09-30T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (5, 2, CAST(N'2018-10-18T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (5, 9, CAST(N'2018-07-28T00:00:00.000' AS DateTime), 0, N'Toxic effect of carbon monoxide from other source, accidental (unintentional), subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (8, 3, CAST(N'2018-05-07T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (8, 5, CAST(N'2018-06-09T00:00:00.000' AS DateTime), 0, N'Siderosis of eye, bilateral')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (8, 8, CAST(N'2018-08-07T00:00:00.000' AS DateTime), 0, N'Intraventricular (nontraumatic) hemorrhage, grade 1, of newborn')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (10, 7, CAST(N'2019-01-17T00:00:00.000' AS DateTime), 1, N'Nondisplaced fracture of anterior wall of left acetabulum, subsequent encounter for fracture with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (11, 5, CAST(N'2019-01-26T00:00:00.000' AS DateTime), 1, N'Leukokeratosis nicotina palati')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (11, 9, CAST(N'2019-01-12T00:00:00.000' AS DateTime), 0, N'Adult osteochondrosis of spine, thoracic region')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (12, 2, CAST(N'2018-07-06T00:00:00.000' AS DateTime), 1, N'Melanocytic nevi')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (12, 9, CAST(N'2018-10-28T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (13, 1, CAST(N'2019-01-27T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (15, 5, CAST(N'2018-05-17T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (15, 6, CAST(N'2018-09-19T00:00:00.000' AS DateTime), 0, N'Other fracture of shaft of radius, unspecified arm, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (18, 5, CAST(N'2019-02-25T00:00:00.000' AS DateTime), 0, N'Laceration with foreign body of right wrist, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (19, 6, CAST(N'2018-05-22T00:00:00.000' AS DateTime), 0, N'Other superficial bite of unspecified part of neck')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (19, 8, CAST(N'2018-05-06T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (20, 1, CAST(N'2019-02-26T00:00:00.000' AS DateTime), 0, N'Spontaneous rupture of extensor tendons, right upper arm')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (20, 4, CAST(N'2019-02-19T00:00:00.000' AS DateTime), 0, N'Burn of third degree of other site of trunk, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (22, 1, CAST(N'2018-11-08T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (22, 9, CAST(N'2019-02-16T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (23, 5, CAST(N'2019-03-08T00:00:00.000' AS DateTime), 0, N'Unspecified injury of unspecified blood vessel at forearm level, unspecified arm, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (24, 7, CAST(N'2018-04-20T00:00:00.000' AS DateTime), 1, N'Corrosion of third degree of unspecified single finger (nail) except thumb, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (24, 9, CAST(N'2019-02-27T00:00:00.000' AS DateTime), 0, N'Poisoning by unspecified general anesthetics, assault')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (25, 1, CAST(N'2019-01-30T00:00:00.000' AS DateTime), 0, N'Terrorism involving other explosions and fragments, terrorist injured')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (25, 3, CAST(N'2019-03-06T00:00:00.000' AS DateTime), 0, N'Corrosion of left eye and adnexa, part unspecified')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (26, 4, CAST(N'2018-12-16T00:00:00.000' AS DateTime), 0, N'Poisoning by cannabis (derivatives), intentional self-harm, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (26, 5, CAST(N'2018-12-16T00:00:00.000' AS DateTime), 1, N'Poisoning by hydantoin derivatives, assault, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (27, 6, CAST(N'2018-09-27T00:00:00.000' AS DateTime), 1, N'Other myositis shoulder')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (28, 9, CAST(N'2019-02-08T00:00:00.000' AS DateTime), 0, N'Nondisplaced fracture of base of fifth metacarpal bone. left hand, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (29, 3, CAST(N'2018-06-04T00:00:00.000' AS DateTime), 0, N'Accidental hit or strike by another person, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (30, 2, CAST(N'2018-08-20T00:00:00.000' AS DateTime), 1, N'Nondisplaced spiral fracture of shaft of radius, unspecified arm, subsequent encounter for closed fracture with nonunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (30, 4, CAST(N'2018-08-06T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (31, 1, CAST(N'2019-03-11T00:00:00.000' AS DateTime), 0, N'Major laceration of right pulmonary blood vessels, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (31, 2, CAST(N'2018-08-22T00:00:00.000' AS DateTime), 1, N'Other superficial bite of other specified part of neck')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (32, 3, CAST(N'2018-09-11T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (32, 8, CAST(N'2018-08-03T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (33, 4, CAST(N'2018-06-28T00:00:00.000' AS DateTime), 0, N'Nondisplaced fracture of distal phalanx of left lesser toe(s), initial encounter for closed fracture')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (34, 6, CAST(N'2019-01-21T00:00:00.000' AS DateTime), 0, N'Toxic effects of chlorofluorocarbons')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (35, 3, CAST(N'2018-09-30T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (35, 4, CAST(N'2018-03-30T00:00:00.000' AS DateTime), 0, N'Person on outside of bus injured in collision with pedal cycle in nontraffic accident, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (35, 5, CAST(N'2018-11-22T00:00:00.000' AS DateTime), 0, N'Intentional self-harm by other specified means, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (35, 7, CAST(N'2018-11-14T00:00:00.000' AS DateTime), 0, N'Sprain of metacarpophalangeal joint of unspecified thumb, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (35, 9, CAST(N'2018-03-27T00:00:00.000' AS DateTime), 0, N'Oncovirus as the cause of diseases classified elsewhere')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (36, 2, CAST(N'2019-01-01T00:00:00.000' AS DateTime), 1, N'Other specified injury of blood vessel of left thumb, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (37, 2, CAST(N'2019-01-27T00:00:00.000' AS DateTime), 0, N'Nondisplaced longitudinal fracture of left patella, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (37, 3, CAST(N'2018-09-03T00:00:00.000' AS DateTime), 1, N'Burn of unspecified body region, unspecified degree')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (37, 4, CAST(N'2018-09-12T00:00:00.000' AS DateTime), 0, N'Nondisplaced spiral fracture of shaft of unspecified femur, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (38, 3, CAST(N'2018-10-01T00:00:00.000' AS DateTime), 0, N'Poisoning by unspecified anesthetic, assault, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (39, 3, CAST(N'2018-10-19T00:00:00.000' AS DateTime), 1, N'Corrosion of unspecified degree of multiple sites of right shoulder and upper limb, except wrist and hand, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (40, 2, CAST(N'2018-10-15T00:00:00.000' AS DateTime), 1, N'Other secondary chronic gout, unspecified elbow, with tophus (tophi)')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (40, 6, CAST(N'2018-06-04T00:00:00.000' AS DateTime), 0, N'Effects of other deprivation')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (40, 9, CAST(N'2018-05-08T00:00:00.000' AS DateTime), 1, N'Complete traumatic amputation of right hand at wrist level, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (41, 1, CAST(N'2018-09-23T00:00:00.000' AS DateTime), 1, N'Burn of unspecified degree of left wrist, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (41, 7, CAST(N'2018-09-23T00:00:00.000' AS DateTime), 0, N'Pressure ulcer of sacral region, unstageable')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (42, 4, CAST(N'2018-04-17T00:00:00.000' AS DateTime), 1, N'Other superficial bite of left little finger, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (47, 1, CAST(N'2018-04-02T00:00:00.000' AS DateTime), 0, N'Bronchitis and pneumonitis due to chemicals, gases, fumes and vapors')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (49, 2, CAST(N'2018-10-17T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (50, 1, CAST(N'2019-01-27T00:00:00.000' AS DateTime), 0, N'Fracture of unspecified part of left clavicle, subsequent encounter for fracture with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (50, 2, CAST(N'2019-01-27T00:00:00.000' AS DateTime), 1, N'Pigmentary glaucoma, bilateral')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (50, 6, CAST(N'2019-01-27T00:00:00.000' AS DateTime), 0, N'Hereditary lymphedema')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (52, 4, CAST(N'2018-08-13T00:00:00.000' AS DateTime), 0, N'War operations involving destruction of aircraft')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (53, 5, CAST(N'2018-12-24T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (53, 9, CAST(N'2018-12-24T00:00:00.000' AS DateTime), 1, N'Other rheumatoid arthritis with rheumatoid factor of right ankle and foot')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (54, 2, CAST(N'2018-04-01T00:00:00.000' AS DateTime), 0, N'Chorioretinal scars after surgery for detachment, right eye')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (55, 6, CAST(N'2018-12-26T00:00:00.000' AS DateTime), 0, N'Complete traumatic amputation of two or more unspecified lesser toes, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (56, 5, CAST(N'2018-10-27T00:00:00.000' AS DateTime), 0, N'Unsatisfactory cytologic smear of anus')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (56, 9, CAST(N'2018-10-27T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (57, 4, CAST(N'2018-10-25T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (58, 3, CAST(N'2018-10-11T00:00:00.000' AS DateTime), 0, N'Toxic effect of venom of caterpillars, accidental (unintentional), initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (58, 4, CAST(N'2018-07-25T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (60, 1, CAST(N'2018-09-16T00:00:00.000' AS DateTime), 0, N'Military operations involving friendly fire, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (63, 2, CAST(N'2019-02-08T00:00:00.000' AS DateTime), 0, N'Anaplastic large cell lymphoma, ALK-negative, intrapelvic lymph nodes')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (63, 9, CAST(N'2019-02-08T00:00:00.000' AS DateTime), 1, N'Periprosthetic osteolysis of internal prosthetic right hip joint, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (64, 5, CAST(N'2018-05-16T00:00:00.000' AS DateTime), 1, N'Neoplasm of uncertain behavior of lip, oral cavity and pharynx')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (64, 9, CAST(N'2018-10-25T00:00:00.000' AS DateTime), 1, N'Central dislocation of left hip')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (65, 1, CAST(N'2018-07-06T00:00:00.000' AS DateTime), 1, N'Other obstructive defects of renal pelvis and ureter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (65, 4, CAST(N'2018-11-13T00:00:00.000' AS DateTime), 0, N'Fibrosis due to genitourinary prosthetic devices, implants and grafts, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (65, 5, CAST(N'2018-07-23T00:00:00.000' AS DateTime), 1, N'Other specified problems related to upbringing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (65, 6, CAST(N'2018-07-01T00:00:00.000' AS DateTime), 0, N'Anterior cord syndrome at C7 level of cervical spinal cord, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (66, 2, CAST(N'2018-11-06T00:00:00.000' AS DateTime), 0, N'Displaced fracture of left ulna styloid process, subsequent encounter for open fracture type I or II with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (66, 5, CAST(N'2018-11-06T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (67, 2, CAST(N'2018-12-15T00:00:00.000' AS DateTime), 0, N'Toxic effect of phenol and phenol homologues, accidental (unintentional), subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (67, 4, CAST(N'2018-12-15T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (67, 6, CAST(N'2018-12-15T00:00:00.000' AS DateTime), 1, N'Nondisplaced fracture of coronoid process of right ulna, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with malunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (68, 5, CAST(N'2018-10-27T00:00:00.000' AS DateTime), 1, N'Nondisplaced segmental fracture of shaft of unspecified tibia, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with nonunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (69, 2, CAST(N'2018-09-30T00:00:00.000' AS DateTime), 1, N'Left sided colitis')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (69, 4, CAST(N'2018-08-23T00:00:00.000' AS DateTime), 0, N'Strain of extensor muscle, fascia and tendon of left index finger at wrist and hand level')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (70, 3, CAST(N'2018-10-06T00:00:00.000' AS DateTime), 1, N'Fall from burning building or structure in controlled fire, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (73, 6, CAST(N'2018-10-04T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (73, 8, CAST(N'2018-08-19T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (73, 9, CAST(N'2018-11-02T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (74, 5, CAST(N'2019-01-11T00:00:00.000' AS DateTime), 1, N'Congenital absence of vulva')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (75, 3, CAST(N'2018-10-22T00:00:00.000' AS DateTime), 1, N'Other superficial bite of right ear, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (75, 8, CAST(N'2019-01-26T00:00:00.000' AS DateTime), 0, N'Open bite of left breast, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (76, 9, CAST(N'2018-11-06T00:00:00.000' AS DateTime), 1, N'Drug or chemical induced diabetes mellitus with proliferative diabetic retinopathy with traction retinal detachment involving the macula, unspecified eye')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (77, 6, CAST(N'2018-12-16T00:00:00.000' AS DateTime), 0, N'Other adverse food reactions, not elsewhere classified')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (79, 7, CAST(N'2018-12-04T00:00:00.000' AS DateTime), 0, N'Toxic effect of other specified noxious substances eaten as food, assault')
GO
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (80, 1, CAST(N'2018-06-05T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (81, 7, CAST(N'2018-12-17T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (81, 9, CAST(N'2018-12-24T00:00:00.000' AS DateTime), 1, N'Genital varices in pregnancy, first trimester')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (82, 4, CAST(N'2018-11-13T00:00:00.000' AS DateTime), 1, N'Acquired absence of eye')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (82, 8, CAST(N'2018-11-13T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (84, 2, CAST(N'2018-11-25T00:00:00.000' AS DateTime), 0, N'Struck by falling object on merchant ship, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (84, 5, CAST(N'2018-11-25T00:00:00.000' AS DateTime), 1, N'Other injury of unspecified muscle, fascia and tendon at shoulder and upper arm level, right arm')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (84, 7, CAST(N'2018-12-21T00:00:00.000' AS DateTime), 0, N'Person on outside of car injured in noncollision transport accident in nontraffic accident')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (85, 7, CAST(N'2018-10-11T00:00:00.000' AS DateTime), 0, N'Car passenger injured in collision with other type car in nontraffic accident, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (86, 1, CAST(N'2018-10-31T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (87, 5, CAST(N'2018-09-12T00:00:00.000' AS DateTime), 1, N'Juvenile osteochondrosis of tibia and fibula, left leg')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (87, 8, CAST(N'2018-09-12T00:00:00.000' AS DateTime), 0, N'Unspecified injury of axillary or brachial vein, unspecified side, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (87, 9, CAST(N'2019-01-11T00:00:00.000' AS DateTime), 1, N'Resistance to vancomycin')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (89, 3, CAST(N'2018-12-03T00:00:00.000' AS DateTime), 1, N'Displaced segmental fracture of shaft of unspecified fibula, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (89, 8, CAST(N'2018-12-03T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (89, 9, CAST(N'2018-12-03T00:00:00.000' AS DateTime), 0, N'Dome fracture of talus')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (90, 1, CAST(N'2019-01-30T00:00:00.000' AS DateTime), 0, N'Premature rupture of membranes, unspecified as to length of time between rupture and onset of labor')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (90, 3, CAST(N'2019-01-30T00:00:00.000' AS DateTime), 0, N'Displaced avulsion fracture of right ischium, subsequent encounter for fracture with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (90, 6, CAST(N'2019-01-30T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (90, 8, CAST(N'2019-01-30T00:00:00.000' AS DateTime), 1, N'Puncture wound without foreign body of oral cavity, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (90, 9, CAST(N'2019-01-30T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (91, 6, CAST(N'2018-09-11T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (92, 4, CAST(N'2018-07-29T00:00:00.000' AS DateTime), 1, N'Pecked by turkey, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (93, 1, CAST(N'2018-03-23T00:00:00.000' AS DateTime), 0, N'Displaced spiral fracture of shaft of left tibia, subsequent encounter for closed fracture with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (93, 7, CAST(N'2018-08-09T00:00:00.000' AS DateTime), 0, N'Laceration with foreign body, unspecified lower leg, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (93, 9, CAST(N'2018-05-28T00:00:00.000' AS DateTime), 0, N'Other cysts of jaw')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (95, 3, CAST(N'2018-11-29T00:00:00.000' AS DateTime), 1, N'Unspecified fracture of right wrist and hand, initial encounter for closed fracture')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (95, 8, CAST(N'2018-08-11T00:00:00.000' AS DateTime), 1, N'Unspecified superficial injury of unspecified hip')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (96, 4, CAST(N'2019-01-28T00:00:00.000' AS DateTime), 1, N'Intentional self-harm by unspecified sharp object, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (97, 3, CAST(N'2019-02-16T00:00:00.000' AS DateTime), 0, N'Stress fracture, unspecified hand, subsequent encounter for fracture with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (97, 4, CAST(N'2018-08-06T00:00:00.000' AS DateTime), 0, N'Injury of optic tract and pathways, unspecified eye, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (98, 5, CAST(N'2018-06-14T00:00:00.000' AS DateTime), 1, N'Toxic effect of contact with unspecified venomous animal')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (98, 7, CAST(N'2018-05-18T00:00:00.000' AS DateTime), 0, N'Corrosion of third degree of right toe(s) (nail), initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (100, 5, CAST(N'2018-07-13T00:00:00.000' AS DateTime), 0, N'Other hypertrophic osteoarthropathy, unspecified shoulder')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (101, 4, CAST(N'2018-10-16T00:00:00.000' AS DateTime), 1, N'Maternal care for other rhesus isoimmunization, first trimester, other fetus')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (102, 1, CAST(N'2018-08-27T00:00:00.000' AS DateTime), 0, N'Other specified noninfective disorders of lymphatic vessels and lymph nodes')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (103, 9, CAST(N'2018-06-22T00:00:00.000' AS DateTime), 0, N'Blister (nonthermal), left hip')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (104, 2, CAST(N'2019-02-14T00:00:00.000' AS DateTime), 0, N'Puncture wound without foreign body of unspecified part of thorax')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (104, 3, CAST(N'2019-02-14T00:00:00.000' AS DateTime), 0, N'Exposure of other prosthetic materials into organ or tissue, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (105, 3, CAST(N'2018-12-21T00:00:00.000' AS DateTime), 0, N'Nondisplaced trimalleolar fracture of unspecified lower leg, subsequent encounter for open fracture type I or II with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (105, 7, CAST(N'2018-12-21T00:00:00.000' AS DateTime), 1, N'Complete traumatic amputation of unspecified ear, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (108, 1, CAST(N'2019-01-31T00:00:00.000' AS DateTime), 0, N'Pregnancy related conditions, unspecified, third trimester')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (109, 8, CAST(N'2018-06-29T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (110, 2, CAST(N'2019-02-22T00:00:00.000' AS DateTime), 0, N'Partial traumatic amputation of right foot, level unspecified, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (110, 6, CAST(N'2018-07-12T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (111, 4, CAST(N'2019-03-03T00:00:00.000' AS DateTime), 0, N'Other sprain of right index finger, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (112, 2, CAST(N'2018-10-15T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (112, 5, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1, N'Torus fracture of upper end of left fibula, subsequent encounter for fracture with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (113, 4, CAST(N'2018-09-01T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (113, 5, CAST(N'2018-09-01T00:00:00.000' AS DateTime), 0, N'Injury of facial nerve, right side, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (113, 6, CAST(N'2018-09-01T00:00:00.000' AS DateTime), 0, N'Corrosion of second degree of unspecified foot, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (113, 7, CAST(N'2018-09-01T00:00:00.000' AS DateTime), 0, N'Unspecified injury of right ankle')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (113, 9, CAST(N'2018-09-01T00:00:00.000' AS DateTime), 0, N'Unspecified injury of unspecified blood vessel at hip and thigh level, right leg')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (114, 2, CAST(N'2018-04-08T00:00:00.000' AS DateTime), 1, N'Anterior cord syndrome at C5 level of cervical spinal cord')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (115, 1, CAST(N'2018-08-17T00:00:00.000' AS DateTime), 1, N'Drowning and submersion due to fall off fishing boat, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (116, 5, CAST(N'2019-01-14T00:00:00.000' AS DateTime), 0, N'Effusion, left knee')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (117, 4, CAST(N'2018-11-28T00:00:00.000' AS DateTime), 1, N'Displaced fracture of lesser trochanter of right femur, subsequent encounter for open fracture type I or II with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (117, 5, CAST(N'2019-01-18T00:00:00.000' AS DateTime), 1, N'Isolated proteinuria with diffuse membranous glomerulonephritis')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (118, 3, CAST(N'2019-01-14T00:00:00.000' AS DateTime), 0, N'Pathological fracture in other disease, left ankle, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (118, 4, CAST(N'2018-07-08T00:00:00.000' AS DateTime), 1, N'Basal cell carcinoma of skin of lower limb, including hip')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (118, 8, CAST(N'2018-11-13T00:00:00.000' AS DateTime), 0, N'Nondisplaced fracture of epiphysis (separation) (upper) of unspecified femur, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (118, 9, CAST(N'2018-07-08T00:00:00.000' AS DateTime), 1, N'Subluxation of right scapula')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (119, 9, CAST(N'2019-01-04T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (120, 3, CAST(N'2019-03-01T00:00:00.000' AS DateTime), 0, N'Nondisplaced comminuted fracture of shaft of ulna, unspecified arm, subsequent encounter for closed fracture with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (121, 6, CAST(N'2018-10-26T00:00:00.000' AS DateTime), 1, N'Open bite of abdominal wall, periumbilic region without penetration into peritoneal cavity')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (122, 1, CAST(N'2018-10-18T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (125, 9, CAST(N'2018-06-30T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (126, 5, CAST(N'2018-06-13T00:00:00.000' AS DateTime), 1, N'Hypertrichosis of left eye, unspecified eyelid')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (126, 8, CAST(N'2019-02-07T00:00:00.000' AS DateTime), 1, N'Other fracture of right great toe, initial encounter for closed fracture')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (127, 3, CAST(N'2019-01-30T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (129, 9, CAST(N'2018-12-10T00:00:00.000' AS DateTime), 1, N'Contact with liquid air')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (130, 5, CAST(N'2019-02-14T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (130, 8, CAST(N'2019-02-10T00:00:00.000' AS DateTime), 1, N'Neoplasm of uncertain behavior of testis')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (131, 1, CAST(N'2018-08-30T00:00:00.000' AS DateTime), 1, N'Unspecified injury of left kidney, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (131, 3, CAST(N'2018-08-17T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (131, 7, CAST(N'2018-07-11T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (132, 1, CAST(N'2018-06-16T00:00:00.000' AS DateTime), 1, N'Nondisplaced fracture of unspecified tibial spine, subsequent encounter for open fracture type I or II with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (133, 8, CAST(N'2019-01-25T00:00:00.000' AS DateTime), 1, N'Unspecified perforation of tympanic membrane, right ear')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (134, 1, CAST(N'2018-10-22T00:00:00.000' AS DateTime), 0, N'Congenital malformations of eyelid, lacrimal apparatus and orbit')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (135, 3, CAST(N'2018-11-09T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (137, 3, CAST(N'2019-02-15T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (137, 4, CAST(N'2019-02-15T00:00:00.000' AS DateTime), 0, N'Congenital pharyngeal pouch')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (139, 2, CAST(N'2018-11-27T00:00:00.000' AS DateTime), 0, N'Poisoning by cardiac-stimulant glycosides and drugs of similar action, undetermined')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (139, 4, CAST(N'2018-07-13T00:00:00.000' AS DateTime), 0, N'Heart-lung transplant rejection')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (140, 8, CAST(N'2018-11-29T00:00:00.000' AS DateTime), 0, N'Legal intervention involving injury by handgun, suspect injured, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (140, 9, CAST(N'2019-01-01T00:00:00.000' AS DateTime), 1, N'Poisoning by coronary vasodilators, accidental (unintentional), subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (141, 1, CAST(N'2019-03-09T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (141, 4, CAST(N'2019-03-09T00:00:00.000' AS DateTime), 1, N'Other fracture of upper and lower end of right fibula, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (142, 4, CAST(N'2018-12-22T00:00:00.000' AS DateTime), 0, N'Retinal micro-aneurysms, unspecified, unspecified eye')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (142, 9, CAST(N'2018-10-14T00:00:00.000' AS DateTime), 1, N'Unspecified fracture of navicular [scaphoid] bone of left wrist, subsequent encounter for fracture with malunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (143, 3, CAST(N'2018-09-25T00:00:00.000' AS DateTime), 1, N'Calcium deposit in bursa, elbow')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (143, 8, CAST(N'2018-12-28T00:00:00.000' AS DateTime), 0, N'Effusion, left hip')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (145, 1, CAST(N'2019-03-07T00:00:00.000' AS DateTime), 0, N'War operations involving destruction of aircraft due to collision with other aircraft, civilian')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (145, 3, CAST(N'2018-10-05T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (145, 9, CAST(N'2018-11-11T00:00:00.000' AS DateTime), 1, N'Displaced spiral fracture of shaft of radius, left arm, subsequent encounter for closed fracture with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (147, 1, CAST(N'2018-12-19T00:00:00.000' AS DateTime), 0, N'Unspecified place in single-family (private) house as the place of occurrence of the external cause')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (148, 1, CAST(N'2019-01-06T00:00:00.000' AS DateTime), 0, N'Squamous blepharitis left upper eyelid')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (149, 3, CAST(N'2019-01-07T00:00:00.000' AS DateTime), 0, N'Injury of trochlear nerve, left side, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (149, 5, CAST(N'2019-01-22T00:00:00.000' AS DateTime), 1, N'Toxic effect of other specified inorganic substances, undetermined, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (151, 1, CAST(N'2019-03-02T00:00:00.000' AS DateTime), 1, N'Unspecified dislocation of other finger')
GO
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (151, 8, CAST(N'2019-02-25T00:00:00.000' AS DateTime), 0, N'Strain of other specified muscles, fascia and tendons at thigh level, right thigh')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (151, 9, CAST(N'2019-03-09T00:00:00.000' AS DateTime), 1, N'Motorcycle driver injured in collision with pedal cycle in traffic accident, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (152, 3, CAST(N'2018-09-10T00:00:00.000' AS DateTime), 0, N'Idiopathic gout, left wrist')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (153, 9, CAST(N'2018-10-12T00:00:00.000' AS DateTime), 0, N'Passenger injured in collision with unspecified motor vehicles in nontraffic accident, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (156, 6, CAST(N'2018-12-27T00:00:00.000' AS DateTime), 1, N'Intentional collision of motor vehicle with train, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (156, 8, CAST(N'2018-12-27T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (157, 7, CAST(N'2019-03-10T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (157, 8, CAST(N'2019-02-28T00:00:00.000' AS DateTime), 1, N'Unspecified injury of unspecified tibial artery, right leg')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (158, 2, CAST(N'2018-07-15T00:00:00.000' AS DateTime), 0, N'Other physeal fracture of lower end of left fibula, subsequent encounter for fracture with malunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (158, 5, CAST(N'2018-07-20T00:00:00.000' AS DateTime), 1, N'Rheumatoid arthritis without rheumatoid factor, right ankle and foot')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (158, 8, CAST(N'2018-07-15T00:00:00.000' AS DateTime), 1, N'Nondisplaced fracture of head of left radius, initial encounter for closed fracture')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (159, 6, CAST(N'2019-01-26T00:00:00.000' AS DateTime), 1, N'Supervision of young primigravida, second trimester')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (159, 9, CAST(N'2018-04-06T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (160, 2, CAST(N'2018-07-06T00:00:00.000' AS DateTime), 0, N'Displaced intertrochanteric fracture of left femur, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (160, 8, CAST(N'2018-11-26T00:00:00.000' AS DateTime), 0, N'Fracture of humerus following insertion of orthopedic implant, joint prosthesis, or bone plate, left arm')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (160, 9, CAST(N'2018-10-25T00:00:00.000' AS DateTime), 0, N'Pedal cycle driver injured in collision with other nonmotor vehicle in traffic accident, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (161, 3, CAST(N'2018-11-02T00:00:00.000' AS DateTime), 0, N'Fracture of left shoulder girdle, part unspecified, subsequent encounter for fracture with nonunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (161, 5, CAST(N'2018-07-24T00:00:00.000' AS DateTime), 1, N'Other benign neoplasm of skin of unspecified lower limb, including hip')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (162, 7, CAST(N'2018-12-20T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (163, 2, CAST(N'2018-08-11T00:00:00.000' AS DateTime), 0, N'Congenital ptosis')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (165, 4, CAST(N'2018-10-28T00:00:00.000' AS DateTime), 1, N'Other superficial bite of left foot')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (166, 7, CAST(N'2019-01-10T00:00:00.000' AS DateTime), 1, N'Fracture of neck, unspecified, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (167, 2, CAST(N'2019-02-10T00:00:00.000' AS DateTime), 0, N'Displaced fracture of right radial styloid process, subsequent encounter for closed fracture with nonunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (167, 5, CAST(N'2019-03-02T00:00:00.000' AS DateTime), 1, N'Unspecified fracture of lower end of unspecified tibia, subsequent encounter for closed fracture with malunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (168, 7, CAST(N'2018-09-15T00:00:00.000' AS DateTime), 0, N'Adverse effect of penicillins, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (169, 4, CAST(N'2018-11-26T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (169, 6, CAST(N'2018-11-26T00:00:00.000' AS DateTime), 0, N'Physical abuse complicating pregnancy')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (170, 1, CAST(N'2018-06-15T00:00:00.000' AS DateTime), 0, N'Injury of facial nerve, unspecified side, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (171, 5, CAST(N'2018-11-16T00:00:00.000' AS DateTime), 1, N'Puncture wound without foreign body of abdominal wall, unspecified quadrant with penetration into peritoneal cavity, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (171, 9, CAST(N'2018-11-16T00:00:00.000' AS DateTime), 1, N'Terrorism involving suicide bomber, civilian injured, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (172, 4, CAST(N'2018-08-04T00:00:00.000' AS DateTime), 0, N'Contracture, unspecified foot')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (172, 8, CAST(N'2018-08-04T00:00:00.000' AS DateTime), 0, N'Puncture wound without foreign body, right ankle')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (173, 3, CAST(N'2018-09-09T00:00:00.000' AS DateTime), 1, N'Unspecified thoracic, thoracolumbar and lumbosacral intervertebral disc disorder')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (174, 2, CAST(N'2019-03-10T00:00:00.000' AS DateTime), 0, N'Acute embolism and thrombosis of unspecified deep veins of left lower extremity')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (174, 5, CAST(N'2018-09-27T00:00:00.000' AS DateTime), 1, N'Legal intervention involving injury by rubber bullet, suspect injured, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (174, 8, CAST(N'2018-12-10T00:00:00.000' AS DateTime), 0, N'War operations involving explosion of depth-charge, civilian')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (174, 9, CAST(N'2018-06-21T00:00:00.000' AS DateTime), 1, N'Displaced fracture of capitate [os magnum] bone, right wrist')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (175, 1, CAST(N'2018-12-14T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (175, 6, CAST(N'2018-10-17T00:00:00.000' AS DateTime), 0, N'Other sequelae of nontraumatic subarachnoid hemorrhage')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (177, 3, CAST(N'2018-06-13T00:00:00.000' AS DateTime), 1, N'Exudative cyst of pars plana, right eye')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (177, 4, CAST(N'2018-06-07T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (179, 1, CAST(N'2018-12-30T00:00:00.000' AS DateTime), 1, N'Focal chorioretinal inflammation of posterior pole, bilateral')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (179, 4, CAST(N'2018-12-30T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (179, 6, CAST(N'2018-12-30T00:00:00.000' AS DateTime), 0, N'Driver of three-wheeled motor vehicle injured in collision with fixed or stationary object in nontraffic accident, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (181, 2, CAST(N'2018-03-19T00:00:00.000' AS DateTime), 1, N'Puncture wound with foreign body of unspecified toe(s) without damage to nail, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (181, 4, CAST(N'2018-08-01T00:00:00.000' AS DateTime), 0, N'Fall into well, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (182, 3, CAST(N'2018-11-26T00:00:00.000' AS DateTime), 0, N'Nondisplaced comminuted fracture of left patella, subsequent encounter for open fracture type I or II with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (182, 8, CAST(N'2018-11-26T00:00:00.000' AS DateTime), 1, N'Abnormal results of other function studies of peripheral nervous system')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (182, 9, CAST(N'2018-11-26T00:00:00.000' AS DateTime), 1, N'Displaced fracture of fifth metatarsal bone, right foot, subsequent encounter for fracture with malunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (183, 8, CAST(N'2018-10-09T00:00:00.000' AS DateTime), 0, N'Exposure to flames in uncontrolled fire, not in building or structure, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (184, 1, CAST(N'2018-10-15T00:00:00.000' AS DateTime), 1, N'Displaced other extraarticular fracture of right calcaneus, subsequent encounter for fracture with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (184, 8, CAST(N'2018-10-27T00:00:00.000' AS DateTime), 0, N'Salter-Harris Type I physeal fracture of upper end of left fibula, initial encounter for closed fracture')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (184, 9, CAST(N'2018-10-15T00:00:00.000' AS DateTime), 1, N'Malignant neoplasm of posterior wall of oropharynx')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (186, 2, CAST(N'2018-09-23T00:00:00.000' AS DateTime), 0, N'Nondisplaced fracture of anterior wall of left acetabulum, subsequent encounter for fracture with nonunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (186, 3, CAST(N'2018-06-20T00:00:00.000' AS DateTime), 0, N'Nondisplaced fracture of medial cuneiform of left foot, initial encounter for open fracture')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (187, 5, CAST(N'2018-11-15T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (188, 3, CAST(N'2018-11-15T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (188, 9, CAST(N'2019-01-06T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (189, 3, CAST(N'2019-02-23T00:00:00.000' AS DateTime), 1, N'Nondisplaced segmental fracture of shaft of radius, left arm, subsequent encounter for closed fracture with malunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (189, 4, CAST(N'2019-02-23T00:00:00.000' AS DateTime), 0, N'Poisoning by, adverse effect of and underdosing of other agents primarily affecting gastrointestinal system')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (190, 2, CAST(N'2018-04-17T00:00:00.000' AS DateTime), 1, N'Primary blast injury of bronchus, unilateral, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (190, 6, CAST(N'2018-07-08T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (191, 8, CAST(N'2019-01-27T00:00:00.000' AS DateTime), 1, N'Unspecified injury of lesser saphenous vein at lower leg level, unspecified leg, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (193, 8, CAST(N'2018-11-05T00:00:00.000' AS DateTime), 1, N'Fracture of subcondylar process of right mandible, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (194, 1, CAST(N'2018-12-31T00:00:00.000' AS DateTime), 0, N'Sprain of chondrosternal joint, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (195, 5, CAST(N'2018-05-15T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (196, 5, CAST(N'2018-07-20T00:00:00.000' AS DateTime), 0, N'Unspecified fracture of unspecified femur, subsequent encounter for open fracture type I or II with routine healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (196, 9, CAST(N'2018-04-30T00:00:00.000' AS DateTime), 0, N'Unspecified motorcycle rider injured in collision with railway train or railway vehicle in nontraffic accident, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (197, 3, CAST(N'2018-07-18T00:00:00.000' AS DateTime), 0, N'Unspecified focal traumatic brain injury without loss of consciousness, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (198, 8, CAST(N'2018-11-14T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (198, 9, CAST(N'2018-11-14T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (200, 2, CAST(N'2018-06-06T00:00:00.000' AS DateTime), 1, N'Underdosing of aspirin, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (200, 6, CAST(N'2018-03-28T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (200, 7, CAST(N'2018-04-10T00:00:00.000' AS DateTime), 1, N'Fall from cliff, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (201, 7, CAST(N'2018-12-31T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (201, 9, CAST(N'2018-06-06T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (204, 6, CAST(N'2018-08-26T00:00:00.000' AS DateTime), 0, N'Laceration without foreign body, unspecified foot, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (206, 6, CAST(N'2018-08-26T00:00:00.000' AS DateTime), 0, N'Neoplasm related pain (acute) (chronic)')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (208, 3, CAST(N'2018-11-21T00:00:00.000' AS DateTime), 0, N'Corrosion of third degree of unspecified palm')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (209, 7, CAST(N'2019-01-14T00:00:00.000' AS DateTime), 0, N'Cervical disc disorder at C5-C6 level with radiculopathy')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (209, 8, CAST(N'2019-03-14T00:00:00.000' AS DateTime), 0, N'Other drug-induced agranulocytosis')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (210, 3, CAST(N'2018-08-12T00:00:00.000' AS DateTime), 0, N'Burkitt lymphoma, intrathoracic lymph nodes')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (210, 4, CAST(N'2018-06-07T00:00:00.000' AS DateTime), 0, N'Personal history of diseases of the musculoskeletal system and connective tissue')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (210, 7, CAST(N'2018-10-16T00:00:00.000' AS DateTime), 0, N'Problems in relationship with in-laws')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (210, 9, CAST(N'2018-05-06T00:00:00.000' AS DateTime), 1, N'Pain due to other internal prosthetic devices, implants and grafts')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (211, 7, CAST(N'2018-09-05T00:00:00.000' AS DateTime), 1, N'Other conduction disorders')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (212, 2, CAST(N'2019-01-18T00:00:00.000' AS DateTime), 0, N'Avulsion of scalp, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (212, 3, CAST(N'2019-01-18T00:00:00.000' AS DateTime), 1, N'Complications of corneal transplant')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (212, 5, CAST(N'2019-01-18T00:00:00.000' AS DateTime), 0, N'Toxic effect of carbon disulfide, undetermined, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (213, 4, CAST(N'2018-12-03T00:00:00.000' AS DateTime), 1, N'Pilonidal cyst and sinus without abscess')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (216, 6, CAST(N'2018-07-28T00:00:00.000' AS DateTime), 0, N'Other cyst of bone, unspecified shoulder')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (216, 8, CAST(N'2018-07-28T00:00:00.000' AS DateTime), 0, N'Reiter''s disease, left wrist')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (217, 2, CAST(N'2018-12-18T00:00:00.000' AS DateTime), 0, N'Nondisplaced fracture of distal phalanx of unspecified great toe, subsequent encounter for fracture with nonunion')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (218, 4, CAST(N'2019-02-12T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (219, 4, CAST(N'2019-01-14T00:00:00.000' AS DateTime), 0, N'Superficial frostbite of unspecified hip and thigh, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (220, 9, CAST(N'2018-10-20T00:00:00.000' AS DateTime), 0, N'Psychophysiologic insomnia')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (221, 8, CAST(N'2018-05-31T00:00:00.000' AS DateTime), 0, N'Disorder of ligament, unspecified shoulder')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (222, 6, CAST(N'2019-02-02T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (223, 8, CAST(N'2019-03-08T00:00:00.000' AS DateTime), 0, N'Nondisplaced longitudinal fracture of left patella, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (224, 7, CAST(N'2018-12-21T00:00:00.000' AS DateTime), 1, N'Abrasion, left knee, initial encounter')
GO
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (225, 1, CAST(N'2019-01-25T00:00:00.000' AS DateTime), 1, N'Osteopathy after poliomyelitis, left shoulder')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (225, 3, CAST(N'2019-01-25T00:00:00.000' AS DateTime), 1, N'Nondisplaced subtrochanteric fracture of right femur, subsequent encounter for closed fracture with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (226, 1, CAST(N'2018-08-14T00:00:00.000' AS DateTime), 0, N'Unspecified fracture of shaft of humerus, unspecified arm, initial encounter for open fracture')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (226, 4, CAST(N'2018-06-11T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (227, 6, CAST(N'2019-01-21T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (228, 5, CAST(N'2019-02-20T00:00:00.000' AS DateTime), 1, N'Military operations involving fragments of improvised explosive device [IED], military personnel, initial encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (228, 9, CAST(N'2019-02-20T00:00:00.000' AS DateTime), 0, N'Tributary (branch) retinal vein occlusion, bilateral, with macular edema')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (229, 6, CAST(N'2018-10-28T00:00:00.000' AS DateTime), 0, N'Pathological fracture, unspecified hand, subsequent encounter for fracture with delayed healing')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (231, 7, CAST(N'2018-08-20T00:00:00.000' AS DateTime), 1, N'Trigger finger, ring finger')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (232, 4, CAST(N'2018-12-11T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (232, 7, CAST(N'2018-12-18T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (233, 5, CAST(N'2018-12-05T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (236, 8, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1, N'Drowning and submersion due to canoe or kayak sinking, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (240, 1, CAST(N'2018-11-20T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (241, 5, CAST(N'2019-02-04T00:00:00.000' AS DateTime), 0, N'Partial traumatic transphalangeal amputation of left middle finger, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (241, 9, CAST(N'2018-08-29T00:00:00.000' AS DateTime), 0, N'Laceration without foreign body of unspecified upper arm, subsequent encounter')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (243, 8, CAST(N'2019-01-23T00:00:00.000' AS DateTime), 1, N'Laceration of other muscles, fascia and tendons at shoulder and upper arm level, unspecified arm')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (244, 1, CAST(N'2018-12-14T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (244, 2, CAST(N'2018-10-28T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (244, 8, CAST(N'2019-02-16T00:00:00.000' AS DateTime), 0, N'Blister (nonthermal) of penis, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (245, 7, CAST(N'2018-07-19T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (246, 9, CAST(N'2018-10-14T00:00:00.000' AS DateTime), 1, N'Salter-Harris Type II physeal fracture of upper end of left fibula, sequela')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (247, 2, CAST(N'2019-03-10T00:00:00.000' AS DateTime), 0, N'Corrosion of second degree of unspecified wrist')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (247, 6, CAST(N'2019-03-10T00:00:00.000' AS DateTime), 1, N'Other fracture of third metacarpal bone, right hand, initial encounter for open fracture')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (247, 8, CAST(N'2019-03-10T00:00:00.000' AS DateTime), 1, N'Encounter for attention to colostomy')
INSERT [dbo].[TestOrdered] ([appointmentID], [testCode], [testDate], [result], [resultDetails]) VALUES (248, 4, CAST(N'2018-12-12T00:00:00.000' AS DateTime), 1, N'Fall into other water striking bottom causing drowning and submersion, subsequent encounter')
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (1, CAST(234.40 AS Decimal(5, 2)), 80, 88, CAST(99.80 AS Decimal(5, 2)), 158, N'I feel Nauseated ', N'Poisoning by unspecified topical agent, undetermined', N'Unspecified fracture of unspecified lumbar vertebra, initial encounter for open fracture', 1)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (2, CAST(354.20 AS Decimal(5, 2)), 150, 95, CAST(98.80 AS Decimal(5, 2)), 40, N'I feel Tired ', N'Explosion and rupture of aerosol can, sequela', N'Other specified injury of other specified blood vessels at shoulder and upper arm level, right arm, sequela', 12)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (3, CAST(209.90 AS Decimal(5, 2)), 179, 64, CAST(104.60 AS Decimal(5, 2)), 140, N'Back problems', N'Calcium deposit in bursa, right ankle and foot', NULL, 28)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (4, CAST(120.20 AS Decimal(5, 2)), 168, 82, CAST(96.60 AS Decimal(5, 2)), 102, N'I feel Chills ', N'Malignant neoplasm of lower-outer quadrant of breast', NULL, 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (5, CAST(284.20 AS Decimal(5, 2)), 156, 76, CAST(101.00 AS Decimal(5, 2)), 87, N'I feel Sweaty ', N'Subluxation of distal interphalangeal joint of left thumb, initial encounter', N'Nondisplaced oblique fracture of shaft of left ulna, subsequent encounter for closed fracture with nonunion', 42)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (6, CAST(113.40 AS Decimal(5, 2)), 165, 73, CAST(104.30 AS Decimal(5, 2)), 115, N'I can''t Taste properly ', N'War operations involving biological weapons, civilian, sequela', N'Unspecified fracture of lower end of right tibia, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with delayed healing', 38)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (7, CAST(98.10 AS Decimal(5, 2)), 173, 73, CAST(104.70 AS Decimal(5, 2)), 99, N'I feel Sweaty ', N'Acute mastoiditis without complications, bilateral', NULL, 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (8, CAST(190.90 AS Decimal(5, 2)), 101, 96, CAST(100.80 AS Decimal(5, 2)), 68, N'I can''t See properly ', N'Adverse effect of cocaine, subsequent encounter', NULL, 17)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (9, CAST(337.40 AS Decimal(5, 2)), 129, 96, CAST(97.20 AS Decimal(5, 2)), 120, N'Migraines', N'Other injury of head of pancreas, subsequent encounter', N'Abrasion of scrotum and testes, subsequent encounter', 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (10, CAST(239.70 AS Decimal(5, 2)), 85, 50, CAST(100.10 AS Decimal(5, 2)), 177, N'I can''t Breathe normally ', N'Nondisplaced fracture of fourth metatarsal bone, unspecified foot', N'Nondisplaced fracture of right tibial tuberosity, subsequent encounter for closed fracture with routine healing', 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (11, CAST(291.70 AS Decimal(5, 2)), 182, 81, CAST(96.20 AS Decimal(5, 2)), 152, N'I feel Light-headed ', N'Abscess of bursa, right elbow', N'Unspecified dislocation of right sternoclavicular joint, initial encounter', 3)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (12, CAST(162.80 AS Decimal(5, 2)), 183, 63, CAST(99.80 AS Decimal(5, 2)), 156, N'Skin disorders', N'Poisoning by cocaine, intentional self-harm, initial encounter', N'Superficial frostbite of unspecified knee and lower leg, subsequent encounter', 31)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (13, CAST(257.00 AS Decimal(5, 2)), 99, 53, CAST(102.30 AS Decimal(5, 2)), 100, N'My chest hurts', N'Chronic venous hypertension (idiopathic) with inflammation of bilateral lower extremity', NULL, 5)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (14, CAST(188.70 AS Decimal(5, 2)), 141, 77, CAST(103.50 AS Decimal(5, 2)), 95, N'I can''t Speak normally ', N'Displaced fracture of hook process of hamate [unciform] bone, right wrist', N'Hermansky-Pudlak syndrome', 18)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (15, CAST(376.70 AS Decimal(5, 2)), 175, 59, CAST(101.20 AS Decimal(5, 2)), 70, N'I can''t Walk normally ', N'Nondisplaced comminuted fracture of shaft of right tibia', N'Unspecified injury of ear, initial encounter', 46)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (16, CAST(251.00 AS Decimal(5, 2)), 167, 78, CAST(104.20 AS Decimal(5, 2)), 133, N'I feel Fever ', N'Displaced supracondylar fracture with intracondylar extension of lower end of right femur, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with routine healing', NULL, 4)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (17, CAST(366.00 AS Decimal(5, 2)), 176, 83, CAST(99.70 AS Decimal(5, 2)), 71, N'My pelvis hurts', N'Displaced fracture of greater tuberosity of right humerus, initial encounter for open fracture', NULL, 23)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (18, CAST(117.60 AS Decimal(5, 2)), 108, 73, CAST(97.40 AS Decimal(5, 2)), 109, N'I feel Sick ', N'Cervical disc disorder with myelopathy, unspecified cervical region', N'Surfactant mutations of the lung', 3)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (19, CAST(330.60 AS Decimal(5, 2)), 163, 62, CAST(97.50 AS Decimal(5, 2)), 95, N'I can''t Move one side – arm and/or leg ', N'Injury of other muscle(s) and tendon(s) of posterior muscle group at lower leg level', NULL, 21)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (20, CAST(374.80 AS Decimal(5, 2)), 187, 75, CAST(102.00 AS Decimal(5, 2)), 104, N'I can''t Pass urine normally ', N'Corrosion of second degree of unspecified thigh, subsequent encounter', NULL, 40)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (21, CAST(296.80 AS Decimal(5, 2)), 176, 54, CAST(100.20 AS Decimal(5, 2)), 140, N'I feel Chills ', N'Unspecified fracture of unspecified calcaneus, subsequent encounter for fracture with nonunion', NULL, 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (22, CAST(136.20 AS Decimal(5, 2)), 98, 62, CAST(99.60 AS Decimal(5, 2)), 158, N'I feel Sweaty ', N'Unspecified condition associated with female genital organs and menstrual cycle', N'Toxic effect of carbon monoxide from other source', 47)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (23, CAST(307.60 AS Decimal(5, 2)), 144, 69, CAST(96.80 AS Decimal(5, 2)), 122, N'Skin disorders', N'Displacement of other prosthetic devices, implants and grafts of genital tract', NULL, 33)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (24, CAST(246.30 AS Decimal(5, 2)), 178, 83, CAST(104.40 AS Decimal(5, 2)), 85, N'Chronic neurologic disorders', N'Fistula of vagina to large intestine', NULL, 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (25, CAST(185.50 AS Decimal(5, 2)), 186, 99, CAST(96.30 AS Decimal(5, 2)), 149, N'I can''t Remember normally ', N'Puncture wound without foreign body of right elbow, sequela', NULL, 8)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (26, CAST(238.30 AS Decimal(5, 2)), 102, 40, CAST(103.30 AS Decimal(5, 2)), 121, N'I can''t Speak normally ', N'Displaced fracture of base of neck of unspecified femur, subsequent encounter for open fracture type I or II with routine healing', N'Unspecified dislocation of right shoulder joint, initial encounter', 37)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (27, CAST(232.00 AS Decimal(5, 2)), 185, 57, CAST(101.50 AS Decimal(5, 2)), 60, N'I can''t Taste properly ', N'Other superficial bite of unspecified front wall of thorax', NULL, 47)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (28, CAST(340.50 AS Decimal(5, 2)), 171, 59, CAST(103.00 AS Decimal(5, 2)), 69, N'I feel like I have to vomit ', N'Sprain of unspecified parts of thorax', N'Subluxation of other carpometacarpal joint of right hand', 19)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (29, CAST(243.90 AS Decimal(5, 2)), 167, 77, CAST(97.80 AS Decimal(5, 2)), 172, N'Back problems', N'Jumping or diving into other water striking bottom causing other injury, subsequent encounter', N'Complications of heart transplant', 36)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (30, CAST(364.80 AS Decimal(5, 2)), 85, 64, CAST(102.40 AS Decimal(5, 2)), 64, N'Bipolar disorder', N'Drowning and submersion due to being washed overboard from (nonpowered) inflatable craft', N'Poisoning by digestants, undetermined, sequela', 26)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (31, CAST(345.50 AS Decimal(5, 2)), 178, 54, CAST(97.90 AS Decimal(5, 2)), 99, N'I can''t Stop sweating ', N'Blister (nonthermal), right ankle', N'Mantle cell lymphoma, extranodal and solid organ sites', 15)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (32, CAST(105.00 AS Decimal(5, 2)), 137, 55, CAST(104.60 AS Decimal(5, 2)), 157, N'My Vagina hurts', N'Attention and concentration deficit following unspecified cerebrovascular disease', NULL, 27)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (33, CAST(239.50 AS Decimal(5, 2)), 71, 61, CAST(100.20 AS Decimal(5, 2)), 55, N'I feel Thirsty ', N'Trigger finger, left ring finger', N'Nondisplaced fracture of shaft of first metacarpal bone, unspecified hand, initial encounter for closed fracture', 37)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (34, CAST(392.90 AS Decimal(5, 2)), 163, 56, CAST(95.80 AS Decimal(5, 2)), 90, N'I feel Weak ', N'Contusion of unspecified thumb without damage to nail', NULL, 37)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (35, CAST(100.90 AS Decimal(5, 2)), 93, 89, CAST(95.90 AS Decimal(5, 2)), 162, N'Skin disorders', N'Poisoning by, adverse effect of and underdosing of other and unspecified hormone antagonists', NULL, 9)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (36, CAST(253.00 AS Decimal(5, 2)), 166, 67, CAST(100.20 AS Decimal(5, 2)), 129, N'I feel Sweaty ', N'Drug-induced headache, not elsewhere classified', NULL, 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (37, CAST(391.80 AS Decimal(5, 2)), 161, 95, CAST(99.90 AS Decimal(5, 2)), 124, N'I feel Sweaty ', N'Adverse effect of antiviral drugs', NULL, 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (38, CAST(266.80 AS Decimal(5, 2)), 89, 62, CAST(99.30 AS Decimal(5, 2)), 156, N'My pelvis hurts', N'Unspecified nondisplaced fracture of surgical neck of right humerus, sequela', NULL, 23)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (39, CAST(256.60 AS Decimal(5, 2)), 72, 48, CAST(100.90 AS Decimal(5, 2)), 56, N'I can''t Stop scratching ', N'Contusion of heart, unspecified with or without hemopericardium, sequela', N'Underdosing of unspecified psychotropic drug', 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (40, CAST(91.60 AS Decimal(5, 2)), 178, 92, CAST(101.10 AS Decimal(5, 2)), 139, N'I can''t Sleep normally ', N'Maxillary fracture, right side, initial encounter for closed fracture', NULL, 4)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (41, CAST(123.00 AS Decimal(5, 2)), 91, 98, CAST(101.90 AS Decimal(5, 2)), 122, N'I can''t Taste properly ', N'Other specified congenital malformation syndromes, not elsewhere classified', NULL, 3)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (42, CAST(156.00 AS Decimal(5, 2)), 107, 50, CAST(102.70 AS Decimal(5, 2)), 116, N'Cholesterol problems', N'Nondisplaced comminuted fracture of shaft of ulna, left arm, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with nonunion', NULL, 30)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (43, CAST(248.90 AS Decimal(5, 2)), 181, 81, CAST(96.20 AS Decimal(5, 2)), 40, N'I can''t Stop scratching ', N'Neurogenic arthritis, not elsewhere classified', N'Salter-Harris Type II physeal fracture of lower end of humerus, right arm, subsequent encounter for fracture with delayed healing', 5)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (44, CAST(307.20 AS Decimal(5, 2)), 74, 70, CAST(100.40 AS Decimal(5, 2)), 119, N'I feel Sweaty ', N'Degeneration of chamber angle, right eye', N'Salter-Harris Type II physeal fracture of lower end of humerus, unspecified arm, subsequent encounter for fracture with nonunion', 20)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (45, CAST(241.20 AS Decimal(5, 2)), 102, 77, CAST(100.70 AS Decimal(5, 2)), 147, N'I can''t Move one side – arm and/or leg ', N'Exposure to laser radiation', N'Epileptic seizures related to external causes, not intractable', 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (46, CAST(338.40 AS Decimal(5, 2)), 87, 58, CAST(97.50 AS Decimal(5, 2)), 94, N'Depression', N'Laceration of fallopian tube', N'Enteropathic arthropathies, left shoulder', 43)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (47, CAST(114.50 AS Decimal(5, 2)), 165, 75, CAST(96.50 AS Decimal(5, 2)), 90, N'I can''t Stop scratching ', N'Driver of three-wheeled motor vehicle injured in collision with car, pick-up truck or van in nontraffic accident, sequela', NULL, 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (48, CAST(266.30 AS Decimal(5, 2)), 73, 79, CAST(97.60 AS Decimal(5, 2)), 94, N'I feel Short of breath ', N'Raynaud''s syndrome', N'Poisoning by butyrophenone and thiothixene neuroleptics, intentional self-harm', 9)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (49, CAST(248.30 AS Decimal(5, 2)), 107, 46, CAST(103.40 AS Decimal(5, 2)), 47, N'My tooth hurts', N'Injury of superficial palmar arch', NULL, 12)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (50, CAST(181.30 AS Decimal(5, 2)), 146, 57, CAST(103.30 AS Decimal(5, 2)), 176, N'My ear hurts', N'Maternal care for malpresentation of fetus', N'Unspecified fracture of right femur, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with malunion', 5)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (51, CAST(104.90 AS Decimal(5, 2)), 115, 90, CAST(98.20 AS Decimal(5, 2)), 175, N'My rectum hurts', N'Colostomy status', NULL, 37)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (52, CAST(130.50 AS Decimal(5, 2)), 76, 49, CAST(101.20 AS Decimal(5, 2)), 167, N'I feel Sleepy ', N'Contact with paper-cutter, subsequent encounter', NULL, 21)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (53, CAST(336.60 AS Decimal(5, 2)), 141, 93, CAST(98.60 AS Decimal(5, 2)), 92, N'I feel Fever ', N'Poisoning by, adverse effect of and underdosing of iminostilbenes', NULL, 48)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (54, CAST(267.30 AS Decimal(5, 2)), 185, 76, CAST(100.60 AS Decimal(5, 2)), 168, N'I can''t Pass urine normally ', N'Burn of unspecified degree of unspecified site of right lower limb, except ankle and foot, sequela', N'Medial subluxation of proximal end of tibia, unspecified knee', 17)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (55, CAST(83.70 AS Decimal(5, 2)), 79, 77, CAST(101.40 AS Decimal(5, 2)), 145, N'I feel Dizzy ', N'Papyraceous fetus, unspecified trimester, other fetus', NULL, 6)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (56, CAST(238.40 AS Decimal(5, 2)), 109, 55, CAST(100.80 AS Decimal(5, 2)), 159, N'I can''t Pass urine normally ', N'Osteonecrosis due to previous trauma, pelvis', NULL, 7)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (57, CAST(138.30 AS Decimal(5, 2)), 102, 44, CAST(101.60 AS Decimal(5, 2)), 114, N'I can''t Pass a bowel action normally ', N'Chronic postrheumatic arthropathy [Jaccoud], elbow', NULL, 43)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (58, CAST(168.50 AS Decimal(5, 2)), 133, 73, CAST(97.00 AS Decimal(5, 2)), 66, N'My skin hurts', N'Displaced fracture of triquetrum [cuneiform] bone, unspecified wrist, initial encounter for closed fracture', NULL, 17)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (59, CAST(273.30 AS Decimal(5, 2)), 120, 61, CAST(95.60 AS Decimal(5, 2)), 160, N'I can''t Stop sweating ', N'Displaced fracture of shaft of first metacarpal bone, left hand, sequela', NULL, 3)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (60, CAST(313.80 AS Decimal(5, 2)), 88, 71, CAST(96.70 AS Decimal(5, 2)), 118, N'I feel Nauseated ', N'Encounter for other procreative investigation and testing', NULL, 11)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (61, CAST(396.40 AS Decimal(5, 2)), 103, 95, CAST(96.20 AS Decimal(5, 2)), 135, N'I can''t Breathe normally ', N'Nondisplaced fracture of shaft of fourth metacarpal bone, right hand, initial encounter for closed fracture', NULL, 10)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (62, CAST(120.60 AS Decimal(5, 2)), 144, 79, CAST(97.70 AS Decimal(5, 2)), 74, N'I can''t Sleep normally ', N'Other specified injury of radial artery at wrist and hand level of left arm, initial encounter', NULL, 30)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (63, CAST(248.60 AS Decimal(5, 2)), 93, 66, CAST(96.10 AS Decimal(5, 2)), 80, N'My rectum hurts', N'Complete traumatic amputation at elbow level', N'Poisoning by cardiac-stimulant glycosides and drugs of similar action, undetermined, sequela', 7)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (64, CAST(162.50 AS Decimal(5, 2)), 163, 62, CAST(101.80 AS Decimal(5, 2)), 95, N'I feel Sick ', N'Torus fracture of upper end of unspecified humerus, subsequent encounter for fracture with delayed healing', NULL, 43)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (65, CAST(327.90 AS Decimal(5, 2)), 149, 43, CAST(102.40 AS Decimal(5, 2)), 56, N'Headaches', N'Carotid sinus syncope', N'Nondisplaced fracture of medial malleolus of right tibia, subsequent encounter for closed fracture with routine healing', 39)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (66, CAST(297.80 AS Decimal(5, 2)), 157, 51, CAST(99.20 AS Decimal(5, 2)), 102, N'My head hurts', N'Toxic effect of contact with other venomous animals', NULL, 16)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (67, CAST(232.40 AS Decimal(5, 2)), 129, 83, CAST(100.20 AS Decimal(5, 2)), 131, N'Depression', N'Unspecified respiratory condition due to chemicals, gases, fumes and vapors', NULL, 25)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (68, CAST(363.90 AS Decimal(5, 2)), 146, 91, CAST(101.20 AS Decimal(5, 2)), 94, N'My tooth hurts', N'Ring corneal ulcer', N'Other specified injury of extensor muscle, fascia and tendon of left thumb at wrist and hand level', 16)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (69, CAST(340.70 AS Decimal(5, 2)), 130, 60, CAST(100.20 AS Decimal(5, 2)), 51, N'I feel Sweaty ', N'Poisoning by other agents primarily acting on the respiratory system, accidental (unintentional)', NULL, 4)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (70, CAST(91.70 AS Decimal(5, 2)), 136, 89, CAST(104.70 AS Decimal(5, 2)), 163, N'I feel Sick ', N'Displaced fracture of epiphysis (separation) (upper) of left femur, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with nonunion', NULL, 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (71, CAST(154.80 AS Decimal(5, 2)), 135, 83, CAST(99.50 AS Decimal(5, 2)), 111, N'I feel Sick ', N'Recurrent dislocation, right toe(s)', NULL, 38)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (72, CAST(176.50 AS Decimal(5, 2)), 100, 54, CAST(98.50 AS Decimal(5, 2)), 103, N'I can''t Pass a bowel action normally ', N'Nondisplaced fracture of coronoid process of left ulna, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with nonunion', NULL, 2)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (73, CAST(163.50 AS Decimal(5, 2)), 169, 62, CAST(104.00 AS Decimal(5, 2)), 108, N'I can''t Stop sweating ', N'Benign neoplasm of middle ear and respiratory system', NULL, 28)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (74, CAST(281.70 AS Decimal(5, 2)), 71, 71, CAST(100.60 AS Decimal(5, 2)), 139, N'I feel Chronic pain ', N'Lead-induced chronic gout, unspecified site, with tophus (tophi)', NULL, 48)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (75, CAST(362.30 AS Decimal(5, 2)), 174, 43, CAST(102.20 AS Decimal(5, 2)), 135, N'I feel Thirsty ', N'Contact with unspecified sharp object(s), subsequent encounter', N'Poisoning by ophthalmological drugs and preparations, undetermined, initial encounter', 31)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (76, CAST(100.50 AS Decimal(5, 2)), 185, 89, CAST(98.40 AS Decimal(5, 2)), 72, N'Osteoarthritis', N'Pedestrian with other conveyance injured in collision with pedal cycle, unspecified whether traffic or nontraffic accident, subsequent encounter', N'Displaced fracture of greater tuberosity of left humerus, subsequent encounter for fracture with routine healing', 5)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (77, CAST(283.00 AS Decimal(5, 2)), 179, 56, CAST(103.00 AS Decimal(5, 2)), 114, N'Headaches', N'Type III traumatic spondylolisthesis of seventh cervical vertebra, subsequent encounter for fracture with routine healing', N'Displacement of intrauterine contraceptive device, sequela', 29)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (78, CAST(267.00 AS Decimal(5, 2)), 188, 61, CAST(99.50 AS Decimal(5, 2)), 130, N'Chronic neurologic disorders', N'Laceration with foreign body of other specified part of neck', NULL, 6)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (79, CAST(382.70 AS Decimal(5, 2)), 132, 62, CAST(101.00 AS Decimal(5, 2)), 52, N'My head hurts', N'Displaced fracture of coracoid process, left shoulder, initial encounter for open fracture', N'Infections of kidney in pregnancy', 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (80, CAST(368.40 AS Decimal(5, 2)), 130, 92, CAST(100.30 AS Decimal(5, 2)), 179, N'I can''t Speak normally ', N'Fall due to collision between other powered watercraft and other watercraft or other object, subsequent encounter', NULL, 17)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (81, CAST(331.30 AS Decimal(5, 2)), 178, 79, CAST(104.30 AS Decimal(5, 2)), 96, N'Upper respiratory conditions', N'Fall in (into) filled bathtub causing other injury, sequela', N'Type 1 diabetes mellitus with proliferative diabetic retinopathy with traction retinal detachment not involving the macula, unspecified eye', 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (82, CAST(164.80 AS Decimal(5, 2)), 153, 80, CAST(102.10 AS Decimal(5, 2)), 42, N'My head hurts', N'Injury of other nerves at wrist and hand level of unspecified arm, initial encounter', NULL, 26)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (83, CAST(391.70 AS Decimal(5, 2)), 93, 61, CAST(100.20 AS Decimal(5, 2)), 75, N'I can''t Stop sweating ', N'Placentitis, unspecified trimester, not applicable or unspecified', N'Laceration of gallbladder, sequela', 1)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (84, CAST(384.60 AS Decimal(5, 2)), 92, 56, CAST(104.60 AS Decimal(5, 2)), 45, N'Cholesterol problems', N'Poisoning by selective serotonin reuptake inhibitors, undetermined', NULL, 32)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (85, CAST(291.80 AS Decimal(5, 2)), 78, 48, CAST(104.40 AS Decimal(5, 2)), 142, N'I feel Light-headed ', N'Nondisplaced transverse fracture of shaft of right femur, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with malunion', NULL, 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (86, CAST(387.50 AS Decimal(5, 2)), 131, 97, CAST(97.20 AS Decimal(5, 2)), 68, N'I feel Chronic pain ', N'Acute embolism and thrombosis of unspecified vein', N'Embolism and thrombosis of vena cava and other thoracic veins', 21)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (87, CAST(88.80 AS Decimal(5, 2)), 129, 86, CAST(99.00 AS Decimal(5, 2)), 40, N'I feel Weak ', N'Traumatic amputation of breast', N'Convergence excess', 34)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (88, CAST(312.50 AS Decimal(5, 2)), 168, 50, CAST(98.50 AS Decimal(5, 2)), 51, N'I feel Thirsty ', N'Puncture wound without foreign body of left buttock, sequela', NULL, 26)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (89, CAST(263.00 AS Decimal(5, 2)), 134, 70, CAST(104.60 AS Decimal(5, 2)), 176, N'I can''t Stop sweating ', N'Retinopathy of prematurity, stage 3, unspecified eye', NULL, 9)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (90, CAST(171.90 AS Decimal(5, 2)), 183, 49, CAST(104.40 AS Decimal(5, 2)), 49, N'I can''t Taste properly ', N'Pedestrian on skateboard injured in collision with car, pick-up truck or van, unspecified whether traffic or nontraffic accident, initial encounter', NULL, 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (91, CAST(110.50 AS Decimal(5, 2)), 73, 77, CAST(99.00 AS Decimal(5, 2)), 123, N'Joint disorders', N'Recession of chamber angle, right eye', N'Stress fracture, left ankle, sequela', 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (92, CAST(122.40 AS Decimal(5, 2)), 77, 69, CAST(98.60 AS Decimal(5, 2)), 54, N'High blood pressure', N'Other ossification of muscle, right forearm', NULL, 8)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (93, CAST(127.50 AS Decimal(5, 2)), 110, 98, CAST(100.20 AS Decimal(5, 2)), 78, N'I can''t Walk normally ', N'Poisoning by antivaricose drugs, including sclerosing agents, accidental (unintentional), subsequent encounter', NULL, 23)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (94, CAST(294.20 AS Decimal(5, 2)), 140, 92, CAST(98.30 AS Decimal(5, 2)), 70, N'I can''t Move one side – arm and/or leg ', N'Other specified injury of left renal artery, initial encounter', NULL, 14)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (95, CAST(331.80 AS Decimal(5, 2)), 112, 77, CAST(97.40 AS Decimal(5, 2)), 159, N'I can''t Write normally ', N'Term delivery with preterm labor, second trimester, fetus 4', NULL, 30)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (96, CAST(256.00 AS Decimal(5, 2)), 94, 43, CAST(102.70 AS Decimal(5, 2)), 166, N'I can''t Stop passing watery bowel actions ', N'Displaced segmental fracture of shaft of ulna, left arm, initial encounter for closed fracture', NULL, 1)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (97, CAST(199.90 AS Decimal(5, 2)), 158, 90, CAST(104.50 AS Decimal(5, 2)), 74, N'I can''t Breathe normally ', N'Sprain of interphalangeal joint of unspecified toe(s)', N'Viral carditis', 15)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (98, CAST(233.60 AS Decimal(5, 2)), 101, 90, CAST(101.00 AS Decimal(5, 2)), 88, N'Anxiety', N'Other physeal fracture of unspecified calcaneus, subsequent encounter for fracture with nonunion', NULL, 15)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (99, CAST(297.90 AS Decimal(5, 2)), 188, 53, CAST(99.90 AS Decimal(5, 2)), 111, N'My rectum hurts', N'Other specified injuries of left ankle', N'Other articular cartilage disorders, elbow', 12)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (100, CAST(116.50 AS Decimal(5, 2)), 127, 73, CAST(100.50 AS Decimal(5, 2)), 131, N'Osteoarthritis', N'Subluxation of T8/T9 thoracic vertebra, initial encounter', N'Lesion of femoral nerve', 19)
GO
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (101, CAST(173.00 AS Decimal(5, 2)), 173, 74, CAST(101.80 AS Decimal(5, 2)), 53, N'I feel like I have the flu ', N'Other specified injury of posterior tibial artery, right leg', N'Other specified injury of other blood vessels at forearm level, unspecified arm, sequela', 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (102, CAST(115.90 AS Decimal(5, 2)), 175, 40, CAST(102.70 AS Decimal(5, 2)), 150, N'My head hurts', N'Noninflammatory disorder of vagina, unspecified', N'Skeletal fluorosis, right hand', 11)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (103, CAST(389.00 AS Decimal(5, 2)), 153, 93, CAST(102.10 AS Decimal(5, 2)), 70, N'My rectum hurts', N'Laceration of flexor muscle, fascia and tendon of unspecified finger at wrist and hand level, sequela', N'Poisoning by other synthetic narcotics, accidental (unintentional), subsequent encounter', 5)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (104, CAST(231.60 AS Decimal(5, 2)), 181, 60, CAST(97.30 AS Decimal(5, 2)), 44, N'Back problems', N'Poisoning by antigonadotrophins, antiestrogens, antiandrogens, not elsewhere classified, accidental (unintentional)', NULL, 28)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (105, CAST(192.10 AS Decimal(5, 2)), 100, 40, CAST(95.80 AS Decimal(5, 2)), 159, N'My pelvis hurts', N'Poisoning by antimalarials and drugs acting on other blood protozoa, accidental (unintentional), subsequent encounter', N'Other physeal fracture of lower end of radius, right arm, initial encounter for closed fracture', 42)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (106, CAST(207.10 AS Decimal(5, 2)), 120, 53, CAST(103.70 AS Decimal(5, 2)), 128, N'I feel Fever ', N'Nondisplaced comminuted fracture of shaft of ulna, left arm, subsequent encounter for open fracture type I or II with routine healing', N'Other fracture of unspecified femur, sequela', 13)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (107, CAST(330.80 AS Decimal(5, 2)), 129, 96, CAST(101.60 AS Decimal(5, 2)), 48, N'My abdomen hurts', N'Corrosion of unspecified degree of back of left hand, subsequent encounter', NULL, 39)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (108, CAST(168.50 AS Decimal(5, 2)), 105, 70, CAST(97.80 AS Decimal(5, 2)), 154, N'My Vagina hurts', N'Abrasion, left lower leg, initial encounter', N'Pathological fracture, left ankle, subsequent encounter for fracture with routine healing', 2)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (109, CAST(104.40 AS Decimal(5, 2)), 155, 77, CAST(96.00 AS Decimal(5, 2)), 176, N'My Vagina hurts', N'Person on outside of pick-up truck or van injured in collision with railway train or railway vehicle in nontraffic accident, subsequent encounter', NULL, 3)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (110, CAST(113.80 AS Decimal(5, 2)), 157, 83, CAST(97.80 AS Decimal(5, 2)), 152, N'I feel Sweaty ', N'Displaced Rolando''s fracture, right hand, sequela', NULL, 46)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (111, CAST(353.50 AS Decimal(5, 2)), 93, 96, CAST(98.80 AS Decimal(5, 2)), 129, N'Upper respiratory conditions', N'Displaced comminuted fracture of left patella, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with nonunion', NULL, 47)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (112, CAST(184.20 AS Decimal(5, 2)), 79, 93, CAST(100.20 AS Decimal(5, 2)), 58, N'High blood pressure', N'Carcinoma in situ of prostate', NULL, 30)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (113, CAST(284.30 AS Decimal(5, 2)), 90, 53, CAST(102.50 AS Decimal(5, 2)), 150, N'I can''t See properly ', N'External constriction, right lower leg, sequela', N'Displaced comminuted fracture of shaft of ulna, right arm, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with routine healing', 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (114, CAST(195.50 AS Decimal(5, 2)), 109, 66, CAST(103.40 AS Decimal(5, 2)), 163, N'I can''t Breathe normally ', N'Other accident on other pedestrian conveyance, sequela', NULL, 26)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (115, CAST(202.70 AS Decimal(5, 2)), 85, 64, CAST(103.80 AS Decimal(5, 2)), 142, N'I can''t Stop sweating ', N'Other specified injury of blood vessel of right ring finger', NULL, 45)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (116, CAST(267.80 AS Decimal(5, 2)), 161, 55, CAST(104.70 AS Decimal(5, 2)), 112, N'My head hurts', N'Subluxation of proximal interphalangeal joint of unspecified thumb', NULL, 13)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (117, CAST(332.00 AS Decimal(5, 2)), 189, 55, CAST(103.70 AS Decimal(5, 2)), 141, N'Cholesterol problems', N'Other specified noninflammatory disorders of uterus', NULL, 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (118, CAST(324.90 AS Decimal(5, 2)), 184, 98, CAST(103.80 AS Decimal(5, 2)), 61, N'I can''t Taste properly ', N'External constriction, right ankle, initial encounter', NULL, 39)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (119, CAST(105.90 AS Decimal(5, 2)), 164, 62, CAST(100.20 AS Decimal(5, 2)), 115, N'I can''t Remember normally ', N'Protozoal diseases complicating pregnancy', NULL, 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (120, CAST(201.90 AS Decimal(5, 2)), 74, 65, CAST(100.40 AS Decimal(5, 2)), 151, N'I feel Chills ', N'Toxic effect of rattlesnake venom, undetermined, initial encounter', NULL, 43)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (121, CAST(89.50 AS Decimal(5, 2)), 121, 59, CAST(98.10 AS Decimal(5, 2)), 140, N'I can''t Swallow normally ', N'Displaced fracture of distal phalanx of right thumb', N'Laceration of left Achilles tendon', 44)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (122, CAST(167.10 AS Decimal(5, 2)), 176, 43, CAST(95.90 AS Decimal(5, 2)), 41, N'I can''t Stop scratching ', N'Displaced fracture of lesser trochanter of unspecified femur, subsequent encounter for closed fracture with malunion', N'Atherosclerosis of other type of bypass graft(s) of the right leg with ulceration of heel and midfoot', 4)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (123, CAST(280.70 AS Decimal(5, 2)), 145, 51, CAST(100.90 AS Decimal(5, 2)), 121, N'I feel Sleepy ', N'Internal hirudiniasis', N'Radial collateral ligament sprain of left elbow', 8)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (124, CAST(129.50 AS Decimal(5, 2)), 74, 47, CAST(103.00 AS Decimal(5, 2)), 77, N'My ear hurts', N'Salter-Harris Type I physeal fracture of upper end of unspecified fibula, subsequent encounter for fracture with nonunion', NULL, 4)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (125, CAST(160.10 AS Decimal(5, 2)), 89, 80, CAST(96.30 AS Decimal(5, 2)), 59, N'I can''t Swallow normally ', N'Contusion of rectum, subsequent encounter', NULL, 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (126, CAST(198.50 AS Decimal(5, 2)), 176, 41, CAST(101.20 AS Decimal(5, 2)), 107, N'I can''t See properly ', N'Other specified injury of popliteal vein', N'Toxic effect of venom of tarantula, assault, sequela', 29)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (127, CAST(100.00 AS Decimal(5, 2)), 128, 81, CAST(101.50 AS Decimal(5, 2)), 71, N'I can''t Hear normally ', N'Burn of second degree of left thumb (nail)', NULL, 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (128, CAST(110.90 AS Decimal(5, 2)), 152, 57, CAST(99.20 AS Decimal(5, 2)), 48, N'I can''t Stop scratching ', N'Burns involving 80-89% of body surface with 10-19% third degree burns', NULL, 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (129, CAST(164.50 AS Decimal(5, 2)), 131, 75, CAST(98.90 AS Decimal(5, 2)), 68, N'I can''t Breathe normally ', N'Other secondary kyphosis, site unspecified', NULL, 20)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (130, CAST(354.90 AS Decimal(5, 2)), 134, 92, CAST(101.30 AS Decimal(5, 2)), 64, N'High blood pressure', N'Nondisplaced fracture of proximal phalanx of right lesser toe(s)', NULL, 8)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (131, CAST(208.60 AS Decimal(5, 2)), 120, 59, CAST(99.50 AS Decimal(5, 2)), 68, N'I feel Chills ', N'Subluxation of interphalangeal joint of right lesser toe(s), subsequent encounter', N'Ocular laceration and rupture with prolapse or loss of intraocular tissue, right eye, subsequent encounter', 47)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (132, CAST(183.40 AS Decimal(5, 2)), 168, 95, CAST(99.90 AS Decimal(5, 2)), 101, N'I feel Light-headed ', N'2-part nondisplaced fracture of surgical neck of unspecified humerus, initial encounter for closed fracture', NULL, 11)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (133, CAST(144.60 AS Decimal(5, 2)), 103, 60, CAST(102.00 AS Decimal(5, 2)), 90, N'I can''t Hear normally ', N'Nondisplaced fracture of neck of left radius, subsequent encounter for closed fracture with nonunion', N'Maternal care for hydrops fetalis, first trimester, fetus 1', 26)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (134, CAST(110.90 AS Decimal(5, 2)), 89, 48, CAST(101.80 AS Decimal(5, 2)), 159, N'Asthma', N'Other congenital malformations of mouth', N'Unspecified problem related to medical facilities and other health care', 8)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (135, CAST(132.60 AS Decimal(5, 2)), 170, 94, CAST(101.80 AS Decimal(5, 2)), 153, N'High blood pressure', N'Other embolism in pregnancy', N'Injury of cervical sympathetic nerves, sequela', 24)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (136, CAST(315.70 AS Decimal(5, 2)), 161, 52, CAST(95.60 AS Decimal(5, 2)), 162, N'I feel Thirsty ', N'Corrosion of second degree of multiple left fingers (nail), including thumb, sequela', NULL, 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (137, CAST(296.90 AS Decimal(5, 2)), 174, 83, CAST(98.20 AS Decimal(5, 2)), 129, N'I can''t Stop sweating ', N'Other fracture of lower end of right femur, subsequent encounter for open fracture type I or II with malunion', N'Other complications of procedures, not elsewhere classified, initial encounter', 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (138, CAST(295.30 AS Decimal(5, 2)), 90, 99, CAST(96.50 AS Decimal(5, 2)), 131, N'Upper respiratory conditions', N'Unspecified physeal fracture of lower end of humerus, right arm, subsequent encounter for fracture with delayed healing', NULL, 13)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (139, CAST(290.60 AS Decimal(5, 2)), 145, 40, CAST(98.90 AS Decimal(5, 2)), 70, N'I can''t Pass urine normally ', N'Subluxation of metatarsophalangeal joint of unspecified lesser toe(s)', NULL, 42)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (140, CAST(116.50 AS Decimal(5, 2)), 96, 90, CAST(102.30 AS Decimal(5, 2)), 48, N'I can''t Swallow normally ', N'Hemarthrosis, right foot', N'Pedal cycle passenger injured in collision with two- or three-wheeled motor vehicle in nontraffic accident, sequela', 25)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (141, CAST(195.60 AS Decimal(5, 2)), 171, 95, CAST(101.60 AS Decimal(5, 2)), 131, N'Asthma', N'Displaced fracture of lateral end of left clavicle, subsequent encounter for fracture with routine healing', N'Displaced segmental fracture of shaft of radius, unspecified arm, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with malunion', 42)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (142, CAST(114.40 AS Decimal(5, 2)), 129, 40, CAST(102.50 AS Decimal(5, 2)), 95, N'I feel Chronic pain ', N'Otalgia, left ear', NULL, 27)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (143, CAST(93.60 AS Decimal(5, 2)), 162, 50, CAST(101.30 AS Decimal(5, 2)), 54, N'I can''t Pass a bowel action normally ', N'Encounter for fitting and adjustment of partial artificial left leg', NULL, 3)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (144, CAST(307.20 AS Decimal(5, 2)), 84, 98, CAST(104.30 AS Decimal(5, 2)), 121, N'I can''t Pass a bowel action normally ', N'Superficial foreign body, right knee, initial encounter', NULL, 5)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (145, CAST(301.40 AS Decimal(5, 2)), 86, 46, CAST(102.80 AS Decimal(5, 2)), 137, N'I can''t See properly ', N'Displaced spiral fracture of shaft of unspecified femur, subsequent encounter for open fracture type I or II with nonunion', N'Nondisplaced fracture of trapezium [larger multangular], right wrist', 30)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (146, CAST(232.50 AS Decimal(5, 2)), 186, 51, CAST(96.30 AS Decimal(5, 2)), 164, N'I feel Thirsty ', N'Crushing injury of right lesser toe(s), subsequent encounter', NULL, 33)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (147, CAST(279.20 AS Decimal(5, 2)), 105, 53, CAST(100.40 AS Decimal(5, 2)), 179, N'My abdomen hurts', N'Infection and inflammatory reaction due to internal fixation device of left femur', N'Calcification and ossification of muscles associated with burns, left lower leg', 34)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (148, CAST(114.90 AS Decimal(5, 2)), 149, 83, CAST(97.70 AS Decimal(5, 2)), 94, N'I feel numbness ', N'Displaced segmental fracture of shaft of radius, right arm, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with routine healing', N'Salter-Harris Type IV physeal fracture of upper end of humerus, left arm, subsequent encounter for fracture with malunion', 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (149, CAST(87.90 AS Decimal(5, 2)), 173, 44, CAST(96.20 AS Decimal(5, 2)), 93, N'I feel numbness ', N'Displaced fracture of right radial styloid process, initial encounter for closed fracture', NULL, 7)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (150, CAST(239.50 AS Decimal(5, 2)), 104, 70, CAST(102.70 AS Decimal(5, 2)), 75, N'I feel numbness ', N'Nondisplaced comminuted fracture of shaft of unspecified tibia, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with delayed healing', NULL, 33)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (151, CAST(327.40 AS Decimal(5, 2)), 86, 67, CAST(98.30 AS Decimal(5, 2)), 168, N'I can''t Breathe normally ', N'Pneumoconiosis due to other specified inorganic dusts', N'Poisoning by antidotes and chelating agents, assault, subsequent encounter', 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (152, CAST(300.20 AS Decimal(5, 2)), 100, 97, CAST(96.40 AS Decimal(5, 2)), 153, N'I can''t Taste properly ', N'Gout due to renal impairment, left ankle and foot', N'Maternal care for (suspected) damage to fetus by drugs, other fetus', 42)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (153, CAST(205.70 AS Decimal(5, 2)), 146, 91, CAST(100.80 AS Decimal(5, 2)), 166, N'I feel Weak ', N'Displaced segmental fracture of shaft of humerus, unspecified arm, subsequent encounter for fracture with routine healing', NULL, 2)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (154, CAST(342.50 AS Decimal(5, 2)), 70, 68, CAST(97.80 AS Decimal(5, 2)), 110, N'Upper respiratory conditions', N'Poisoning by unspecified drugs primarily affecting the autonomic nervous system, undetermined, sequela', NULL, 27)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (155, CAST(254.90 AS Decimal(5, 2)), 165, 90, CAST(96.70 AS Decimal(5, 2)), 60, N'My tooth hurts', N'Malignant neoplasm of overlapping sites of retroperitoneum and peritoneum', NULL, 4)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (156, CAST(187.30 AS Decimal(5, 2)), 93, 56, CAST(98.50 AS Decimal(5, 2)), 110, N'Bipolar disorder', N'Assault by smoke, fire and flames, subsequent encounter', N'Strain of extensor muscle, fascia and tendon of right ring finger at wrist and hand level, initial encounter', 19)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (157, CAST(157.30 AS Decimal(5, 2)), 163, 92, CAST(100.60 AS Decimal(5, 2)), 96, N'I feel Weak ', N'Injury of trigeminal nerve, left side', NULL, 24)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (158, CAST(127.10 AS Decimal(5, 2)), 100, 74, CAST(100.20 AS Decimal(5, 2)), 78, N'I feel Nauseated ', N'Neoplasm of uncertain behavior of other specified digestive organs', NULL, 19)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (159, CAST(228.00 AS Decimal(5, 2)), 141, 94, CAST(97.30 AS Decimal(5, 2)), 145, N'My ear hurts', N'Isolated proteinuria with diffuse membranous glomerulonephritis', NULL, 7)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (160, CAST(116.40 AS Decimal(5, 2)), 143, 76, CAST(96.50 AS Decimal(5, 2)), 50, N'Chronic neurologic disorders', N'Displaced fracture of medial condyle of left humerus, subsequent encounter for fracture with malunion', N'Toxic effect of chloroform, undetermined, subsequent encounter', 24)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (161, CAST(101.90 AS Decimal(5, 2)), 160, 99, CAST(100.10 AS Decimal(5, 2)), 82, N'My tooth hurts', N'Early cutaneous congenital syphilis', NULL, 15)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (162, CAST(308.80 AS Decimal(5, 2)), 105, 79, CAST(100.80 AS Decimal(5, 2)), 179, N'My abdomen hurts', N'Stable burst fracture of T11-T12 vertebra, initial encounter for open fracture', N'Unspecified superficial injuries of breast, left breast, initial encounter', 39)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (163, CAST(263.20 AS Decimal(5, 2)), 175, 82, CAST(103.10 AS Decimal(5, 2)), 61, N'High blood pressure', N'Fracture of mandible of other specified site', N'Congenital absence of right hand and finger', 42)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (164, CAST(159.50 AS Decimal(5, 2)), 73, 46, CAST(99.80 AS Decimal(5, 2)), 67, N'I can''t Smell things normally ', N'Other physeal fracture of upper end of left femur, subsequent encounter for fracture with nonunion', NULL, 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (165, CAST(258.30 AS Decimal(5, 2)), 120, 81, CAST(97.30 AS Decimal(5, 2)), 126, N'I can''t Remember normally ', N'Anal fistula', NULL, 2)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (166, CAST(189.80 AS Decimal(5, 2)), 128, 68, CAST(104.70 AS Decimal(5, 2)), 178, N'I can''t Speak normally ', N'Nondisplaced spiral fracture of shaft of unspecified tibia, initial encounter for open fracture type IIIA, IIIB, or IIIC', N'Car passenger injured in collision with heavy transport vehicle or bus in nontraffic accident', 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (167, CAST(169.80 AS Decimal(5, 2)), 141, 46, CAST(102.40 AS Decimal(5, 2)), 168, N'I can''t Stop sweating ', N'Spontaneous rupture of other tendons, thigh', NULL, 48)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (168, CAST(150.50 AS Decimal(5, 2)), 109, 98, CAST(97.20 AS Decimal(5, 2)), 167, N'I feel tingling ', N'Nondisplaced apophyseal fracture of unspecified femur, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with malunion', NULL, 47)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (169, CAST(252.40 AS Decimal(5, 2)), 187, 50, CAST(98.90 AS Decimal(5, 2)), 109, N'High blood pressure', N'Anterior corneal pigmentations, right eye', NULL, 25)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (170, CAST(163.30 AS Decimal(5, 2)), 174, 51, CAST(96.00 AS Decimal(5, 2)), 84, N'Upper respiratory conditions', N'Other fracture of unspecified femur, subsequent encounter for open fracture type I or II with malunion', N'Poisoning by local anesthetics, accidental (unintentional), subsequent encounter', 34)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (171, CAST(209.00 AS Decimal(5, 2)), 96, 86, CAST(97.10 AS Decimal(5, 2)), 91, N'My ear hurts', N'Leakage of ventricular intracranial (communicating) shunt, subsequent encounter', N'Drowning and submersion due to other accident to fishing boat, subsequent encounter', 42)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (172, CAST(366.70 AS Decimal(5, 2)), 111, 61, CAST(100.70 AS Decimal(5, 2)), 44, N'I feel Sweaty ', N'Salter-Harris Type IV physeal fracture of unspecified calcaneus, subsequent encounter for fracture with malunion', N'Encounter for fitting and adjustment of other devices related to nervous system and special senses', 7)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (173, CAST(170.60 AS Decimal(5, 2)), 77, 62, CAST(99.40 AS Decimal(5, 2)), 85, N'My pelvis hurts', N'Contusion and laceration of cerebrum, unspecified, with loss of consciousness greater than 24 hours without return to pre-existing conscious level with patient surviving, subsequent encounter', NULL, 32)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (174, CAST(191.60 AS Decimal(5, 2)), 152, 73, CAST(101.50 AS Decimal(5, 2)), 94, N'Skin disorders', N'Minor laceration of right carotid artery, subsequent encounter', N'Cystic meniscus, anterior horn of medial meniscus, unspecified knee', 24)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (175, CAST(186.10 AS Decimal(5, 2)), 76, 41, CAST(95.70 AS Decimal(5, 2)), 45, N'Chronic neurologic disorders', N'War operations involving unarmed hand to hand combat, military personnel', NULL, 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (176, CAST(178.60 AS Decimal(5, 2)), 146, 75, CAST(104.40 AS Decimal(5, 2)), 125, N'I can''t Hear normally ', N'Other contact with rat, initial encounter', N'Pathological fracture in other disease, left radius, initial encounter for fracture', 32)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (177, CAST(81.60 AS Decimal(5, 2)), 88, 97, CAST(98.00 AS Decimal(5, 2)), 103, N'I feel Thirsty ', N'Unspecified fracture of unspecified talus, subsequent encounter for fracture with malunion', NULL, 8)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (178, CAST(234.00 AS Decimal(5, 2)), 142, 61, CAST(99.10 AS Decimal(5, 2)), 97, N'My back hurts', N'Stable burst fracture of first cervical vertebra, initial encounter for closed fracture', NULL, 39)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (179, CAST(215.40 AS Decimal(5, 2)), 148, 44, CAST(99.80 AS Decimal(5, 2)), 79, N'My pelvis hurts', N'Toxic effect of unspecified inorganic substance, undetermined, sequela', NULL, 49)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (180, CAST(265.90 AS Decimal(5, 2)), 187, 76, CAST(103.60 AS Decimal(5, 2)), 118, N'I can''t Pass urine normally ', N'Displaced comminuted fracture of shaft of humerus, left arm, subsequent encounter for fracture with routine healing', NULL, 6)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (181, CAST(362.50 AS Decimal(5, 2)), 139, 42, CAST(97.50 AS Decimal(5, 2)), 85, N'I feel Short of breath ', N'Dislocation of distal end of left ulna, sequela', N'Insect bite (nonvenomous) of unspecified elbow, initial encounter', 44)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (182, CAST(318.00 AS Decimal(5, 2)), 174, 88, CAST(102.20 AS Decimal(5, 2)), 94, N'Depression', N'Polyhydramnios, third trimester, fetus 3', NULL, 20)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (183, CAST(201.70 AS Decimal(5, 2)), 76, 52, CAST(96.80 AS Decimal(5, 2)), 76, N'Cholesterol problems', N'Corrosion of second degree of head, face, and neck, unspecified site', NULL, 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (184, CAST(294.70 AS Decimal(5, 2)), 105, 82, CAST(101.30 AS Decimal(5, 2)), 172, N'Chronic neurologic disorders', N'Long chain/very long chain acyl CoA dehydrogenase deficiency', NULL, 24)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (185, CAST(205.60 AS Decimal(5, 2)), 100, 55, CAST(95.90 AS Decimal(5, 2)), 89, N'I feel my mouth is dry ', N'Other fracture of upper end of unspecified ulna, subsequent encounter for open fracture type I or II with routine healing', N'Nondisplaced intertrochanteric fracture of right femur, initial encounter for open fracture type IIIA, IIIB, or IIIC', 35)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (186, CAST(176.80 AS Decimal(5, 2)), 151, 99, CAST(103.00 AS Decimal(5, 2)), 170, N'I feel electric tweaks ', N'Struck by golf ball, sequela', NULL, 12)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (187, CAST(91.00 AS Decimal(5, 2)), 187, 40, CAST(102.50 AS Decimal(5, 2)), 170, N'Asthma', N'Cerebral infarction due to unspecified occlusion or stenosis of bilateral carotid arteries', N'Laceration of flexor muscle, fascia and tendon of left ring finger at wrist and hand level, initial encounter', 47)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (188, CAST(98.30 AS Decimal(5, 2)), 167, 46, CAST(98.60 AS Decimal(5, 2)), 176, N'I can''t Remember normally ', N'Other fracture of lower end of left tibia, subsequent encounter for open fracture type I or II with routine healing', NULL, 29)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (189, CAST(81.00 AS Decimal(5, 2)), 141, 95, CAST(97.60 AS Decimal(5, 2)), 129, N'I feel Sleepy ', N'Unspecified complication of foreign body accidentally left in body following heart catheterization, subsequent encounter', N'Ulcerative (chronic) pancolitis with fistula', 20)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (190, CAST(126.40 AS Decimal(5, 2)), 177, 97, CAST(97.60 AS Decimal(5, 2)), 129, N'I can''t Swallow normally ', N'Gastric contents in larynx causing other injury, sequela', NULL, 47)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (191, CAST(128.70 AS Decimal(5, 2)), 182, 47, CAST(104.90 AS Decimal(5, 2)), 113, N'I can''t Breathe normally ', N'Burn of second degree of back of right hand', N'Nondisplaced fracture (avulsion) of medial epicondyle of left humerus, initial encounter for closed fracture', 38)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (192, CAST(98.20 AS Decimal(5, 2)), 148, 94, CAST(101.80 AS Decimal(5, 2)), 77, N'Headaches', N'Other specified injury of other specified muscles and tendons at ankle and foot level, left foot', NULL, 31)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (193, CAST(127.30 AS Decimal(5, 2)), 134, 87, CAST(97.10 AS Decimal(5, 2)), 137, N'Diabetes', N'Crushing injury of unspecified external genital organs, male, initial encounter', NULL, 6)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (194, CAST(123.60 AS Decimal(5, 2)), 178, 67, CAST(101.00 AS Decimal(5, 2)), 62, N'I feel Dizzy ', N'Pedestrian injured in traffic accident involving military vehicle, initial encounter', NULL, 20)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (195, CAST(300.70 AS Decimal(5, 2)), 71, 75, CAST(97.80 AS Decimal(5, 2)), 126, N'I can''t Stop passing watery bowel actions ', N'Displacement of indwelling urethral catheter, subsequent encounter', NULL, 27)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (196, CAST(336.10 AS Decimal(5, 2)), 118, 95, CAST(102.10 AS Decimal(5, 2)), 61, N'Anxiety', N'Corrosion of third degree of unspecified site of right lower limb, except ankle and foot, sequela', N'Torsion of left ovary and ovarian pedicle', 45)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (197, CAST(94.50 AS Decimal(5, 2)), 78, 41, CAST(102.40 AS Decimal(5, 2)), 160, N'I feel Sweaty ', N'Nondisplaced fracture of second metatarsal bone, right foot, initial encounter for open fracture', NULL, 25)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (198, CAST(318.40 AS Decimal(5, 2)), 113, 93, CAST(102.60 AS Decimal(5, 2)), 171, N'I feel Tired ', N'Malignant neoplasm of uterine adnexa, unspecified', NULL, 37)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (199, CAST(193.90 AS Decimal(5, 2)), 146, 85, CAST(96.70 AS Decimal(5, 2)), 73, N'Skin disorders', N'Congenital malformation of ear causing impairment of hearing, unspecified', NULL, 24)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (200, CAST(394.30 AS Decimal(5, 2)), 141, 44, CAST(100.10 AS Decimal(5, 2)), 143, N'I feel Chills ', N'Spontaneous rupture of flexor tendons, multiple sites', NULL, 15)
GO
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (201, CAST(318.20 AS Decimal(5, 2)), 152, 48, CAST(104.10 AS Decimal(5, 2)), 45, N'My pelvis hurts', N'Toxic effect of unspecified gases, fumes and vapors, assault, subsequent encounter', N'Toxic effect of contact with stingray, undetermined', 20)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (202, CAST(359.20 AS Decimal(5, 2)), 107, 93, CAST(99.40 AS Decimal(5, 2)), 66, N'I feel Thirsty ', N'Leakage of unspecified vascular graft, subsequent encounter', N'Unspecified dislocation of right ring finger', 1)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (203, CAST(228.10 AS Decimal(5, 2)), 176, 96, CAST(96.90 AS Decimal(5, 2)), 86, N'I can''t Pass urine normally ', N'Unspecified fracture of right forearm, subsequent encounter for closed fracture with malunion', NULL, 15)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (204, CAST(396.90 AS Decimal(5, 2)), 167, 76, CAST(96.30 AS Decimal(5, 2)), 121, N'I can''t Sleep normally ', N'Synovial hypertrophy, not elsewhere classified, right upper arm', NULL, 36)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (205, CAST(145.30 AS Decimal(5, 2)), 140, 42, CAST(102.20 AS Decimal(5, 2)), 59, N'I can''t Stop sweating ', N'Fall into other water striking bottom causing drowning and submersion, sequela', NULL, 3)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (206, CAST(180.30 AS Decimal(5, 2)), 106, 98, CAST(96.20 AS Decimal(5, 2)), 113, N'I can''t Walk normally ', N'Displaced avulsion fracture of right ischium', N'Major laceration of greater saphenous vein at hip and thigh level, left leg, sequela', 23)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (207, CAST(263.90 AS Decimal(5, 2)), 181, 65, CAST(100.50 AS Decimal(5, 2)), 46, N'My chest hurts', N'Hemiplegia and hemiparesis following nontraumatic subarachnoid hemorrhage affecting unspecified side', N'Toxic effect of aflatoxin, intentional self-harm, sequela', 33)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (208, CAST(235.20 AS Decimal(5, 2)), 83, 66, CAST(98.50 AS Decimal(5, 2)), 97, N'I can''t Sleep normally ', N'Person on outside of three-wheeled motor vehicle injured in collision with car, pick-up truck or van in traffic accident, subsequent encounter', NULL, 14)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (209, CAST(341.20 AS Decimal(5, 2)), 176, 42, CAST(100.90 AS Decimal(5, 2)), 152, N'I feel Weak ', N'Other spondylosis with myelopathy, cervical region', NULL, 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (210, CAST(176.60 AS Decimal(5, 2)), 94, 93, CAST(104.40 AS Decimal(5, 2)), 154, N'I can''t Pass a bowel action normally ', N'Pneumonia in diseases classified elsewhere', NULL, 28)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (211, CAST(192.00 AS Decimal(5, 2)), 124, 99, CAST(99.60 AS Decimal(5, 2)), 68, N'My abdomen hurts', N'Hepatic fibrosis with hepatic sclerosis', NULL, 10)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (212, CAST(121.10 AS Decimal(5, 2)), 140, 78, CAST(103.40 AS Decimal(5, 2)), 142, N'Anxiety', N'Target of (perceived) adverse discrimination and persecution', N'Injury of median nerve at wrist and hand level', 46)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (213, CAST(224.30 AS Decimal(5, 2)), 133, 100, CAST(101.50 AS Decimal(5, 2)), 43, N'Anxiety', N'Encounter for other administrative examinations', NULL, 39)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (214, CAST(275.30 AS Decimal(5, 2)), 166, 59, CAST(104.40 AS Decimal(5, 2)), 61, N'I feel Tired ', N'Other specified disorders of cartilage', NULL, 16)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (215, CAST(235.90 AS Decimal(5, 2)), 113, 73, CAST(101.20 AS Decimal(5, 2)), 109, N'I can''t Speak normally ', N'Motorcycle driver injured in noncollision transport accident in nontraffic accident', N'Prosthetic and other implants, materials and accessory otorhinolaryngological devices associated with adverse incidents', 34)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (216, CAST(134.50 AS Decimal(5, 2)), 77, 69, CAST(104.00 AS Decimal(5, 2)), 46, N'I can''t Stop passing watery bowel actions ', N'Breakdown (mechanical) of internal fixation device of other bones', N'Burn of unspecified degree of toe(s) (nail)', 50)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (217, CAST(169.80 AS Decimal(5, 2)), 92, 56, CAST(96.00 AS Decimal(5, 2)), 88, N'I can''t Pass a bowel action normally ', N'Laceration of flexor muscle, fascia and tendon of left middle finger at wrist and hand level', NULL, 37)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (218, CAST(164.60 AS Decimal(5, 2)), 162, 92, CAST(98.70 AS Decimal(5, 2)), 123, N'My extremities hurt', N'Other fracture of unspecified femur, initial encounter for closed fracture', NULL, 33)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (219, CAST(243.90 AS Decimal(5, 2)), 169, 42, CAST(100.60 AS Decimal(5, 2)), 51, N'I can''t Taste properly ', N'Other incomplete lesion at C3 level of cervical spinal cord', NULL, 50)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (220, CAST(102.60 AS Decimal(5, 2)), 79, 93, CAST(95.80 AS Decimal(5, 2)), 55, N'My tooth hurts', N'Newborn affected by malpresentation before labor', NULL, 39)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (221, CAST(115.70 AS Decimal(5, 2)), 109, 78, CAST(101.70 AS Decimal(5, 2)), 62, N'Anxiety', N'Diseases of the nervous system complicating pregnancy, second trimester', N'Puncture wound of abdominal wall with foreign body, left upper quadrant without penetration into peritoneal cavity, sequela', 6)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (222, CAST(312.00 AS Decimal(5, 2)), 73, 44, CAST(100.80 AS Decimal(5, 2)), 175, N'High blood pressure', N'Gestational [pregnancy-induced] hypertension without significant proteinuria, first trimester', N'Superficial foreign body of unspecified finger, sequela', 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (223, CAST(314.10 AS Decimal(5, 2)), 121, 95, CAST(101.10 AS Decimal(5, 2)), 161, N'I can''t Sleep normally ', N'Unspecified fracture of T11-T12 vertebra, sequela', NULL, 21)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (224, CAST(95.70 AS Decimal(5, 2)), 153, 52, CAST(97.70 AS Decimal(5, 2)), 84, N'Asthma', N'Assault by unspecified firearm discharge, subsequent encounter', NULL, 4)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (225, CAST(296.60 AS Decimal(5, 2)), 97, 82, CAST(97.50 AS Decimal(5, 2)), 140, N'I feel Sleepy ', N'Displaced segmental fracture of shaft of left fibula, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with routine healing', N'Hemorrhagic detachment of retinal pigment epithelium', 22)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (226, CAST(200.80 AS Decimal(5, 2)), 106, 55, CAST(103.10 AS Decimal(5, 2)), 122, N'My skin hurts', N'Displaced bimalleolar fracture of unspecified lower leg, initial encounter for open fracture type I or II', NULL, 30)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (227, CAST(382.40 AS Decimal(5, 2)), 167, 74, CAST(103.20 AS Decimal(5, 2)), 108, N'My skin hurts', N'Puncture wound with foreign body of left front wall of thorax with penetration into thoracic cavity, subsequent encounter', NULL, 47)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (228, CAST(210.10 AS Decimal(5, 2)), 148, 54, CAST(97.10 AS Decimal(5, 2)), 144, N'Skin disorders', N'Poisoning by unspecified narcotics, intentional self-harm', NULL, 20)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (229, CAST(176.20 AS Decimal(5, 2)), 75, 75, CAST(103.00 AS Decimal(5, 2)), 166, N'I can''t Stop scratching ', N'Salter-Harris Type I physeal fracture of upper end of humerus, left arm, initial encounter for closed fracture', NULL, 30)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (230, CAST(300.60 AS Decimal(5, 2)), 189, 96, CAST(100.40 AS Decimal(5, 2)), 99, N'Headaches', N'Displaced fracture of anterior column [iliopubic] of unspecified acetabulum, subsequent encounter for fracture with delayed healing', NULL, 34)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (231, CAST(169.60 AS Decimal(5, 2)), 162, 48, CAST(100.10 AS Decimal(5, 2)), 56, N'Cholesterol problems', N'Unspecified superficial injury of left knee', N'Poisoning by antivaricose drugs, including sclerosing agents, assault, subsequent encounter', 6)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (232, CAST(82.40 AS Decimal(5, 2)), 134, 89, CAST(102.40 AS Decimal(5, 2)), 101, N'I can''t Stop scratching ', N'Abrasion of right middle finger, subsequent encounter', N'Striking against wall of swimming pool', 7)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (233, CAST(160.80 AS Decimal(5, 2)), 141, 82, CAST(99.70 AS Decimal(5, 2)), 82, N'Joint disorders', N'Laceration with foreign body of unspecified part of head, sequela', NULL, 13)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (234, CAST(105.50 AS Decimal(5, 2)), 182, 56, CAST(99.40 AS Decimal(5, 2)), 139, N'I can''t Walk normally ', N'Unspecified fracture of shaft of humerus, left arm, subsequent encounter for fracture with delayed healing', N'Corrosion of first degree of right elbow', 50)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (235, CAST(126.90 AS Decimal(5, 2)), 172, 65, CAST(97.10 AS Decimal(5, 2)), 156, N'Anxiety', N'Forced landing of glider (nonpowered) injuring occupant, subsequent encounter', NULL, 50)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (236, CAST(233.70 AS Decimal(5, 2)), 154, 78, CAST(102.30 AS Decimal(5, 2)), 111, N'Chronic neurologic disorders', N'Pedestrian with other conveyance injured in collision with railway train or railway vehicle, unspecified whether traffic or nontraffic accident, sequela', NULL, 16)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (237, CAST(311.90 AS Decimal(5, 2)), 150, 99, CAST(99.00 AS Decimal(5, 2)), 120, N'Skin disorders', N'Laceration without foreign body of right upper arm, sequela', N'Parachutist injured on landing', 41)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (238, CAST(162.70 AS Decimal(5, 2)), 80, 61, CAST(95.70 AS Decimal(5, 2)), 74, N'Osteoarthritis', N'Nondisplaced comminuted fracture of shaft of radius, left arm, subsequent encounter for closed fracture with routine healing', NULL, 10)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (239, CAST(92.00 AS Decimal(5, 2)), 109, 68, CAST(98.20 AS Decimal(5, 2)), 103, N'I feel like I have to vomit ', N'Displaced simple supracondylar fracture without intercondylar fracture of right humerus', NULL, 6)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (240, CAST(398.90 AS Decimal(5, 2)), 97, 47, CAST(102.90 AS Decimal(5, 2)), 120, N'I feel numbness ', N'Pedestrian injured in nontraffic accident involving other motor vehicles, sequela', NULL, 18)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (241, CAST(255.10 AS Decimal(5, 2)), 188, 70, CAST(102.50 AS Decimal(5, 2)), 101, N'I feel tingling ', N'Neoplasm of uncertain behavior of respiratory organ, unspecified', NULL, 40)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (242, CAST(288.60 AS Decimal(5, 2)), 71, 52, CAST(99.80 AS Decimal(5, 2)), 176, N'I feel like I have the flu ', N'Staphyloma posticum', NULL, 38)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (243, CAST(166.40 AS Decimal(5, 2)), 117, 51, CAST(99.10 AS Decimal(5, 2)), 165, N'I feel Thirsty ', N'Toxic effect of venom of ants, intentional self-harm', NULL, 43)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (244, CAST(150.60 AS Decimal(5, 2)), 105, 45, CAST(101.00 AS Decimal(5, 2)), 47, N'I can''t Write normally ', N'Nondisplaced fracture of base of neck of left femur', N'Sprain of unspecified cruciate ligament of right knee', 6)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (245, CAST(143.20 AS Decimal(5, 2)), 98, 98, CAST(95.80 AS Decimal(5, 2)), 141, N'I feel Short of breath ', N'Passenger of other special all-terrain or other off-road motor vehicle injured in traffic accident, initial encounter', NULL, 33)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (246, CAST(146.10 AS Decimal(5, 2)), 138, 47, CAST(102.00 AS Decimal(5, 2)), 170, N'I feel Chills ', N'Poisoning by other psychotropic drugs, intentional self-harm, subsequent encounter', NULL, 7)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (247, CAST(395.10 AS Decimal(5, 2)), 179, 72, CAST(98.60 AS Decimal(5, 2)), 98, N'Chronic neurologic disorders', N'Nondisplaced fracture of olecranon process with intraarticular extension of left ulna, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with malunion', NULL, 9)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (248, CAST(313.30 AS Decimal(5, 2)), 88, 68, CAST(97.70 AS Decimal(5, 2)), 139, N'I feel Dizzy ', N'Explosion on board other powered watercraft, sequela', NULL, 27)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (249, CAST(104.80 AS Decimal(5, 2)), 89, 76, CAST(97.20 AS Decimal(5, 2)), 102, N'My pelvis hurts', N'Posterior dislocation of unspecified radial head, subsequent encounter', N'Sequelae of unspecified nutritional deficiency', 37)
INSERT [dbo].[Visit] ([appointmentID], [weight], [systolicBP], [diastolicBP], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis], [nurseID]) VALUES (250, CAST(149.60 AS Decimal(5, 2)), 112, 98, CAST(99.20 AS Decimal(5, 2)), 141, N'Joint disorders', N'Fat embolism (traumatic), sequela', NULL, 39)
/****** Object:  Index [UQ_Administrator_PersonID]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[Administrator] ADD  CONSTRAINT [UQ_Administrator_PersonID] UNIQUE NONCLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Appointment_Date_DoctorID]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [UQ_Appointment_Date_DoctorID] UNIQUE NONCLUSTERED 
(
	[apptDatetime] ASC,
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Appointment_Date_PatientID]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [UQ_Appointment_Date_PatientID] UNIQUE NONCLUSTERED 
(
	[apptDatetime] ASC,
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Doctor_PersonID]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[Doctor] ADD  CONSTRAINT [UQ_Doctor_PersonID] UNIQUE NONCLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_LabTest_TestName]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[LabTest] ADD  CONSTRAINT [UQ_LabTest_TestName] UNIQUE NONCLUSTERED 
(
	[testName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Nurse_PersonID]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[Nurse] ADD  CONSTRAINT [UQ_Nurse_PersonID] UNIQUE NONCLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Patient_PersonID]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [UQ_Patient_PersonID] UNIQUE NONCLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Person_SSN]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [UQ_Person_SSN] UNIQUE NONCLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_TestOrdered_Appointment_TestDate_TestCode]    Script Date: 4/29/2019 9:20:06 PM ******/
ALTER TABLE [dbo].[TestOrdered] ADD  CONSTRAINT [UQ_TestOrdered_Appointment_TestDate_TestCode] UNIQUE NONCLUSTERED 
(
	[appointmentID] ASC,
	[testDate] ASC,
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_Person]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Person]
GO
ALTER TABLE [dbo].[DoctorSpecialty]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialty_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[DoctorSpecialty] CHECK CONSTRAINT [FK_DoctorSpecialty_Doctor]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_Person]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Person]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Credential] FOREIGN KEY([username])
REFERENCES [dbo].[Credential] ([username])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Credential]
GO
ALTER TABLE [dbo].[TestOrdered]  WITH CHECK ADD  CONSTRAINT [FK_TestOrdered_LabTest] FOREIGN KEY([testCode])
REFERENCES [dbo].[LabTest] ([testCode])
GO
ALTER TABLE [dbo].[TestOrdered] CHECK CONSTRAINT [FK_TestOrdered_LabTest]
GO
ALTER TABLE [dbo].[TestOrdered]  WITH CHECK ADD  CONSTRAINT [FK_TestOrdered_Visit] FOREIGN KEY([appointmentID])
REFERENCES [dbo].[Visit] ([appointmentID])
GO
ALTER TABLE [dbo].[TestOrdered] CHECK CONSTRAINT [FK_TestOrdered_Visit]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Appointment] FOREIGN KEY([appointmentID])
REFERENCES [dbo].[Appointment] ([appointmentID])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Appointment]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Nurse] FOREIGN KEY([nurseID])
REFERENCES [dbo].[Nurse] ([nurseID])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Nurse]
GO
/****** Object:  StoredProcedure [dbo].[sp_mostPerformedTestsDuringDates]    Script Date: 4/29/2019 9:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		CS6232-G1
-- Create date: 4/21/2019
-- Description:	Purpose: Gets the statistics that show the most performed tests during the specified period of time for the tests that were performed at least twice.
-- =============================================
CREATE PROCEDURE [dbo].[sp_mostPerformedTestsDuringDates] 
	@p_startDate DATE, 
	@p_endDate DATE 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE	@total_all_tests INT;
	  
	SELECT @total_all_tests = COUNT(*) 
	FROM TestOrdered tord
		JOIN LabTest lt
		ON tord.testCode = lt.testCode
		WHERE testDate BETWEEN @p_startDate AND @p_endDate AND result IS NOT NULL

	SELECT tord.testCode, testName, COUNT(tord.testCode) AS total_tests, @total_all_tests AS total_all_tests,
		COUNT(CASE WHEN result = 0 THEN 1 ELSE NULL END) AS normal_Results,
		COUNT(CASE WHEN result = 1 THEN 1 ELSE NULL END) AS abnormal_Results,
		COUNT(CASE WHEN DATEDIFF(YEAR, per.birthDate, tord.testDate) BETWEEN 18 AND 29 THEN 1 ELSE NULL END) AS age_18To29,
		COUNT(CASE WHEN DATEDIFF(YEAR, per.birthDate, tord.testDate) BETWEEN 30 AND 39 THEN 1 ELSE NULL END) AS age_30To39
	FROM TestOrdered tord
		JOIN LabTest lt
		ON tord.testCode = lt.testCode
		JOIN Appointment app
		ON tord.appointmentID = app.appointmentID
		JOIN patient p
		ON app.patientID = p.patientID
		JOIN Person per
		ON p.personID = per.personID
	WHERE testDate BETWEEN @p_startDate AND @p_endDate AND result IS NOT NULL
	GROUP BY tord.testCode, testName
	HAVING COUNT(tord.testCode) > 1
	ORDER BY COUNT(tord.testCode) DESC, tord.testCode DESC
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SSN must be unique' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'CONSTRAINT',@level2name=N'UQ_Person_SSN'
GO
USE [master]
GO
ALTER DATABASE [CS6232-g1] SET  READ_WRITE 
GO
