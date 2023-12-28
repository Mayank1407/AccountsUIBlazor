CREATE TABLE [dbo].[VendorPayments] (
    [VendorPaymentId]          INT NOT NULL IDENTITY,
    [AmountPaid]   BIGINT           NULL,
    [createdDate]  DATETIME         CONSTRAINT [DF_VendorPayments_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedDate] DATETIME         CONSTRAINT [DF_VendorPayments_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdBy]    NVARCHAR (50)    NULL,
    [modifiedBy]   NVARCHAR (50)    NULL,
    [LoggedInUser] NVARCHAR (500)   NULL,
    [VendorId]     INT NOT NULL,
    [StockInId]    INT NOT NULL, 
    CONSTRAINT [PK_VendorPayments] PRIMARY KEY ([VendorPaymentId])
    
);

