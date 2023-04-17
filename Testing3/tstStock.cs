using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Stock
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
        string Name = "Iphone14";
        string Description = "New phone";
        string Price = "900";
        string StockLevel = "100";
        string DateAdded = DateTime.Now.Date.ToString();

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
        [TestMethod]
        public void ValidMethodOk()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            Error = AnStock.Valid(Name,Description,Price,StockLevel,DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "aaaaaaaaaaaa";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            Name = Name.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date variable to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date variable to whatever the date is less 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date variable to whatever the date is less 1 day
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidDate()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            String DateAdded = "this is not a date!";
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = ""; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "aa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = ""; //this should be ok
            Description = Description.PadRight(49, 'a'); // this should work
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = ""; //this should be ok
            Description = Description.PadRight(50, 'a'); // this should work
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            Description = Description.PadRight(51, 'a'); // this should fail
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = ""; //this should trigger an error
            Description = Description.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "-1"; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "0"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "1"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "1999"; //this should be ok            
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "2000"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "1000"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "2001"; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "50000"; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Price = "Not a price"; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "-1"; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "0"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "1"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "1999"; //this should be ok            
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "2000"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "Not a number" ; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "1000"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLevelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "2001"; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockLevel = "50000"; //this should trigger an error
            //invoke the method
            Error = AnStock.Valid(Name, Description, Price, StockLevel, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
