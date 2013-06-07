/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
Use ReservationDB
GO

Delete from Reservation
Delete from Room
Delete from Hotel
Delete from Guest
Delete from Policy
Delete from [Status]

GO
Declare @GuestID1 uniqueidentifier
Declare @GuestID2 uniqueidentifier
Declare @GuestID3 uniqueidentifier

set @GuestID1 = NEWID();
set @GuestID2 = NEWID();
set @GuestID3 = NEWID();


INSERT INTO [dbo].[Guest] ([Id], [FirstName], [LastName], [Email], [Phone]) VALUES (@GuestID1, 'John', 'Miller', 'John@sifi.com', '+123456789')
INSERT INTO [dbo].[Guest] ([Id], [FirstName], [LastName], [Email], [Phone]) VALUES (@GuestID2, 'Jim', 'Jacobson', 'Jim@towo.com', '+123456789')
INSERT INTO [dbo].[Guest] ([Id], [FirstName], [LastName], [Email], [Phone]) VALUES (@GuestID3, 'Sivaraj', 'Kumar', 'Siva@tata.com', '+123456789')

INSERT INTO [dbo].[Hotel] ([Id], [Description], [City]) VALUES (1, 'Oberai Bangalore', 'Bangalore')
INSERT INTO [dbo].[Hotel] ([Id], [Description], [City]) VALUES (2, 'Oberai Mumbai', 'Mumbai')
INSERT INTO [dbo].[Hotel] ([Id], [Description], [City]) VALUES (3, 'Oberai Hyderbad', 'Hyderbad')

INSERT INTO [dbo].[Policy] ([Id], [Percentage]) VALUES (1, 5)

INSERT INTO [dbo].[Status] ([Id], [Description], [Name]) VALUES (1, 'Pending Booking', 'Pending')
INSERT INTO [dbo].[Status] ([Id], [Description], [Name]) VALUES (2, 'Booking Confirmed', 'Confirmed')
INSERT INTO [dbo].[Status] ([Id], [Description], [Name]) VALUES (3, 'Cancelled Booking', 'Cancelled')

INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (1, 'Sleep Dorm', 1, 20, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (2, 'RnR', 1, 20, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (3, 'Working Suite', 1, 20, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (4, 'Office Away', 1, 20, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (5, 'Home Away', 1, 20, 'Some additional text')

INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (6, 'Sleep Dorm', 2, 10, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (7, 'RnR', 2, 10, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (8, 'Working Suite', 2, 10, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (9, 'Office Away', 2, 10, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (10, 'Home Away', 2, 10, 'Some additional text')

INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (11, 'Sleep Dorm', 3, 10, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (12, 'RnR', 3, 10, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (13, 'Working Suite', 3, 10, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (14, 'Office Away', 3, 10, 'Some additional text')
INSERT INTO [dbo].[Room] ([Id], [Description], [HotelId], [NoOfRooms], [AdditionalDetails]) VALUES (15, 'Home Away', 3, 10, 'Some additional text')

INSERT INTO [dbo].[Reservation] ([Id], [GuestId], [Date], [NoOfRooms], [CreatedDate], [ModifiedDate], [StatusId], [RoomId]) 
VALUES (NEWID(), @GuestID1, '2013/03/06', 2, SYSDATETIME(), SYSDATETIME(), 1, 1)
INSERT INTO [dbo].[Reservation] ([Id], [GuestId], [Date], [NoOfRooms], [CreatedDate], [ModifiedDate], [StatusId], [RoomId]) 
VALUES (NEWID(), @GuestID1, '2013/04/01', 2, SYSDATETIME(), SYSDATETIME(), 1, 1)
INSERT INTO [dbo].[Reservation] ([Id], [GuestId], [Date], [NoOfRooms], [CreatedDate], [ModifiedDate], [StatusId], [RoomId]) 
VALUES (NEWID(), @GuestID2, '2013/05/05', 2, SYSDATETIME(), SYSDATETIME(), 1, 2)
INSERT INTO [dbo].[Reservation] ([Id], [GuestId], [Date], [NoOfRooms], [CreatedDate], [ModifiedDate], [StatusId], [RoomId]) 
VALUES (NEWID(), @GuestID3, '2013/06/01', 2, SYSDATETIME(), SYSDATETIME(), 1, 10)
