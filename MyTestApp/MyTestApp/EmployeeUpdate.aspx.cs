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
    public partial class EmployeeUpdate : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            connection();
            string query = "select * from Employee where Name like'" + txtName.Text + "%'";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader dr;
            dr = com.ExecuteReader();


            if (dr.HasRows)
            {
                dr.Read();
               
               txtAddress.Text = dr["Address"].ToString();
               txtEmail.Text = dr["Email"].ToString();

               
            }
            else
            {
                
               Response.Write("The search Term " + txtName.Text + " &nbsp;Is Not Available in the Records");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connection();
            string query = "update Employee set Address= '" + txtAddress.Text + "', Email ='" + txtEmail.Text  + "' where Name='" + txtName.Text +  "'";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            Response.Write(" Record has been Updated");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeListPage.aspx");
        }
    }
}