using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        string ID = "1";
        string Name = "aaron";
        string Pass = "taurus";
        string Email = "aaron04@gmail.com";
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
            Int32 ID = 1;
            Found = aCustomer.Find(ID);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestNameFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = aCustomer.Find(ID);
            if (aCustomer.Name != "Aaron")
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
            Int32 ID = 1;
            Found = aCustomer.Find(ID);
            if (aCustomer.ID != 1)
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
            Int32 ID = 1;
            Found = aCustomer.Find(ID);
            if (aCustomer.DateAdded != Convert.ToDateTime("15/05/2021"))
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
            Int32 ID = 1;
            Found = aCustomer.Find(ID);
            if (aCustomer.Email != "aaronayala@gmail.com")
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
            Int32 ID = 1;
            Found = aCustomer.Find(ID);
            if (aCustomer.Pass != "taurus")
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
            Int32 ID = 1;
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
            Error = aCustomer.Valid(Name, Email, Pass, Active, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "";
            Error = aCustomer.Valid(Name, Email, Pass, Active, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void NameMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "a";
            Error = aCustomer.Valid(Name, Email, Pass, Active, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aa";
            Error = aCustomer.Valid(Name, Email, Pass, Active, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aaaa";
            Error = aCustomer.Valid(Name, Email, Pass, Active, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aaaaaa";
            Error = aCustomer.Valid(Name, Email, Pass, Active, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aaa";
            Error = aCustomer.Valid(Name, Email, Pass, Active, DateAdded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string Name = "aaaaaaa";
            Error = aCustomer.Valid(Name, Email, Pass, Active, DateAdded);
            Assert.AreEqual(Error, "");

        }
    }
}
