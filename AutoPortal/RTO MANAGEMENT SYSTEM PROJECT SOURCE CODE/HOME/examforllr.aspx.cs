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

public partial class HOME_examforllr : System.Web.UI.Page
{
    int n, n1, n2, n3, n4, n5, n6, n7, n8, n9;
    //var _StopWatch = new StopWatch();
    SqlConnection cn = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
       

         Session["exam"] = TextBox4.Text;
        TextBox3.Text = Session["uname"].ToString();
        TextBox2.Text = Session["chalno"].ToString();
        TextBox1.Text = Session["adate"].ToString();
        string str1;
        str1 = "select max(examno)from llrexam ";
        cmd = new SqlCommand(str1, cn);
        SqlDataReader dr;
        cn.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read())
            TextBox4.Text = dr[0].ToString();
        dr.Close();
        cn.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //string str=String.Empty;
        //str = "insert into llrexam(ans1,ans2,ans3,ans4,ans5,ans6,ans7,ans8,ans9,ans10,name,edate,chalno) values ('" + RadioButtonList1.SelectedItem.Text + "','" + RadioButtonList11.SelectedItem.Text + "','" + RadioButtonList3.SelectedItem.Text + "','" + RadioButtonList4.SelectedItem.Text + "','" + RadioButtonList5.SelectedItem.Text + "','" + RadioButtonList6.SelectedItem.Text + "','" + RadioButtonList7.SelectedItem.Text + "','" + RadioButtonList8.SelectedItem.Text + "','" + RadioButtonList9.SelectedItem.Text + "','" + RadioButtonList10.SelectedItem.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + TextBox1.Text + "')";
        cn.Open();
        SqlCommand cmd = new SqlCommand("insert into llrexam(ans1,ans2,ans3,ans4,ans5,ans6,ans7,ans8,ans9,ans10,name,edate,chalno) values ('" + RadioButtonList1.SelectedItem.Text + "','" + RadioButtonList11.SelectedItem.Text + "','" + RadioButtonList3.SelectedItem.Text + "','" + RadioButtonList4.SelectedItem.Text + "','" + RadioButtonList5.SelectedItem.Text + "','" + RadioButtonList6.SelectedItem.Text + "','" + RadioButtonList7.SelectedItem.Text + "','" + RadioButtonList8.SelectedItem.Text + "','" + RadioButtonList9.SelectedItem.Text + "','" + RadioButtonList10.SelectedItem.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + TextBox1.Text + "')", cn);
        //Timer1.Enabled = false;
        SqlDataReader dr;
      
        dr = cmd.ExecuteReader();
       
          if (RadioButtonList1.SelectedItem.Text=="Red")
        {

            n = 1;

        }

        else
        {
            n = 0;
        }
     
        if (RadioButtonList11.SelectedItem.Text == "No")
        {

            n1 = 1+n;

        }

        else
        {
            n1 = 0+n;
        }
        if (RadioButtonList3.SelectedItem.Text == "Green")
        {

            n2 =n1+ 1;

        }

        else
        {
            n2 = n1+0;
        }
          if (RadioButtonList4.SelectedItem.Text== "slow down & pass on the ")
        {

            n3 = n2+1;

        }

        else
        {
            n3 = n2+0;
        }
        
        if (RadioButtonList5.SelectedItem.Text== "stop until the lights turn greed")
        {

            n4 = n3+1;

        }

        else
        {
            n4 = n3+0;
        }
        
        if (RadioButtonList6.SelectedItem.Text == "do not use lights")
        {

            n5 = n4+1;

        }

        else
        {
            n5 = n4+0;
        }
        if (RadioButtonList7.SelectedItem.Text == "Speed Up")
        {

            n6 = n5+1;

        }

        else
        {
            n6 = n5+0;
        }
        
        if (RadioButtonList8.SelectedItem.Text == "Red")
        {

            n7 = 1+n6;

        }

        else
        {
            n7 = 0+n6;
        }
         if (RadioButtonList9.SelectedItem.Text == "No")
        {

            n8 = 1+n7;

        }

        else
        {
            n8 = 0+n7;
        }
        if (RadioButtonList10.SelectedItem.Text == "according to signals")
        {
            n9 = 1 + n8;
           
        }

        else
        {
            n9 = 0 + n8;
        }
     
    
     Session["cnt"] = n9;
        Response.Redirect("~/HOME/result.aspx");
    }
 
   
}
