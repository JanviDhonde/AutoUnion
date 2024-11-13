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

public partial class rto_ExamResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("~/HOME/EMPLOYEES.aspx");
        }
if (IsPostBack == false)
        {
           SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from result", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                DropDownList1.Items.Add(dr[1].ToString());
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter("select * from result where examno='"+DropDownList1.SelectedItem .Text +"'",con);
        DataSet ds = new DataSet();
        da.Fill(ds, "result");
        GridView2.DataSource = ds;
        GridView2.DataMember = "result";
        GridView2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter("select * from result", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "result");
        GridView2.DataSource = ds;
        GridView2.DataMember = "result";
        GridView2.DataBind();
    }
    }

