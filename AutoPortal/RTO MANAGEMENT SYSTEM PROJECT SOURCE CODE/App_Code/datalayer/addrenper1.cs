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
/// Summary description for addrenper1
/// </summary>
public class addrenper1
{
    SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");

	public addrenper1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal int insertdata(addrenper addrenper)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("srrenper1", con);
        //cmd.CommandText = "srperlic";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@llr", addrenper.llr);
        cmd.Parameters.AddWithValue("@dateofiss", addrenper.dateofiss);
        cmd.Parameters.AddWithValue("@dateofren", addrenper.dateofren);
        cmd.Parameters.AddWithValue("@typelicence", addrenper.typelicence);
        cmd.Parameters.AddWithValue("@name", addrenper.name);
        cmd.Parameters.AddWithValue("@sdw", addrenper.sdw);
        cmd.Parameters.AddWithValue("@dob", addrenper.dob);
        cmd.Parameters.AddWithValue("@bloodg", addrenper.bloodg);
        cmd.Parameters.AddWithValue("@add1", addrenper.add1);
        cmd.Parameters.AddWithValue("@add2", addrenper.add2);
        cmd.Parameters.AddWithValue("@city", addrenper.city);
        cmd.Parameters.AddWithValue("@state", addrenper.state);
        cmd.Parameters.AddWithValue("@phone", addrenper.phone);
        cmd.Parameters.AddWithValue("@ident1", addrenper.ident1);
        cmd.Parameters.AddWithValue("@ident2", addrenper.ident2);
        cmd.Parameters.AddWithValue("@vfrom", addrenper.vfrom);
        cmd.Parameters.AddWithValue("@vto", addrenper.vto);
        cmd.Parameters.AddWithValue("@chano", addrenper.chano);
        cmd.Parameters.AddWithValue("@amount", addrenper.amount);

        return cmd.ExecuteNonQuery();
    }
}
