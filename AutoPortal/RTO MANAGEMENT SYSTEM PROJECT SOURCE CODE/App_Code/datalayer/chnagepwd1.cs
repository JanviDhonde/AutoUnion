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
/// Summary description for chnagepwd1
/// </summary>
public class chnagepwd1
{
    SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
	public chnagepwd1()
	{
		//
		// TODO: Add constructor logic here
		//
	}




    internal int updatedata(Changepwd changepwd)
    {
        con.Open();
       
        SqlCommand cmd = new SqlCommand("update  addemp set password= '" + changepwd.password + "' where id='" +changepwd.id+ "'", con);
        
       return  cmd.ExecuteNonQuery();
        
    }
}
