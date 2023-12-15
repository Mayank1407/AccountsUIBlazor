CREATE TABLE [dbo].[SalesReturns] (
    [StockInId]    BIGINT           NULL,
    [CustId]       BIGINT           NULL,
    [ProductType]  INT              NULL,
    [Quantity]     BIGINT           NULL,
    [Price]        BIGINT           NULL,
    [Total]        BIGINT           NULL,
    [createdDate]  DATETIME         CONSTRAINT [DF_SalesReturns_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedDate] DATETIME         CONSTRAINT [DF_SalesReturns_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdBy]    NVARCHAR (50)    NULL,
    [modifiedBy]   NVARCHAR (50)    NULL,
    [LoggedInUser] NVARCHAR (500)   NULL,
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_SalesReturns_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

