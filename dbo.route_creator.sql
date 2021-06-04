CREATE TABLE [dbo].[Bus Route Creator]
(
	[Route ID] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Station Name] VARCHAR(50) NULL, 
    [Distance Form Source] INT NULL, 
    [Arrival Time] TIME NULL, 
    [Departure Time] TIME NULL
)
