namespace ProductShopAndMenu
{
    public class ShopModel
    {
        private List<Product> _products = new();
        private IProductShower _productShower;

        public ShopModel(ConsoleProductShower consoleProductShower)
        {
            _productShower = consoleProductShower;
        }

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
            _productShower.ShowProducts(_products);
        }

        public void ShowAllProductInfo()
        {
            _productShower.ShowAllProductInfo(_products);
        }

        public bool ContainsProduct()
        {
            return _products.Count > 0;
        }

        public int GetProductCount()
        {
            return _products.Count;
        }

        public IButton[] GetMenuButtons()
        {
            throw new NotImplementedException();
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
            _productShower.ShowProducts(productsByCategory);
        }
    }
}



//Создать класс который будет содержать словарь где ключ и значение будут string
//Сделать из класса синглетон
//Создать метод, куда мы будем передавать ключ и получать значение из словоря по ключу
//Создать статический класс, который содержит в себе 2 словоря, с английскими словами и русскими
//Заполнить словарь вашими ключами и значениями из программы