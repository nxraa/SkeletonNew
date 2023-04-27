using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrders
    {
        //good test data
        string DeliveryType = "Standard";
        string ProductId = "2";
        string QuantityNo = "3";
        string OrderDate = DateTime.Now.Date.ToString();



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
        public void DeliveryTypeProperty()
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
        public void OrderIdProperty()
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
        public void TestDeliveryTypeFound()
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
        public void TestProductIdFound()
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
        public void TestQuantityFound()
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
        public void TestOrderCompletedFound()
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTypeMinLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryType = "";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTypeMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryType = "d";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTypeMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryType = "de";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTypeMaxLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryType = "ddddddddd";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTypeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryType = "dddddddddd";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTypeMid()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryType = "ddddd";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTypeMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryType = "ddddddddddd";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTypeExtremeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryType = "";
            DeliveryType = DeliveryType.PadRight(500, 'a');
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        
         [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

       
        [TestMethod]
        public void OrderDateMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string OrderDate = "this is not  a date!";
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void ProductIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ProductId = "";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ProductId = "1";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ProductId = "12";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ProductId = "1234";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ProductId = "12345";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ProductId = "123456";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ProductId = "123";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdInvalidData()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string ProductId = "abcde"; //not a number
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreNotEqual(Error, "");
        }



        
         [TestMethod]
        public void QuantityNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string QuantityNo = "";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityNoMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string QuantityNo = "1";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityNoPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string QuantityNo = "12";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string QuantityNo = "12";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityNoMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ProductId = "123";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string QuantityNo = "1234";
            //invoke the method
            Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
         [TestMethod]
         public void QuantityNoMid()
         {
             //create an instance of the class we want to create
             clsOrders AnOrder = new clsOrders();
             //string variable to store any error message
             String Error = "";
             //this should pass
             string QuantityNo = "1";
             //invoke the method
             Error = AnOrder.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
             //test to see that the result is correct
             Assert.AreEqual(Error, "");
         }
        [TestMethod]
        public void QuantityNoInvalidData()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string QuantityNo = "abc"; //not a number
            Error = AnOrders.Valid(DeliveryType, ProductId, QuantityNo, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        
    }
}
