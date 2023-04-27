using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestStockCollection
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.AvailableInStore = true;
            TestItem.ProductId = 1;
            TestItem.Name = "iphone 14";
            TestItem.Description = "New phone";
            TestItem.Price = 900;
            TestItem.StockLevel = 100;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        [TestMethod]
        public void ThisStockOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.AvailableInStore = true;
            TestStock.ProductId = 1;
            TestStock.Name = "iphone 14";
            TestStock.Description = "New iphone";
            TestStock.Price = 900;
            TestStock.StockLevel = 100;
            TestStock.DateAdded = DateTime.Now.Date;
            //asign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set the properties of the test object
            TestItem.AvailableInStore = true;
            TestItem.ProductId = 1;
            TestItem.Name = "iphone 14";
            TestItem.Description = "New iphone";
            TestItem.Price = 900;
            TestItem.StockLevel = 100;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductId = 1;
            TestItem.Name = "iphone 14";
            TestItem.Description = "New iphone";
            TestItem.Price = 900;
            TestItem.StockLevel = 100;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.AvailableInStore = true;
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        
        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Name = "iphone 15";
            TestItem.Description = "New iphone";
            TestItem.Price = 900;
            TestItem.StockLevel = 100;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.AvailableInStore = true;
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //modify the test data
            TestItem.AvailableInStore = false;
            TestItem.Name = "iphone 16";
            TestItem.Description = "New iphone";
            TestItem.Price = 1000;
            TestItem.StockLevel = 50;
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see thisstock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AvailableInStore = true;
            TestItem.ProductId = 1;
            TestItem.Name = "Iphone 14";
            TestItem.Description = "New phone";
            TestItem.Price = 900;
            TestItem.StockLevel = 100;
            TestItem.DateAdded = DateTime.Now.Date;
            //set thisstock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByNameMethodOk()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //aply a blank string (should return all records);
            FilteredStocks.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a post code that doesn't exist
            FilteredStocks.ReportByName("xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStocks.Count);
        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an insstance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //var to store outcome
            Boolean Ok = true;
            //apply a post code that doesnt exist
            FilteredStocks.ReportByName("AAA AAA");
            //check that the correct number of records are found
            if (FilteredStocks.Count == 2)
            {
                //check that the first record is ID 16
                if (FilteredStocks.StockList[0].ProductId != 16)
                {
                    Ok = false;
                }
                //check that the first record is ID 17
                if (FilteredStocks.StockList[1].ProductId != 17)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            //test to see that there are no records
            Assert.IsTrue(Ok);
        }
    }
}
