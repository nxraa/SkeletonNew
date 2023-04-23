using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        string ID = "2";
        string Name = "Harry";
        string Pass = "lol";
        string Email = "harryhuang@gmail.com";
        string DateAdded = DateTime.Now.Date.ToString();
        string Active = "true";



        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }


        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }
        [TestMethod]
        public void ActiveProperty()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean TestData = true;
            aCustomer.Active = TestData;
            Assert.AreEqual(aCustomer.Active, TestData);
        }
        [TestMethod]
        public void DateProperty()
        {
            clsCustomer aCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            aCustomer.DateAdded = TestData;
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void NameProperty()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Aaron";
            aCustomer.Name = TestData;
            Assert.AreEqual(aCustomer.Name, TestData);

        }
        [TestMethod]
        public void EmailProperty()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "aaron2003@gmail.com";
            aCustomer.Email = TestData;
            Assert.AreEqual(aCustomer.Email, TestData);

        }

        [TestMethod]
        public void PasswordProperty()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "lol";
            aCustomer.Pass = TestData;
            Assert.AreEqual(aCustomer.Pass, TestData);

        }

        [TestMethod]
        public void IDProperty()
        {
            clsCustomer aCustomer = new clsCustomer();
            Int32 TestData = 1;
            aCustomer.ID = TestData;
            Assert.AreEqual(aCustomer.ID, TestData);

        }

        [TestMethod]

        public void FindMethod()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 ID = 2;
            Found = aCustomer.Find(ID);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestNameFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 2;
            Found = aCustomer.Find(ID);
            if (aCustomer.Name != "Harry")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerIDFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 2;
            Found = aCustomer.Find(ID);
            if (aCustomer.ID != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateAddedFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 2;
            Found = aCustomer.Find(ID);
            if (aCustomer.DateAdded != Convert.ToDateTime("15/05/2022"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestEmailFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 2;
            Found = aCustomer.Find(ID);
            if (aCustomer.Email != "harryhuang@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestPassFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 2;
            Found = aCustomer.Find(ID);
            if (aCustomer.Pass != "lol")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestActiveFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 2;
            Found = aCustomer.Find(ID);
            if (aCustomer.Active != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void ValidMethodOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "";
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void NameMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "a";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aa";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aaaa";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aaaaaa";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameExtremeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void NameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aaa";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aaaaaaa";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DateAddedExtremeMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void DateAddedMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void DateAddedMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void DateAddedMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void DateAddedExtremeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void DateAddedInvalidData()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string DateAdded = "this is not a date!";
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void EmailMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Email = "";
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void EmailMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Email = "a";
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]

        public void EmailMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Email = "aa";
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void EmailMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Email = "";
            Email = Email.PadRight(29, 'a');
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void EmailMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Email = "";
            Email = Email.PadRight(30, 'a');
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void EmailMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Email = "";
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void EmailMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Email = "";
            Email = Email.PadRight(15, 'a');
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void PassMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Pass = "";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void PassMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Pass = "a";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]

        public void PassMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Pass = "aa";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PassMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Pass= "";
            Pass = Pass.PadRight(49, 'a');
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PassMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Pass = "";
            Pass = Pass.PadRight(50, 'a');
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PassMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Pass = "";
            Error = aCustomer.Valid(Name, Email, Pass, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void PassMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Pass = "";
            Pass = Pass.PadRight(25, 'a');
            Error = aCustomer.Valid(Name, Email, Pass,  DateAdded);
            Assert.AreEqual(Error, "");
        }

        
    }
}
