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
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the stock number
        string Name = txtName.Text;
        string Description = txtDescription.Text;
        string Price = txtPrice.Text;
        string StockLevel = txtStockLevel.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
        if (Error == "")
        {
            //capture the productId, name, description, price, stocklevel, dateadded and availableInStore
            AnStock.ProductId = ProductId;
            AnStock.Name = Name;
            AnStock.Description = Description;
            AnStock.Price = float.Parse(Price);
            AnStock.StockLevel = Convert.ToInt32(StockLevel);
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            AnStock.AvailableInStore = chkAvailableInStore.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            //if this is a new record i.e productId = -1 then add the data
            if (ProductId == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AnStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(ProductId);
                //set the thisstock property
                StockList.ThisStock = AnStock;
                //update the record
                StockList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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
            txtName.Text = AnStock.Name;
            txtDescription.Text = AnStock.Description;
            txtPrice.Text = AnStock.Price.ToString();
            txtStockLevel.Text = AnStock.StockLevel.ToString();
            txtDateAdded.Text = AnStock.DateAdded.ToString();
            chkAvailableInStore.Checked = AnStock.AvailableInStore;

        }
    }
}