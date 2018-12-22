
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/20/2018 12:40:39
-- Generated from EDMX file: E:\programs\C#.Net\Projects\EPAM\Tasks\EpamTask4\Entity\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EpamTask4_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_ClientOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_ItemOrder];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Files]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Files];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] uniqueidentifier  NOT NULL,
    [Data] datetime  NOT NULL,
    [Customer_Id] uniqueidentifier  NOT NULL,
    [Item_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Cost] int  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] uniqueidentifier  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [Id] uniqueidentifier  NOT NULL,
    [FileName] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [PK_Files]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customer_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_ClientOrder]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientOrder'
CREATE INDEX [IX_FK_ClientOrder]
ON [dbo].[Orders]
    ([Customer_Id]);
GO

-- Creating foreign key on [Item_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_ItemOrder]
    FOREIGN KEY ([Item_Id])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemOrder'
CREATE INDEX [IX_FK_ItemOrder]
ON [dbo].[Orders]
    ([Item_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------