CREATE TABLE [dbo].[CustomerPayments] (
    [CustomerPaymentId] BIGINT           IDENTITY (1, 1) NOT NULL,
    [CustId]            BIGINT           NULL,
    [AmountPaid]        BIGINT           NULL,
    [createdDate]       DATETIME         CONSTRAINT [DF_CustomerPayments_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedDate]      DATETIME         CONSTRAINT [DF_CustomerPayments_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdBy]         NVARCHAR (50)    NULL,
    [modifiedBy]        NVARCHAR (50)    NULL,
    [LoggedInUser]      NVARCHAR (500)   NULL,
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_CustomerPayments] PRIMARY KEY CLUSTERED ([CustomerPaymentId] ASC)
);

