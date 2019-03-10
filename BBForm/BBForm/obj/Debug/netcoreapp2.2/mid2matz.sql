IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Player] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [JerseyNumber] int NOT NULL,
    [DOB] datetime2 NOT NULL,
    [Height] nvarchar(max) NOT NULL,
    [CurrentTeam] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Player] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [PlayerTeam] (
    [Id] int NOT NULL IDENTITY,
    [TeamName] nvarchar(max) NOT NULL,
    [PlayerName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_PlayerTeam] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Team] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Team] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190310062456_Initial', N'2.2.2-servicing-10034');

GO

