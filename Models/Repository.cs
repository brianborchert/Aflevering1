namespace Aflevering1.Models
{
    public static class Repository
    {
        private static List<Product> products = new();

        public static IEnumerable<Product> Products => products;

        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        public static void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
    }
}