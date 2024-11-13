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
/// Summary description for addrenlicence1
/// </summary>
public class addrenlicence1
{
    SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");

	public addrenlicence1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

   

    internal int insertdata(addrenlicence addrenlicence)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("srperlic", con);
        //cmd.CommandText = "srperlic";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@llrno", addrenlicence.llr);
        cmd.Parameters.AddWithValue("@dateofiss", addrenlicence.dateofiss);
        cmd.Parameters.AddWithValue("@dateofren", addrenlicence.dateofren);
        cmd.Parameters.AddWithValue("@typelicence", addrenlicence.typelicence);
        cmd.Parameters.AddWithValue("@name", addrenlicence.name);
        cmd.Parameters.AddWithValue("@sdw", addrenlicence.sdw);
        cmd.Parameters.AddWithValue("@dob", addrenlicence.dob);
        cmd.Parameters.AddWithValue("@bloodg", addrenlicence.bloodg);
        cmd.Parameters.AddWithValue("@add1", addrenlicence.add1);
        cmd.Parameters.AddWithValue("@add2", addrenlicence.add2);
        cmd.Parameters.AddWithValue("@city", addrenlicence.city);
        cmd.Parameters.AddWithValue("@state", addrenlicence.state);
        cmd.Parameters.AddWithValue("@phone", addrenlicence.phone);
        cmd.Parameters.AddWithValue("@ident1", addrenlicence.ident1);
        cmd.Parameters.AddWithValue("@ident2", addrenlicence.ident2);
        cmd.Parameters.AddWithValue("@vfrom", addrenlicence.vfrom);
        cmd.Parameters.AddWithValue("@vto", addrenlicence.vto);
        cmd.Parameters.AddWithValue("@chano", addrenlicence.chano);
        cmd.Parameters.AddWithValue("@amount", addrenlicence.amount);

        return cmd.ExecuteNonQuery();
          }
}
