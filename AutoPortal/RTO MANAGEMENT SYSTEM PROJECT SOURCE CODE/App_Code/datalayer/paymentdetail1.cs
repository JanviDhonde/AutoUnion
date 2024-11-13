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
/// Summary description for paymentdetail1
/// </summary>
public class paymentdetail1
{
    SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");

	public paymentdetail1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal int insertdata(paymentdetail paymentdetail)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("srpayment", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@chano", paymentdetail.chano);
        cmd.Parameters.AddWithValue("@chaname", paymentdetail.chaname);
        cmd.Parameters.AddWithValue("@chaamount", paymentdetail.chaamount);
        cmd.Parameters.AddWithValue("@officecode", paymentdetail.officecode);
        cmd.Parameters.AddWithValue("@chadate", paymentdetail.chadate);
        return cmd.ExecuteNonQuery();




           }
}
