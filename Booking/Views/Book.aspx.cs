using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c = Booking.Controller;

namespace Booking.Views
{
    public partial class Book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            c.Resort resortController = new c.Resort();

            int id = Convert.ToInt16(Request.QueryString["id"]);

            repResort.DataSource = resortController.GetResort(id);
            repResort.DataBind();
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
          
        }
    }
}