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
/// Summary description for addperlicence
/// </summary>
public class addperlicence
{
	public addperlicence()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _image;

    public string image
    {
        get { return _image; }
        set { _image = value; }
    }
    private string _plno;

    public string plno
    {
        get { return _plno; }
        set { _plno = value; }
    }
    private string _ldate;

    public string ldate
    {
        get { return _ldate; }
        set { _ldate = value; }
    }
    private string _name;

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _swd;

    public string swd
    {
        get { return _swd; }
        set { _swd = value; }
    }
    private string _dob;

    public string dob
    {
        get { return _dob; }
        set { _dob = value; }
    }
    private string _bg;

    public string bg
    {
        get { return _bg; }
        set { _bg = value; }
    }
    private string _a1;

    public string a1
    {
        get { return _a1; }
        set { _a1 = value; }
    }
    private string _a2;

    public string a2
    {
        get { return _a2; }
        set { _a2 = value; }
    }
    private string _city;

    public string city
    {
        get { return _city; }
        set { _city = value; }
    }
    private string _state;

    public string state
    {
        get { return _state; }
        set { _state = value; }
    }
    private string _phone;

    public string phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    private string _mark;

    public string mark
    {
        get { return _mark; }
        set { _mark = value; }
    }
    private string _vfrom;

    public string vfrom
    {
        get { return _vfrom; }
        set { _vfrom = value; }
    }
    private string _vto;

    public string vto
    {
        get { return _vto; }
        set { _vto = value; }
    }
    private string _type;

    public string type
    {
        get { return _type; }
        set { _type = value; }
    }

    public int insertdata()
    {
        //throw new Exception("The method or operation is not implemented.");
        addperlicence1 obj1 = new addperlicence1();
        return obj1.insertdata(this);
    }
}
