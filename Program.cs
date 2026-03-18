using System.Transactions;

namespace ProductDiscount
{
    class Product
    {
        int id;
        string name;
        double price;
        double discount;

        public Product(int id, string n, double p, double d)
        {
            this.id = id;
            this.name = n;
            this.price = p;
            this.discount = d;

        }
        public double PriceAfterDiscount()
        {
            discount = price * discount / 100;
            double finalprice = price - discount;
            return finalprice;
        }
        public void Display()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ActualPrice : " + price);
            Console.WriteLine("Discount : " + discount);
            Console.WriteLine("Price after Discount : " + PriceAfterDiscount());

        }
            
    }
}
