USE [master]
GO

IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'TMS')
DROP DATABASE [TMS]
GO

USE [master]
GO

CREATE DATABASE [TMS]
GO
