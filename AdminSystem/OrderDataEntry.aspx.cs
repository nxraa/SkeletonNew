using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderId != -1) 
            {
                //display the current data for the record
                DisplayOrders();
            }


        }
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
            AnOrders.OrderId = OrderId; //don't miss this bit
            AnOrders.DeliveryType = DeliveryType;
            AnOrders.ProductId = Convert.ToInt32(ProductId);
            AnOrders.QuantityNo = Convert.ToInt32(QuantityNo);
            AnOrders.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrders.OrderCompleted = chkOrderCompleted.Checked;
            //create new instance of the orders collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();
            
            //if this is a new record i.e. OrderId = -1 then add the data
            if(OrderId == -1) 
            {
                 //set the ThisOrder Property
                OrdersList.ThisOrder = AnOrders;
                //add the new record
                 OrdersList.Add();
            }
            else 
            {
                //find the record to update
                OrdersList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrdersList.ThisOrder = AnOrders;
                //update the record
                OrdersList.Update();
            }      

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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtOrderId.Text = "";
        txtDeliveryType.Text = "";
        txtProductId.Text = "";
        txtQuantity.Text = "";
        txtOrderDate.Text = "";
        chkOrderCompleted.Checked = false;
    }
    void DisplayOrders() 
    {
        clsOrdersCollection OrderBook = new clsOrdersCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for this record
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtDeliveryType.Text = OrderBook.ThisOrder.DeliveryType;
        txtProductId.Text = OrderBook.ThisOrder.ProductId.ToString();
        txtQuantity.Text = OrderBook.ThisOrder.QuantityNo.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        chkOrderCompleted.Checked = OrderBook.ThisOrder.OrderCompleted;

    }

}