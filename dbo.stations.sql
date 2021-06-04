CREATE TABLE [dbo].[stations] (
    [stationcode]    NVARCHAR (50) NOT NULL,
    [stationname]   NVARCHAR (50) NOT NULL,
    [stationaddress] NVARCHAR (50) NOT NULL,
    [routeid]        NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_stations] PRIMARY KEY CLUSTERED ([stationcode] ASC)
);

