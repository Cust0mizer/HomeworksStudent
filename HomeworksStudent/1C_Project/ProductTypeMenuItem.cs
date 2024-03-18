using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class ProductTypeMenuItem<T1> : IMenuItem, IAction {
        public event Action<T1> OnClick;
        public string Description => _localizationManager.GetLocaleText(LocaleKey.Vegetables);
        private LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;

        private readonly T1 _productType;

        public ProductTypeMenuItem(Action<T1> action, T1 productType) {
            _productType = productType;
            OnClick = action;
        }

        public void Run() {
            OnClick?.Invoke(_productType);
        }
    }
}