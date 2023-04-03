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
        //capture the devivery type
        AnOrders.DeliveryType = txtDeliveryType.Text;
        AnOrders.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrders.ProductId = Convert.ToInt32(txtProductId.Text);
        AnOrders.QuantityNo = Convert.ToInt32(txtQuantity.Text);
        AnOrders.OrderCompleted = chkOrderCompleted.Checked;
        AnOrders.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //store the orders in the session object
        Session["AnOrders"] = AnOrders;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

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