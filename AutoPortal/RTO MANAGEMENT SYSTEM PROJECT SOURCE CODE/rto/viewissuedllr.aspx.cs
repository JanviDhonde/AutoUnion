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

public partial class rto_viewissuedllr : System.Web.UI.Page
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
        ////SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        ////SqlCommand cmd = new SqlCommand("select cha1 from issuedllr where cha1= '" + TextBox2.Text + "'", con);
        ////con.Open();
        ////SqlDataReader dr = cmd.ExecuteReader();
        ////if (dr.Read())
        ////{
        ////    Session["cha"] = dr[0].ToString();
        ////    Response.Redirect("viewllrapplications.aspx?id=");
        ////}
        ////else
        ////    Page.RegisterStartupScript("a", "<script> alert('under processing') </script>");

        int cha = int.Parse(TextBox2.Text);
        Response.Redirect("viewllrapplications.aspx?id="+cha);
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
