using Booking.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using m = Booking.Model;

namespace Booking.DatabaseHelper
{
    public class Database
    {
        const string database = "Booking";
        const string server = "localhost";
        SqlConnection connection = new SqlConnection($"Data Source={server};Initial Catalog={database};Integrated Security=True");

        public DataTable GetResorts()
        {
            return this.Fill("[dbo].[spGetResorts]", null);
        }

        public DataTable GetResort(int id)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@id", id),
            };

            return this.Fill("[dbo].[spGetResort]", param);
        }

        public void SaveBooking(m.Book book)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@resortId", book.Id),
                new SqlParameter("@email", book.Session.email),
                new SqlParameter("@checkin", book.Checkin),
                new SqlParameter("@checkout", book.Checkout),
                new SqlParameter("@adults", book.Adults),
                new SqlParameter("@kids", book.Kids),
                new SqlParameter("@cost", book.Cost),
                new SqlParameter("@total", book.Total),
            };

            this.ExecuteQuery("[dbo].[spSaveBooking]", param);
        }

        public void UpdateBooking(m.Book book)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@bookId", book.BookId),
                new SqlParameter("@checkin", book.Checkin),
                new SqlParameter("@checkout", book.Checkout),
                new SqlParameter("@adults", book.Adults),
                new SqlParameter("@kids", book.Kids),
                new SqlParameter("@cost", book.Cost),
                new SqlParameter("@total", book.Total),
            };

            this.ExecuteQuery("[dbo].[spUpdateBooking]", param);
        }

        public DataTable GetMyBookings(string email)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@email", email),
            };

            return this.Fill("[dbo].[spGetMyBookings]", param);
        }

        public DataTable GetBooking(int bookId)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@bookId", bookId),
            };

            return this.Fill("[dbo].[spGetBooking]", param);
        }

        public void DeleteBooking(string email, int bookId)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@email", email),
                new SqlParameter("@bookId", bookId),
            };

            this.ExecuteQuery("[dbo].[spDeleteBooking]", param);
        }

        public DataTable Fill(string storedProcedure, List<SqlParameter> param)
        {
            try
            {
                using (this.connection)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    if (param != null)
                    {
                        foreach (SqlParameter p in param)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }

                    DataTable ds = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExecuteQuery(string storedProcedure, List<SqlParameter> param)
        {
            try
            {
                using (this.connection)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    if (param != null)
                    {
                        foreach (SqlParameter p in param)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}