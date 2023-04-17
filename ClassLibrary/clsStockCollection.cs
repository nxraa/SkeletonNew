using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member thisStock
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList 
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
            }
        }
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the arrray list with the data table
            PopulateArray(DB);
        }
            void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock AnStock = new clsStock();
                //read in the fields from the current record
                AnStock.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AnStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnStock.Price = Convert.ToSingle(DB.DataTable.Rows[Index]["Price"]);
                AnStock.StockLevel = Convert.ToInt32(DB.DataTable.Rows[Index]["StockLevel"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.AvailableInStore = Convert.ToBoolean(DB.DataTable.Rows[Index]["AvailableInStore"]);
                //add the record of the private data member
                mStockList.Add(AnStock);
                //point at the next record
                Index++;
            }
        }
        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock
            //connect to the datbase
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@StockLevel", mThisStock.StockLevel);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@AvailableInStore", mThisStock.AvailableInStore);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }
        public void Update()
        {
            //update an existing record based on the value of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for this stored procedure 
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("StockLevel", mThisStock.StockLevel);
            DB.AddParameter("DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@AvailableInStore", mThisStock.AvailableInStore);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisstocks
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}