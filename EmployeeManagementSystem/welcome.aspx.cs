using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string currentusertype = Convert.ToString(Session["currentusertype"]);
                switch (currentusertype)
                {
                    case "Administrator": Response.Redirect("AdminWelcomePage.aspx"); break;
                    case "Manager": Response.Redirect("ManagerWelcomePage.aspx"); break;
                    case "Employee": Response.Redirect("EmployeeWelcomePage.aspx"); break;
                    default: Response.Redirect("Index.aspx"); break;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }
    }
}