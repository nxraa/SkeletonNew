using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data menber for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();
        //private data member thisOrders
        clsOrders mThisOrder = new clsOrders();

        //public property for the Orders List
        public List<clsOrders> OrdersList 
        { 
            get
            {
                //return the private data
                return mOrdersList;
            }
            set
            {
                //set the private data
                mOrdersList = value;
            }
        }
        public int Count 
        {
            get 
            {
                //return the count of the list
                return mOrdersList.Count;      
            }
            set 
            {
                //we shall worry about this later
            }
        }
       //public property for This Order
        public clsOrders ThisOrder 
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set 
            {
                //set the private data
                mThisOrder = value;            
            }
        }
       

        public clsOrdersCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank order
                clsOrders AnOrders = new clsOrders();
                //read in the fields from the current record
                AnOrders.OrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderCompleted"]);
                AnOrders.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrders.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AnOrders.QuantityNo = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrders.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrders.DeliveryType = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryType"]);
                //add record to private data member
                mOrdersList.Add(AnOrders);
                //point to next record
                Index++;

            }
           
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderCompleted", mThisOrder.OrderCompleted);
            DB.AddParameter("@ProductID", mThisOrder.ProductId);
            DB.AddParameter("@QuantityNo", mThisOrder.QuantityNo);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@DeliveryType", mThisOrder.DeliveryType);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblOrders_Insert");
        }
        public void Update() 
        {
            //update an existing recording  based on the values of thisOrder
            //connection to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OrderCompleted", mThisOrder.OrderCompleted);
            DB.AddParameter("@ProductID", mThisOrder.ProductId);
            DB.AddParameter("@QuantityNo", mThisOrder.QuantityNo);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@DeliveryType", mThisOrder.DeliveryType);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete() 
        {
            //deletes the record pointed to by thisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }
    }
}