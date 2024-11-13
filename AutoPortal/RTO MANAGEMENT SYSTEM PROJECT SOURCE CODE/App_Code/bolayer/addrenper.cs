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
/// Summary description for addrenper
/// </summary>
public class addrenper
{
	public addrenper()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _llr;

    public string llr
    {
        get { return _llr; }
        set { _llr = value; }
    }
    private string _dateofiss;

    public string dateofiss
    {
        get { return _dateofiss; }
        set { _dateofiss = value; }
    }
    private string _dateofren;

    public string dateofren
    {
        get { return _dateofren; }
        set { _dateofren = value; }
    }
    private string _typelicence;

    public string typelicence
    {
        get { return _typelicence; }
        set { _typelicence = value; }
    }
    private string _name;

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _sdw;

    public string sdw
    {
        get { return _sdw; }
        set { _sdw = value; }
    }
    private string _dob;

    public string dob
    {
        get { return _dob; }
        set { _dob = value; }
    }
    private string _bloodg;

    public string bloodg
    {
        get { return _bloodg; }
        set { _bloodg = value; }
    }
    private string _add1;

    public string add1
    {
        get { return _add1; }
        set { _add1 = value; }
    }
    private string _add2;

    public string add2
    {
        get { return _add2; }
        set { _add2 = value; }
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
    private string _ident1;

    public string ident1
    {
        get { return _ident1; }
        set { _ident1 = value; }
    }
    private string _ident2;

    public string ident2
    {
        get { return _ident2; }
        set { _ident2 = value; }
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
    private string _chano;

    public string chano
    {
        get { return _chano; }
        set { _chano = value; }
    }
    private string _amount;

    public string amount
    {
        get { return _amount; }
        set { _amount = value; }
    }



    public int insertdata()
    {

        addrenper1 obj1 = new addrenper1();
        return obj1.insertdata(this);
    }

    
}
