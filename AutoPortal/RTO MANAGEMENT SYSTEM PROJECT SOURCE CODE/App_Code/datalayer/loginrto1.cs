using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for loginrto1
/// </summary>
public class loginrto1
{
    SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
	public loginrto1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal DataSet getdata(loginrto loginrto)
    {
        SqlCommand cmd = new SqlCommand("select id,password,username from admin1", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}
