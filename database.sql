USE [master]
GO
/****** Object:  Database [BTS1]    Script Date: 9/30/2021 3:24:27 PM ******/
CREATE DATABASE [BTS1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BTS1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BTS1.mdf' , SIZE = 47104KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BTS1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BTS1_log.ldf' , SIZE = 47104KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BTS1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BTS1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BTS1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BTS1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BTS1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BTS1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BTS1] SET ARITHABORT OFF 
GO
ALTER DATABASE [BTS1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BTS1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BTS1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BTS1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BTS1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BTS1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BTS1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BTS1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BTS1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BTS1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BTS1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BTS1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BTS1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BTS1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BTS1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BTS1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BTS1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BTS1] SET RECOVERY FULL 
GO
ALTER DATABASE [BTS1] SET  MULTI_USER 
GO
ALTER DATABASE [BTS1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BTS1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BTS1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BTS1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BTS1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BTS1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BTS1', N'ON'
GO
ALTER DATABASE [BTS1] SET QUERY_STORE = OFF
GO
USE [BTS1]
GO
/****** Object:  Table [dbo].[busdetails]    Script Date: 9/30/2021 3:24:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[busdetails](
	[busno] [nvarchar](50) NOT NULL,
	[busname] [nvarchar](50) NOT NULL,
	[chooseroute] [nvarchar](50) NOT NULL,
	[bustype] [nvarchar](50) NOT NULL,
	[noofseats] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Driver] [nvarchar](50) NOT NULL,
	[conductor] [nvarchar](50) NOT NULL,
	[busstatus] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_busdetails] PRIMARY KEY CLUSTERED 
(
	[busno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[busoute]    Script Date: 9/30/2021 3:24:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[busoute](
	[routeid] [nvarchar](50) NOT NULL,
	[choosestation] [varchar](50) NOT NULL,
	[distancefromsource] [varchar](50) NOT NULL,
	[arrivaltime] [varchar](50) NOT NULL,
	[departuretime] [varchar](50) NOT NULL,
 CONSTRAINT [PK_busroute] PRIMARY KEY CLUSTERED 
(
	[routeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTB]    Script Date: 9/30/2021 3:24:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTB](
	[employeeid] [nvarchar](50) NOT NULL,
	[employeename] [nvarchar](50) NOT NULL,
	[role] [nvarchar](50) NOT NULL,
	[employeeaddress] [nvarchar](50) NOT NULL,
	[employeephoneno] [nvarchar](50) NOT NULL,
	[fathersname] [nvarchar](50) NOT NULL,
	[mothersname] [nvarchar](50) NOT NULL,
	[citizenshipno] [nvarchar](15) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmployeeTB] PRIMARY KEY CLUSTERED 
(
	[employeeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTBother]    Script Date: 9/30/2021 3:24:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTBother](
	[employeeid] [nvarchar](50) NOT NULL,
	[employeename] [nvarchar](50) NOT NULL,
	[role] [nvarchar](50) NOT NULL,
	[employeeaddress] [nvarchar](50) NOT NULL,
	[employeephoneno] [nvarchar](50) NOT NULL,
	[fathersname] [nvarchar](50) NOT NULL,
	[mothersname] [nvarchar](50) NOT NULL,
	[citizenshipno] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmployeeTBother] PRIMARY KEY CLUSTERED 
(
	[employeeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stations]    Script Date: 9/30/2021 3:24:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stations](
	[stationcode] [nvarchar](50) NOT NULL,
	[stationname] [nvarchar](50) NOT NULL,
	[stationaddress] [nvarchar](50) NOT NULL,
	[routeid] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_stations] PRIMARY KEY CLUSTERED 
(
	[stationcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ticketcreator]    Script Date: 9/30/2021 3:24:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ticketcreator](
	[ticketno] [int] NOT NULL,
	[busno] [nvarchar](50) NOT NULL,
	[sourcestation] [nvarchar](50) NOT NULL,
	[destinationstation] [nvarchar](50) NOT NULL,
	[distancefromsource] [nvarchar](50) NOT NULL,
	[chooseroute] [nvarchar](50) NOT NULL,
	[noofpassengers] [int] NOT NULL,
	[issueddate] [nvarchar](50) NOT NULL,
	[departuredate] [nvarchar](50) NOT NULL,
	[departuretime] [nvarchar](50) NOT NULL,
	[arrivaltime] [nvarchar](50) NOT NULL,
	[totalfarecost] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[age] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phoneno] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ticketcreator] PRIMARY KEY CLUSTERED 
(
	[ticketno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'1', N'1', N'ddd', N'AC Suspension', N'111', N'1', N'ghh', N'sdfssdf', N'Unavailable')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'11', N'3336', N'653', N'AC Suspension', N'956', N'653', N'956', N'65', N'Unavailable')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'2', N'ds', N'ddd', N'AC Suspension', N'22', N'ds2', N'ds', N'sdfssdf', N'Unavailable')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'21', N'dd', N'ewe', N'Super Deluxe', N'43', N'dd2', N'ghh', N'ghh', N'Unavailable')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'3', N'3', N'55', N'AC Suspension', N'44', N'FDS', N'ds', N'ds', N'Unavailable')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'7', N'7', N'7', N'AC Suspension', N'7', N'7', N'7', N'7', N'Unavailable')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'8', N'8', N'8', N'AC Suspension', N'8', N'8', N'8', N'8', N'Unavailable')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'BA 3 PA 6685', N'SUDURPASCHIM  YATAYAT', N'Mahendra Highway ', N'Super Deluxe', N'67', N'AFD8', N'sdfssdf', N'joshi', N'Available')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'CHAND', N'SURAJ', N'SURAJ', N'AC Suspension', N'SURAJ', N'SURAJ', N'sdfssdf', N'joshi', N'Available')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'cxs', N'sd', N'55', N'Deluxe', N'45', N'sf', N'ds', N'ig', N'Unavailable')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'NA 4 KHA 5512', N'BAITADI DELUXE', N'Bhim Dutta Highway', N'Super Deluxe', N'62', N'BTDIE62', N'ref', N'ghh', N'Available')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'SE 4 PA 5429', N'SPY', N'ewe', N'Deluxe', N'55', N'RJT56', N'PRABIN', N'SAMEER', N'Available')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'SE 4 PA 6857', N'Karnali River Yatayat', N'Mahendra Highway', N'AC Suspension', N'67', N'BS 42SE', N'Prabin', N'Bipin', N'Available')
INSERT [dbo].[busdetails] ([busno], [busname], [chooseroute], [bustype], [noofseats], [Model], [Driver], [conductor], [busstatus]) VALUES (N'SURAJ', N'SURAJ', N'SURAJ', N'AC Suspension', N'SURAJ', N'SURAJ', N'sdfssdf', N'joshi', N'Unavailable')
GO
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N'1', N'Mahendra Highway', N'715', N'12:30:09 PM', N'12:30:09 PM')
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N'33', N'ewe', N'34', N'wqe', N'sdfsdf')
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N'5', N'55', N'55', N'55', N'55')
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N'a', N'a', N'a', N'a', N'a')
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N'adfs', N'asdfs', N'adfs', N'adfs', N'dfs')
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N'dd', N'ddd', N'd', N'd', N'd')
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N's', N'ss', N's', N's', N's')
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N'sda', N'aas', N'34', N'sa2', N'sa2')
INSERT [dbo].[busoute] ([routeid], [choosestation], [distancefromsource], [arrivaltime], [departuretime]) VALUES (N'vc', N'dfg', N'dfg', N'df', N'df')
GO
INSERT [dbo].[EmployeeTB] ([employeeid], [employeename], [role], [employeeaddress], [employeephoneno], [fathersname], [mothersname], [citizenshipno], [email], [pass]) VALUES (N'1', N'admin', N'Administrator', N'dhn', N'575189', N'dbc', N'sbc', N'45-45-68-45746', N'admin@gmail.com', N'admin')
GO
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'2', N'attariya', N'ewe', N's')
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'23', N'er', N'asdsf', N'5')
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'3', N'3', N'ewe', N's')
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'asdf', N'sadf', N'asdsf', N'dd')
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'df', N'dsfdf', N'asdsf', N'dd')
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'dfhg', N'kjhg', N'asdsf', N'adfs')
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'ds', N'dsf', N'asdsf', N'a')
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'ewre', N'ewre', N'dhn', N'34')
INSERT [dbo].[stations] ([stationcode], [stationname], [stationaddress], [routeid]) VALUES (N'sa', N'sa', N'asdsf', N'dd')
GO
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (1, N'SE 4 PA 6857', N'Dhangadhi', N'Kathmandu', N'517', N'Mahendra Highway', 2, N'Monday, June 28, 2021', N'Thursday, April 1, 2021', N'3:36:00 PM', N'6:30:00 AM', 6000, N'Sameer Joshi', N'23', N'Male ', N'Taranagar', N'9865681256')
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (2, N'lkjhb', N'dhn', N'ktm', N'717', N'ddd', 3, N'Friday, June 4, 2021', N'Saturday, June 5, 2021', N'3:36:00 PM', N'6:22:07 AM', 6000, N'sameer', N'22', N'Male ', N'dhn', N'9865')
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (5, N'lkjh', N'd', N'ktm', N'555', N'ewe', 4, N'Thursday, April 1, 2021', N'Thursday, April 1, 2021', N'3:36:00 PM', N'2:22:56 PM', 8000, N'sc', N'21', N'Male ', N'd', N'9866')
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (6, N'lkjhb', N'dhn', N'ktm', N'717', N'ddd', 5, N'Friday, June 4, 2021', N'Saturday, June 5, 2021', N'3:36:00 PM', N'6:22:07 AM', 6000, N'sameerr', N'22', N'Male ', N'dhn', N'9865')
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (7, N'32', N'dhn', N'ktm', N'32', N'ewe', 3, N'Thursday, April 1, 2021', N'Thursday, April 1, 2021', N'3:36:00 PM', N'5:27:38 PM', 3223, N'ds', N'33', N'Male ', N'dhn', N'323423')
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (12, N'1', N'dhn', N'ktm', N'234', N'asdfs', 2, N'Thursday, April 1, 2021', N'Thursday, April 1, 2021', N'3:36:00 PM', N'11:12:11 PM', 3232, N's', N'33', N'Male ', N'dhn', N'23456')
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (65, N'21', N'dhn', N'ktm', N'dr5', N'a', 5, N'Thursday, April 1, 2021', N'Thursday, April 1, 2021', N'3:36:00 PM', N'12:43:43 AM', 545, N'rgfh', N'dfgh', N'Female', N'dhn', N'45')
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (523, N'asdf4321', N'ktm', N'dhn', N'715', N'ddd', 2, N'Thursday, April 1, 2021', N'Thursday, April 1, 2021', N'3:36:00 PM', N'8:40:18 AM', 4000, N'suraj', N'20', N'Male ', N'dhn', N'575189')
INSERT [dbo].[ticketcreator] ([ticketno], [busno], [sourcestation], [destinationstation], [distancefromsource], [chooseroute], [noofpassengers], [issueddate], [departuredate], [departuretime], [arrivaltime], [totalfarecost], [name], [age], [gender], [address], [phoneno]) VALUES (786, N'11', N'dhn', N'ktm', N'715', N'ewe', 3, N'Thursday, April 1, 2021', N'Thursday, April 1, 2021', N'3:36:00 PM', N'9:30:26 AM', 6000, N'bipin bam', N'21', N'Male ', N'dhn', N'575134')
GO
ALTER TABLE [dbo].[EmployeeTB] ADD  CONSTRAINT [DF__EmployeeT__Emplo__47DBAE45]  DEFAULT ((1)) FOR [employeeid]
GO
USE [master]
GO
ALTER DATABASE [BTS1] SET  READ_WRITE 
GO
