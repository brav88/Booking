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

        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            string msg = string.Empty;
            c.Login loginController = new c.Login();

            if (loginController.SignInWithPassword(new Model.User { Email = txtEmail.Value, Password = txtPassword.Value }))
            {
                //msg = "Login successfull";
                cardLogin.Attributes.Add("hidden", "hidden");
                cardUser.Attributes.Remove("hidden");
            }
            else
            {
                msg = "Incorrect credentials";
            }

            //Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showModal('"+ msg +"')", true);
        }
    }
}