using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void Sample1_1stx1_100() {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Add("Harry Potter 1", 1);
            shoppingCart.Add("Harry Potter 2", 0);
            shoppingCart.Add("Harry Potter 3", 0);
            shoppingCart.Add("Harry Potter 4", 0);
            shoppingCart.Add("Harry Potter 5", 0);

            var expected = 100;

            var actual = shoppingCart.CalculatePrice();

            Assert.AreEqual(expected, actual);
        }
    }
    
    public class ShoppingCart
    {
        public ShoppingCart()
        {

        }

        public void Add(string bookName, int count)
        {

        }

        public int CalculatePrice()
        {
            return 0;
        }
    }
}
