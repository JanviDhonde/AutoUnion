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

public partial class HOME_ApplyforLlr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Session["uname"] = TextBox3.Text;
        Session["adate"] = TextBox2.Text;
        Session["chalno"] = TextBox13.Text;
        SqlConnection myConnection = new SqlConnection( @"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        myConnection.Open();
        if (fileImgUpload.HasFile)
        {
            fileImgUpload.SaveAs(Server.MapPath("~/employee/Images/" + fileImgUpload.FileName));
           
        }
        SqlCommand myCommand = new SqlCommand("insert into applyllr(image,date1,name,sdw,dob,bloodg,add1,add2,city,state,phno,ident,licensetype,chalno) values('"+fileImgUpload.FileName+"','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "', '" + TextBox6.Text + "','" + TextBox7.Text + "', '" + TextBox8.Text + "','" + TextBox9.Text + "', '" + TextBox10.Text + "','" + TextBox11.Text + "', '" + TextBox12.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox13.Text + "')", myConnection);
        
        // Mark the Command as a Text
        myCommand.CommandType = CommandType.Text;
        
        
        if (myCommand.ExecuteNonQuery() > 0)
        {
            myConnection.Close();
            Response.Redirect("~/HOME/paymentchalla.aspx");
        }
        else
        {
            Response.Write("<script>alert('not correct')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {


        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
    }
}
