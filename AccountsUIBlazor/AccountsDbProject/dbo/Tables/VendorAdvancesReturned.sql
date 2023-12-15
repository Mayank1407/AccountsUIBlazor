CREATE TABLE [dbo].[VendorAdvancesReturned] (
    [VendorId]     BIGINT           NULL,
    [Amount]       BIGINT           NULL,
    [createdDate]  DATETIME         CONSTRAINT [DF_VendorAdvancesReturned_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedDate] DATETIME         CONSTRAINT [DF_VendorAdvancesReturned_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdBy]    NVARCHAR (50)    NULL,
    [modifiedBy]   NVARCHAR (50)    NULL,
    [LoggedInUser] NVARCHAR (500)   NULL,
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_VendorAdvancesReturned_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

