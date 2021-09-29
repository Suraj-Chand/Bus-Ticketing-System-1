USE [BTS1]
GO
/****** Object:  Table [dbo].[busdetails]    Script Date: 6/25/2021 5:21:34 PM ******/
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
/****** Object:  Table [dbo].[busoute]    Script Date: 6/25/2021 5:21:34 PM ******/
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
/****** Object:  Table [dbo].[EmployeeTB]    Script Date: 6/25/2021 5:21:34 PM ******/
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
/****** Object:  Table [dbo].[EmployeeTBother]    Script Date: 6/25/2021 5:21:34 PM ******/
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
/****** Object:  Table [dbo].[stations]    Script Date: 6/25/2021 5:21:34 PM ******/
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
/****** Object:  Table [dbo].[ticketcreator]    Script Date: 6/25/2021 5:21:34 PM ******/
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
	[noofpassengers] [nvarchar](50) NOT NULL,
	[issueddate] [nvarchar](50) NOT NULL,
	[departuredate] [nvarchar](50) NOT NULL,
	[departuretime] [nvarchar](50) NOT NULL,
	[arrivaltime] [nvarchar](50) NOT NULL,
	[totalfarecost] [nvarchar](50) NOT NULL,
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
ALTER TABLE [dbo].[EmployeeTB] ADD  CONSTRAINT [DF__EmployeeT__Emplo__47DBAE45]  DEFAULT ((1)) FOR [employeeid]
GO
