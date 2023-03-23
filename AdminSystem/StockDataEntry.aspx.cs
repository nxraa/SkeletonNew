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
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the stock number
        AnStock.ProductId = Convert.ToInt32(txtProductId.Text);
        AnStock.Name = txtName.Text;
        AnStock.Description = txtDescription.Text;
        AnStock.Price = Convert.ToInt32(txtPrice.Text);
        AnStock.StockLevel = Convert.ToInt32(txtStockLevel.Text);
        AnStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AnStock.AvailableInStore = chkAvailableInStore.Checked;
        //store the address in the session object
        Session["AnStock"] = AnStock;
        //Navigate to viewer Page
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 ProductId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductId = Convert.ToInt32(txtProductId.Text);
        Found = AnStock.Find(ProductId);
        //if found
        if (Found == true)
        {
            //disaplay the values of the properties in the form
            txtProductId.Text = AnStock.ProductId.ToString();
            txtName.Text = AnStock.Name;
            txtDescription.Text = AnStock.Description;
            txtPrice.Text = AnStock.Price.ToString();
            txtStockLevel.Text = AnStock.StockLevel.ToString();
            txtDateAdded.Text = AnStock.DateAdded.ToString();
            chkAvailableInStore.Checked = AnStock.AvailableInStore;

        }
    }
}