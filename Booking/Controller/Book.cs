using Booking.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using m = Booking.Model;

namespace Booking.Controller
{
    public class Book
    {
        public bool SaveBook(m.Book book)
        {
            try
            {
                DatabaseHelper.Database db = new DatabaseHelper.Database();

                db.SaveBooking(book);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<m.Book> GetMyBookings(LoginResponsePayload session)
        {
            List<m.Book> bookList = new List<m.Book>();
            DatabaseHelper.Database db = new DatabaseHelper.Database();

            DataTable ds = db.GetMyBookings(session.email);

            foreach (DataRow row in ds.Rows)
            {
                bookList.Add(new m.Book
                {
                    BookId = Convert.ToInt16(row["bookId"]),
                    Checkin = Convert.ToDateTime(row["checkin"]),
                    Checkout = Convert.ToDateTime(row["checkout"]),
                    Adults = Convert.ToInt16(row["adults"]),
                    Kids = Convert.ToInt16(row["kids"]),
                    Cost = Convert.ToInt16(row["cost"]),
                    Total = Convert.ToInt16(row["total"]),
                    Photo = row["photo"].ToString(),
                    Name = row["name"].ToString(),
                });
            }

            return bookList;
        }
    }
}