namespace PotterShoppingCart
{
    public class Product
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
}
