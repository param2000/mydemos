using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace CustomFileHandlerDemo.User
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = User.Identity.Name;
            lblRole.Text = Roles.GetRolesForUser().FirstOrDefault();

            if (Request.QueryString.Get("Logout") == "1")
            {
                FormsAuthentication.SignOut();
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}
