using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //test to see that exists
            Assert.IsNotNull(AnOrders);
        }

        [TestMethod]
        public void OrderCompletedProperty()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //create some test data to assign the property
            Boolean TestData = true;
            //assign the data to the proterty
            AnOrders.OrderCompleted = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderCompleted, TestData);
        }
       
        [TestMethod]
        public void OrderDateProperty()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrders.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderDate, TestData);
        }
        
        
        
        [TestMethod]
        public void QuantityProperty()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrders.QuantityNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.QuantityNo, TestData);
        }

        [TestMethod]
        public void ProductIdProperty()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrders.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.ProductId, TestData);
        }
        [TestMethod]
        public void DeliveryType()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            // Create some test data to assign to the property
            string TestData = "Standard";
            // Assign the data to the property
            AnOrders.DeliveryType = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrders.DeliveryType, TestData);
        }
        [TestMethod]
        public void OrderId()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            // Create some test data to assign to the property
            Int32 TestData = 1;
            // Assign the data to the property
            AnOrders.OrderId = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrders.OrderId, TestData);
        }
        [TestMethod]
        public void FindMethod()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method 
            Found = AnOrders.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
      
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrders.Find(OrderId);
            //check the address no
            if (AnOrders.OrderId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;

            //invoke the method
            Found = AnOrders.Find(OrderId);
            //check the property
            if (AnOrders.OrderDate != Convert.ToDateTime("12/02/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryType()
        {
            
            clsOrders AnOrders = new clsOrders();
           
            Boolean Found = false;       
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrders.Find(OrderId);
            if (AnOrders.DeliveryType != "Standard")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
            //output the value being set for debugging purposes
            
        }
        [TestMethod]
        public void TestProductId()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrders.Find(OrderId);
            //check the property
            if (AnOrders.ProductId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantity()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrders.Find(OrderId);
            //check the property
            if (AnOrders.QuantityNo != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderCompleted()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrders.Find(OrderId);
            //check the property
            if (AnOrders.OrderCompleted != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
