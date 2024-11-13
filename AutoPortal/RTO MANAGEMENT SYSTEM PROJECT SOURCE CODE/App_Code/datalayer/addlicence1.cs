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
/// Summary description for addlicence1
/// </summary>
public class addlicence1
{

    SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
	public addlicence1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    
internal int insertdata(addlicence addlicence)
{
    con.Open();
 	//throw new Exception("The method or operation is not implemented.");
    SqlCommand cmd = new SqlCommand("insert into llrdetails values('" + addlicence.image + "'," + addlicence.llrno + ",'" + addlicence.ldate + "','" + addlicence.name + "','" + addlicence.swd + "','" + addlicence.dob + "','" + addlicence.bg + "','" + addlicence.a1 + "','" + addlicence.a2 + "','" + addlicence.city + "','" + addlicence.state + "','" + addlicence.phone + "','" + addlicence.mark + "','" + addlicence.vfrom + "','" + addlicence.vto + "','" + addlicence.type + "')", con);
    return cmd.ExecuteNonQuery();

}

}
