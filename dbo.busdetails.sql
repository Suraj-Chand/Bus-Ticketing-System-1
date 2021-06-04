CREATE TABLE [dbo].[busdetails] (
    [busno]       NVARCHAR (50) NOT NULL,
    [busname]     NVARCHAR (50) NOT NULL,
	[chooseroute] NVARCHAR (50) Not null,
    [bustype]     NVARCHAR (50) NOT NULL,
    [noofseats]   NVARCHAR (50) NOT NULL,
    [Model]       NVARCHAR (50) NOT NULL,
    [Driver]      NVARCHAR (50) NOT NULL,
    [conductor]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_busdetails] PRIMARY KEY CLUSTERED ([busno] ASC)
);

