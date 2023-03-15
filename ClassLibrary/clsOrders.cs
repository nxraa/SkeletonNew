using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Completed { get; set; }
        public DateTime Date { get; set; }
        public int QuantityNo { get; set; }
        public int ProductId { get; set; }
        public string DeliveryType { get; set; }
        public int OrderId { get; set; }
    }
}