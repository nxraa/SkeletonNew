using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
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

    }
}
