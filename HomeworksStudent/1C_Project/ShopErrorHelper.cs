namespace ProductShopAndMenu
{
    public static class ShopErrorHelper
    {
        private const string NO_PRODUCT = "Нет продуктов в магазине!";

        public static void NoProductMessage()
        {
            InputHelper.PrintError(NO_PRODUCT);
        }
    }
}