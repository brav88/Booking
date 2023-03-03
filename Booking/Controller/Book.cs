using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}