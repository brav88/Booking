USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[spSaveBooking]    Script Date: 16/3/2023 21:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSaveBooking]
		@resortId INT,
		@email VARCHAR(50),
		@checkin DATETIME,
		@checkout DATETIME,
		@adults INT,
		@kids INT,
		@cost DECIMAL,
		@total DECIMAL
AS
BEGIN
	INSERT INTO [dbo].[Bookings]
           ([resortId]
           ,[email]
           ,[checkin]
           ,[checkout]
           ,[adults]
           ,[kids]
           ,[cost]
           ,[total])
     VALUES
           (@resortId
           ,@email
           ,@checkin
           ,@checkout
           ,@adults
           ,@kids
           ,@cost
           ,@total)
END
