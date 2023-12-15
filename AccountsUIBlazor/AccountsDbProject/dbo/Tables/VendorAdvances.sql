CREATE TABLE [dbo].[VendorAdvances] (
    [VendorId]                  BIGINT           NULL,
    [Amount]                    BIGINT           NULL,
    [createdDate]               DATETIME         CONSTRAINT [DF_VendorAdvances_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedDate]              DATETIME         CONSTRAINT [DF_VendorAdvances_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdBy]                 NVARCHAR (50)    NULL,
    [modifiedBy]                NVARCHAR (50)    NULL,
    [Id]                        UNIQUEIDENTIFIER NOT NULL,
    [IsCompletePaymentReceived] BIT              NULL,
    CONSTRAINT [PK_VendorAdvances_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

