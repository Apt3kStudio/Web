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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190521010130_addnewfilforlogo')
BEGIN
    ALTER TABLE [LandingPages] ADD [logo] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190521010130_addnewfilforlogo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190521010130_addnewfilforlogo', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190523230324_googleservicejson')
BEGIN
    ALTER TABLE [FirebaseSettings] ADD [GoogleServicesFileURL] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190523230324_googleservicejson')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190523230324_googleservicejson', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190523232405_googleservicejson1')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[FirebaseSettings]') AND [c].[name] = N'GoogleServicesFileURL');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [FirebaseSettings] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [FirebaseSettings] ALTER COLUMN [GoogleServicesFileURL] bigint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190523232405_googleservicejson1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190523232405_googleservicejson1', N'2.2.4-servicing-10062');
END;

GO

