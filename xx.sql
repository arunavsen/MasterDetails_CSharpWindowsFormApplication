USE [MasterDetailsDB]
GO
/****** Object:  Table [dbo].[EmpCompany]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpCompany](
	[EmpCmpID] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [int] NULL,
	[CompanyName] [varchar](50) NULL,
	[PositionId] [int] NULL,
	[ExpYear] [int] NULL,
 CONSTRAINT [PK_EmpCompany] PRIMARY KEY CLUSTERED 
(
	[EmpCmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpCode] [varchar](50) NULL,
	[EmpName] [varchar](50) NULL,
	[PositionId] [int] NULL,
	[DOB] [date] NULL,
	[Gender] [varchar](50) NULL,
	[State] [varchar](15) NULL,
	[ImagePath] [varchar](250) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[PositionId] [int] NOT NULL,
	[Position] [varchar](50) NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[EmpCompanyAddOrEdit]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EmpCompanyAddOrEdit]
@EmpCmpId int,
@EmpId int,
@CompanyName varchar(100),
@PositionID int,
@ExpYear int
AS

	--Insert
	If @EmpCmpId = 0
		Insert into EmpCompany(EmpId, CompanyName, PositionId, ExpYear)
		VALUES (@EmpId, @CompanyName, @PositionID, @ExpYear)

	--Update
	Else
		UPDATE EmpCompany
		SET
			EmpId = @EmpId,
			CompanyName = @CompanyName,
			PositionId = @PositionID,
			ExpYear = @ExpYear
		where EmpCmpID = @EmpCmpId
GO
/****** Object:  StoredProcedure [dbo].[EmpCompanyDelete]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EmpCompanyDelete]
@EmpCmpID int
As
	--Master
	Delete from EmpCompany where EmpCmpID = @EmpCmpID

GO
/****** Object:  StoredProcedure [dbo].[EmployeeAddOrEdit]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EmployeeAddOrEdit]
@EmpId int,
@EmpCode varchar(50),
@EmpName varchar(100),
@PositionID int,
@DOB date,
@Gender varchar(20),
@State varchar(15),
@ImagePath varchar(250)
AS

	--Insert
	If @EmpId = 0 Begin
		Insert into Employee(EmpCode, EmpName, PositionId, DOB,Gender, State, ImagePath)
		Values (@EmpCode, @EmpName, @PositionID, @DOB, @Gender, @State, @ImagePath)

		select SCOPE_IDENTITY();

		END

	--Update
	Else Begin
		Update Employee
		set
			EmpCode = @EmpCode,
			EmpName = @EmpName,
			PositionId = @PositionID,
			DOB = @DOB,
			Gender = @Gender,
			State = @State,
			ImagePath = @ImagePath
		where EmpId = @EmpId

		select @EmpId;
		END
GO
/****** Object:  StoredProcedure [dbo].[EmployeeDelete]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EmployeeDelete]
@EmpId int
As
	--Master
	Delete from Employee where EmpId = @EmpId
	--Details
	Delete from EmpCompany where EmpId = @EmpId

GO
/****** Object:  StoredProcedure [dbo].[EmployeeViewAll]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EmployeeViewAll]
As
Select E.EmpId, E.EmpCode, E.EmpName, P.Position, E.DOB, E.State from Employee E
Inner Join Position P on E.PositionId = P.PositionId
GO
/****** Object:  StoredProcedure [dbo].[EmployeeViewById]    Script Date: 8/31/2021 5:43:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EmployeeViewById]
@EmpId int
As
	--Master
	Select * from Employee where EmpId = @EmpId

	--Details
	Select * from EmpCompany where EmpId = @EmpId
GO
