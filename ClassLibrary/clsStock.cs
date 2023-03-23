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
            //string s =  "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = H:\\Local databse\\App_Data\\AddressBook1.mdf; Integrated Security = True; Connect Timeout = 30";

            // return true;
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            DB.Execute("sproc_tblStock_FilterByProductId");
            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
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
    }
}
