using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for loginrto
/// </summary>
public class loginrto
{
	public loginrto()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int _empid;

    public int id
    {
        get { return _empid; }
        set { _empid = value; }
    }
    private string _username;

    public string MyProperty
    {
        get { return _username; }
        set { _username = value; }
    }
    private string _password;

    public string password
    {
        get { return _password; }
        set { _password = value; }
    }

    public DataSet getdata()
    {
        loginrto1 obj1 = new loginrto1();
        return obj1.getdata(this);
    }
}
