namespace ProductShopAndMenu
{
    public class Product : IContainsName
    {
        public ProductType ProductType { get; private set; }
        public int Price { get; private set; }
        public string Name { get; private set; }

        public Product(ProductType productType, string name, int price)
        {
            ProductType = productType;
            Price = price;
            Name = name;
        }
    }

    public class ProductView : IDescription
    {
        public string Description => _product.Name;
        private readonly Product _product;

        public ProductView(Product product)
        {
            _product = product;
        }
    }
}