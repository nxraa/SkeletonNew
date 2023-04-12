using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }

            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }

        public clsCustomer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsCustomer aCustomer = new clsCustomer();
                aCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountActive"]);
                aCustomer.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                aCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                aCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                aCustomer.Pass = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPass"]);
                aCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDate"]);
                mCustomerList.Add(aCustomer);
                Index ++;
            }
        }
    }
}