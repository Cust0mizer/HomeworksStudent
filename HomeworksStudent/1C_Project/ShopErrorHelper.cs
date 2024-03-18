using HomeworksStudent;

namespace ProductShopAndMenu
{
    public static class ShopErrorHelper
    {
        private static LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;

        public static void NoProductMessage()
        {
            InputHelper.PrintError(_localizationManager.GetLocaleText(LocaleKey.NoProduct));
        }
    }
}