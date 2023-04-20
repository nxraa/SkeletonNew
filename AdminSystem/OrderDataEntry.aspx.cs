using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {

        //create a new instance of clsOrders
        clsOrders AnOrders = new clsOrders();
        string DeliveryType = txtDeliveryType.Text;
        string ProductId = txtProductId.Text;
        string QuantityNo = txtQuantity.Text;
        string OrderDate = txtOrderDate.Text;
        AnOrders.OrderCompleted = chkOrderCompleted.Checked;// add to add it so chek box would work
        //variable to store any error messages
        string Error = "";
        //Validate the data
        Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
        if (Error == "")
        {
            //capture
            AnOrders.DeliveryType = DeliveryType;
            AnOrders.ProductId = Convert.ToInt32(ProductId);
            AnOrders.QuantityNo = Convert.ToInt32(QuantityNo);
            AnOrders.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrders.OrderCompleted = chkOrderCompleted.Checked;
            //create new instance of the orders collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();
            //set the ThisOrder Property
            OrdersList.ThisOrder = AnOrders;
            //add the new record
            OrdersList.Add();
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;

        }
         
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the orders class
        clsOrders AnOrders = new clsOrders();
        //variable to store the primary key
        Int32 OrderId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrders.Find(OrderId);
        //if found
        if (Found == true) 
        {
            txtOrderId.Text = AnOrders.OrderId.ToString();
            txtDeliveryType.Text = AnOrders.DeliveryType;
            txtProductId.Text = AnOrders.ProductId.ToString();
            txtQuantity.Text = AnOrders.QuantityNo.ToString();
            txtOrderDate.Text = AnOrders.OrderDate.ToString();
            chkOrderCompleted.Checked = AnOrders.OrderCompleted;
        
        
        }
    }
}