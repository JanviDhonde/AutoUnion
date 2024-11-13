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

public partial class HOME_result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["uname"].ToString();
        Label6.Text = Session["exam"].ToString();
        Label2.Text = Session["chalno"].ToString();
        Label3.Text = Session["adate"].ToString();
        Label4.Text = Session["cnt"].ToString();
        if (Int32.Parse(Label4.Text) >= 4)
        {
            Label5.Text = "Pass";

        }
        else
        {
            Label5.Text = "Fail";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlCommand cmd = new SqlCommand("insert into result values('" + Label1.Text + "','" + Label6.Text + "','" + Label2.Text + "','" + Label3.Text + "','" + Label4.Text + "','" + Label5.Text + "')", con);
        con.Open();
        cmd.ExecuteNonQuery();

        if (Label5.Text == "Pass")
        {
            Response.Redirect("pass.aspx");

        }
        else
        {
            Response.Redirect("fail.aspx");
        }

    }
}
