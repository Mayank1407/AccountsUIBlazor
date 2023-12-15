CREATE TABLE [dbo].[Vendor] (
    [FirstName]         NVARCHAR (500)   NULL,
    [MiddleName]        NVARCHAR (500)   NULL,
    [LastName]          NVARCHAR (500)   NULL,
    [MobileNo]          NVARCHAR (500)   NULL,
    [CreatedDate]       DATETIME         CONSTRAINT [DF_VendorDetails_createdDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedDate]      DATETIME         CONSTRAINT [DF_VendorDetails_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [CreatedBy]         NVARCHAR (50)    NULL,
    [ModifiedBy]        NVARCHAR (50)    NULL,
    [IsActive]          BIT              CONSTRAINT [DF_Vendor_IsActive] DEFAULT ((1)) NULL,
    [NickName]          NVARCHAR (500)   NULL,
    [ReferredBy]        NVARCHAR (500)   NULL,
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [Email]             NVARCHAR (500)   NULL,
    [Address]           NVARCHAR (4000)  NULL,
    [City]              NVARCHAR (50)    NULL,
    [State]             NVARCHAR (4000)  NULL,
    [AlterNateMobileNo] NVARCHAR (50)    NULL,
    CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED ([Id] ASC)
);

