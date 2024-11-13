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
/// Summary description for login
/// </summary>
public class login
{
	public login()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int _empid;

    public int empid
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
    private string _phone;

    public string phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    private string _adress;

    public string adress
    {
        get { return _adress; }
        set { _adress = value; }
    }



    public DataSet insertdata()
    {
        login1 obj1 = new login1();
        return obj1.insertdata(this);
    }

    public object getdata()
    {
        throw new Exception("The method or operation is not implemented.");
    }
}
