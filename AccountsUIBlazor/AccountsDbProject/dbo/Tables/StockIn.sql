CREATE TABLE [dbo].[StockIn] (
    [CreatedDate]           DATETIME         NOT NULL,
    [LoadName]              NVARCHAR (MAX)   NOT NULL,
    [UpdatedDate]           DATETIME         NULL,
    [LastModifiedDate]      DATETIME         NULL,
    [LoginID]               NVARCHAR (MAX)   NULL,
    [isActive]              BIT              CONSTRAINT [DF_StockIn_isActive] DEFAULT ((1)) NOT NULL,
    [Quantity]              INT              NOT NULL,
    [Id]                    UNIQUEIDENTIFIER NOT NULL,
    [VendorId]              UNIQUEIDENTIFIER NOT NULL,
    [IsCompletePaymentDone] BIT              NULL,
    CONSTRAINT [PK_StockIn_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_StockIn_Vendor] FOREIGN KEY ([VendorId]) REFERENCES [dbo].[Vendor] ([Id])
);

