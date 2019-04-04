﻿CREATE TABLE [dbo].TBL_CAT_EQUIPMENT
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DESCRIPTION] NVARCHAR(50) NULL, 
    [ACTIVE] BIT NULL, 
    [CREATE_USERID] INT NULL, 
    [CREATE_DATE] DATE NULL DEFAULT GETDATE(), 
    [CHANGE_USERID] INT NULL, 
    [CHANGE_DATE] DATE NULL DEFAULT GETDATE()
)