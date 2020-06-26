IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [TblGroup] (
    [GroupId] int NOT NULL IDENTITY,
    [GroupName] nvarchar(50) NOT NULL,
    [Description] nvarchar(100) NULL,
    [StoreId] int NOT NULL,
    CONSTRAINT [PK_TblGroup] PRIMARY KEY ([GroupId])
);

GO

CREATE TABLE [TblGroupMenu] (
    [Menu] nvarchar(450) NOT NULL,
    [GroupId] int NOT NULL,
    [StoreId] int NOT NULL,
    [View] bit NOT NULL,
    [Add] bit NOT NULL,
    [Edit] bit NOT NULL,
    [Delete] bit NOT NULL,
    CONSTRAINT [PK_TblGroupMenu] PRIMARY KEY ([Menu], [GroupId])
);

GO

CREATE TABLE [TblProduct] (
    [ProductId] int NOT NULL IDENTITY,
    [CreateDate] datetime2 NOT NULL,
    [CreateBy] varchar(50) NULL,
    [UpdateDate] datetime2 NULL,
    [UpdateBy] varchar(50) NULL,
    [StoreId] int NOT NULL,
    [ProductCode] varchar(5) NOT NULL,
    [ProductName] nvarchar(150) NOT NULL,
    [SupplierId] int NOT NULL,
    [TaxId] int NOT NULL,
    [UnitCalcId] int NULL,
    [ProductPrice] decimal(18,2) NOT NULL,
    [ProductInventory] decimal(18,2) NOT NULL,
    [Description] nvarchar(100) NULL,
    [Status] int NULL,
    CONSTRAINT [PK_TblProduct] PRIMARY KEY ([ProductId])
);

GO

CREATE TABLE [TblRoom] (
    [RoomId] int NOT NULL IDENTITY,
    [CreateDate] datetime2 NOT NULL,
    [CreateBy] varchar(50) NULL,
    [UpdateDate] datetime2 NULL,
    [UpdateBy] varchar(50) NULL,
    [StoreId] int NOT NULL,
    [RoomName] nvarchar(100) NOT NULL,
    [RoomType] int NOT NULL,
    [RoomPrice] decimal(18,2) NOT NULL,
    [Description] nvarchar(100) NULL,
    [Status] int NULL,
    CONSTRAINT [PK_TblRoom] PRIMARY KEY ([RoomId])
);

GO

CREATE TABLE [TblStore] (
    [StoreId] int NOT NULL IDENTITY,
    [StoreName] nvarchar(50) NOT NULL,
    [Address] nvarchar(100) NULL,
    CONSTRAINT [PK_TblStore] PRIMARY KEY ([StoreId])
);

GO

CREATE TABLE [TblSupplier] (
    [SupplierId] int NOT NULL IDENTITY,
    [CreateDate] datetime2 NOT NULL,
    [CreateBy] varchar(50) NULL,
    [UpdateDate] datetime2 NULL,
    [UpdateBy] varchar(50) NULL,
    [StoreId] int NOT NULL,
    [SupplierName] nvarchar(150) NOT NULL,
    [Address] nvarchar(150) NULL,
    [Description] nvarchar(100) NULL,
    [Status] int NULL,
    CONSTRAINT [PK_TblSupplier] PRIMARY KEY ([SupplierId])
);

GO

CREATE TABLE [TblTax] (
    [TaxId] int NOT NULL IDENTITY,
    [CreateDate] datetime2 NOT NULL,
    [CreateBy] varchar(50) NULL,
    [UpdateDate] datetime2 NULL,
    [UpdateBy] varchar(50) NULL,
    [StoreId] int NOT NULL,
    [TaxName] nvarchar(100) NOT NULL,
    [TaxValue] decimal(18,2) NOT NULL,
    [Status] int NULL,
    CONSTRAINT [PK_TblTax] PRIMARY KEY ([TaxId])
);

GO

CREATE TABLE [TblUnitCalc] (
    [UnitCalcId] int NOT NULL IDENTITY,
    [CreateDate] datetime2 NOT NULL,
    [CreateBy] varchar(50) NULL,
    [UpdateDate] datetime2 NULL,
    [UpdateBy] varchar(50) NULL,
    [StoreId] int NOT NULL,
    [UnitCalcName] nvarchar(100) NOT NULL,
    [Status] int NULL,
    CONSTRAINT [PK_TblUnitCalc] PRIMARY KEY ([UnitCalcId])
);

GO

CREATE TABLE [TblUser] (
    [UserId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(30) NOT NULL,
    [LastName] nvarchar(30) NOT NULL,
    [Email] varchar(50) NULL,
    [PhoneNumber] varchar(15) NULL,
    [Address] nvarchar(100) NULL,
    [Username] varchar(50) NOT NULL,
    [Password] varchar(32) NOT NULL,
    [Token] varchar(100) NULL,
    CONSTRAINT [PK_TblUser] PRIMARY KEY ([UserId])
);

GO

CREATE TABLE [TblUserGroup] (
    [UserGroupId] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    [StoreId] int NOT NULL,
    [GroupId] int NOT NULL,
    CONSTRAINT [PK_TblUserGroup] PRIMARY KEY ([UserGroupId])
);

GO

CREATE TABLE [TblUserMenu] (
    [Menu] nvarchar(450) NOT NULL,
    [UserId] int NOT NULL,
    [StoreId] int NOT NULL,
    [View] bit NOT NULL,
    [Add] bit NOT NULL,
    [Edit] bit NOT NULL,
    [Delete] bit NOT NULL,
    CONSTRAINT [PK_TblUserMenu] PRIMARY KEY ([Menu], [UserId])
);

GO

CREATE TABLE [TblUserStore] (
    [UserId] int NOT NULL,
    [StoreId] int NOT NULL,
    CONSTRAINT [PK_TblUserStore] PRIMARY KEY ([UserId], [StoreId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200626061519_InitialCreate', N'3.1.4');

GO