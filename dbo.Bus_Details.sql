CREATE TABLE [dbo].[Bus_Details] (
    [busno]       NVARCHAR (50) NOT NULL,
    [busname]     NVARCHAR (50) NOT NULL,
    [bustype]     NVARCHAR (50) NOT NULL,
    [noofseats]   NVARCHAR (50) NOT NULL,
    [Model]       NVARCHAR (50) NOT NULL,
    [Driver]      NVARCHAR (50) NOT NULL,
    [conductor]   NVARCHAR (50) NOT NULL,
    [chooseroute] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Bus_Details] PRIMARY KEY CLUSTERED ([busno] ASC)
);

