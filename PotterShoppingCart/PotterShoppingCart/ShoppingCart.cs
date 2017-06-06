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
        BookPrice bookPrice;
        public ShoppingCart()
        {
            productsOfCart = new List<Product>();
            bookPrice = new BookPrice();
        }

        public void Add(string bookName, int amount)
        {
            productsOfCart.Add(new Product(bookName, bookPrice.GetPriceByBookname(bookName), amount));
        }

        public double CalculatePrice()
        {
            double totalPrice = 0;
            int temp = 0;

            while (true)
            {
                var inCart = from p in productsOfCart
                             where p.Amount > 0
                             select p;

                if (inCart.Count() != 0)
                {
                    int minAmount = (from p in inCart
                                     where p.Amount > 0
                                     select p.Amount).Min();
                    foreach (var a in inCart)
                    {
                        temp += a.Price * minAmount;
                    }
                    totalPrice += temp * GetDiscount(inCart.Count());
                    temp = 0;
                    foreach (var p in productsOfCart)
                    {
                        p.Amount -= minAmount;
                    }
                }
                else
                {
                    break;
                }
            }

            return totalPrice;
        }

        private double GetDiscount(int count)
        {
            switch (count)
            {
                case 2:
                    return 0.95;
                case 3:
                    return 0.9;
                case 4:
                    return 0.8;
                case 5:
                    return 0.75;
                default:
                    return 1;
            }
        }
    }

    internal class Product
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string Name, int Price, int Amount)
        {
            this.Name = Name;
            this.Price = Price;
            this.Amount = Amount;
        }
    }

    internal class BookPrice
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
