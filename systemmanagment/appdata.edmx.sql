
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/06/2024 20:30:32
-- Generated from EDMX file: C:\Users\Amin\Desktop\systemmanagment\systemmanagment\appdata.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbapp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TB_Users_TB_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Users] DROP CONSTRAINT [FK_TB_Users_TB_Roles];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TB_Persons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Persons];
GO
IF OBJECT_ID(N'[dbo].[TB_Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Roles];
GO
IF OBJECT_ID(N'[dbo].[TB_Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Users];
GO
IF OBJECT_ID(N'[dbappModelStoreContainer].[vwpersons]', 'U') IS NOT NULL
    DROP TABLE [dbappModelStoreContainer].[vwpersons];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TB_Persons'
CREATE TABLE [dbo].[TB_Persons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(20)  NULL,
    [family] nvarchar(20)  NULL,
    [phone] nchar(10)  NULL,
    [codm] nchar(10)  NOT NULL,
    [address] nchar(40)  NULL
);
GO

-- Creating table 'TB_Roles'
CREATE TABLE [dbo].[TB_Roles] (
    [RoleId] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(30)  NULL
);
GO

-- Creating table 'TB_Users'
CREATE TABLE [dbo].[TB_Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [RoleId_Fk] int  NULL,
    [UserName] nvarchar(30)  NULL,
    [Password] nvarchar(30)  NULL,
    [Name] nvarchar(30)  NULL,
    [Family] nvarchar(30)  NULL,
    [LastLogin] nvarchar(30)  NULL
);
GO

-- Creating table 'vwpersons'
CREATE TABLE [dbo].[vwpersons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(20)  NULL,
    [family] nvarchar(20)  NULL,
    [codm] nchar(10)  NOT NULL,
    [phone] nchar(10)  NULL,
    [address] nchar(40)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'TB_Persons'
ALTER TABLE [dbo].[TB_Persons]
ADD CONSTRAINT [PK_TB_Persons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [RoleId] in table 'TB_Roles'
ALTER TABLE [dbo].[TB_Roles]
ADD CONSTRAINT [PK_TB_Roles]
    PRIMARY KEY CLUSTERED ([RoleId] ASC);
GO

-- Creating primary key on [UserId] in table 'TB_Users'
ALTER TABLE [dbo].[TB_Users]
ADD CONSTRAINT [PK_TB_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [Id], [codm] in table 'vwpersons'
ALTER TABLE [dbo].[vwpersons]
ADD CONSTRAINT [PK_vwpersons]
    PRIMARY KEY CLUSTERED ([Id], [codm] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RoleId_Fk] in table 'TB_Users'
ALTER TABLE [dbo].[TB_Users]
ADD CONSTRAINT [FK_TB_Users_TB_Roles]
    FOREIGN KEY ([RoleId_Fk])
    REFERENCES [dbo].[TB_Roles]
        ([RoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_Users_TB_Roles'
CREATE INDEX [IX_FK_TB_Users_TB_Roles]
ON [dbo].[TB_Users]
    ([RoleId_Fk]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------