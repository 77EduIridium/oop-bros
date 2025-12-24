using OrderAndProduct.Models;

namespace OrderAndProduct
{
    class Program
    {
        static void Main()
        {
            var product1 = new Models.Product("Laptop", 1500.00m);
            var product2 = new Models.Product("Smartphone", 800.00m);

            var order = new Order();
            order.AddProduct(product1, 2);
            order.AddProduct(product2, 3);
            order.PrintOrderDetails();
        }
    }
}