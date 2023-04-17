using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ProductId;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be deleted from the session object
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book class
        clsStockCollection StocksBook = new clsStockCollection();
        //find the record to delete
        StocksBook.ThisStock.Find(ProductId);
        //delete the record
        StocksBook.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}