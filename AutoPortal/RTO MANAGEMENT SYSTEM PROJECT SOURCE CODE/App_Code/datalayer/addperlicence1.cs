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
/// Summary description for addperlicence1
/// </summary>
public class addperlicence1
{
     SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");

	public addperlicence1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
   
internal int insertdata(addperlicence addperlicence)
{
 	//throw new Exception("The method or operation is not implemented.");
    con.Open();
 	//throw new Exception("The method or operation is not implemented.");
    SqlCommand cmd = new SqlCommand("insert into pldetails values('" + addperlicence.image + "'," + addperlicence.plno + ",'" + addperlicence.ldate + "','" + addperlicence.name + "','" + addperlicence.swd + "','" + addperlicence.dob + "','" + addperlicence.bg + "','" + addperlicence.a1 + "','" + addperlicence.a2 + "','" + addperlicence.city + "','" + addperlicence.state + "','" + addperlicence.phone + "','" + addperlicence.mark + "','" + addperlicence.vfrom + "','" + addperlicence.vto + "','" + addperlicence.type + "')", con);
    return cmd.ExecuteNonQuery();

}

}
