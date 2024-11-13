using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class employee_viewissuedllrdetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("~/HOME/EMPLOYEES.aspx");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Create Instance of Connection and Command Object
        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");

        con.Open();
        SqlCommand myCommand = new SqlCommand("select * from llrdetails where llrno='" + TextBox1.Text + "'", con);

        // Mark the Command as a Text
        myCommand.CommandType = CommandType.Text;

        SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
        DataSet myDataSet = new DataSet();
        myAdapter.Fill(myDataSet);

        GridView1.DataSource = myDataSet;
        GridView1.DataBind();

       con.Close();

    }



        // Create Instance of Connection and Command Object
      

    protected void  Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");

       con.Open();
        SqlCommand myCommand = new SqlCommand("select * from llrdetails ",con);

        // Mark the Command as a Text
        myCommand.CommandType = CommandType.Text;

        SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
        DataSet myDataSet = new DataSet();
        myAdapter.Fill(myDataSet);

        GridView1.DataSource = myDataSet;
        GridView1.DataBind();

        con.Close();


}
}
