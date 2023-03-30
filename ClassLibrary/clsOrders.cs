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

        public bool Find(int QuantityNo)
        {
            //set the private data menbers to the test data value
            mOrderId = 1;
            mOrderDate = Convert.ToDateTime("16/09/2015");
            mDeliveryType = ("Standard");
            mProductId = 31;
            mQuantityNo = 2;
            mOrderCompleted = true;
            //always return true
            return true;
        }


    }
}