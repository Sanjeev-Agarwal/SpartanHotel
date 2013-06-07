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
Use SearchDB
GO
Delete from [RoomAvailability]
GO
INSERT INTO [dbo].[RoomAvailability] ([RoomDescription], [City], [Date], [RoomId], [NoofAvailableRooms], [LastRefreshed]) VALUES ('Sleep Dorm', 'Bangalore', '2013/06/06', 1, 20, '2013/06/06')
INSERT INTO [dbo].[RoomAvailability] ([RoomDescription], [City], [Date], [RoomId], [NoofAvailableRooms], [LastRefreshed]) VALUES ('RnR', 'Bangalore', '2013/06/06', 2, 10, '2013/06/06')
INSERT INTO [dbo].[RoomAvailability] ([RoomDescription], [City], [Date], [RoomId], [NoofAvailableRooms], [LastRefreshed]) VALUES ('Working Suite', 'Bangalore', '2013/06/06', 3, 5, '2013/06/06')
INSERT INTO [dbo].[RoomAvailability] ([RoomDescription], [City], [Date], [RoomId], [NoofAvailableRooms], [LastRefreshed]) VALUES ('Office Away', 'Bangalore', '2013/06/06', 4, 11, '2013/06/06')
INSERT INTO [dbo].[RoomAvailability] ([RoomDescription], [City], [Date], [RoomId], [NoofAvailableRooms], [LastRefreshed]) VALUES ('Home Away', 'Bangalore', '2013/06/06', 5, 0, '2013/06/06')

