CREATE TABLE [dbo].[busoute] (
    [routeid]            NVARCHAR (50) NOT NULL,
    [choosestation]      VARCHAR (50)  NOT NULL,
    [distancefromsource] VARCHAR (50)  NOT NULL,
    [arrivaltime]        VARCHAR (50)  NOT NULL,
    [departuretime]      VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_busroute] PRIMARY KEY CLUSTERED ([routeid] ASC)
);

