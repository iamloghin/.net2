
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/13/2019 23:19:33
-- Generated from EDMX file: C:\Users\Alex\source\repos\.net2\lab3\ServiceAutoSolution\ServiceAutoModelDesign\ServiceAutoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ServiceAutoDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CarChassis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK_CarChassis];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK_ClientCar];
GO
IF OBJECT_ID(N'[dbo].[FK_OperationMechanic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_OperationMechanic];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_OrderCar];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_OrderClient];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetailImage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Images] DROP CONSTRAINT [FK_OrderDetailImage];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetailMaterial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Materials] DROP CONSTRAINT [FK_OrderDetailMaterial];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetailMechanic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mechanics] DROP CONSTRAINT [FK_OrderDetailMechanic];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetailOperation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_OrderDetailOperation];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderDetailOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetailOrder];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cars];
GO
IF OBJECT_ID(N'[dbo].[Chassis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Chassis];
GO
IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Images]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Images];
GO
IF OBJECT_ID(N'[dbo].[Materials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materials];
GO
IF OBJECT_ID(N'[dbo].[Mechanics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mechanics];
GO
IF OBJECT_ID(N'[dbo].[Operations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operations];
GO
IF OBJECT_ID(N'[dbo].[OrderDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderDetails];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] uniqueidentifier  NOT NULL,
    [LastName] nvarchar(15)  NOT NULL,
    [FirstName] nvarchar(15)  NOT NULL,
    [Address] nvarchar(50)  NOT NULL,
    [City] nvarchar(10)  NOT NULL,
    [Country] nvarchar(10)  NOT NULL,
    [Phone] nvarchar(13)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [Id] uniqueidentifier  NOT NULL,
    [AutoNumber] nvarchar(10)  NOT NULL,
    [ChassisSeries] nvarchar(25)  NOT NULL,
    [ClientId] uniqueidentifier  NOT NULL,
    [Chassis_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Chassis'
CREATE TABLE [dbo].[Chassis] (
    [Id] uniqueidentifier  NOT NULL,
    [Cod] nvarchar(2)  NOT NULL,
    [Description] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Mechanics'
CREATE TABLE [dbo].[Mechanics] (
    [Id] uniqueidentifier  NOT NULL,
    [FirstName] nvarchar(15)  NOT NULL,
    [LastName] nvarchar(15)  NOT NULL,
    [OrderDetailId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Materials'
CREATE TABLE [dbo].[Materials] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Amount] decimal(10,2)  NOT NULL,
    [Price] decimal(10,2)  NOT NULL,
    [PurchaseDate] datetime  NOT NULL,
    [OrderDetailId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
    [Id] uniqueidentifier  NOT NULL,
    [Title] nvarchar(15)  NOT NULL,
    [Description] nvarchar(256)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Photo] varbinary(max)  NOT NULL,
    [OrderDetailId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Operations'
CREATE TABLE [dbo].[Operations] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(256)  NOT NULL,
    [ExecutionTime] decimal(6,2)  NOT NULL,
    [OrderDetailId] uniqueidentifier  NOT NULL,
    [Mechanic_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] uniqueidentifier  NOT NULL,
    [OrderStatus] int  NOT NULL,
    [SystemDate] datetime  NOT NULL,
    [AppointmentDate] datetime  NOT NULL,
    [FinishDate] datetime  NOT NULL,
    [KmBoard] tinyint  NOT NULL,
    [Description] nvarchar(1024)  NOT NULL,
    [PartsValue] decimal(10,2)  NOT NULL,
    [Car_Id] uniqueidentifier  NOT NULL,
    [Client_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'OrderDetails'
CREATE TABLE [dbo].[OrderDetails] (
    [Id] uniqueidentifier  NOT NULL,
    [Order_Id] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Chassis'
ALTER TABLE [dbo].[Chassis]
ADD CONSTRAINT [PK_Chassis]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mechanics'
ALTER TABLE [dbo].[Mechanics]
ADD CONSTRAINT [PK_Mechanics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [PK_Materials]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Operations'
ALTER TABLE [dbo].[Operations]
ADD CONSTRAINT [PK_Operations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [PK_OrderDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Chassis_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_CarChassis]
    FOREIGN KEY ([Chassis_Id])
    REFERENCES [dbo].[Chassis]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarChassis'
CREATE INDEX [IX_FK_CarChassis]
ON [dbo].[Cars]
    ([Chassis_Id]);
GO

-- Creating foreign key on [Car_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_OrderCar]
    FOREIGN KEY ([Car_Id])
    REFERENCES [dbo].[Cars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderCar'
CREATE INDEX [IX_FK_OrderCar]
ON [dbo].[Orders]
    ([Car_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_OrderClient]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderClient'
CREATE INDEX [IX_FK_OrderClient]
ON [dbo].[Orders]
    ([Client_Id]);
GO

-- Creating foreign key on [Order_Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_OrderDetailOrder]
    FOREIGN KEY ([Order_Id])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetailOrder'
CREATE INDEX [IX_FK_OrderDetailOrder]
ON [dbo].[OrderDetails]
    ([Order_Id]);
GO

-- Creating foreign key on [OrderDetailId] in table 'Mechanics'
ALTER TABLE [dbo].[Mechanics]
ADD CONSTRAINT [FK_OrderDetailMechanic]
    FOREIGN KEY ([OrderDetailId])
    REFERENCES [dbo].[OrderDetails]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetailMechanic'
CREATE INDEX [IX_FK_OrderDetailMechanic]
ON [dbo].[Mechanics]
    ([OrderDetailId]);
GO

-- Creating foreign key on [OrderDetailId] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [FK_OrderDetailMaterial]
    FOREIGN KEY ([OrderDetailId])
    REFERENCES [dbo].[OrderDetails]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetailMaterial'
CREATE INDEX [IX_FK_OrderDetailMaterial]
ON [dbo].[Materials]
    ([OrderDetailId]);
GO

-- Creating foreign key on [OrderDetailId] in table 'Operations'
ALTER TABLE [dbo].[Operations]
ADD CONSTRAINT [FK_OrderDetailOperation]
    FOREIGN KEY ([OrderDetailId])
    REFERENCES [dbo].[OrderDetails]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetailOperation'
CREATE INDEX [IX_FK_OrderDetailOperation]
ON [dbo].[Operations]
    ([OrderDetailId]);
GO

-- Creating foreign key on [OrderDetailId] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [FK_OrderDetailImage]
    FOREIGN KEY ([OrderDetailId])
    REFERENCES [dbo].[OrderDetails]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderDetailImage'
CREATE INDEX [IX_FK_OrderDetailImage]
ON [dbo].[Images]
    ([OrderDetailId]);
GO

-- Creating foreign key on [Mechanic_Id] in table 'Operations'
ALTER TABLE [dbo].[Operations]
ADD CONSTRAINT [FK_OperationMechanic]
    FOREIGN KEY ([Mechanic_Id])
    REFERENCES [dbo].[Mechanics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperationMechanic'
CREATE INDEX [IX_FK_OperationMechanic]
ON [dbo].[Operations]
    ([Mechanic_Id]);
GO

-- Creating foreign key on [ClientId] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_ClientCar]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientCar'
CREATE INDEX [IX_FK_ClientCar]
ON [dbo].[Cars]
    ([ClientId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------