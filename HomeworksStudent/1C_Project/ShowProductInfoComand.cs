using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class ShowProductInfoComand : IAction, IMenuItem
    {
        public string Description => "Показать информацию о продуктах";
        private BackButton _backButton = ServiceLocator.Instance.BackButton;
        private Shop _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            if (_shop.ContainsProduct())
            {
                _shop.ShowProductInfo(new ConsoleProductShower());
            }
            else
            {
                ShopErrorHelper.NoProductMessage();
                _backButton.AwaitBackClick();
            }
        }
    }
}