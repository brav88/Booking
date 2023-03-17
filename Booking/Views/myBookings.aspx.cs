using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c = Booking.Controller;
using m = Booking.Model;

namespace Booking.Views
{
    public partial class myBookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["loginInfo"] == null)
                {
                    Response.Redirect("Booking.aspx?session=false");
                }

                m.LoginResponsePayload session = (m.LoginResponsePayload)Session["loginInfo"];

                c.Book bookController = new c.Book();

                repMyBookings.DataSource = bookController.GetMyBookings(session);
                repMyBookings.DataBind();                
            }
        }
    }
}