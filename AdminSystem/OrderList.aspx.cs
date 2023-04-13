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
        lstOrdersList.DataTextField = "DeliveryType";
        //bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void lstOrdersList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}