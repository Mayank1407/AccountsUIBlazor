CREATE TABLE [dbo].[Expenses] (
    [ExpenseName]   NVARCHAR (MAX)   NULL,
    [ExpenseTypeId] BIGINT           NULL,
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED ([Id] ASC)
);

