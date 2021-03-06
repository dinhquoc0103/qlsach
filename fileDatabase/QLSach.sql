USE [QLSach]	/****** Create database before USE and Query All ******/
GO
/****** Object:  Table [dbo].[users]    Script Date: 04/08/2021 13:34:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[UserCode] [varchar](10) NOT NULL,
	[FullName] [nvarchar](64) NULL,
	[Email] [varchar](64) NULL,
	[Password] [nvarchar](64) NULL,
	[Status] [tinyint] NULL,
	[JoinDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[book]    Script Date: 04/08/2021 13:34:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[book](
	[BookCode] [varchar](10) NOT NULL,
	[BookName] [nvarchar](255) NULL,
	[Price] [int] NULL,
	[Category] [nvarchar](64) NULL,
	[Author] [nvarchar](64) NULL,
	[PublishingBy] [nvarchar](64) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
