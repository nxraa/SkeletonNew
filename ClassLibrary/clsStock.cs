using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mProductId;
        private string mName;
        private string mDescription;
        private float mPrice;
        private Int32 mStockLevel;
        private DateTime mDateAdded;
        private Boolean mAvailableInStore;

        public Int32 ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public Int32 StockLevel
        {
            get
            {
                return mStockLevel;
            }
            set
            {
                mStockLevel = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public bool AvailableInStore
        {
            get
            {
                return mAvailableInStore;
            }
            set
            {
                mAvailableInStore = value;
            }
        }


        public bool Find(int ProductId)
        {
            // return true;
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            DB.Execute("sproc_tblStock_FilterByProductId");
            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToSingle(DB.DataTable.Rows[0]["Price"]);
                mStockLevel = Convert.ToInt32(DB.DataTable.Rows[0]["StockLevel"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailableInStore = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailableInStore"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string Name, string Description, string Price, string StockLevel, string DateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //create a temporary variable to store the price
            float TempPrice;
            //create a temporary variable to store the stock level
            Int32 TempStockLevel;
            //if the name is blank
            if (Name.Length == 0)
            {
                Error = Error + "The name shouldn't be blank : ";
            }
            // if the name is longer than 10 characters
            if (Name.Length > 10)
            {
                //record the error
                Error = Error + "The name must not be less than 10 character : ";
            }
            try
            {
                //copy the dateadded value to the datetemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //Record the error 
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            if (Description.Length == 0)
            {
                Error = Error + "The description shouldn't be blank : ";
            }
            // if the name is longer than 10 characters
            if (Description.Length > 50)
            {
                //record the error
                Error = Error + "The description must not be less than 50 character : ";
            }
            try
            {
                TempPrice = Convert.ToSingle(Price);
                if (TempPrice < 0)
                {
                    Error = Error + "The price cant be less than 0 : ";
                }
                if (TempPrice > 2000)
                {
                    Error = Error + "The price cant be over 2000 : ";
                }
            }
            catch
            {
                Error += "The price should be a number : ";
            }
            try
            {
                TempStockLevel = Convert.ToInt32(StockLevel);
                if (TempStockLevel < 0)
                {
                    Error = Error + "The stock level can't be below 0 : ";
                }
                if (TempStockLevel > 2000)
                {
                    Error = Error + "The stock level can be over 2000 : ";
                }
            }
            catch
            {
                Error = Error + "The stock level should be a number : ";
            }
            //return any error messages
            return Error;
        }
    }
}
