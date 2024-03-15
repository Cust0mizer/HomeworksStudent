namespace ProductShopAndMenu
{
    public class ShopModel
    {
        private List<Product> _products = new List<Product>();
        private IProductShower _iproductShower;

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(int index)
        {
            _products.RemoveAt(index);
        }

        public void ShowProductInfo()
        {
            _iproductShower.ShowProducts(_products);
        }

        public void ShowAllProductInfo()
        {
            _iproductShower.ShowAllProductInfo(_products);
        }

        public bool ContainsProduct()
        {
            return _products.Count > 0;
        }

        public int GetProductCount()
        {
            return _products.Count;
        }

        public void ShowProductByType(ProductType productType)
        {
            List<Product> productsByCategory = new();

            foreach (var item in _products)
            {
                if (item.ProductType == productType)
                {
                    productsByCategory.Add(item);
                }
            }
            _iproductShower.ShowProducts(productsByCategory);
        }
    }
}