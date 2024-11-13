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

public partial class HOME_licholderdetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter("select llrno,ldate,name,swd,dob,bg,a1,a2,city,state,phone,mark,vfrom,vto,type from llrdetails", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "llrdetails");
        GridView1.DataSource = ds;
        GridView1.DataMember = "llrdetails";
        GridView1.DataBind();
    }
}
