CREATE TABLE [dbo].[CustomerDetails] (
    [CustAddressId]   INT              IDENTITY (1, 1) NOT NULL,
    [CustId]          BIGINT           NULL,
    [CustAddress]     NVARCHAR (MAX)   NULL,
    [alternateMobile] NVARCHAR (50)    NULL,
    [homePhone]       NVARCHAR (50)    NULL,
    [officePhone]     NVARCHAR (50)    NULL,
    [email]           NVARCHAR (50)    NULL,
    [address]         NVARCHAR (MAX)   NULL,
    [city]            NVARCHAR (MAX)   NULL,
    [state]           NVARCHAR (MAX)   NULL,
    [shopName]        NVARCHAR (MAX)   NULL,
    [shopLocation]    NVARCHAR (MAX)   NULL,
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_CustomerAddress] PRIMARY KEY CLUSTERED ([CustAddressId] ASC)
);

