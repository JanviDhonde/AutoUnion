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
/// Summary description for paymentdetail
/// </summary>
public class paymentdetail
{
	public paymentdetail()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _chano;

    public string chano
    {
        get { return _chano; }
        set { _chano = value; }
    }
    private string _chaname;

    public string chaname
    {
        get { return _chaname; }
        set { _chaname = value; }
    }
    private string _chaamount;

    public string chaamount
    {
        get { return _chaamount; }
        set { _chaamount = value; }
    }
    private string _officecode;

    public string officecode
    {
        get { return _officecode; }
        set { _officecode = value; }
    }
    private string _chadate;

    public string chadate
    {
        get { return _chadate; }
        set { _chadate = value; }
    }


    public int insertdata()
    {
        paymentdetail1 obj1 = new paymentdetail1();
        return obj1.insertdata(this);
    }
}
