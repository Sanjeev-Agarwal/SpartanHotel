CREATE TABLE [dbo].[Reservation]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [GuestId] UNIQUEIDENTIFIER NOT NULL, 
    [Date] DATE NOT NULL, 
    [NoOfRooms] SMALLINT NOT NULL, 
    [CreatedDate] DATETIME NOT NULL, 
    [ModifiedDate] DATETIME NULL, 
    [StatusId] SMALLINT NOT NULL, 
    [RoomId] SMALLINT NOT NULL, 
    CONSTRAINT [FK_Reservation_Guest] FOREIGN KEY ([GuestId]) REFERENCES [Guest]([Id]), 
	CONSTRAINT [FK_Reservation_Room] FOREIGN KEY ([RoomId]) REFERENCES [Room]([Id]),
	CONSTRAINT [FK_Reservation_Status] FOREIGN KEY ([StatusId]) REFERENCES [Status]([Id])  
)
