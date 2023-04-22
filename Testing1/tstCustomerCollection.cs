using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Name = "aaron";
            TestItem.Email = "aaron05@gmail.com";
            TestItem.Pass = "taurus";
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);


        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Active = true;
            TestCustomer.ID = 1;
            TestCustomer.Name = "aaron";
            TestCustomer.Email = "aaron05@gmail.com";
            TestCustomer.Pass = "taurus";
            TestCustomer.DateAdded = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);


        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Name = "aaron";
            TestItem.Email = "aaron05@gmail.com";
            TestItem.Pass = "taurus";
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);


        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Name = "bronny";
            TestItem.Email = "bron05@gmail.com";
            TestItem.Pass = "bronny";
            TestItem.DateAdded = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.ID = PrimaryKey;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Name = "bronny";
            TestItem.Email = "bron05@gmail.com";
            TestItem.Pass = "bronny";
            TestItem.DateAdded = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestItem;
            //modify test data
            TestItem.Active = false;
            TestItem.ID = 1;
            TestItem.Name = "johnny";
            TestItem.Email = "john05@gmail.com";
            TestItem.Pass = "johnny";
            TestItem.DateAdded = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Name = "bronny";
            TestItem.Email = "bron05@gmail.com";
            TestItem.Pass = "bronny";
            TestItem.DateAdded = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.ID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }


    }


}
