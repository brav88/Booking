using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using c = Booking.Controller;
using m = Booking.Model;

namespace Booking.Views
{
    public partial class myBookings : System.Web.UI.Page
    {
        //public List<m.Book> bookList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["loginInfo"] == null)
                {
                    Response.Redirect("Booking.aspx?session=false");
                }

                LoadBookings();
            }
        }

        public void LoadBookings()
        {
            m.LoginResponsePayload session = (m.LoginResponsePayload)Session["loginInfo"];

            c.Book bookController = new c.Book();

            repMyBookings.DataSource = bookController.GetMyBookings(session);
            repMyBookings.DataBind();

            if (repMyBookings.Items.Count == 0)
            {
                divNoBooks.Attributes.Remove("hidden");
            }
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            var button = (HtmlButton)sender;
            Session["bookId"] = Convert.ToInt16(button.Attributes["dataId"]);

            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction",
                "showModal('Delete booking','Do you really want to delete this booking?')", true);
        }

        protected void btnConfirmDelete_ServerClick(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt16(Session["bookId"]);

            m.LoginResponsePayload session = (m.LoginResponsePayload)Session["loginInfo"];

            c.Book bookController = new c.Book();
            bookController.DeleteBooking(session.email, bookId);

            LoadBookings();
        }
    }
}