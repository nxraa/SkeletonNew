using System;

namespace ClassLibrary
{
    public class clsOrders
    {

        public bool Completed { get; set; }
        public DateTime Date { get; set; }              
        
        
         //private data member for the AddressNo property
           private Int32 mQuantityNo;
           //public property for the address number
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
 

        public int ProductId { get; set; }
        public string DeliveryType { get; set; }
        public int OrderId { get; set; }

        public bool Find(int QuantityNo)
        {
            //set the private data menbers to the test data value
            mQuantityNo = 1;
            //always return true
            return true;
        }
    }
}