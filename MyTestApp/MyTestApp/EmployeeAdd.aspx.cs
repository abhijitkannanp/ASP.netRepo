using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace MyTestApp
{
    public partial class EmployeeAdd : System.Web.UI.Page
    {

        public SqlConnection con;
        public string constr;

        public void connection()
        {
            constr = ConfigurationManager.ConnectionStrings["CustomerDBConnctionString"].ToString();
            con = new SqlConnection(constr);
            con.Open();

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connection();
            string query = "insert into Employee values ('"+ txtName.Text +"','" + txtAddress.Text + "','" + txtEmail.Text + "')";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            Response.Write("New Record has been Inserted");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeListPage.aspx");
        }
    }
}