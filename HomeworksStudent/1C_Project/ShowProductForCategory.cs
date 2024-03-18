using HomeworksStudent.MenuProject;
using HomeworksStudent;
using End;

namespace ProductShopAndMenu {
    public class ShowProductForCategory : IAction, IMenuItem {
        public string Description => "Показать все продукты по категории";
        private ButtonEnumFactory _enumFactory = ServiceLocator.Instance.ButtonEnumFactory;
        private BackButton _backButton = ServiceLocator.Instance.BackButton;
        private ShopModel _shop = ServiceLocator.Instance.Shop;

        public void Run() {
            if (_shop.ContainsProduct()) {
                Action<ProductType> action = _shop.ShowProductByType;
                Menu menu = new Menu(_enumFactory.GetButtons(action));
                menu.Start(true);
            }
            else {
                ShopErrorHelper.NoProductMessage();
                _backButton.AwaitBackClick();
            }
        }
    }
}