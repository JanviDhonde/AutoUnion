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

public partial class rto_IssuingofPerminentLicence : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("~/HOME/EMPLOYEES.aspx");
        }
         if (IsPostBack == false)
        {
    SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from pldetails ", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }


    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

  
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlCommand cmd = new SqlCommand("insert into issuedpl (plno,name,issuat,issuby)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox8.Text + "') ", con);
        con.Open();
        cmd.ExecuteNonQuery();
        Response.Write("sucessfully inserted");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            // Create Instance of Connection and Command Object
            
    SqlConnection myConnection = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from pldetails where plno='" + DropDownList1.SelectedItem.Text + "'", myConnection);

            // Mark the Command as a Text
            myCommand.CommandType = CommandType.Text;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);

            GridView1.DataSource = myDataSet;
            GridView1.DataBind();
            TextBox1.Text = myDataSet.Tables[0].Rows[0][1].ToString();
            TextBox2.Text = myDataSet.Tables[0].Rows[0][3].ToString();
            TextBox3.Text = myDataSet.Tables[0].Rows[0][7].ToString();
            TextBox4.Text = myDataSet.Tables[0].Rows[0][15].ToString();
            TextBox5.Text = myDataSet.Tables[0].Rows[0][2].ToString();
            TextBox6.Text = myDataSet.Tables[0].Rows[0][6].ToString();
            TextBox9.Text = myDataSet.Tables[0].Rows[0][13].ToString();
            //TextBox10.Text = myDataSet.Tables[0].Rows[0][17].ToString();

            myConnection.Close();
        }
        catch (SqlException SQLexc)
        {
            Response.Write("Data Retrival Failure. Error Details : " + SQLexc.ToString());
        }
    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";

        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        //TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
       

    }
}
