using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void Sample1_1stx1_100()
        {
            var shoppingCart = new ShoppingCart();
            List<Product> productsOfCart = new List<Product>()
            {
                new Product(Name: "Harry Potter 1", Price:100, Amount:1)
            };

            var expected = 100;

            var actual = shoppingCart.CalculatePrice(productsOfCart);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void Sample2_1stX1_2ndX1_190()
        {
            var shoppingCart = new ShoppingCart();
            List<Product> productsOfCart = new List<Product>()
            {
                new Product(Name: "Harry Potter 1", Price:100, Amount:1),
                new Product(Name: "Harry Potter 2", Price:100, Amount:1)
            };

            var expected = 190;

            var actual = shoppingCart.CalculatePrice(productsOfCart);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sample3_1stX1_2ndX1_3rdX1_270()
        {
            var shoppingCart = new ShoppingCart();
            List<Product> productsOfCart = new List<Product>()
            {
                new Product(Name: "Harry Potter 1", Price:100, Amount:1),
                new Product(Name: "Harry Potter 2", Price:100, Amount:1),
                new Product(Name: "Harry Potter 3", Price:100, Amount:1)
            };

            var expected = 270;

            var actual = shoppingCart.CalculatePrice(productsOfCart);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sample4_1stX1_2ndX1_3rdX1_4thX1_320()
        {
            var shoppingCart = new ShoppingCart();
            List<Product> productsOfCart = new List<Product>()
            {
                new Product(Name: "Harry Potter 1", Price:100, Amount:1),
                new Product(Name: "Harry Potter 2", Price:100, Amount:1),
                new Product(Name: "Harry Potter 3", Price:100, Amount:1),
                new Product(Name: "Harry Potter 4", Price:100, Amount:1)
            };

            var expected = 320;

            var actual = shoppingCart.CalculatePrice(productsOfCart);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sample5_1stX1_2ndX1_3rdX1_4thX1_5thX1_375()
        {
            var shoppingCart = new ShoppingCart();
            List<Product> productsOfCart = new List<Product>()
            {
                new Product(Name: "Harry Potter 1", Price:100, Amount:1),
                new Product(Name: "Harry Potter 2", Price:100, Amount:1),
                new Product(Name: "Harry Potter 3", Price:100, Amount:1),
                new Product(Name: "Harry Potter 4", Price:100, Amount:1),
                new Product(Name: "Harry Potter 5", Price:100, Amount:1)
            };

            var expected = 375;

            var actual = shoppingCart.CalculatePrice(productsOfCart);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sample6_1stX1_2ndX1_3rdX2_370()
        {
            var shoppingCart = new ShoppingCart();
            List<Product> productsOfCart = new List<Product>()
            {
                new Product(Name: "Harry Potter 1", Price:100, Amount:1),
                new Product(Name: "Harry Potter 2", Price:100, Amount:1),
                new Product(Name: "Harry Potter 3", Price:100, Amount:2)
            };

            var expected = 370;

            var actual = shoppingCart.CalculatePrice(productsOfCart);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sample7_1stX1_2ndX2_3rdX2_460()
        {
            var shoppingCart = new ShoppingCart();
            List<Product> productsOfCart = new List<Product>()
            {
                new Product(Name: "Harry Potter 1", Price:100, Amount:1),
                new Product(Name: "Harry Potter 2", Price:100, Amount:2),
                new Product(Name: "Harry Potter 3", Price:100, Amount:2)
            };

            var expected = 460;

            var actual = shoppingCart.CalculatePrice(productsOfCart);

            Assert.AreEqual(expected, actual);
        }
    }
}
