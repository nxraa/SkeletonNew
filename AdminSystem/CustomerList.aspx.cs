using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }


    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "ID";
        lstCustomerList.DataTextField = "Name";
        lstCustomerList.DataBind();

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = -1;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ID;
        if( lstCustomerList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = ID;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}