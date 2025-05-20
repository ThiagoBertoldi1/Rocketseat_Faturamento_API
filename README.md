# How to Run This Project

## 1. Set Up SQL Server

You can set up a SQL Server instance using Docker with the following configuration:

```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=MinhaSenhaForte123!" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server
```

Then, using SQL Server Management Studio (SSMS), create a new database named Faturamento and execute the following script:

```SQL
USE [Faturamento]

CREATE TABLE [dbo].[Fatura](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdProduto] [bigint] NOT NULL,
	[Descricao] [varchar](255) NULL,
	[DtInclusao] [datetime] NOT NULL,
	[MetodoPagamento] [int] NOT NULL
)

CREATE TABLE [dbo].[Produto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Preco] [decimal](18, 2) NOT NULL
)

INSERT INTO dbo.Produto (Nome, Preco)
VALUES
('Product1', 10),
('Product2', 20),
('Product3', 30)
```

## #2 Run the API Project

Clone the repository and navigate to the folder containing the `.sln` file. Then, run:

```CLI
dotnet restore
dotnet run
```

## #3 Done! 🎉

Thanks
