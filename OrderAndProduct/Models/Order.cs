namespace OrderAndProduct.Models
{
    public class Order
    {
        private Dictionary<Product, int> _products = [];
        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;

                foreach (var (product, count) in _products)
                    total += product.Price * count;

                return total;
            }
        }

        public void AddProduct(Product product, int count = 1) =>
            _products.Add(product, count);

        public void RemoveProduct(string name)
        {
            var product = _products.Keys.FirstOrDefault(p => p.Name == name);
            if (product != null)
                _products.Remove(product);
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine("Order Details:");

            foreach (var (product, count) in _products)
                Console.WriteLine($"- {product.Name}: {product.Price} x {count}");

            Console.WriteLine($"Total Price: {TotalPrice}");
        }
    }
}