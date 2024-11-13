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

public partial class HOME_EMPLOYEES : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        insertdata();
    }

    private void insertdata()
    {
        try
        {
       
        login obj = new login();
        obj.empid =int.Parse( TextBox1.Text);
        obj.password = TextBox2.Text;
        DataSet ds = new DataSet();
        ds = obj.insertdata();

        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["id"].ToString() == TextBox1.Text)
            {
                if (ds.Tables[0].Rows[0]["password"].ToString() == TextBox2.Text)
                {
                    Session["username"] = ds.Tables[0].Rows[0]["name"].ToString();
                    Session["ID"] = ds.Tables[0].Rows[0]["id"].ToString();
                    Response.Redirect("~/employee/welcomeemp.aspx");
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "incorrect matching";
            }
        }
        }
            catch(Exception ex)
        {
                Response.Write(ex.Message);
            }


       
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}