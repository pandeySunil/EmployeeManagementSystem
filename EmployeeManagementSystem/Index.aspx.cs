using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentusertype"] != null || Convert.ToString(Session["currentusertype"]) != "")
                Response.Redirect("welcome.aspx");
            txtUserName.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
               // lblError.Text = "";
                string username = txtPassword.Text;
                string password = txtUserName.Text;

                if (username == "admin" && password == "admin@123")
                {
                    Session["currentusertype"] = "Administrator";
                    Response.Redirect("welcome.aspx", false);
                }
                else if (username == "manager" && password == "manager123")
                {
                    Session["currentusertype"] = "Manager";
                    Response.Redirect("welcome.aspx", false);
                }
                else if (username == "sunil" && password == "sunil@123")
                {
                    Session["currentusertype"] = "Employee";
                    Response.Redirect("EmployeeWelcomePage.aspx", false);
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DELL-PC;Initial Catalog=payroll;Integrated Security=True");
                    SqlDataAdapter adp = new SqlDataAdapter("select * from employee where Eusername='" + username + "' and Epassword='" + password + "'", con);
                    con.Open();
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count >= 1)
                    {
                        Session["currentusertype"] = "Employee";
                        Session["currentusername"] = username;
                        Session["currentuserpassword"] = password;
                        Session["currentemployeeid"] = Convert.ToInt32(dt.Rows[0]["employeeid"]);
                        Session["currentemployeename"] = Convert.ToString(dt.Rows[0]["name"]);
                        Response.Redirect("welcome.aspx", false);
                    }
                }

            }
            catch (Exception ex)
            {
               // lblError.Text = "Error: " + ex.Message;
            }
        }
    }
  }
