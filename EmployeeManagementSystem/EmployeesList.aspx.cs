using System;
using System.Collections;
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
            ArrayList Array_L = new ArrayList();
            
            Array_L.Add("One");
            Array_L.Add("two");
            Array_L.Add(2);
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Hike");
           
            gvarray.DataSource = dt1;
            gvarray.DataBind();
            DataTable dt = new DataTable();
            DataColumn hike = new DataColumn();
            dt.Columns.Add(hike);
            DataTable EmployeeData = new DataTable();
            EmployeeData.Columns.Add("Name");
            EmployeeData.Columns.Add("UserName");
            EmployeeData.Columns.Add("Password");
            EmployeeData.Columns.Add("Email");
            EmployeeData.Columns.Add("Mobile");
            EmployeeData.Columns.Add("Gender");
            EmployeeData.Columns.Add("DOB");
            EmployeeData.Columns.Add("State");
            EmployeeData.Columns.Add("City");
            EmployeeData.Columns.Add("Nationality");
            EmployeeData.Columns.Add("Active");
            EmployeeData.Columns.Add("Hike");
            EmployeeData.Columns.Add("Salary");
            try
            {

                ArrayList arrylist = new ArrayList();
                DataSet dataSet = new DataSet();
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                "Data Source=YH1008679DT\\SQLEXPRESS2014;Initial Catalog=EmployeeManagementDb;Integrated Security=True";
                conn.Open();

                SqlDataAdapter adp = new SqlDataAdapter("select * from EmpTable Join Salary on EmpTable.Id = Salary.Emoloyee_Id", conn);
                adp.Fill(dt);
                conn.Close();
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("select * from EmpTable Join Salary on EmpTable.Id = Salary.Emoloyee_Id", conn);
                
                SqlDataReader reader = sqlcmd.ExecuteReader();
               
                DataTable dtHike = new DataTable();
                DataColumn dataColumn = new DataColumn();
                dataColumn.ColumnName = "Hike";
                dtHike.Columns.Add(dataColumn);
               
                if (reader.HasRows) {
                    while (reader.Read()) {
                        DataRow row = EmployeeData.NewRow();
                        row["Name"] = reader["Name"];
                        row["UserName"] = reader["UserName"];
                        row["Hike"] = (Convert.ToDouble(reader["Amount"]) * 0.1);
                        row["Password"] = reader["Password"];
                        row["Email"] = reader["Email"];
                        row["Mobile"] = reader["Mobile"];
                        row["Gender"] = reader["Gender"];
                        row["DOB"] = reader["DOB"];
                        row["State"] = reader["State"];
                        row["City"] = reader["City"];
                        row["Nationality"] = reader["Nationality"];
                        row["Active"] = reader["Active"];
                        row["Salary"] = reader["Amount"];
                        EmployeeData.Rows.Add(row);

        //var  rowdsadsd = dtHike.NewRow();
        // rowdsadsd["Hike"] = ((reader.GetDecimal(14)) * (1 / 10));
        // dt.Rows.Add(rowdsadsd);
        //arrylist.Add(reader.GetDecimal(14)); 
        ////dtHike.Rows.Add(row.Cells[0].Text, row.Cells[1].Text);
                        //double v = Convert.ToDouble((reader.GetDecimal(14)));
                        //double c = 10 / 100;
                        //double r = v * 0.1;
                        //arrylist.Add(r);
                        

                    }
                    for (int i = 0; i < arrylist.Count; i++)
                    {
                        dt1.Rows.Add();
                        dt1.Rows[i]["Hike"] = arrylist[i].ToString();
                    }
                }

                //adp.Fill(dt);
                dataSet.Tables.Add(dt);
                dataSet.Tables.Add(dt1);





                EmployeeListGridView.DataSource = EmployeeData;
                EmployeeListGridView.DataBind();
                GridView1.DataSource = arrylist;
                GridView1.DataBind();
                conn.Close();



            }

            catch (Exception Ex)
            {

            }

            
        }
    }
}