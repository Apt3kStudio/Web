IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190508143928_DashboardEntity1PKAutoIncre')
BEGIN
    CREATE TABLE [Dashboards] (
        [ID] int NOT NULL IDENTITY,
        [Header] nvarchar(max) NULL,
        [Body] nvarchar(max) NULL,
        CONSTRAINT [PK_Dashboards] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190508143928_DashboardEntity1PKAutoIncre')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190508143928_DashboardEntity1PKAutoIncre', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190508215613_LandingPage1')
BEGIN
    CREATE TABLE [LandingPages] (
        [ID] int NOT NULL IDENTITY,
        [Header] nvarchar(max) NULL,
        [Body] nvarchar(max) NULL,
        CONSTRAINT [PK_LandingPages] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190508215613_LandingPage1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190508215613_LandingPage1', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514005529_LandingPageDetailProduct')
BEGIN
    ALTER TABLE [LandingPages] ADD [ProductDetail] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514005529_LandingPageDetailProduct')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190514005529_LandingPageDetailProduct', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190518134743_FBToken')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [FBToken] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190518134743_FBToken')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190518134743_FBToken', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190518174653_FirebaseSettingTable')
BEGIN
    CREATE TABLE [FirebaseSettings] (
        [ID] int NOT NULL IDENTITY,
        [ApplicationID] nvarchar(max) NULL,
        [SenderID] nvarchar(max) NULL,
        [DeviceID] nvarchar(max) NULL,
        [RequestType] nvarchar(max) NULL,
        [ContentType] nvarchar(max) NULL,
        [FCMSendUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_FirebaseSettings] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190518174653_FirebaseSettingTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190518174653_FirebaseSettingTable', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190518191657_FirebaseSettingColProfileName')
BEGIN
    ALTER TABLE [FirebaseSettings] ADD [ProfileName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190518191657_FirebaseSettingColProfileName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190518191657_FirebaseSettingColProfileName', N'2.2.4-servicing-10062');
END;

GO

