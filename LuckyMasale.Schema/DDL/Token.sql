

CREATE TABLE [dbo].[Token]
(
	[TokenId] INT IDENTITY(1,1) NOT NULL,
	[AccessToken] nvarchar(max) NOT NULL,
	[InstanceURL] varchar(200) NULL,
	[Id] varchar(200) NULL,
	[AccessTokenType] varchar(50) NOT NULL,
	[IssuedAt] varchar(100) NULL,
	[Signature] varchar(100) NULL,
	[CreatedDate] datetime,
	[IsActive] bit NULL,

	 CONSTRAINT [PK_TokenId] PRIMARY KEY CLUSTERED 
	(
		[TokenId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
