using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu {
    public class AddComand : IAction, IMenuItem {
        public string Description => _translateModule.GetLocaleText(LocaleKey.AddProduct);
        private ButtonEnumFactory _enumFactory = ServiceLocator.Instance.ButtonEnumFactory;
        private TranslateModule _translateModule = ServiceLocator.Instance.TranslateModule;
        private ShopModel _shop = ServiceLocator.Instance.Shop;
        private ProductType _productType;

        public void Run() {
            if (InputHelper.TextInputField(_translateModule.GetLocaleText(LocaleKey.SetProductName), out string productName)) {
                Console.WriteLine(_translateModule.GetLocaleText(LocaleKey.SetProductPrice));
                if (int.TryParse(Console.ReadLine(), out int price)) {
                    Action<ProductType> action = SetProductType;
                    Menu menu = new Menu(_enumFactory.GetButtons(action));
                    menu.Start(false);
                    Console.WriteLine(_translateModule.GetLocaleText(LocaleKey.SetProductType));
                    _shop.AddProduct(new Product(_productType, productName, price));
                }
            }
        }

        private void SetProductType(ProductType productType) {
            _productType = productType;
        }
    }

    public class SetLocaleComand : IAction, IMenuItem {
        private TranslateModule _translateModule = ServiceLocator.Instance.TranslateModule;
        private ButtonEnumFactory _enumFactory = ServiceLocator.Instance.ButtonEnumFactory;
        public string Description => _translateModule.GetLocaleText(LocaleKey.Localization);

        public void Run() {
            Action<Locales> action = _translateModule.SetLocale;
            Menu menu = new Menu(_enumFactory.GetButtons(action));
            menu.Start(true);
        }
    }
}