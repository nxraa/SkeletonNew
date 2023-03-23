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
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session onject
        AnStock = (clsStock)Session["AnStock"];
        Response.Write(AnStock.ProductId);
        Response.Write(AnStock.Name);
        Response.Write(AnStock.Description);
        Response.Write(AnStock.Price);
        Response.Write(AnStock.StockLevel);
        Response.Write(AnStock.DateAdded);
        Response.Write(AnStock.AvailableInStore);
    }
}