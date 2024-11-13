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

public partial class rto_perminentlicencedetail : System.Web.UI.Page
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

        SqlConnection myConnection= new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        myConnection.Open();
        SqlCommand myCommand = new SqlCommand("select * from pldetails where plno='" + TextBox1.Text + "'", myConnection);

        // Mark the Command as a Text
        myCommand.CommandType = CommandType.Text;

        SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
        DataSet myDataSet = new DataSet();
        myAdapter.Fill(myDataSet);

        GridView1.DataSource = myDataSet;
        GridView1.DataBind();

        myConnection.Close();
    }
  
    
    protected void Button2_Click(object sender, EventArgs e)
    {
         
        // Create Instance of Connection and Command Object

        SqlConnection myConnection= new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        myConnection.Open();
        SqlCommand myCommand = new SqlCommand("select * from pldetails ", myConnection);

        // Mark the Command as a Text
        myCommand.CommandType = CommandType.Text;

        SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
        DataSet myDataSet = new DataSet();
        myAdapter.Fill(myDataSet);

        GridView1.DataSource = myDataSet;
        GridView1.DataBind();

        myConnection.Close();
    }
}
