CREATE TABLE [dbo].[Sales] (
    [ProductType]  INT              NULL,
    [Quantity]     INT              NOT NULL,
    [Price]        INT              NOT NULL,
    [Total]        INT              NOT NULL,
    [createdDate]  DATETIME         CONSTRAINT [DF_Sales_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedDate] DATETIME         CONSTRAINT [DF_Sales_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdBy]    NVARCHAR (50)    NULL,
    [modifiedBy]   NVARCHAR (50)    NULL,
    [LoggedInUser] NVARCHAR (500)   NULL,
    [IsActive]     BIT              CONSTRAINT [DF_Sales_IsActive] DEFAULT ((1)) NOT NULL,
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [CustomerId]   UNIQUEIDENTIFIER NULL,
    [VendorId]     UNIQUEIDENTIFIER NULL,
    [StockInId]    UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sales_StockIn] FOREIGN KEY ([StockInId]) REFERENCES [dbo].[StockIn] ([Id]),
    CONSTRAINT [FK_Sales_Vendor] FOREIGN KEY ([VendorId]) REFERENCES [dbo].[Vendor] ([Id])
);

