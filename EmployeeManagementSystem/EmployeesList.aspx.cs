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
    public partial class EmployeesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                "Data Source=DESKTOP-6G1H7Q6;Initial Catalog=EmployeeManagementDb;Integrated Security=True";
                conn.Open();


                SqlCommand sqlcmd = new SqlCommand("Select * From EmpTable", conn);

                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

                da.Fill(dt);
                EmployeeListGridView.DataSource  = dt;
                EmployeeListGridView.DataBind();
                conn.Close();
                
            }

            catch (Exception Ex)
            {

            }

            
        }
    }
}