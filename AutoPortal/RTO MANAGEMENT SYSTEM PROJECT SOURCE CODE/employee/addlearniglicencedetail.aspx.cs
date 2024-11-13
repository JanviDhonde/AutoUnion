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

public partial class employee_addlearniglicencedetail : System.Web.UI.Page
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
        addlicence obj = new addlicence();
        if (fileImgUpload.HasFile)
        {
            fileImgUpload.SaveAs(Server.MapPath("~/employee/Images/" + fileImgUpload.FileName));
            obj.image = fileImgUpload.FileName;
        }
       
        obj.llrno = int.Parse(TextBox15.Text);
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text="";
        TextBox7.Text = "";
        TextBox8.Text = "";
       
        TextBox10.Text = "";
        TextBox12.Text = "";
        TextBox11.Text = "";
        TextBox13.Text = "";
        TextBox14.Text = "";
        TextBox15.Text = "";
    }
}
