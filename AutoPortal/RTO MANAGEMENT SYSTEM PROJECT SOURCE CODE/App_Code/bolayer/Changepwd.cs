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
/// Summary description for Changepwd
/// </summary>
public class Changepwd
{
	public Changepwd()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int _id;

    public int id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _name;

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _password;

    public string password
    {
        get { return _password; }
        set { _password = value; }
    }
	

    public int updatedata()
    {
        chnagepwd1 obj1 = new chnagepwd1();
        return obj1.updatedata(this);
    }
}
