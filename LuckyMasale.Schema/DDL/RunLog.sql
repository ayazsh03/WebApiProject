CREATE TABLE [dbo].[RunLog]
(
	[RunLogID] INT NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(MAX) NULL, 
    [ControllerName] VARCHAR(100) NULL, 
    [Status] BIT NULL, 
    [CreatedDate] DATETIME NULL, 
    [ModifiedDate] DATETIME NULL
)
