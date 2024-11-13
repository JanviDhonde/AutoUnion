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

public partial class employee_viewregisterdetails : System.Web.UI.Page
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
        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter("select * from regdetails where regno='" + TextBox1.Text + "'", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "regdetails");
        GridView1.DataSource = ds;
        GridView1.DataMember = "regdetails";
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter("select * from regdetails ", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "regdetails");
        GridView1.DataSource = ds;
        GridView1.DataMember = "regdetails";
        GridView1.DataBind();
    }
}
