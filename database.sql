CREATE DATABASE [YSpringDb];
GO
USE [YSpringDb];
GO

CREATE TABLE [dbo].[UserInfo](
    [Id] [varchar](50) NOT NULL PRIMARY KEY,
    [Name] [varchar](60) NOT NULL,
    [Password] [varchar](40) NOT NULL,
    [Role] [varchar](20) NOT NULL
);
GO

CREATE TABLE [dbo].[Product](
    [Id] [varchar](50) NOT NULL PRIMARY KEY,
    [name] [varchar](60) NOT NULL,
    [price] [decimal](18, 2) NOT NULL,
    [stock] [int] NOT NULL,
    [ExpiryDate] [date] NOT NULL
);
GO

CREATE TABLE [dbo].[CustomerTable](
    [Customer Id] [varchar](20) NOT NULL PRIMARY KEY,
    [Customer Name] [varchar](50) NOT NULL,
    [Customer Phone] [varchar](20) NOT NULL
);
GO

CREATE TABLE [dbo].[Bill](
    [BillId] [varchar](20) NOT NULL PRIMARY KEY,
    [CustomerId] [varchar](20) NULL,
    [CustomerName] [varchar](50) NULL,
    [CustomerPhone] [varchar](20) NULL,
    [TotalAmount] [decimal](18, 2) NULL,
    [BillingDate] [datetime] DEFAULT (getdate())
);
GO