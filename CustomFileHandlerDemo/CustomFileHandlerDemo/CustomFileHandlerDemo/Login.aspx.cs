using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomFileHandlerDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ctrlLogin_LoggedIn(object sender, EventArgs e)
        {
            Response.Redirect("~/User/Default.aspx");
        }
    }
}
