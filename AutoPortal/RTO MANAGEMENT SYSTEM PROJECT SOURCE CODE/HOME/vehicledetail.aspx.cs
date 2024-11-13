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

public partial class HOME_vehicledetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter("select regno,regdate,nameofapp,typeofveh,date1,chassisno,engineno,seatcap,fuel from regdetails", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "regdetails");
        GridView1.DataSource = ds;
        GridView1.DataMember = "regdetails";
        GridView1.DataBind();
    }
}
