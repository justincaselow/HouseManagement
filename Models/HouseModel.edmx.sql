
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/28/2013 16:41:23
-- Generated from EDMX file: C:\Users\Justin\Google Drive\Programming\Visual Studio\HouseManagement\Models\HouseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HouseManagement];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ITransactionPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ITransactions] DROP CONSTRAINT [FK_ITransactionPerson];
GO
IF OBJECT_ID(N'[dbo].[FK_Expense_inherits_ITransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ITransactions_Expense] DROP CONSTRAINT [FK_Expense_inherits_ITransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_Credit_inherits_ITransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ITransactions_Credit] DROP CONSTRAINT [FK_Credit_inherits_ITransaction];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ItemTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemTypes];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[ITransactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ITransactions];
GO
IF OBJECT_ID(N'[dbo].[ITransactions_Expense]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ITransactions_Expense];
GO
IF OBJECT_ID(N'[dbo].[ITransactions_Credit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ITransactions_Credit];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ItemTypes'
CREATE TABLE [dbo].[ItemTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CreditId] int  NOT NULL
);
GO

-- Creating table 'ITransactions'
CREATE TABLE [dbo].[ITransactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GbpAmount] decimal(18,0)  NOT NULL,
    [TransactionDate] datetime  NOT NULL,
    [Payer_Id] int  NOT NULL
);
GO

-- Creating table 'ITransactions_Expense'
CREATE TABLE [dbo].[ITransactions_Expense] (
    [Description] nvarchar(max)  NOT NULL,
    [Cost] nvarchar(max)  NOT NULL,
    [Quantity] float  NOT NULL,
    [Id] int  NOT NULL,
    [ItemType_Id] int  NOT NULL
);
GO

-- Creating table 'ITransactions_Credit'
CREATE TABLE [dbo].[ITransactions_Credit] (
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ItemTypes'
ALTER TABLE [dbo].[ItemTypes]
ADD CONSTRAINT [PK_ItemTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ITransactions'
ALTER TABLE [dbo].[ITransactions]
ADD CONSTRAINT [PK_ITransactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ITransactions_Expense'
ALTER TABLE [dbo].[ITransactions_Expense]
ADD CONSTRAINT [PK_ITransactions_Expense]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ITransactions_Credit'
ALTER TABLE [dbo].[ITransactions_Credit]
ADD CONSTRAINT [PK_ITransactions_Credit]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Payer_Id] in table 'ITransactions'
ALTER TABLE [dbo].[ITransactions]
ADD CONSTRAINT [FK_ITransactionPerson]
    FOREIGN KEY ([Payer_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ITransactionPerson'
CREATE INDEX [IX_FK_ITransactionPerson]
ON [dbo].[ITransactions]
    ([Payer_Id]);
GO

-- Creating foreign key on [ItemType_Id] in table 'ITransactions_Expense'
ALTER TABLE [dbo].[ITransactions_Expense]
ADD CONSTRAINT [FK_ExpenseItemType]
    FOREIGN KEY ([ItemType_Id])
    REFERENCES [dbo].[ItemTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseItemType'
CREATE INDEX [IX_FK_ExpenseItemType]
ON [dbo].[ITransactions_Expense]
    ([ItemType_Id]);
GO

-- Creating foreign key on [CreditId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_CreditPerson]
    FOREIGN KEY ([CreditId])
    REFERENCES [dbo].[ITransactions_Credit]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CreditPerson'
CREATE INDEX [IX_FK_CreditPerson]
ON [dbo].[People]
    ([CreditId]);
GO

-- Creating foreign key on [Id] in table 'ITransactions_Expense'
ALTER TABLE [dbo].[ITransactions_Expense]
ADD CONSTRAINT [FK_Expense_inherits_ITransaction]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[ITransactions]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'ITransactions_Credit'
ALTER TABLE [dbo].[ITransactions_Credit]
ADD CONSTRAINT [FK_Credit_inherits_ITransaction]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[ITransactions]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------