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
            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=DESKTOP-6G1H7Q6;Initial Catalog=EmployeeManagementDb;Integrated Security=True";
            int userId = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Insert_User"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", txtFristName.Text + "" + txtLastName);
                        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPwd.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", RadioButtonList1.SelectedValue);
                        cmd.Parameters.AddWithValue("@DOB", Convert.ToString(txtDob));
                        cmd.Parameters.AddWithValue("@State", drpState.SelectedValue);
                        cmd.Parameters.AddWithValue("@City", drpCity.SelectedValue);
                        cmd.Parameters.AddWithValue("@Nationality", checkNationality.Checked.ToString());
                        cmd.Parameters.AddWithValue("@Active", 1);
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
}