USE [Employee]
GO
/****** Object:  Table [dbo].[Interns]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MentorId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_Intern] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JuniorSoftwareDevelopers]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JuniorSoftwareDevelopers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SeniorId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_JuniorSoftwareDeveloper] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectManagers]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectManagers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_ProjectManager] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QAEngineers]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QAEngineers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagerId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_QAEngineer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SeniorSoftwareDevelopers]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeniorSoftwareDevelopers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagerId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_SeniorSoftwareDeveloper] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SoftwareDevelopers]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoftwareDevelopers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SeniorId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_SoftwareDeveloper] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemAnalysts]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemAnalysts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagerId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_SystemAnalyst] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestEngineers]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestEngineers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagerId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_TestEngineer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UIDesigners]    Script Date: 30.11.2021 12:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UIDesigners](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagerId] [int] NULL,
	[FirstName] [text] NULL,
	[LastName] [text] NULL,
	[Address] [varchar](255) NULL,
	[Phone] [bigint] NULL,
	[EmailAddress] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[WorkSituation] [varchar](50) NULL,
	[Wage] [money] NULL,
 CONSTRAINT [PK_UIDesigner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Interns]  WITH CHECK ADD  CONSTRAINT [FK_Intern_SoftwareDeveloper] FOREIGN KEY([MentorId])
REFERENCES [dbo].[SoftwareDevelopers] ([Id])
GO
ALTER TABLE [dbo].[Interns] CHECK CONSTRAINT [FK_Intern_SoftwareDeveloper]
GO
ALTER TABLE [dbo].[JuniorSoftwareDevelopers]  WITH CHECK ADD  CONSTRAINT [FK_JuniorSoftwareDeveloper_SeniorSoftwareDeveloper] FOREIGN KEY([SeniorId])
REFERENCES [dbo].[SeniorSoftwareDevelopers] ([Id])
GO
ALTER TABLE [dbo].[JuniorSoftwareDevelopers] CHECK CONSTRAINT [FK_JuniorSoftwareDeveloper_SeniorSoftwareDeveloper]
GO
ALTER TABLE [dbo].[QAEngineers]  WITH CHECK ADD  CONSTRAINT [FK_QAEngineer_ProjectManager] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[ProjectManagers] ([Id])
GO
ALTER TABLE [dbo].[QAEngineers] CHECK CONSTRAINT [FK_QAEngineer_ProjectManager]
GO
ALTER TABLE [dbo].[SeniorSoftwareDevelopers]  WITH CHECK ADD  CONSTRAINT [FK_SeniorSoftwareDeveloper_ProjectManager] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[ProjectManagers] ([Id])
GO
ALTER TABLE [dbo].[SeniorSoftwareDevelopers] CHECK CONSTRAINT [FK_SeniorSoftwareDeveloper_ProjectManager]
GO
ALTER TABLE [dbo].[SoftwareDevelopers]  WITH CHECK ADD  CONSTRAINT [FK_SoftwareDeveloper_SeniorSoftwareDeveloper] FOREIGN KEY([SeniorId])
REFERENCES [dbo].[SeniorSoftwareDevelopers] ([Id])
GO
ALTER TABLE [dbo].[SoftwareDevelopers] CHECK CONSTRAINT [FK_SoftwareDeveloper_SeniorSoftwareDeveloper]
GO
ALTER TABLE [dbo].[SystemAnalysts]  WITH CHECK ADD  CONSTRAINT [FK_SystemAnalyst_ProjectManager] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[ProjectManagers] ([Id])
GO
ALTER TABLE [dbo].[SystemAnalysts] CHECK CONSTRAINT [FK_SystemAnalyst_ProjectManager]
GO
ALTER TABLE [dbo].[TestEngineers]  WITH CHECK ADD  CONSTRAINT [FK_TestEngineer_ProjectManager] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[ProjectManagers] ([Id])
GO
ALTER TABLE [dbo].[TestEngineers] CHECK CONSTRAINT [FK_TestEngineer_ProjectManager]
GO
ALTER TABLE [dbo].[UIDesigners]  WITH CHECK ADD  CONSTRAINT [FK_UIDesigner_ProjectManager] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[ProjectManagers] ([Id])
GO
ALTER TABLE [dbo].[UIDesigners] CHECK CONSTRAINT [FK_UIDesigner_ProjectManager]
GO
