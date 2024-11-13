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

public partial class employee_addperminentlicencedetail : System.Web.UI.Page
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
        //throw new Exception("The method or operation is not implemented.");
        addperlicence obj = new addperlicence();
        if (fileImgUpload.HasFile)
        {
            fileImgUpload.SaveAs(Server.MapPath("~/IMAGES/" + fileImgUpload.FileName));
            obj.image = fileImgUpload.FileName;
        }
   
        obj.plno = TextBox1.Text;
        obj.ldate = TextBox2.Text;
        obj.name = TextBox3.Text;
        obj.swd = TextBox4.Text;
        obj.dob = TextBox5.Text;
        obj.bg = TextBox6.Text;
        obj.a1 = TextBox7.Text;
        obj.a2 = TextBox8.Text;
        obj.city = TextBox9.Text;
        obj.state = TextBox10.Text;
        obj.phone = TextBox11.Text;
        obj.mark = TextBox12.Text;
        obj.vfrom = TextBox13.Text;
        obj.vto = TextBox14.Text;
        obj.type = DropDownList1.SelectedItem.Text;
        int result;
        result = obj.insertdata();

        if (result > 0)
        {
            Label1.Visible = true;
            Label1.Text = "INSERTED";
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "NOT INSERTED";
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
