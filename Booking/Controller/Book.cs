using Booking.Model;
using Booking.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public bool UpdateBook(m.Book book)
        {
            try
            {
                DatabaseHelper.Database db = new DatabaseHelper.Database();

                db.UpdateBooking(book);

                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool DeleteBooking(string email, int bookId)
        {
            try
            {
                DatabaseHelper.Database db = new DatabaseHelper.Database();

                db.DeleteBooking(email, bookId);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public m.Book GetBooking(int bookId)
        {            
            DatabaseHelper.Database db = new DatabaseHelper.Database();

            DataTable ds = db.GetBooking(bookId);

            foreach (DataRow row in ds.Rows)
            {
                return new m.Book
                {
                    Id = Convert.ToInt16(row["resortId"]),
                    BookId = Convert.ToInt16(row["bookId"]),
                    Checkin = Convert.ToDateTime(row["checkin"]),
                    Checkout = Convert.ToDateTime(row["checkout"]),
                    Adults = Convert.ToInt16(row["adults"]),
                    Kids = Convert.ToInt16(row["kids"]),
                    Cost = Convert.ToInt16(row["cost"]),
                    Total = Convert.ToInt16(row["total"]),
                };
            }  
            
            return null;
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
                    Id = Convert.ToInt16(row["resortId"]),
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