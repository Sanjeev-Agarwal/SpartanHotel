CREATE TABLE [dbo].[Room]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY, 
    [Description] NVARCHAR(200) NOT NULL, 
    [HotelId] SMALLINT NOT NULL, 
    [NoOfRooms] SMALLINT NOT NULL, 
    [AdditionalDetails] NVARCHAR(500) NULL,
	CONSTRAINT [FK_Room_Hotel] FOREIGN KEY ([HotelId]) REFERENCES [Hotel]([Id]) 
)
