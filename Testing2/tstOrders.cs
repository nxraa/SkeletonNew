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
            AnOrders.Completed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.Completed, TestData);
        }
        [TestMethod]
        public void OrderDateProperty()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrders.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrders.Date, TestData);
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
            Int32 QuantityNo = 1;
            //invoke the method 
            Found = AnOrders.Find(QuantityNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestQuantityNoFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 QuantityNo = 1;
            //invoke the method
            Found = AnOrders.Find(QuantityNo);
            //check the address no
            if (AnOrders.QuantityNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
