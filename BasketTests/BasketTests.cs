using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketNS;
using System.Collections.Specialized;

namespace BasketTests
{
    [TestClass]
    public class BasketTests
    {
        Basket keijonOstoskori;

        [TestInitialize]
        public void testInit()
        {
            keijonOstoskori = new Basket("Keijo");
            keijonOstoskori.AddProduct("Kissa", 10);
            keijonOstoskori.AddProduct("Pasi", 10);            
        }

        [TestCleanup]
        public void testClean()
        {
            keijonOstoskori = null;
        }

        [TestMethod]
        public void TestCustomerIsString()
        {
            Assert.IsInstanceOfType(keijonOstoskori.Customer, typeof(string), "Variable customer is not a string.");
        }

        [TestMethod]
        public void TestContentsIsList()
        {
            Assert.IsInstanceOfType(keijonOstoskori.Contents, typeof(StringCollection), "Variable contents is not a StringCollection.");
        }

        [TestMethod]
        public void TestPriceIsNumber()
        {
            Assert.IsInstanceOfType(keijonOstoskori.Price, typeof(float), "Variable price is not a float.");
        }

        [TestMethod]
        public void TestCanAddProduct()
        {
            keijonOstoskori.AddProduct("kala", 5);
            CollectionAssert.Contains(keijonOstoskori.Contents,"kala", "AddProduct did not add the product to the list.");
        }

        [TestMethod]
        public void TestCanRemoveProduct()
        {
            keijonOstoskori.DeleteProduct("Pasi", 10);
            CollectionAssert.DoesNotContain(keijonOstoskori.Contents, "Pasi", "DeleteProduct did not delete the product from the list.");
        }
    }
}
