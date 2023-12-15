CREATE TABLE [dbo].[VendorDetails] (
    [VendorId]        BIGINT           NULL,
    [homePhone]       NVARCHAR (500)   NULL,
    [address]         NVARCHAR (MAX)   NULL,
    [city]            NVARCHAR (500)   NULL,
    [state]           NVARCHAR (500)   NULL,
    [alternateMobile] NVARCHAR (500)   NULL,
    [email]           NVARCHAR (500)   NULL,
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_VendorDetails] PRIMARY KEY CLUSTERED ([Id] ASC)
);

