namespace ProductShopAndMenu {
    public class ShopModel {
        private List<Product> _products = new List<Product>();
        private IProductShower _productShower;

        public ShopModel(ConsoleProductShower consoleProductShower) {
            _productShower = consoleProductShower;
        }

        public void AddProduct(Product product) {
            _products.Add(product);
        }

        public void RemoveProduct(int index) {
            _products.RemoveAt(index);
        }

        public void ShowProductInfo() {
            _productShower.ShowProducts(_products);
        }

        public void ShowAllProductInfo() {
            _productShower.ShowAllProductInfo(_products);
        }

        public bool ContainsProduct() {
            return _products.Count > 0;
        }

        public int GetProductCount() {
            return _products.Count;
        }

        public void ShowProductByType(ProductType productType) {
            List<Product> productsByCategory = new();

            foreach (var item in _products) {
                if (item.ProductType == productType) {
                    productsByCategory.Add(item);
                }
            }
            _productShower.ShowProducts(productsByCategory);
        }
    }

    public class TranslateModule {
        private Dictionary<LocaleKey, string> _currentLocale = new();

        public TranslateModule(Locales locales) {
            SetLocale(locales);
        }

        public string GetLocaleText(LocaleKey key) {
            return _currentLocale[key];
        }

        public void SetLocale(Locales locales) {
            _currentLocale = Locale.GetLocale(locales);
        }
    }

    public static class Locale {
        //Key/text

        private static readonly Dictionary<LocaleKey, string> RuLocale = new Dictionary<LocaleKey, string>() {
            { LocaleKey.Vegetables, "Овощи" },
            { LocaleKey.Fruits, "Фрукты" },
            { LocaleKey.Bakery, "Выпечка" },
            { LocaleKey.SetProductName, "Введите имя продукта" },
            { LocaleKey.Localization, "Локализация" },
            { LocaleKey.AddProduct, "Добавление продуктов" },
            { LocaleKey.SetProductPrice, "Введите цену продукта" },
            { LocaleKey.SetProductType, "Выберети тип продукта" },
        };

        private static readonly Dictionary<LocaleKey, string> EnLocale = new Dictionary<LocaleKey, string>() {
            { LocaleKey.Vegetables, "Vegetables" },
            { LocaleKey.Fruits, "Fruits" },
            { LocaleKey.Bakery, "Bakery" },
            { LocaleKey.SetProductName, "Set product name" },
            { LocaleKey.Localization, "Localization" },
            { LocaleKey.AddProduct, "Add Product" },
            { LocaleKey.SetProductPrice, "Set product price" },
            { LocaleKey.SetProductType, "Set product type" },
        };

        public static Dictionary<LocaleKey, string> GetLocale(Locales locales) {
            Dictionary<LocaleKey, string> result = null;

            switch (locales) {
                case Locales.En:
                    result = EnLocale;
                    break;
                default:
                    result = RuLocale;
                    break;
            }

            return result;
        }
    }

    public enum LocaleKey {
        Vegetables,
        Fruits,
        Bakery,
        SetProductName,
        Localization,
        AddProduct,
        SetProductPrice,
        SetProductType,
    }

    public enum Locales {
        Ru,
        En
    }
}