using Newtonsoft.Json.Linq;

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

    public class ProductMenuItem<T> : IButton
    {
        public string Description => _description;
        private readonly string _description;

        public delegate T OnClick();
        public OnClick Action;

        public ProductMenuItem(Product product)
        {
            _description = product.Name;
        }

        public void Run()
        {
            Action?.Invoke();
        }
    }
}