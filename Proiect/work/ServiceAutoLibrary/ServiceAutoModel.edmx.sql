
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/24/2019 19:37:27
-- Generated from EDMX file: D:\Workspace\Windows\Documents\GitHub\logalex96\.net2\.net2\lab3\ServiceAutoLibrary\ServiceAutoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AUTO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaMaterial_DetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliuComandaMaterial] DROP CONSTRAINT [FK_DetaliuComandaMaterial_DetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaMaterial_Material]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliuComandaMaterial] DROP CONSTRAINT [FK_DetaliuComandaMaterial_Material];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaOperatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Operatii] DROP CONSTRAINT [FK_DetaliuComandaOperatie];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaImagine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Imagini] DROP CONSTRAINT [FK_DetaliuComandaImagine];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliComenzi] DROP CONSTRAINT [FK_DetaliuComandaComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comenzi] DROP CONSTRAINT [FK_ComandaClient];
GO
IF OBJECT_ID(N'[dbo].[FK_AutoClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autos] DROP CONSTRAINT [FK_AutoClient];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaAuto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comenzi] DROP CONSTRAINT [FK_ComandaAuto];
GO
IF OBJECT_ID(N'[dbo].[FK_AutoSasiu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autos] DROP CONSTRAINT [FK_AutoSasiu];
GO
IF OBJECT_ID(N'[dbo].[FK_MecanicDetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mecanics] DROP CONSTRAINT [FK_MecanicDetaliuComanda];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clienti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clienti];
GO
IF OBJECT_ID(N'[dbo].[Autos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autos];
GO
IF OBJECT_ID(N'[dbo].[Sasiuri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sasiuri];
GO
IF OBJECT_ID(N'[dbo].[Mecanics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mecanics];
GO
IF OBJECT_ID(N'[dbo].[Materiale]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materiale];
GO
IF OBJECT_ID(N'[dbo].[Imagini]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Imagini];
GO
IF OBJECT_ID(N'[dbo].[Operatii]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operatii];
GO
IF OBJECT_ID(N'[dbo].[Comenzi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comenzi];
GO
IF OBJECT_ID(N'[dbo].[DetaliComenzi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetaliComenzi];
GO
IF OBJECT_ID(N'[dbo].[DetaliuComandaMaterial]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetaliuComandaMaterial];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clienti'
CREATE TABLE [dbo].[Clienti] (
    [ClientId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(20)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] nvarchar(13)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Autos'
CREATE TABLE [dbo].[Autos] (
    [AutoId] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(10)  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [Client_ClientId] int  NOT NULL,
    [Sasiu_SasiuId] int  NOT NULL
);
GO

-- Creating table 'Sasiuri'
CREATE TABLE [dbo].[Sasiuri] (
    [SasiuId] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nvarchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Mecanics'
CREATE TABLE [dbo].[Mecanics] (
    [MecanicId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [MecanicDetaliuComanda_Mecanic_DetaliuComandaId] int  NULL
);
GO

-- Creating table 'Materiale'
CREATE TABLE [dbo].[Materiale] (
    [MaterialId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(10,2)  NOT NULL,
    [Pret] decimal(10,2)  NOT NULL,
    [DataAprovizionare] datetime2  NOT NULL
);
GO

-- Creating table 'Imagini'
CREATE TABLE [dbo].[Imagini] (
    [ImagineId] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL,
    [Data] datetime2  NOT NULL,
    [Foto] varbinary(max)  NOT NULL,
    [DetaliuComanda_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'Operatii'
CREATE TABLE [dbo].[Operatii] (
    [OperatieId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(6,2)  NOT NULL,
    [DetaliuComandaOperatie_Operatie_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'Comenzi'
CREATE TABLE [dbo].[Comenzi] (
    [ComandaId] int IDENTITY(1,1) NOT NULL,
    [StareComanda] int  NOT NULL,
    [DataSystem] datetime2  NOT NULL,
    [DataProgramare] datetime2  NOT NULL,
    [DataFinalizare] datetime2  NOT NULL,
    [KmBord] int  NOT NULL,
    [Descriere] nvarchar(1024)  NOT NULL,
    [ValoarePiese] decimal(10,2)  NOT NULL,
    [Client_ClientId] int  NOT NULL,
    [Auto_AutoId] int  NOT NULL
);
GO

-- Creating table 'DetaliComenzi'
CREATE TABLE [dbo].[DetaliComenzi] (
    [DetaliuComandaId] int IDENTITY(1,1) NOT NULL,
    [Comanda_ComandaId] int  NOT NULL
);
GO

-- Creating table 'DetaliuComandaMaterial'
CREATE TABLE [dbo].[DetaliuComandaMaterial] (
    [DetaliuComandaMaterial_Material_DetaliuComandaId] int  NOT NULL,
    [Materials_MaterialId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ClientId] in table 'Clienti'
ALTER TABLE [dbo].[Clienti]
ADD CONSTRAINT [PK_Clienti]
    PRIMARY KEY CLUSTERED ([ClientId] ASC);
GO

-- Creating primary key on [AutoId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [PK_Autos]
    PRIMARY KEY CLUSTERED ([AutoId] ASC);
GO

-- Creating primary key on [SasiuId] in table 'Sasiuri'
ALTER TABLE [dbo].[Sasiuri]
ADD CONSTRAINT [PK_Sasiuri]
    PRIMARY KEY CLUSTERED ([SasiuId] ASC);
GO

-- Creating primary key on [MecanicId] in table 'Mecanics'
ALTER TABLE [dbo].[Mecanics]
ADD CONSTRAINT [PK_Mecanics]
    PRIMARY KEY CLUSTERED ([MecanicId] ASC);
GO

-- Creating primary key on [MaterialId] in table 'Materiale'
ALTER TABLE [dbo].[Materiale]
ADD CONSTRAINT [PK_Materiale]
    PRIMARY KEY CLUSTERED ([MaterialId] ASC);
GO

-- Creating primary key on [ImagineId] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [PK_Imagini]
    PRIMARY KEY CLUSTERED ([ImagineId] ASC);
GO

-- Creating primary key on [OperatieId] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [PK_Operatii]
    PRIMARY KEY CLUSTERED ([OperatieId] ASC);
GO

-- Creating primary key on [ComandaId] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [PK_Comenzi]
    PRIMARY KEY CLUSTERED ([ComandaId] ASC);
GO

-- Creating primary key on [DetaliuComandaId] in table 'DetaliComenzi'
ALTER TABLE [dbo].[DetaliComenzi]
ADD CONSTRAINT [PK_DetaliComenzi]
    PRIMARY KEY CLUSTERED ([DetaliuComandaId] ASC);
GO

-- Creating primary key on [DetaliuComandaMaterial_Material_DetaliuComandaId], [Materials_MaterialId] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [PK_DetaliuComandaMaterial]
    PRIMARY KEY CLUSTERED ([DetaliuComandaMaterial_Material_DetaliuComandaId], [Materials_MaterialId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DetaliuComandaMaterial_Material_DetaliuComandaId] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [FK_DetaliuComandaMaterial_DetaliuComanda]
    FOREIGN KEY ([DetaliuComandaMaterial_Material_DetaliuComandaId])
    REFERENCES [dbo].[DetaliComenzi]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Materials_MaterialId] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [FK_DetaliuComandaMaterial_Material]
    FOREIGN KEY ([Materials_MaterialId])
    REFERENCES [dbo].[Materiale]
        ([MaterialId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMaterial_Material'
CREATE INDEX [IX_FK_DetaliuComandaMaterial_Material]
ON [dbo].[DetaliuComandaMaterial]
    ([Materials_MaterialId]);
GO

-- Creating foreign key on [DetaliuComandaOperatie_Operatie_DetaliuComandaId] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [FK_DetaliuComandaOperatie]
    FOREIGN KEY ([DetaliuComandaOperatie_Operatie_DetaliuComandaId])
    REFERENCES [dbo].[DetaliComenzi]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaOperatie'
CREATE INDEX [IX_FK_DetaliuComandaOperatie]
ON [dbo].[Operatii]
    ([DetaliuComandaOperatie_Operatie_DetaliuComandaId]);
GO

-- Creating foreign key on [DetaliuComanda_DetaliuComandaId] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [FK_DetaliuComandaImagine]
    FOREIGN KEY ([DetaliuComanda_DetaliuComandaId])
    REFERENCES [dbo].[DetaliComenzi]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaImagine'
CREATE INDEX [IX_FK_DetaliuComandaImagine]
ON [dbo].[Imagini]
    ([DetaliuComanda_DetaliuComandaId]);
GO

-- Creating foreign key on [Comanda_ComandaId] in table 'DetaliComenzi'
ALTER TABLE [dbo].[DetaliComenzi]
ADD CONSTRAINT [FK_DetaliuComandaComanda]
    FOREIGN KEY ([Comanda_ComandaId])
    REFERENCES [dbo].[Comenzi]
        ([ComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaComanda'
CREATE INDEX [IX_FK_DetaliuComandaComanda]
ON [dbo].[DetaliComenzi]
    ([Comanda_ComandaId]);
GO

-- Creating foreign key on [Client_ClientId] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_ComandaClient]
    FOREIGN KEY ([Client_ClientId])
    REFERENCES [dbo].[Clienti]
        ([ClientId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaClient'
CREATE INDEX [IX_FK_ComandaClient]
ON [dbo].[Comenzi]
    ([Client_ClientId]);
GO

-- Creating foreign key on [Client_ClientId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [FK_AutoClient]
    FOREIGN KEY ([Client_ClientId])
    REFERENCES [dbo].[Clienti]
        ([ClientId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoClient'
CREATE INDEX [IX_FK_AutoClient]
ON [dbo].[Autos]
    ([Client_ClientId]);
GO

-- Creating foreign key on [Auto_AutoId] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_ComandaAuto]
    FOREIGN KEY ([Auto_AutoId])
    REFERENCES [dbo].[Autos]
        ([AutoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaAuto'
CREATE INDEX [IX_FK_ComandaAuto]
ON [dbo].[Comenzi]
    ([Auto_AutoId]);
GO

-- Creating foreign key on [Sasiu_SasiuId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [FK_AutoSasiu]
    FOREIGN KEY ([Sasiu_SasiuId])
    REFERENCES [dbo].[Sasiuri]
        ([SasiuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoSasiu'
CREATE INDEX [IX_FK_AutoSasiu]
ON [dbo].[Autos]
    ([Sasiu_SasiuId]);
GO

-- Creating foreign key on [MecanicDetaliuComanda_Mecanic_DetaliuComandaId] in table 'Mecanics'
ALTER TABLE [dbo].[Mecanics]
ADD CONSTRAINT [FK_MecanicDetaliuComanda]
    FOREIGN KEY ([MecanicDetaliuComanda_Mecanic_DetaliuComandaId])
    REFERENCES [dbo].[DetaliComenzi]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MecanicDetaliuComanda'
CREATE INDEX [IX_FK_MecanicDetaliuComanda]
ON [dbo].[Mecanics]
    ([MecanicDetaliuComanda_Mecanic_DetaliuComandaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------