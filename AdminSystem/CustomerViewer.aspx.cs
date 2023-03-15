using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer aCustomer = new clsCustomer();
        aCustomer = (clsCustomer)Session["aCustomer"];
        Response.Write(aCustomer.Name);
        Response.Write(aCustomer.ID);
        Response.Write(aCustomer.Pass);
        Response.Write(aCustomer.Email);
        Response.Write(aCustomer.DateAdded);
        Response.Write(aCustomer.Active);


    }
}