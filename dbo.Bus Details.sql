CREATE TABLE [dbo].[Bus Details]
(
	[Bus No] VARCHAR(50) NOT NULL PRIMARY KEY IDENTITY, 
    [Bus Name] VARCHAR(50) NOT NULL, 
    [Choose Route] CHAR(30) NOT NULL, 
    [Bus Type] CHAR(10) NOT NULL, 
    [No of Seats] VARCHAR(10) NOT NULL, 
    [Model] VARCHAR(50) NULL
)
