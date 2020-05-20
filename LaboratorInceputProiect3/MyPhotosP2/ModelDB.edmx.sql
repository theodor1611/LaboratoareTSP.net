
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/01/2020 16:28:40
-- Generated from EDMX file: C:\Users\Theo\source\repos\MyPhotosP2\MyPhotosP2\ModelDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProiectDB2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Media'
CREATE TABLE [dbo].[Media] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [PozaSauVideo] nvarchar(max)  NOT NULL,
    [Sters] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Proprietatis'
CREATE TABLE [dbo].[Proprietatis] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumeCamp] nvarchar(max)  NULL,
    [ValoareCamp] nvarchar(max)  NULL
);
GO

-- Creating table 'MediaProprietati'
CREATE TABLE [dbo].[MediaProprietati] (
    [Media_Id] int  NOT NULL,
    [Proprietatis_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [PK_Media]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Proprietatis'
ALTER TABLE [dbo].[Proprietatis]
ADD CONSTRAINT [PK_Proprietatis]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Media_Id], [Proprietatis_Id] in table 'MediaProprietati'
ALTER TABLE [dbo].[MediaProprietati]
ADD CONSTRAINT [PK_MediaProprietati]
    PRIMARY KEY CLUSTERED ([Media_Id], [Proprietatis_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Media_Id] in table 'MediaProprietati'
ALTER TABLE [dbo].[MediaProprietati]
ADD CONSTRAINT [FK_MediaProprietati_Media]
    FOREIGN KEY ([Media_Id])
    REFERENCES [dbo].[Media]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Proprietatis_Id] in table 'MediaProprietati'
ALTER TABLE [dbo].[MediaProprietati]
ADD CONSTRAINT [FK_MediaProprietati_Proprietati]
    FOREIGN KEY ([Proprietatis_Id])
    REFERENCES [dbo].[Proprietatis]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaProprietati_Proprietati'
CREATE INDEX [IX_FK_MediaProprietati_Proprietati]
ON [dbo].[MediaProprietati]
    ([Proprietatis_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------