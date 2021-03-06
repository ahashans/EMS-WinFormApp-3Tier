USE [EMS]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DeptId] [int] IDENTITY(1005,1) NOT NULL,
	[DeptName] [varchar](50) NOT NULL,
	[DeptSalary] [numeric](12, 0) NOT NULL,
	[DeptLocation] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpInfo]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpInfo](
	[EmpId] [int] IDENTITY(1002,1) NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[DeptName] [varchar](50) NOT NULL,
	[Location] [varchar](250) NOT NULL,
	[ContactNo] [numeric](11, 0) NOT NULL,
 CONSTRAINT [PK_EmpInfo] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocId] [int] NOT NULL,
	[LocName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1000, N'Audit', CAST(80000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1001, N'Accounts', CAST(35000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1002, N'Security', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1003, N'Marketing', CAST(45000 AS Numeric(12, 0)), N'Building B')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1004, N'HR', CAST(31000 AS Numeric(12, 0)), N'Dhaka')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1005, N'Customer Care', CAST(29000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1006, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1007, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1008, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1009, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1010, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1011, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1012, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1013, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1014, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1015, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1016, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1017, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1018, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1019, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1020, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1021, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1022, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1023, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1024, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1025, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1026, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1027, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1028, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1029, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1030, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1031, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1032, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1033, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1034, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1035, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1036, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1037, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1038, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1039, N'A String', CAST(10000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1040, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
INSERT [dbo].[Department] ([DeptId], [DeptName], [DeptSalary], [DeptLocation]) VALUES (1041, N'A String', CAST(2000000 AS Numeric(12, 0)), N'Building A')
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[EmpInfo] ON 

INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1000, N'Hick Vine', N'Audit', N'Building A', CAST(1711111111 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1001, N'John Rayne', N'HR', N'Building B', CAST(1911111111 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1002, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1003, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1004, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1005, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1006, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1007, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1008, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1009, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1010, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1011, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1012, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1013, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1014, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1015, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1016, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1017, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1018, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1019, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1020, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1021, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1022, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1023, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1024, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1025, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1026, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1027, N'A String', N'A String', N'A String', CAST(1500000000 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1028, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [DeptName], [Location], [ContactNo]) VALUES (1029, N'A String', N'A String', N'A String', CAST(1999999999 AS Numeric(11, 0)))
SET IDENTITY_INSERT [dbo].[EmpInfo] OFF
INSERT [dbo].[Location] ([LocId], [LocName]) VALUES (1, N'Building A')
INSERT [dbo].[Location] ([LocId], [LocName]) VALUES (2, N'Building B')
/****** Object:  StoredProcedure [dbo].[USPAddDept]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[USPAddDept]
(
@DeptName VARCHAR(50), 
@DeptSalary NUMERIC(12,0),
@DeptLocation VARCHAR(50)
)
AS
BEGIN
INSERT INTO Department(DeptName, DeptSalary, DeptLocation)
VALUES(@DeptName,@DeptSalary, @DeptLocation)
END

GO
/****** Object:  StoredProcedure [dbo].[USPDept]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[USPDept]
AS
BEGIN
SELECT DEPTID, DEPTNAME FROM Department
END
GO
/****** Object:  StoredProcedure [dbo].[USPEmpDtls]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROCEDURE [dbo].[USPEmpDtls]
(
@EmpName VARCHAR(30),
@DeptName VARCHAR(25), 
@Location VARCHAR(250),
@ContactNumber NUMERIC(11,0)
)
AS
BEGIN
INSERT INTO EmpInfo(EmpName, DeptName, Location, ContactNo)
VALUES(@EmpName, @DeptName, @Location, @ContactNumber)
END
GO
/****** Object:  StoredProcedure [dbo].[USPGetLastDeptId]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[USPGetLastDeptId]
@deptId int out
AS 
BEGIN
set @deptId = ident_current('Department')
return @deptId
END
GO
/****** Object:  StoredProcedure [dbo].[USPGetLastEmptId]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[USPGetLastEmptId]
@EmpId int out
AS 
BEGIN
set @EmpId = ident_current('EmpInfo')
return @EmpId
END
GO
/****** Object:  StoredProcedure [dbo].[USPLocation]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[USPLocation]
AS
BEGIN
SELECT * FROM LOCATION
END
GO
/****** Object:  StoredProcedure [dbo].[USPViewEmpDtlsByDept]    Script Date: 07-Apr-18 10:56:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[USPViewEmpDtlsByDept]
(@DeptName VARCHAR(50))
AS
BEGIN
SELECT * FROM EmpInfo Where DeptName = @DeptName
END
GO
