IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Student] (
    [StudentId] uniqueidentifier NOT NULL,
    [AnotherKeyProperty] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Age] int NULL,
    [IsRegularStudent] bit NOT NULL DEFAULT CAST(0 AS bit),
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId], [AnotherKeyProperty])
);

GO

CREATE PROCEDURE MyCustomProcedure AS SELECT * FROM Student

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200910065959_InitialMigration', N'3.1.8');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [AnotherKeyProperty], [Age], [Name])
VALUES ('b49e754e-bd5b-4173-8b09-9d2ae69bdd44', '00000000-0000-0000-0000-000000000000', 24, N'Emir Balcı');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [AnotherKeyProperty], [Age], [Name])
VALUES ('8d3a93b7-a903-41dc-bddc-68e08a8393d9', '00000000-0000-0000-0000-000000000000', 27, N'Emre Balcı');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200915063249_SeedInitialData', N'3.1.8');

GO

ALTER TABLE [Student] DROP CONSTRAINT [PK_Student];

GO

DELETE FROM [Student]
WHERE [StudentId] = '8d3a93b7-a903-41dc-bddc-68e08a8393d9' AND [AnotherKeyProperty] = '00000000-0000-0000-0000-000000000000';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = 'b49e754e-bd5b-4173-8b09-9d2ae69bdd44' AND [AnotherKeyProperty] = '00000000-0000-0000-0000-000000000000';
SELECT @@ROWCOUNT;


GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Student]') AND [c].[name] = N'IsRegularStudent');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Student] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Student] ALTER COLUMN [IsRegularStudent] bit NOT NULL;
ALTER TABLE [Student] ADD DEFAULT CAST(1 AS bit) FOR [IsRegularStudent];

GO

ALTER TABLE [Student] ADD CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId]);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [AnotherKeyProperty], [Name])
VALUES ('22b0456a-2daa-4635-8aa3-8442e03e4af6', 24, '00000000-0000-0000-0000-000000000000', N'Emir Balcı');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [AnotherKeyProperty], [Name])
VALUES ('b0642811-1f03-4154-aacf-185374a194e0', 26, '00000000-0000-0000-0000-000000000000', N'Emre Balcı');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [AnotherKeyProperty], [Name])
VALUES ('4c04b1ea-42ee-43af-9507-2f78f2fa8568', 29, '00000000-0000-0000-0000-000000000000', N'Onur Balcı');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200915073754_AdditionalRowInserted', N'3.1.8');

GO

DELETE FROM [Student]
WHERE [StudentId] = '22b0456a-2daa-4635-8aa3-8442e03e4af6';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = '4c04b1ea-42ee-43af-9507-2f78f2fa8568';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = 'b0642811-1f03-4154-aacf-185374a194e0';
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [AnotherKeyProperty], [Name])
VALUES ('1829f0e8-4866-41ab-b34b-e85c1de147a2', 24, '00000000-0000-0000-0000-000000000000', N'Emir Balcı'),
('961c5226-dbda-4519-a55f-0dc493400acc', 26, '00000000-0000-0000-0000-000000000000', N'Emre Balcı'),
('e31a0b04-a3ad-4de2-8907-e1e4eec4cc5f', 29, '00000000-0000-0000-0000-000000000000', N'Onur Balcı'),
('4d24d022-47e6-46d8-86cc-bb287392ef60', 45, '00000000-0000-0000-0000-000000000000', N'Nuran Balcı');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200916063038_RevertTestMigration', N'3.1.8');

GO

