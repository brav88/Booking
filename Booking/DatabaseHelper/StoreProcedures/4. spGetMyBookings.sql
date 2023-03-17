USE [Booking]
GO

/****** Object:  StoredProcedure [dbo].[spGetMyBookings]    Script Date: 16/3/2023 21:04:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spGetMyBookings] 
	@email VARCHAR(50)
AS
BEGIN
	SELECT * 
	FROM Bookings b
		INNER JOIN Resorts r
		ON b.resortId = r.id
	WHERE email = @email
END


delete from Bookings where bookId=1003
GO


