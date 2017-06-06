using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        List<Product> productsOfCart;
        BookPrice bookPrice = new BookPrice();
        public ShoppingCart()
        {
            productsOfCart = new List<Product>();
        }

        public void Add(string bookName, int amouint)
        {
            productsOfCart.Add(new Product(bookName, bookPrice.GetPriceByBookname(bookName), amouint));
        }

        public int CalculatePrice()
        {
            int temp = 0;
            foreach (var product in productsOfCart)
            {
                temp += product.Amouint * product.Price;
            }
            return temp;
        }
    }

    internal class Product
    {
        public int Amouint { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(string Name, int Price, int Amouint)
        {
            this.Name = Name;
            this.Price = Price;
            this.Amouint = Amouint;
        }
    }
    public class BookPrice
    {
        private Dictionary<string, int> BookPriceDictionary;

        public BookPrice()
        {
            BookPriceDictionary = new Dictionary<string, int>();
            BookPriceDictionary.Add("Harry Potter 1", 100);
            BookPriceDictionary.Add("Harry Potter 2", 100);
            BookPriceDictionary.Add("Harry Potter 3", 100);
            BookPriceDictionary.Add("Harry Potter 4", 100);
            BookPriceDictionary.Add("Harry Potter 5", 100);
        }
        public int GetPriceByBookname(String name)
        {
            if (true == (BookPriceDictionary.ContainsKey(name)))
            {
                return BookPriceDictionary[name];
            }
            else
            {
                return 0;
            }
        }

    }
}
