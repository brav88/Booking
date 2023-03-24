USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteBooking]    Script Date: 23/3/2023 18:16:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteBooking]
	@email VARCHAR(50),
	@bookId INT
AS
BEGIN	
	DELETE FROM Bookings WHERE bookId = @bookId AND email = @email
END
