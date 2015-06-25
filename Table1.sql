/*
   terça-feira, 4 de junho de 201317:13:19
   User: 
   Server: .\SQLEXPRESS
   Database: 
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table1
	(
	IDUSUARIO int NOT NULL,
	NOME char(10) NOT NULL,
	SENHA varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table1 ADD CONSTRAINT
	PK_Table1 PRIMARY KEY CLUSTERED 
	(
	IDUSUARIO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX IX_Table1 ON dbo.Table1
	(
	IDUSUARIO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.Table1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
