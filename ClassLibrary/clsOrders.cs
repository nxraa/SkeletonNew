using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //OrderDate private menber variable
        private DateTime mOrderDate;
        
        //OrderDate public property
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        
        
         //private data member for the AddressNo property
           private Int32 mOrderId;
           //public property for the address number
          public int OrderId
        {
            get 
            {
                //return the private data
                return mOrderId;
            }
            set 
            {
                //set the value of the private data member
                mOrderId = value; 
            }
        }

        //private data member for the ProductId property
        private Int32 mProductId;
        //public property for the ProductId
        public int ProductId
        {
            get
            {
                //return the private data
                return mProductId;
            }
            set
            {
                //set the value of the private data member
                mProductId = value;
            }
        }


        //private data member for delivery type
        private string mDeliveryType;
        //public data member for delivery type
        public string DeliveryType
        {
            get
            {
                //return the private data
                return mDeliveryType;
            }
            set
            {
                //set the private data
                mDeliveryType = value;
            }
        }

        //private data member for the Quantity property
        private Int32 mQuantityNo;
        //public property for the Quantity property
        public int QuantityNo
        {
            get
            {
                //return the private data
                return mQuantityNo;
            }
            set
            {
                //set the value of the private data member
                mQuantityNo = value;
            }
        }

        //private data member for active
        private Boolean mOrderCompleted;
        //public property for active
        public bool OrderCompleted
        {
            get
            {
                //return the private data
                return mOrderCompleted;
            }
            set
            {
                //set the private data
                mOrderCompleted = value;
            }
        }

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order id to seach for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderId");
    //if one record is found (the should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mDeliveryType = Convert.ToString(DB.DataTable.Rows[0]["DeliveryType"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mQuantityNo = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mOrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderCompleted"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string deliveryType, string productId, string quantityNo, string orderDate)
        {
            String Error = "";

            //create a temporary variable to store date values
            DateTime DateTemp;


            if (deliveryType.Length == 0)
            {
                Error = Error + "The delivery type can't be blank : ";
            }
            if (deliveryType.Length > 10)
            {
                Error = Error + "The delivery type can't be bigger than 10 characters : ";
            }

          try
          {

              
            //copy the OrderDate value to the DateTemp variable
            DateTemp = Convert.ToDateTime(orderDate);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past: ";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
          }
          catch
          {
               Error = Error + "The date was not a valid date : ";
          }



            switch (productId.ToString().Length)
            {
                case 0:
                    Error = Error + "The Product Id cannot be blank : ";
                    break;
                case int n when n > 5:
                    Error = Error + "The Product Id cannot be bigger than 5 characters : ";
                    break;
                default:
                    if (!int.TryParse(productId.ToString(), out int parsedProductId))
                    {
                        Error = Error + "The Product Id must be an integer : ";
                    }
                    break;
            }

            switch (quantityNo.ToString().Length)
            {
                case 0:
                    Error = Error + "The Quantity No cannot be blank : ";
                    break;
                case int n when n > 3:
                    Error = Error + "The Quantity No cannot be bigger than 3 characters : ";
                    break;
                default:
                    if (!int.TryParse(quantityNo.ToString(), out int parsedQuantityNo))
                    {
                        Error = Error + "The Quantity No must be an integer : ";
                    }
                    break;
            }



            return Error;




        }




    }
}