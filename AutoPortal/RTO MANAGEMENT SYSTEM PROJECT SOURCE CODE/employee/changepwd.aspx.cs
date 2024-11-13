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

public partial class employee_changepwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("~/HOME/EMPLOYEES.aspx");
        }
        TextBox1.Text = Session["ID"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        updatedata();
    }

    private void updatedata()
    {
       
        Changepwd obj = new Changepwd();
        obj.id = int.Parse(TextBox1.Text);
        obj.name = TextBox2.Text;
        obj.password = TextBox4.Text;
        int result;
        result = obj.updatedata();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";

    }
}
