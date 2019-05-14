
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/25/2019 20:19:42
-- Generated from EDMX file: D:\Workspace\Windows\Documents\GitHub\logalex96\.net2\.net2\lab3\CarService\CarServiceModel.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clienti'
CREATE TABLE [dbo].[Clienti] (
    [Id] uniqueidentifier  NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(20)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] nvarchar(13)  NOT NULL UNIQUE,
    [Email] nvarchar(50)  NOT NULL UNIQUE
);
GO

-- Creating table 'Autos'
CREATE TABLE [dbo].[Autos] (
    [Id] uniqueidentifier  NOT NULL,
    [NumarAuto] nvarchar(10)  NOT NULL UNIQUE,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [Sasiu_Id] uniqueidentifier  NOT NULL,
    [Client_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Sasiuri'
CREATE TABLE [dbo].[Sasiuri] (
    [Id] uniqueidentifier  NOT NULL,
    [CodSasiu] nvarchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Comenzi'
CREATE TABLE [dbo].[Comenzi] (
    [Id] uniqueidentifier  NOT NULL,
    [StareComanda] int  NOT NULL,
    [DataSystem] datetime2  NOT NULL,
    [DataProgramare] datetime2  NOT NULL,
    [DataFinalizare] datetime2  NULL,
    [KmBoard] int  NULL,
    [Descriere] nvarchar(1024)  NOT NULL,
    [ValoarePiese] decimal(10,2)  NULL,
    [Client_Id] uniqueidentifier  NOT NULL,
    [Auto_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Operatii'
CREATE TABLE [dbo].[Operatii] (
    [Id] uniqueidentifier  NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(6,2)  NULL,
    [DetaliuComandaOperatie_Operatie_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Imagini'
CREATE TABLE [dbo].[Imagini] (
    [Id] uniqueidentifier  NOT NULL,
    [Titlu] nvarchar(20)  NOT NULL,
    [Descriere] nvarchar(256)  NULL,
    [Data] datetime2  NOT NULL,
    [Foto] varbinary(max)  NOT NULL,
    [DetaliuComanda_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Materiale'
CREATE TABLE [dbo].[Materiale] (
    [Id] uniqueidentifier  NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(10,2)  NOT NULL,
    [Pret] decimal(10,2)  NOT NULL,
    [DataAprovizionare] datetime2  NOT NULL
);
GO

-- Creating table 'Mecanici'
CREATE TABLE [dbo].[Mecanici] (
    [Id] uniqueidentifier  NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [DetaliuComandaMecanic_Mecanic_Id] uniqueidentifier  NULL
);
GO

-- Creating table 'DetaliiComanda'
CREATE TABLE [dbo].[DetaliiComanda] (
    [Id] uniqueidentifier  NOT NULL,
    [Comanda_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'DetaliuComandaMaterial'
CREATE TABLE [dbo].[DetaliuComandaMaterial] (
    [DetaliuComandaMaterial_Material_Id] uniqueidentifier  NOT NULL,
    [Materials_Id] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clienti'
ALTER TABLE [dbo].[Clienti]
ADD CONSTRAINT [PK_Clienti]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [PK_Autos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sasiuri'
ALTER TABLE [dbo].[Sasiuri]
ADD CONSTRAINT [PK_Sasiuri]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [PK_Comenzi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [PK_Operatii]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [PK_Imagini]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Materiale'
ALTER TABLE [dbo].[Materiale]
ADD CONSTRAINT [PK_Materiale]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mecanici'
ALTER TABLE [dbo].[Mecanici]
ADD CONSTRAINT [PK_Mecanici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetaliiComanda'
ALTER TABLE [dbo].[DetaliiComanda]
ADD CONSTRAINT [PK_DetaliiComanda]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DetaliuComandaMaterial_Material_Id], [Materials_Id] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [PK_DetaliuComandaMaterial]
    PRIMARY KEY CLUSTERED ([DetaliuComandaMaterial_Material_Id], [Materials_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Sasiu_Id] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [FK_AutoSasiu]
    FOREIGN KEY ([Sasiu_Id])
    REFERENCES [dbo].[Sasiuri]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoSasiu'
CREATE INDEX [IX_FK_AutoSasiu]
ON [dbo].[Autos]
    ([Sasiu_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [FK_ClientAuto]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clienti]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAuto'
CREATE INDEX [IX_FK_ClientAuto]
ON [dbo].[Autos]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_ComandaClient]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clienti]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaClient'
CREATE INDEX [IX_FK_ComandaClient]
ON [dbo].[Comenzi]
    ([Client_Id]);
GO

-- Creating foreign key on [Auto_Id] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_ComandaAuto]
    FOREIGN KEY ([Auto_Id])
    REFERENCES [dbo].[Autos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaAuto'
CREATE INDEX [IX_FK_ComandaAuto]
ON [dbo].[Comenzi]
    ([Auto_Id]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [FK_DetaliuComandaImagine]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliiComanda]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaImagine'
CREATE INDEX [IX_FK_DetaliuComandaImagine]
ON [dbo].[Imagini]
    ([DetaliuComanda_Id]);
GO

-- Creating foreign key on [DetaliuComandaMecanic_Mecanic_Id] in table 'Mecanici'
ALTER TABLE [dbo].[Mecanici]
ADD CONSTRAINT [FK_DetaliuComandaMecanic]
    FOREIGN KEY ([DetaliuComandaMecanic_Mecanic_Id])
    REFERENCES [dbo].[DetaliiComanda]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMecanic'
CREATE INDEX [IX_FK_DetaliuComandaMecanic]
ON [dbo].[Mecanici]
    ([DetaliuComandaMecanic_Mecanic_Id]);
GO

-- Creating foreign key on [DetaliuComandaOperatie_Operatie_Id] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [FK_DetaliuComandaOperatie]
    FOREIGN KEY ([DetaliuComandaOperatie_Operatie_Id])
    REFERENCES [dbo].[DetaliiComanda]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaOperatie'
CREATE INDEX [IX_FK_DetaliuComandaOperatie]
ON [dbo].[Operatii]
    ([DetaliuComandaOperatie_Operatie_Id]);
GO

-- Creating foreign key on [DetaliuComandaMaterial_Material_Id] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [FK_DetaliuComandaMaterial_DetaliuComanda]
    FOREIGN KEY ([DetaliuComandaMaterial_Material_Id])
    REFERENCES [dbo].[DetaliiComanda]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Materials_Id] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [FK_DetaliuComandaMaterial_Material]
    FOREIGN KEY ([Materials_Id])
    REFERENCES [dbo].[Materiale]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMaterial_Material'
CREATE INDEX [IX_FK_DetaliuComandaMaterial_Material]
ON [dbo].[DetaliuComandaMaterial]
    ([Materials_Id]);
GO

-- Creating foreign key on [Comanda_Id] in table 'DetaliiComanda'
ALTER TABLE [dbo].[DetaliiComanda]
ADD CONSTRAINT [FK_DetaliuComandaComanda]
    FOREIGN KEY ([Comanda_Id])
    REFERENCES [dbo].[Comenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaComanda'
CREATE INDEX [IX_FK_DetaliuComandaComanda]
ON [dbo].[DetaliiComanda]
    ([Comanda_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------