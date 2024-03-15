namespace ProductShopAndMenu
{
    public class Shop
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(int index)
        {
            _products.RemoveAt(index);
        }

        public void ShowProductInfo(IProductShower productShower)
        {
            productShower.ShowProduct(_products);
        }

        public void ShowAllProductInfo(IProductShower productShower)
        {
            productShower.ShowAllProductInfo(_products);
        }

        public bool ContainsProduct()
        {
            return _products.Count > 0;
        }

        public int GetProductCount()
        {
            return _products.Count;
        }
    }
}