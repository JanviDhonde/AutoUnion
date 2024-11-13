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

public partial class employee_paymentdetails : System.Web.UI.Page
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
        paymentdetail obj = new paymentdetail();
        obj.chano = TextBox1.Text;
        obj.chaname = TextBox2.Text;
        obj.chaamount = TextBox3.Text;
        obj.officecode = TextBox4.Text;
        obj.chadate = TextBox5.Text;
        int result;
        result = obj.insertdata();
        if (result > 0)
        {
            Response.Write("<script>alert('inserted')</script>");
        }
        else
        {
            Response.Write("<script>alert('not inserted')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }
}
