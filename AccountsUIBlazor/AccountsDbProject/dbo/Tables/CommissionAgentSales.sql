CREATE TABLE [dbo].[CommissionAgentSales] (
    [CommissionAgentSalesId] BIGINT           IDENTITY (1, 1) NOT NULL,
    [VendorId]               BIGINT           NULL,
    [PurchasePrice]          BIGINT           NULL,
    [Quantity]               BIGINT           NULL,
    [Total]                  BIGINT           NULL,
    [createdDate]            DATETIME         CONSTRAINT [DF_CommissionAgentSales_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedDate]           DATETIME         CONSTRAINT [DF_CommissionAgentSales_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdBy]              NVARCHAR (50)    NULL,
    [modifiedBy]             NVARCHAR (50)    NULL,
    [LoggedInUser]           NVARCHAR (500)   NULL,
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_CommissionAgentSales] PRIMARY KEY CLUSTERED ([CommissionAgentSalesId] ASC)
);

