CREATE TABLE [dbo].[VendorPayments] (
    [AmountPaid]   BIGINT           NULL,
    [createdDate]  DATETIME         CONSTRAINT [DF_VendorPayments_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedDate] DATETIME         CONSTRAINT [DF_VendorPayments_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdBy]    NVARCHAR (50)    NULL,
    [modifiedBy]   NVARCHAR (50)    NULL,
    [LoggedInUser] NVARCHAR (500)   NULL,
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [VendorId]     UNIQUEIDENTIFIER NOT NULL,
    [StockInId]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_VendorPayments_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_VendorPayments_StockIn] FOREIGN KEY ([StockInId]) REFERENCES [dbo].[StockIn] ([Id]),
    CONSTRAINT [FK_VendorPayments_VendorPayments] FOREIGN KEY ([VendorId]) REFERENCES [dbo].[Vendor] ([Id])
);

