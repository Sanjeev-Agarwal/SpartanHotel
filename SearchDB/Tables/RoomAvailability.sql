CREATE TABLE [dbo].[RoomAvailability]
(
	[RoomDescription] NVARCHAR(100) NOT NULL PRIMARY KEY, 
    [City] NVARCHAR(100) NOT NULL, 
    [Date] DATE NOT NULL, 
    [RoomId] SMALLINT NOT NULL, 
    [NoofAvailableRooms] SMALLINT NOT NULL, 
    [LastRefreshed] DATETIME NOT NULL
)
