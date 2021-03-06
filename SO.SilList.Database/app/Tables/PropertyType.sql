﻿CREATE TABLE [app].[PropertyType] (
    [propertyTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [name]           NVARCHAR (50) NULL,
    [description]    NVARCHAR (50) NULL,
    [created]        DATETIME      CONSTRAINT [DF__PropertyT__creat__3C69FB99] DEFAULT (getdate()) NOT NULL,
    [modified]       DATETIME      CONSTRAINT [DF__PropertyT__modif__3D5E1FD2] DEFAULT (getdate()) NOT NULL,
    [createdBy]      INT           NULL,
    [modifiedBy]     INT           NULL,
    [isActive]       BIT           NOT NULL DEFAULT ((1)),
    CONSTRAINT [PK__Property__97B944DA3D7865E6] PRIMARY KEY CLUSTERED ([propertyTypeId] ASC)
);






