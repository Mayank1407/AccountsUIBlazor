CREATE TABLE [dbo].[CommissionPercentage] (
    [CommissionPercentageId] BIGINT           IDENTITY (1, 1) NOT NULL,
    [Percentage]             FLOAT (53)       NULL,
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_CommissionPercentage] PRIMARY KEY CLUSTERED ([CommissionPercentageId] ASC)
);

