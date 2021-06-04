CREATE TABLE [dbo].[ticketcreator] (
    [ticketno]           NVARCHAR (50) NOT NULL,
    [busno]              NVARCHAR (50) NOT NULL,
    [sourcestation]      NVARCHAR (50) NOT NULL,
    [destinationstation] NVARCHAR (50) NOT NULL,
    [chooseroute]        NVARCHAR (50) NOT NULL,
    [distancefromsource] NVARCHAR (50) NOT NULL,
    [totalfarecost]      NVARCHAR (50) NOT NULL,
    [issueddate]         NVARCHAR (50) NOT NULL,
    [departuredate]      NVARCHAR (50) NOT NULL,
    [departuretime]      NVARCHAR (50) NOT NULL,
    [arrivaltime]        NVARCHAR (50) NOT NULL,
    [name]               NVARCHAR (50) NOT NULL,
    [age]                NVARCHAR (50) NOT NULL,
    [gender]             NVARCHAR (50) NOT NULL,
    [address]            NVARCHAR (50) NOT NULL,
    [phoneno]            NVARCHAR (50) NOT NULL,
	[noofpassengers]            NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ticketcreator] PRIMARY KEY CLUSTERED ([ticketno] ASC)
);

