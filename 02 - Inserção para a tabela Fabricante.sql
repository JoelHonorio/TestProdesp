INSERT INTO 
	[dbo].[Fabricante]
	(
		[Id]
		,[Marca]
		,[DataCriacao]
		,[DataModificacao]
	)
VALUES
	(
		'7ac53a99-07b2-481f-a30c-7017b891e286'
		,'Pfizer'
		,GETDATE()
		,GETDATE()
	)
GO

INSERT INTO 
	[dbo].[Fabricante]
    (
		[Id]
        ,[Marca]
        ,[DataCriacao]
        ,[DataModificacao]
	)
VALUES
    (
		'f064b162-7e84-446a-9e74-fc41620cd8bb'
        ,'Sinovac'
        ,GETDATE()
        ,GETDATE()
	)
GO