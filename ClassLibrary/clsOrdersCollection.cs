using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data menber for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();
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
        public clsOrders ThisOrder { get; set; }
       

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
    }
}