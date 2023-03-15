using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int QuantityNo { get; set; }
        public int ProductNo { get; set; }
        public string DeliveryType { get; set; }
        public int OrderId { get; set; }
    }
}