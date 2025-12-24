using OrderAndProduct.Models;

namespace OrderAndProduct.Managers
{
    static class ProductManager
    {
        static List<Product> _products = [];

        public static void AddProduct(Product product) =>
            _products.Add(product);
        
        public static void RemoveProduct(string name)
        {
            var product = _products.FirstOrDefault(p => p.Name == name);
            if (product != null)
                _products.Remove(product);
        }
    }
}