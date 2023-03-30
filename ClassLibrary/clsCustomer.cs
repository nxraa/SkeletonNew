using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private string mName;
        private Int32 mID;
        private DateTime mDateAdded;
        private string mEmail;
        private string mPass;
        private Boolean mActive;


        public bool Active
        {
            get
            {

                return mActive;
            }
            set
            {
                mActive = value;
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
        public string Email
        {
            get
            {


                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string Pass
        {
            get
            {
                return mPass;

            }
            set
            {
                mPass = value;
            }
        }


        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }
            public bool Find(int iD)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", iD); 
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mPass = Convert.ToString(DB.DataTable.Rows[0]["CustomerPass"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActive"]);
                return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string name, string email, string pass, string active, string dateAdded)
        {
            String Error = "";
            if (name.Length == 0)
            {
                Error = Error + "The name may not be blank : ";
            }
            if(name.Length > 6)
            {
                Error = Error + "The name must be less than 6 characters : ";
            }
            return Error;
        }
    }
}