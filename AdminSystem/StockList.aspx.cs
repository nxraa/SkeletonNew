using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stocks to be processed
        ProductId = Convert.ToInt32(Session["ProductId"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductId != -1)
            {
                //Display the cureent data for the record
                DisplayStock();
            }
        }
    }
    void DisplayStock()
    {
        //create an instance of the address collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to list of addresses in the collection
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductId";
        //set the data field to display
        lstStockList.DataTextField = "Name";
        //bind the data to the list
        lstStockList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductId"] = -1;
        //redirect to the data entery page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ProductId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductId"] = ProductId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 ProductId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductId"] = ProductId;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByName(txtEnterName.Text);
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductId";
        //set the name of the field to display 
        lstStockList.DataTextField = "Name";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection
        clsStockCollection Stocks = new clsStockCollection();
        //clear any existing filter to tidy up the interface
        txtEnterName.Text = "";
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductId";
        //set the name of the field to display
        lstStockList.DataTextField = "Name";
        //bind the data to the list
        lstStockList.DataBind();
    }
}