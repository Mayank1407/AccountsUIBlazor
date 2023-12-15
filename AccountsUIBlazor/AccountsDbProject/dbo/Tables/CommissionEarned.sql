CREATE TABLE [dbo].[CommissionEarned] (
    [CommissionEarnedId]     BIGINT           IDENTITY (1, 1) NOT NULL,
    [StockInId]              BIGINT           NULL,
    [Amount]                 BIGINT           NULL,
    [createdBy]              NVARCHAR (500)   NULL,
    [modifiedDate]           DATETIME         CONSTRAINT [DF_CommissionEarned_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdDate]            DATETIME         CONSTRAINT [DF_CommissionEarned_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedBy]             NVARCHAR (500)   NULL,
    [CommissionPercentageId] BIGINT           NULL,
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_CommissionEarned] PRIMARY KEY CLUSTERED ([CommissionEarnedId] ASC),
    CONSTRAINT [FK_CommissionEarned_CommissionPercentage] FOREIGN KEY ([CommissionPercentageId]) REFERENCES [dbo].[CommissionPercentage] ([CommissionPercentageId])
);

