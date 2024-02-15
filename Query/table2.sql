﻿CREATE TABLE [dbo].[Cities] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (100)            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC));

CREATE TABLE [dbo].[Categories] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (100)            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC));

    CREATE TABLE [dbo].[Business] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (100)            NOT NULL,
    [Category] INT  NOT NULL,
    [CityId] INT NOT NULL,
    [Adress] NVARCHAR (100) NULL,
    [PhoneNum] NVARCHAR (10) NOT NULL,
    [OpeningHours]  NVARCHAR (100) NULL,
    [MoreInfo] NVARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT FK_CitiesBusiness FOREIGN KEY (CityId)
    REFERENCES Cities(Id));


    CREATE TABLE [dbo].[HousingUnits] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [CityId] INT NOT NULL,
    [PhoneNum] NVARCHAR (10) NOT NULL,
    [Adress] NVARCHAR (100) NOT NULL,
    [Mr] INT NOT NULL,
    [Name]  NVARCHAR (100)            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT FK_CitiesHousingUnits FOREIGN KEY (CityId)
    REFERENCES Cities(Id));