IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Fabricante] (
    [Id] uniqueidentifier NOT NULL,
    [Marca] nvarchar(50) NOT NULL,
    [DataCriacao] datetime NOT NULL,
    [DataModificacao] datetime NOT NULL,
    CONSTRAINT [PK_Fabricante] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Imunobiologico] (
    [Id] uniqueidentifier NOT NULL,
    [FabricanteId] uniqueidentifier NOT NULL,
    [Descricao] nvarchar(400) NOT NULL,
    [AnoLote] int NOT NULL,
    [DataCriacao] datetime NOT NULL,
    [DataModificacao] datetime NOT NULL,
    CONSTRAINT [PK_Imunobiologico] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Imunobiologico_Fabricante_FabricanteId] FOREIGN KEY ([FabricanteId]) REFERENCES [Fabricante] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Imunobiologico_FabricanteId] ON [Imunobiologico] ([FabricanteId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220729210158_Initial', N'6.0.7');
GO

COMMIT;
GO