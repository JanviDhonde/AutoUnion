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

public partial class employee_addregdetails : System.Web.UI.Page
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

        con.Open();
        String s = "insert into regdetails values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "', '" + TextBox6.Text + "','" + TextBox7.Text + "', '" + TextBox8.Text + "','" + TextBox9.Text + "', '" + TextBox10.Text + "','" + TextBox11.Text + "','" + DropDownList1.SelectedItem.Text + "', '" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "', '" + TextBox15.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox16.Text + "')";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Label1.Visible = true;
        Label1.Text = "values r inserted";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        TextBox1.Text = " ";
        TextBox2.Text = " ";
        TextBox3.Text = " ";
        TextBox4.Text = " ";
        TextBox5.Text = " ";
        TextBox6.Text = " ";
        TextBox7.Text = " ";
        TextBox8.Text = " ";
        TextBox9.Text = " ";
        TextBox10.Text = " ";
        TextBox11.Text = " ";
        TextBox12.Text = " ";
        TextBox13.Text = " ";
        TextBox14.Text = " ";
        TextBox15.Text = " ";
        TextBox16.Text = " ";
    }
}
