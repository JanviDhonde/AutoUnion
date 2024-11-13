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

public partial class rto_IssuingofLearinglicence : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("select * from llrdetails ", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList3.Items.Add(dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }
        if (IsPostBack == false)
        {
            SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from result where result='Pass' ", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList4.Items.Add(dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }


    }
   

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView3.Visible = false;
        GridView2.Visible = true ;
        try
        {
            // Create Instance of Connection and Command Object
            SqlConnection myConnection = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from llrdetails where name='" + DropDownList3.SelectedItem.Text + "'", myConnection);

            // Mark the Command as a Text
            myCommand.CommandType = CommandType.Text;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);

            GridView2.DataSource = myDataSet;
            GridView2.DataBind();
           
            TextBox1.Text = myDataSet.Tables[0].Rows[0][1].ToString();
            //TextBox2.Text = myDataSet.Tables[0].Rows[0][6].ToString();
            TextBox3.Text = myDataSet.Tables[0].Rows[0][3].ToString();
            TextBox4.Text = myDataSet.Tables[0].Rows[0][4].ToString();
            TextBox5.Text = myDataSet.Tables[0].Rows[0][5].ToString();
            TextBox6.Text = myDataSet.Tables[0].Rows[0][6].ToString();
            TextBox7.Text = myDataSet.Tables[0].Rows[0][7].ToString();
            TextBox9.Text = myDataSet.Tables[0].Rows[0][9].ToString();
            TextBox11.Text = myDataSet.Tables[0].Rows[0][11].ToString();
            TextBox12.Text = myDataSet.Tables[0].Rows[0][12].ToString();
            TextBox13.Text = myDataSet.Tables[0].Rows[0][13].ToString();
            TextBox14.Text = myDataSet.Tables[0].Rows[0][14].ToString();
           
            myConnection.Close();
        }
        catch (SqlException SQLexc)
        {
            Response.Write("Data Retrival Failure. Error Details : " + SQLexc.ToString());
        }
    }

  
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
        SqlCommand cmd = new SqlCommand("insert into issuedllr (llr1,cha1,llr,name,validity,issu,issuby)values('"+DropDownList3.SelectedItem .Text +"','"+DropDownList4 .SelectedItem .Text +"','"+TextBox1 .Text +"','"+TextBox3 .Text +"','"+TextBox14.Text+"','"+DropDownList2 .SelectedItem .Text +"','"+TextBox15 .Text +"') ", con);
        con.Open();
        cmd.ExecuteNonQuery();
        Response.Write("sucessfully Inserted");
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView2.Visible = false;
        GridView3.Visible = true ;
        try
        {
            // Create Instance of Connection and Command Object
            SqlConnection myConnection = new SqlConnection(@"Data Source=EGGG\SKDB;Initial Catalog=roadtransport;Integrated Security=true");
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from applyllr where chalno='" + DropDownList4.SelectedItem.Text + "'", myConnection);

            // Mark the Command as a Text
            myCommand.CommandType = CommandType.Text;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);

            GridView3.DataSource = myDataSet;
            GridView3.DataBind();
            //TextBox1.Text = myDataSet.Tables[0].Rows[0][4].ToString();
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
            //TextBox13.Text = myDataSet.Tables[0].Rows[0][4].ToString();

            TextBox16.Text = myDataSet.Tables[0].Rows[0][12].ToString();
            //TextBox11.Text = myDataSet.Tables[0].Rows[0][13].ToString();
            //TextBox12.Text = myDataSet.Tables[0].Rows[0][14].ToString();
            //TextBox13.Text = myDataSet.Tables[0].Rows[0][15].ToString();
            //TextBox14.Text = myDataSet.Tables[0].Rows[0][16].ToString();
            //TextBox16.Text = myDataSet.Tables[0].Rows[0][17].ToString();
            //TextBox16.Text = myDataSet.Tables[0].Rows[0][9].ToString();
            //TextBox9.Text = myDataSet.Tables[0].Rows[0][16].ToString();
            //TextBox10.Text = myDataSet.Tables[0].Rows[0][17].ToString();

            myConnection.Close();
        }
        catch (SqlException SQLexc)
        {
            Response.Write("Data Retrival Failure. Error Details : " + SQLexc.ToString());
        }

    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
        TextBox14.Text = "";
       
        


    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

