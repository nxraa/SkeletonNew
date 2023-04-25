using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to check if it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrdersListOK() {

            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some data to assign to the property
            //in this case the data needs to be a list od objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderId = 1;
            TestItem.ProductId = 1;
            TestItem.QuantityNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryType = "Standard";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }
        [TestMethod]
        public void OrdersListPropertyOK()
        {

            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some data to assign to the property
            clsOrders TestOrders = new clsOrders();
            //set its properties
            TestOrders.OrderCompleted = true;
            TestOrders.OrderId = 1;
            TestOrders.ProductId = 1;
            TestOrders.QuantityNo = 1;
            TestOrders.OrderDate = DateTime.Now.Date;
            TestOrders.DeliveryType = "Standard";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrders;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some data to assign to the property
            //in this case the data needs to be a list od objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderId = 1;
            TestItem.ProductId = 1;
            TestItem.QuantityNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryType = "Standard";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOk() 
        {
            // create instance of class 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderId = 1;
            TestItem.ProductId = 1;
            TestItem.QuantityNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryType = "Express";
            //set ThisPrders to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that  the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK() 
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.ProductId = 1;
            TestItem.QuantityNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryType = "Express";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key to the test data
            TestItem.OrderCompleted = false;
            TestItem.ProductId = 9;
            TestItem.QuantityNo = 7;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryType = "Standard";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK() 
        { 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.ProductId = 1;
            TestItem.QuantityNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryType = "Express";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
     
            Assert.IsFalse(Found);
                            
        } 
        [TestMethod]
        public void ReportByDeliveryTypeOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a blank string (should return all the records);
            FilteredOrders.ReportbyDeliveryType("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByDeliveryTypeNoneFound() 
        {
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a delivery type that doesn't exist
            FilteredOrders.ReportbyDeliveryType("xxxxxxxx");
            //test to see that tere are no  records
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByDeliveryTypeTestDataFound()
        {
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a delivery type
            FilteredOrders.ReportbyDeliveryType("Overnight");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2) 
            {
                //check that the first order is ID 10
                if (FilteredOrders.OrdersList[0].OrderId != 10) 
                {
                    OK = false;
                }
                if (FilteredOrders.OrdersList[1].OrderId != 11) 
                {
                    OK = false;
                }  
            }
            else 
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);

        }
    }
}
