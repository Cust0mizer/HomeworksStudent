using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class RemoveComand : IAction, IMenuItem
    {
        public string Description => "Удаление продуктов";
        private BackButton _backButton = ServiceLocator.Instance.BackButton;
        private Shop _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            if (_shop.ContainsProduct())
            {
                ConsoleProductShower consoleProductShower = new ConsoleProductShower();
                _shop.ShowAllProductInfo(consoleProductShower);

                if (InputHelper.ChangeInput("", 1, _shop.GetProductCount(), out int inputValue))
                {
                    _shop.RemoveProduct(inputValue - 1);
                }
            }
            else
            {
                ShopErrorHelper.NoProductMessage();
                _backButton.AwaitBackClick();
            }
        }
    }

    public static class ShopErrorHelper
    {
        private const string NO_PRODUCT = "Нет продуктов в магазине!";

        public static void NoProductMessage()
        {
            InputHelper.PrintError(NO_PRODUCT);
        }
    }
}