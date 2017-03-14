
/****** Object:  UserDefinedTableType [dbo].[IdNamePairs]    Script Date: 1/21/2017 11:24:02 PM ******/
CREATE TYPE [dbo].[IdNamePairs] AS TABLE(
	[Id] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL
)
GO
