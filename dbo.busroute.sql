CREATE TABLE [dbo].[busoute] (
    [Route ID]             VARCHAR (50) NOT NULL,
    [choose station]       VARCHAR (50) NOT NULL,
    [Distance From Source] FLOAT (53)   NOT NULL,
    [Arrival Time]         TIME (7)     NOT NULL,
    [Departiure Time]      TIME (7)     NOT NULL,
    CONSTRAINT [PK_busroute] PRIMARY KEY CLUSTERED ([Route ID] ASC)
);

