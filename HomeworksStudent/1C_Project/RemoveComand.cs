using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class RemoveComand : IButton
    {
        public string Description => _localizationManager.GetLocaleText(LocaleKey.RemoveProduct);
        private LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;
        private BackButton _backButton = ServiceLocator.Instance.BackButton;
        private ShopModel _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            if (_shop.ContainsProduct())
            {
                _shop.ShowAllProductInfo();
                if (InputHelper.ChangeInput("Product", 1, _shop.GetProductCount(), out int userUnputValue))
                {
                    _shop.RemoveProduct(userUnputValue - 1);
                }


                //Menu menu = new Menu(_shop.GetMenuButtons());
                //menu.Start("");
            }
            else
            {
                ShopErrorHelper.NoProductMessage();
                _backButton.AwaitBackClick();
            }
        }
    }
}