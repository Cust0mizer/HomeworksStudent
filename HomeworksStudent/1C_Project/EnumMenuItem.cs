using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class EnumMenuItem<T1> : IButton where T1 : struct, Enum
    {
        public event Action<T1> OnClick;
        public string Description => _localizationManager.GetLocaleText(GetLocaleKey());
        private LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;

        private readonly T1 _productType;

        public EnumMenuItem(Action<T1> action, T1 productType)
        {
            _productType = productType;
            OnClick = action;
        }

        public void Run()
        {
            OnClick?.Invoke(_productType);
        }

        private LocaleKey GetLocaleKey()
        {
            LocaleKey result = default;
            if (InputHelper.ConvertEnumToType(_productType, out LocaleKey resultValue))
            {
                result = resultValue;
            }
            return result;
        }
    }

    public class ProductButton<T1> : IMenuItem, IAction
    {
        public event Action<T1> OnClick;
        public string Description => _description;

        private readonly T1 _productType;
        private readonly string _description;

        public ProductButton(Action<T1> action, T1 productType, string description)
        {
            _productType = productType;
            _description = description;
            OnClick = action;
        }

        public void Run()
        {
            OnClick?.Invoke(_productType);
        }
    }
}