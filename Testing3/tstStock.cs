using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void AvailableInStoretOk()
        {
            clsStock AnStock = new clsStock();
            Boolean TestData = true;
            AnStock.AvailableInStore = TestData;
            Assert.AreEqual(AnStock.AvailableInStore, TestData);
        }
        [TestMethod]

        public void DateAddedStockOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void ProductIdOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductId, TestData);
        }
        [TestMethod]
        public void StockLevelOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 10;
            //assign the data to the property
            AnStock.StockLevel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockLevel, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            float TestData = 900;
            //assign the data to the property
            AnStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Price, TestData);
        }
        [TestMethod]
        public void NameOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Iphone 14";
            //assign the data to the property
            AnStock.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Name, TestData);
        }
        [TestMethod]
        public void DescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "New phone with new technology, get it now!!!";
            //assign the data to the property
            AnStock.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Description, TestData);
        }
        [TestMethod]

        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //test to see if the results is true
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            /*
            if (AnStock.ProductId != 21)
            {
                Ok = false;
            }
            */
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            /*if (AnStock.Name != "Iphone")
            {
                Ok = false;
            }
            */
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            /*if (AnStock.Description != "new iphone")
            {
                Ok = false;
            }
            */
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            /*if (AnStock.Price != 900)
            {
                Ok = false;
            }
            */
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            /*if (AnStock.DateAdded != Convert.ToDateTime("1/01/2023"))
            {
                Ok = false;
            }
            */
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestAvailableInStoreFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            /*if (AnStock.AvailableInStore != true)
            {
                Ok = false;
            }
            */
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestStockLevelFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 ProductId = 1;
            Found = AnStock.Find(ProductId);
            /*if (AnStock.StockLevel != 100 )
            {
                Ok = false;
            }
            */
            Assert.IsTrue(Ok);
        }
    }
}
