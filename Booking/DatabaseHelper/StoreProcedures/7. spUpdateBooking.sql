USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateBooking]    Script Date: 13/4/2023 19:12:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateBooking]
		@bookId INT,
		@checkin DATETIME,
		@checkout DATETIME,
		@adults INT,
		@kids INT,
		@cost DECIMAL,
		@total DECIMAL
AS
BEGIN
	UPDATE [dbo].[Bookings]
	   SET [checkin] = @checkin
		  ,[checkout] = @checkout
		  ,[adults] = @adults
		  ,[kids] = @kids
		  ,[cost] = @cost
		  ,[total] = @total
	 WHERE bookId = @bookId		
END
