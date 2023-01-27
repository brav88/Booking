using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c = Booking.Controller;

namespace Booking
{
    public partial class Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            c.Resort resortController = new c.Resort();
            
            repResorts.DataSource = resortController.GetResorts();
            repResorts.DataBind();
        }
    }
}