
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/30/2020 06:50:00
-- Generated from EDMX file: C:\Bitbucket_repositories\WebManuals\WebManuals\Models\WebManualContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [webmanuals];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_manual_languageid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[manuals] DROP CONSTRAINT [FK_manual_languageid];
GO
IF OBJECT_ID(N'[dbo].[FK_manual_modeltypeid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[manuals] DROP CONSTRAINT [FK_manual_modeltypeid];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[languages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[languages];
GO
IF OBJECT_ID(N'[dbo].[manuals]', 'U') IS NOT NULL
    DROP TABLE [dbo].[manuals];
GO
IF OBJECT_ID(N'[dbo].[modeltypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[modeltypes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'languages'
CREATE TABLE [dbo].[languages] (
    [languageid] int IDENTITY(1,1) NOT NULL,
    [language_name] varchar(45)  NULL
);
GO

-- Creating table 'manuals'
CREATE TABLE [dbo].[manuals] (
    [manualid] int IDENTITY(1,1) NOT NULL,
    [manual_name] varchar(128)  NULL,
    [manual_languageid] int  NULL,
    [manual_modeltypeid] int  NULL,
    [manual_url] varchar(45)  NULL,
    [manual_content] varbinary(max)  NULL,
    [manual_master_model] varchar(45)  NULL
);
GO

-- Creating table 'modeltypes'
CREATE TABLE [dbo].[modeltypes] (
    [modeltypeid] int IDENTITY(1,1) NOT NULL,
    [modeltype_name] varchar(45)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [languageid] in table 'languages'
ALTER TABLE [dbo].[languages]
ADD CONSTRAINT [PK_languages]
    PRIMARY KEY CLUSTERED ([languageid] ASC);
GO

-- Creating primary key on [manualid] in table 'manuals'
ALTER TABLE [dbo].[manuals]
ADD CONSTRAINT [PK_manuals]
    PRIMARY KEY CLUSTERED ([manualid] ASC);
GO

-- Creating primary key on [modeltypeid] in table 'modeltypes'
ALTER TABLE [dbo].[modeltypes]
ADD CONSTRAINT [PK_modeltypes]
    PRIMARY KEY CLUSTERED ([modeltypeid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [manual_languageid] in table 'manuals'
ALTER TABLE [dbo].[manuals]
ADD CONSTRAINT [FK_manual_languageid]
    FOREIGN KEY ([manual_languageid])
    REFERENCES [dbo].[languages]
        ([languageid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_manual_languageid'
CREATE INDEX [IX_FK_manual_languageid]
ON [dbo].[manuals]
    ([manual_languageid]);
GO

-- Creating foreign key on [manual_modeltypeid] in table 'manuals'
ALTER TABLE [dbo].[manuals]
ADD CONSTRAINT [FK_manual_modeltypeid]
    FOREIGN KEY ([manual_modeltypeid])
    REFERENCES [dbo].[modeltypes]
        ([modeltypeid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_manual_modeltypeid'
CREATE INDEX [IX_FK_manual_modeltypeid]
ON [dbo].[manuals]
    ([manual_modeltypeid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------