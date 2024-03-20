using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class ShowProductInfoComand : IButton
    {
        public string Description => _localizationManager.GetLocaleText(LocaleKey.ShowProductInfo);
        private LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;
        private BackButton _backButton = ServiceLocator.Instance.BackButton;
        private ShopModel _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            if (_shop.ContainsProduct())
            {
                _shop.ShowProductInfo();
            }
            else
            {
                ShopErrorHelper.NoProductMessage();
                _backButton.AwaitBackClick();
            }
        }
    }
}
