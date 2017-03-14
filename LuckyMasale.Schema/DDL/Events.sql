CREATE TABLE [dbo].[Events]
(
	[EventId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Id] bit NOT NULL,
	[OwnerId] bit NOT NULL,
	[Name] bit NOT NULL,
	[CreatedDate] bit NOT NULL,
	[CreatedById] bit NOT NULL,
	[LastModifiedDate] bit NOT NULL,
	[LastModifiedById] bit NOT NULL,
	[SystemModstamp] varchar(10) NOT NULL,
	[LastActivityDate] varchar(10) NOT NULL,
	[MayEdit] varchar(10) NOT NULL,
	[IsLocked] bit NOT NULL,
	[Actual_Attendance_vod__c] bit NOT NULL,
	[Actual_Cost_vod__c] varchar(100) NOT NULL,
	[Actual_Meal_Cost_Per_Person_vod__c] bit NOT NULL,
	[Attendees_Requesting_Meals_vod__c] bit NOT NULL,
	[Attendees_With_Meals_vod__c] bit NOT NULL,
	[City_vod__c] bit NOT NULL,
	[Committed_Cost_vod__c] bit NOT NULL,
	[Country_vod__c] bit NOT NULL,
	[Description_vod__c] bit NOT NULL,
	[End_Time_vod__c] varchar(100) NOT NULL,
	[Estimated_Attendance_vod__c] varchar(100) NOT NULL,
	[Estimated_Cost_vod__c] varchar(100) NOT NULL,
	[Event_Configuration_vod__c] varchar(100) NOT NULL,
	[External_ID_vod__c] varchar(100) NOT NULL,
	[HCPs_With_Meals_vod__c] varchar(100) NOT NULL,
	[Invited_Attendees_vod__c] int NULL,
	[Location_Address_Line_2_vod__c] varchar(1000) NULL,
	[Location_Address_vod__c] varchar(1000) NULL,
	[Location_vod__c] varchar(100) NULL,
	[Lock_vod__c] bit NULL,
	[Mobile_ID_vod__c] varchar(100) NULL,
	[Override_Lock_vod__c] bit NULL,
	[Parent_Event_vod__c] varchar(100) NULL,
	[Postal_Code_vod__c] varchar(10) NULL,
	[Start_Time_vod__c] varchar(100) NULL,
	[State_Province_vod__c] varchar(50) NULL,
	[Status_vod__c] varchar(50) NULL,
	[Stub_Mobile_Id_vod__c] varchar(50) NULL,
	[Stub_SFDC_Id_vod__c] varchar(50) NULL,



	
	 CONSTRAINT [PK_EventId] PRIMARY KEY CLUSTERED 
	(
		[EventId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


