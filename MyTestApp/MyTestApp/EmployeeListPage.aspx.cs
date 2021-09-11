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
    public partial class MyEmployeePage : System.Web.UI.Page
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
            Label2.Visible = false;
        }
        private void rep_bind()
        {
            connection();
            string query = "select * from Employee where Name like '" + TextBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            connection();
            string query = "select Name  from Employee where Name like'" + TextBox1.Text + "%'";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader dr;
            dr = com.ExecuteReader();


            if (dr.HasRows)
            {
                dr.Read();

                rep_bind();
                GridView1.Visible = true;

                TextBox1.Text = "";
                Label2.Text = "";
            }
            else
            {
                GridView1.Visible = false;
                Label2.Visible = true;
                Label2.Text = "The search Term " + TextBox1.Text + " &nbsp;Is Not Available in the Records"; ;

            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeAdd.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeUpdate.aspx");
        }
    }
}