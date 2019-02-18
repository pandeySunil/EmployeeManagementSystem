using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//@Name NVARCHAR(255),
//      @UserName NVARCHAR(255),
//      @Password NVARCHAR(255),
//	  @Email NVARCHAR(255),
//	  @Mobile NVARCHAR(255),
//	  @Gender NVARCHAR(255),
//	  @DOB NVARCHAR(255),
//	  @State NVARCHAR(255),
//	  @City NVARCHAR(244),
//	  @Nationality NVARCHAR(255),
//	  @Active bit

namespace EmployeeManagementSystem
{
    public partial class EmployeeWelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Request.QueryString["name"]==null))
            {
                //Response.Redirect("~/EmployeeWelcomePage?name" + name + "&userName" + userName + "&password"
                //   + password + "&email" + email + "&mobile" + mobile + "&gender" + gender + "&doB" + doB + "&state" + state + "&city"
                //   + city + "&nationality" + nationality);
                txtFristName.Text = Request.QueryString["name"];
                txtUserName.Text = Request.QueryString["userName"];
                txtPwd.Text = Request.QueryString["password"];
                txtEmail.Text = Request.QueryString["email"];
                txtMobile.Text = Request.QueryString["mobile"];
                //RadioButtonList. = Request.QueryString["gender"];
                txtDob.Text = Request.QueryString["doB"];
                drpState.SelectedValue = Request.QueryString["state"];
                drpCity.SelectedValue = Request.QueryString["city"];
                //ch.Text = Request.QueryString["nationality"];
                int UserId = Convert.ToInt32(Request.QueryString["Id"]);
                btn1.Text = "Update Record";
                txtPwd.Visible = false;
                Textbox1.Visible = false;

            }

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Update Record") { UpdateRecord(); }
            else
            {
                var connectionString = /*"Data Source=.;Initial Catalog=EmployeeManagementDb;Integrated Security=True";*/
                "Data Source=YH1008679DT\\SQLEXPRESS2014;Initial Catalog=EmployeeManagementDb;Integrated Security=True";
                int userId = 0;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert_User"))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Name", txtFristName.Text);
                            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", txtPwd.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                            cmd.Parameters.AddWithValue("@Gender", RadioButtonList1.SelectedValue);
                            cmd.Parameters.AddWithValue("@DOB", Convert.ToString(txtDob.Text));
                            cmd.Parameters.AddWithValue("@State", drpState.SelectedValue);
                            cmd.Parameters.AddWithValue("@City", drpCity.SelectedValue);
                            cmd.Parameters.AddWithValue("@Nationality", checkNationality.Checked.ToString());
                            cmd.Parameters.AddWithValue("@Active",1 );
                            cmd.Connection = con;
                            con.Open();
                            userId = Convert.ToInt32(cmd.ExecuteScalar());
                            con.Close();
                        }
                    }
                    string message = string.Empty;
                    switch (userId)
                    {
                        case -1:
                            message = "Username already exists.\\nPlease choose a different username.";
                            break;
                        case -2:
                            message = "Supplied email address has already been used.";
                            break;
                        default:
                            message = "Registration successful.\\nUser Id: " + userId.ToString();
                            break;
                    }
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
                }
            }
        }
        private void UpdateRecord()
        {

            var connectionString = /*"Data Source=.;Initial Catalog=EmployeeManagementDb;Integrated Security=True";*/
            "Data Source=YH1008679DT\\SQLEXPRESS2014;Initial Catalog=EmployeeManagementDb;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Update_User"))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Name", txtFristName.Text);
                            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());

                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                            cmd.Parameters.AddWithValue("@Gender", RadioButtonList1.SelectedValue);
                            cmd.Parameters.AddWithValue("@DOB", Convert.ToString(txtDob.Text));
                            cmd.Parameters.AddWithValue("@State", drpState.SelectedValue);
                            cmd.Parameters.AddWithValue("@City", drpCity.SelectedValue);
                            cmd.Parameters.AddWithValue("@Nationality", checkNationality.Checked.ToString());
                            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(Request.QueryString["Id"]));
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteScalar();
                            con.Close();
                        }
                    }
                }
             }
            catch (Exception Ex)
            {


            }

        }
    }
}