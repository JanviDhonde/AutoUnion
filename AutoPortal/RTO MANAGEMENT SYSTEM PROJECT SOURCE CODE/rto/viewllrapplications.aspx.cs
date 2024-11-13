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

public partial class rto_viewllrapplications : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("~/HOME/EMPLOYEES.aspx");
        }
        if(Request.QueryString["id"]!=null)
        {
            int d = int.Parse(Request.QueryString["id"]);
        }
        
        
        try
        {
            // Create Instance of Connection and Command Object
            SqlConnection myConnection = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from applyllr where chalno='"+int.Parse(Request.QueryString["id"])+"'", myConnection);

            // Mark the Command as a Text
            myCommand.CommandType = CommandType.Text;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);

            GridView2.DataSource = myDataSet;
            GridView2.DataBind();

            //TextBox2.Text = myDataSet.Tables[0].Rows[0][6].ToString();
            TextBox3.Text = myDataSet.Tables[0].Rows[0][2].ToString();
            TextBox4.Text = myDataSet.Tables[0].Rows[0][3].ToString();
            TextBox5.Text = myDataSet.Tables[0].Rows[0][4].ToString();
            TextBox6.Text = myDataSet.Tables[0].Rows[0][5].ToString();
            TextBox7.Text = myDataSet.Tables[0].Rows[0][6].ToString();
            TextBox9.Text = myDataSet.Tables[0].Rows[0][8].ToString();
            TextBox10.Text = myDataSet.Tables[0].Rows[0][9].ToString();
            TextBox11.Text = myDataSet.Tables[0].Rows[0][10].ToString();
            TextBox12.Text = myDataSet.Tables[0].Rows[0][11].ToString();
            

            TextBox16.Text = myDataSet.Tables[0].Rows[0][12].ToString();
            // TextBox15.Text = myDataSet.Tables[0].Rows[0][9].ToString();
            //TextBox9.Text = myDataSet.Tables[0].Rows[0][16].ToString();
            //TextBox10.Text = myDataSet.Tables[0].Rows[0][17].ToString();

            myConnection.Close();
            myConnection.Open();
            SqlCommand myCommand1 = new SqlCommand("select * from issuedllr  where cha1='" + int.Parse(Request.QueryString["id"]) + "'", myConnection);

            // Mark the Command as a Text
            myCommand1.CommandType = CommandType.Text;
            SqlDataReader dr = myCommand1.ExecuteReader();
            if (dr.Read())
            {
                TextBox1.Text = dr[3].ToString();
                TextBox14.Text = dr[5].ToString();
                TextBox17.Text = dr[6].ToString();
                TextBox15.Text = dr[7].ToString();
            }

        }

        catch (SqlException SQLexc)
        {
            Response.Write("Data Retrival Failure. Error Details : " + SQLexc.ToString());
        }

    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
