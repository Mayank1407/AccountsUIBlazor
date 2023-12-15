CREATE TABLE [dbo].[CommissionAgentExpenses] (
    [CommissionAgentExpensesId] BIGINT           IDENTITY (1, 1) NOT NULL,
    [ExpenseId]                 BIGINT           NULL,
    [Amount]                    BIGINT           NULL,
    [createdBy]                 NVARCHAR (500)   NULL,
    [modifiedDate]              DATETIME         CONSTRAINT [DF_CommisionAgentExpenses_modifiedDate] DEFAULT (getdate()) NOT NULL,
    [createdDate]               DATETIME         CONSTRAINT [DF_CommisionAgentExpenses_createdDate] DEFAULT (getdate()) NOT NULL,
    [modifiedBy]                NVARCHAR (500)   NULL,
    [Id]                        UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_CommisionAgentExpenses] PRIMARY KEY CLUSTERED ([CommissionAgentExpensesId] ASC)
);

