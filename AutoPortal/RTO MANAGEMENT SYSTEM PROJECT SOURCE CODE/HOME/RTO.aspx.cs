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

public partial class HOME_RTO : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        GetData();
    }

    private void GetData()
    {

        loginrto obj = new loginrto();
        obj.id = int.Parse(TextBox1.Text);
        obj.password = TextBox2.Text;
        DataSet ds = new DataSet();
        ds = obj.getdata();
        Session["username"] = ds.Tables[0].Rows[0]["username"].ToString();
        Session["id"] = ds.Tables[0].Rows[0]["id"].ToString();
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["id"].ToString() == TextBox1.Text)
            {
                if (ds.Tables[0].Rows[0]["password"].ToString() == TextBox2.Text)
                {
                    Response.Redirect("~/RTO/home.aspx");
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "incorrect matching";
            }

        }
    }
}
