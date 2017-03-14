CREATE TABLE [dbo].[Attendees](
	[AttendeeId] [int] IDENTITY(1,1) NOT NULL,
	[EventFKId] [varchar](1000) NOT NULL,
	[Id] [varchar](1000) NOT NULL,
	[Name] [varchar](1000) NOT NULL,
	[OwnerId] [varchar](100) NULL,
	[IsDeleted] [bit] NULL,
	[RecordTypeId] [bit] NULL,
	[CreatedDate] [varchar](100) NULL,
	[CreatedById] [varchar](100) NULL,
	[LastModifiedDate] [varchar](200) NULL,
	[LastModifiedById] [varchar](200) NULL,
	[SystemModstamp] [varchar](200) NULL,
	[MayEdit] [bit] NULL,
	[IsLocked] [bit] NULL,
	[Account_vod__c] [varchar](100) NULL,
	[Attendee_Name_vod__c] [varchar](200) NULL,
	[Contact_vod__c] [varchar](50) NULL,
	[End_Time_vod__c] [varchar](100) NULL,
	[Event_vod__c] [varchar](100) NULL,
	[External_ID_vod__c] [varchar](100) NULL,
	[Meal_Opt_In_vod__c] [bit] NULL,
	[Meal_Preference_vod__c] [varchar](100) NULL,
	[Mobile_ID_vod__c] [varchar](100) NULL,
	[Organization_vod__c] [varchar](200) NULL,
	[Signature_Datetime_vod__c] [varchar](100) NULL,
	[Signature_vod__c] [varchar](100) NULL,
	[Signee_vod__c] [varchar](100) NULL,
	[Start_Time_vod__c] [varchar](100) NULL,
	[Status_vod__c] [varchar](100) NULL,
	[Stub_Mobile_Id_vod__c] [varchar](100) NULL,
	[Stub_SFDC_Id_vod__c] [varchar](100) NULL,
	[User_vod__c] [varchar](100) NULL,
	[Vessel_Number_vod__c] [varchar](100) NULL,
	[Address_Line_1_vod__c] [varchar](2000) NULL,
	[Address_Line_2_vod__c] [varchar](2000) NULL,
	[City_vod__c] [varchar](100) NULL,
	[Credentials_vod__c] [varchar](100) NULL,
	[Email_vod__c] [varchar](100) NULL,
	[First_Name_vod__c] [varchar](200) NULL,
	[Last_Name_vod__c] [varchar](200) NULL,
	[Phone_vod__c] [varchar](20) NULL,
	[Prescriber_vod__c] [varchar](200) NULL,
	[Title_vod__c] [varchar](500) NULL,
	[Walk_In_Reference_ID_vod__c] [varchar](100) NULL,
	[Walk_In_Status_vod__c] [varchar](100) NULL,
	[Zip_vod__c] [varchar](100) NULL,
	[Entity_Reference_Id_vod__c] [varchar](100) NULL,
	[Furigana_vod__c] [varchar](200) NULL,
	[Online_Registration_Status_vod__c] [varchar](100) NULL,
	[Attendee_Type_vod__c] [varchar](100) NULL,
 CONSTRAINT [PK_AttendeeId] PRIMARY KEY CLUSTERED 
(
	[AttendeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


