﻿CREATE TABLE [data].[Image] (
    [imageId]    UNIQUEIDENTIFIER CONSTRAINT [DF__Image__imageId__403A8C7D] DEFAULT (newid()) NOT NULL,
    [recordId]   UNIQUEIDENTIFIER NULL,
    [name]       NVARCHAR (50)    NULL,
    [url]        NVARCHAR (250)   NULL,
    [path]       NVARCHAR (250)   NULL,
    [fileType]   NVARCHAR (50)    NULL,
    [siteId]     INT              NULL,
    [height]     INT              NULL,
    [width]      INT              NULL,
    [size]       INT              NULL,
    [created]    DATETIME         CONSTRAINT [DF__Image__created__412EB0B6] DEFAULT (getdate()) NOT NULL,
    [modified]   DATETIME         CONSTRAINT [DF__Image__modified__4222D4EF] DEFAULT (getdate()) NOT NULL,
    [createdBy]  INT              NULL,
    [modifiedBy] INT              NULL,
    [isActive]   BIT              CONSTRAINT [DF__Image__isActive__473C8FC7] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED ([imageId] ASC)
);











