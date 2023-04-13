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
        


    }    
}
