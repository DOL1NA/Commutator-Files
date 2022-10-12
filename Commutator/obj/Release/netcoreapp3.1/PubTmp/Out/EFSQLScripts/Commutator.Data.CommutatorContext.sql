IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221010214516_InitialCreate')
BEGIN
    CREATE TABLE [Movie] (
        [ID] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NULL,
        [IP] nvarchar(max) NULL,
        [Mac] nvarchar(max) NULL,
        [VLAN] nvarchar(max) NULL,
        [Sern] nvarchar(max) NULL,
        [Invn] nvarchar(max) NULL,
        [BuyDate] datetime2 NOT NULL,
        [UstDate] datetime2 NOT NULL,
        [Atug] int NOT NULL,
        [Koment] nvarchar(max) NULL,
        CONSTRAINT [PK_Movie] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221010214516_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221010214516_InitialCreate', N'3.1.25');
END;

GO

