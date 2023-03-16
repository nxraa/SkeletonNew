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
        AnOrders.Completed = chkOrderCompleted.Checked;
        AnOrders.Date = Convert.ToDateTime(txtOrderDate.Text);
        //store the orders in the session object
        Session["AnOrders"] = AnOrders;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

    }
}