USE [Booking]
GO
/****** Object:  StoredProcedure [dbo].[spGetBooking]    Script Date: 13/4/2023 19:11:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetBooking] 
	@bookId INT
AS
BEGIN
	SELECT * 
	FROM Bookings b		
	WHERE bookId = @bookId
END
