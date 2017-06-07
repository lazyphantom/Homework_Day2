using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        public double CalculatePrice(List<Product> productsOfCart)
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
}
