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

public partial class employee_addrenewalperminentdetail : System.Web.UI.Page
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
        insertdata();
    }

    private void insertdata()
    {
          addrenper obj = new addrenper();
        obj.llr = TextBox1.Text;
        obj.dateofiss = TextBox2.Text;
        obj.dateofren = TextBox3.Text;
        obj.typelicence = DropDownList1.SelectedItem.Text;
        obj.name = TextBox4.Text;
        obj.sdw = TextBox5.Text;
        obj.dob = TextBox6.Text;
        obj.bloodg=TextBox7.Text;
        obj.add1 = TextBox8.Text;
        obj.add2 = TextBox9.Text;
        obj.city = TextBox10.Text;
        obj.state = TextBox11.Text;
        obj.phone = TextBox12.Text;
        obj.ident1 = TextBox13.Text;
        obj.ident2 = TextBox14.Text;
        obj.vfrom = TextBox15.Text;
        obj.vto = TextBox16.Text;
        obj.chano = TextBox17.Text;
        obj.amount = TextBox18.Text;
        int result;
        result = obj.insertdata();
        if (result > 0)
        {
            Response.Write("<script>alert('INSERTED')</script>");
        }
        else
        {
            Response.Write("<script>alert('NOT INSERTED')</script>");
        }
    }
    }

