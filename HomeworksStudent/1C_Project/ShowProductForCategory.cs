using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class ShowProductForCategory : IAction, IMenuItem
    {
        public string Description => "Показать все продукты по категории";
        private BackButton _backButton = ServiceLocator.Instance.BackButton;
        private ShopModel _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            if (_shop.ContainsProduct())
            {
                _shop.ShowAllProductInfo();

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
}