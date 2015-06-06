
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/28/2015 19:48:50
-- Generated from EDMX file: E:\GitMVC\ShoppingCartMVC\ShopingCartEF\ShoppingCartModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ShoppingCart];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Band_Product_Brand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Band_Product] DROP CONSTRAINT [FK_Band_Product_Brand];
GO
IF OBJECT_ID(N'[dbo].[FK_Band_Product_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Band_Product] DROP CONSTRAINT [FK_Band_Product_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_Image_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Image] DROP CONSTRAINT [FK_Image_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderItem_Orther]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderItem] DROP CONSTRAINT [FK_OrderItem_Orther];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderItem_Producct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderItem] DROP CONSTRAINT [FK_OrderItem_Producct];
GO
IF OBJECT_ID(N'[dbo].[FK_Orther_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orther] DROP CONSTRAINT [FK_Orther_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_Orther_PaymenMethods]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orther] DROP CONSTRAINT [FK_Orther_PaymenMethods];
GO
IF OBJECT_ID(N'[dbo].[FK_Products_Brand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_Brand];
GO
IF OBJECT_ID(N'[dbo].[FK_Products_Category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_Category];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Band_Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Band_Product];
GO
IF OBJECT_ID(N'[dbo].[Brand]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Brand];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[Image]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Image];
GO
IF OBJECT_ID(N'[dbo].[News]', 'U') IS NOT NULL
    DROP TABLE [dbo].[News];
GO
IF OBJECT_ID(N'[dbo].[OrderItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderItem];
GO
IF OBJECT_ID(N'[dbo].[Orther]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orther];
GO
IF OBJECT_ID(N'[dbo].[Page]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Page];
GO
IF OBJECT_ID(N'[dbo].[PaymenMethods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PaymenMethods];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Band_Product'
CREATE TABLE [dbo].[Band_Product] (
    [BrandID] int  NOT NULL,
    [ProductsID] int  NOT NULL,
    [Note] nvarchar(150)  NULL
);
GO

-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [BrandID] int IDENTITY(1,1) NOT NULL,
    [ImageUrl] nvarchar(250)  NULL,
    [Name] nvarchar(150)  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(250)  NULL,
    [Description] nvarchar(400)  NULL,
    [ImageUrl] nvarchar(250)  NULL,
    [ParentID] int  NULL,
    [SortOrder] int  NULL,
    [IsPublished] bit  NULL,
    [test] nvarchar(250)  NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(150)  NULL,
    [Phone] int  NULL,
    [DOB] varchar(50)  NULL,
    [Adress] nvarchar(150)  NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
    [ImageID] int  NOT NULL,
    [ImageUrl] nvarchar(250)  NULL,
    [ProductID] int  NULL
);
GO

-- Creating table 'News'
CREATE TABLE [dbo].[News] (
    [NewsID] int IDENTITY(1,1) NOT NULL,
    [ImageUrl] nvarchar(250)  NOT NULL,
    [Name] nvarchar(150)  NOT NULL,
    [CreateDate] datetime  NULL,
    [Author] nvarchar(50)  NULL,
    [Content] nvarchar(max)  NULL,
    [Hits] int  NULL
);
GO

-- Creating table 'OrderItems'
CREATE TABLE [dbo].[OrderItems] (
    [OrtherID] int  NOT NULL,
    [ProductID] int  NOT NULL,
    [Name] nvarchar(150)  NULL,
    [Price] bigint  NULL,
    [Quantily] int  NULL
);
GO

-- Creating table 'Orthers'
CREATE TABLE [dbo].[Orthers] (
    [OrtherID] int IDENTITY(1,1) NOT NULL,
    [CustomerID] int  NULL,
    [DateOrdered] datetime  NULL,
    [DateRicived] datetime  NULL,
    [ShippingMethod] nvarchar(50)  NULL,
    [PaymentMethod] int  NULL,
    [PaymentType] nvarchar(50)  NULL,
    [Status] nvarchar(150)  NULL,
    [Amout] bigint  NULL
);
GO

-- Creating table 'Pages'
CREATE TABLE [dbo].[Pages] (
    [PageID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [Alias] varchar(50)  NULL,
    [Content] nvarchar(400)  NULL
);
GO

-- Creating table 'PaymenMethods'
CREATE TABLE [dbo].[PaymenMethods] (
    [PaymenMethodsID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductsID] int  NOT NULL,
    [CategoryID] int  NULL,
    [BrandID] int  NULL,
    [ImageUrl] nvarchar(250)  NULL,
    [Name] nvarchar(250)  NOT NULL,
    [Description] nvarchar(400)  NULL,
    [Price] float  NOT NULL,
    [SalePrice] float  NULL,
    [Detail] nvarchar(max)  NULL,
    [DateCreated] datetime  NULL,
    [SortOrder] int  NULL,
    [IsPublished] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BrandID], [ProductsID] in table 'Band_Product'
ALTER TABLE [dbo].[Band_Product]
ADD CONSTRAINT [PK_Band_Product]
    PRIMARY KEY CLUSTERED ([BrandID], [ProductsID] ASC);
GO

-- Creating primary key on [BrandID] in table 'Brands'
ALTER TABLE [dbo].[Brands]
ADD CONSTRAINT [PK_Brands]
    PRIMARY KEY CLUSTERED ([BrandID] ASC);
GO

-- Creating primary key on [CategoryID] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Creating primary key on [CustomerID] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerID] ASC);
GO

-- Creating primary key on [ImageID] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([ImageID] ASC);
GO

-- Creating primary key on [NewsID] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [PK_News]
    PRIMARY KEY CLUSTERED ([NewsID] ASC);
GO

-- Creating primary key on [OrtherID], [ProductID] in table 'OrderItems'
ALTER TABLE [dbo].[OrderItems]
ADD CONSTRAINT [PK_OrderItems]
    PRIMARY KEY CLUSTERED ([OrtherID], [ProductID] ASC);
GO

-- Creating primary key on [OrtherID] in table 'Orthers'
ALTER TABLE [dbo].[Orthers]
ADD CONSTRAINT [PK_Orthers]
    PRIMARY KEY CLUSTERED ([OrtherID] ASC);
GO

-- Creating primary key on [PageID] in table 'Pages'
ALTER TABLE [dbo].[Pages]
ADD CONSTRAINT [PK_Pages]
    PRIMARY KEY CLUSTERED ([PageID] ASC);
GO

-- Creating primary key on [PaymenMethodsID] in table 'PaymenMethods'
ALTER TABLE [dbo].[PaymenMethods]
ADD CONSTRAINT [PK_PaymenMethods]
    PRIMARY KEY CLUSTERED ([PaymenMethodsID] ASC);
GO

-- Creating primary key on [ProductsID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductsID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BrandID] in table 'Band_Product'
ALTER TABLE [dbo].[Band_Product]
ADD CONSTRAINT [FK_Band_Product_Brand]
    FOREIGN KEY ([BrandID])
    REFERENCES [dbo].[Brands]
        ([BrandID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProductsID] in table 'Band_Product'
ALTER TABLE [dbo].[Band_Product]
ADD CONSTRAINT [FK_Band_Product_Products]
    FOREIGN KEY ([ProductsID])
    REFERENCES [dbo].[Products]
        ([ProductsID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Band_Product_Products'
CREATE INDEX [IX_FK_Band_Product_Products]
ON [dbo].[Band_Product]
    ([ProductsID]);
GO

-- Creating foreign key on [BrandID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_Brand]
    FOREIGN KEY ([BrandID])
    REFERENCES [dbo].[Brands]
        ([BrandID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_Brand'
CREATE INDEX [IX_FK_Products_Brand]
ON [dbo].[Products]
    ([BrandID]);
GO

-- Creating foreign key on [CategoryID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_Category]
    FOREIGN KEY ([CategoryID])
    REFERENCES [dbo].[Categories]
        ([CategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_Category'
CREATE INDEX [IX_FK_Products_Category]
ON [dbo].[Products]
    ([CategoryID]);
GO

-- Creating foreign key on [CustomerID] in table 'Orthers'
ALTER TABLE [dbo].[Orthers]
ADD CONSTRAINT [FK_Orther_Customer]
    FOREIGN KEY ([CustomerID])
    REFERENCES [dbo].[Customers]
        ([CustomerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Orther_Customer'
CREATE INDEX [IX_FK_Orther_Customer]
ON [dbo].[Orthers]
    ([CustomerID]);
GO

-- Creating foreign key on [ProductID] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [FK_Image_Products]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ProductsID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Image_Products'
CREATE INDEX [IX_FK_Image_Products]
ON [dbo].[Images]
    ([ProductID]);
GO

-- Creating foreign key on [OrtherID] in table 'OrderItems'
ALTER TABLE [dbo].[OrderItems]
ADD CONSTRAINT [FK_OrderItem_Orther]
    FOREIGN KEY ([OrtherID])
    REFERENCES [dbo].[Orthers]
        ([OrtherID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProductID] in table 'OrderItems'
ALTER TABLE [dbo].[OrderItems]
ADD CONSTRAINT [FK_OrderItem_Producct]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ProductsID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderItem_Producct'
CREATE INDEX [IX_FK_OrderItem_Producct]
ON [dbo].[OrderItems]
    ([ProductID]);
GO

-- Creating foreign key on [PaymentMethod] in table 'Orthers'
ALTER TABLE [dbo].[Orthers]
ADD CONSTRAINT [FK_Orther_PaymenMethods]
    FOREIGN KEY ([PaymentMethod])
    REFERENCES [dbo].[PaymenMethods]
        ([PaymenMethodsID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Orther_PaymenMethods'
CREATE INDEX [IX_FK_Orther_PaymenMethods]
ON [dbo].[Orthers]
    ([PaymentMethod]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------