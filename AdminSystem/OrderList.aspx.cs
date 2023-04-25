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
        //if this is first time page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        //set the data source to list of addresses in the collection
        lstOrdersList.DataSource = Orders.OrdersList;
        //set name of primary key
        lstOrdersList.DataValueField = "OrderId";
        //set the data fiel to display
        lstOrdersList.DataTextField = "OrderId";
        //bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void lstOrdersList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1) 
        {
            //get the primary key of the record to edit
            OrderId = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1) 
        {
            //get the primary key value of the record to be deleted
            OrderId = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list"; 
        }


    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportbyDeliveryType(txtFilter.Text);
        lstOrdersList.DataSource = Orders.OrdersList;
        //set name of the primary key
        lstOrdersList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrdersList.DataTextField = "OrderId";
        //bind the data to the list
        lstOrdersList.DataBind();


    }


    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the orders collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportbyDeliveryType("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrdersList.DataSource = Orders.OrdersList;
        //set the name of primary key
        lstOrdersList.DataValueField = "OrderId";
        //set the name of the field to diaplay
        lstOrdersList.DataTextField = "OrderId";
        //bind the data to the list
        lstOrdersList.DataBind();
    }
}