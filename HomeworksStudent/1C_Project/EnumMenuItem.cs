using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class EnumMenuItem<T1> : IMenuItem, IAction where T1 : struct, Enum {
        public event Action<T1> OnClick;
        public string Description =>  _localizationManager.GetLocaleText(GetLocaleKey());
        private LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;

        private readonly T1 _productType;

        public EnumMenuItem(Action<T1> action, T1 productType) {
            _productType = productType;
            OnClick = action;
        }

        public void Run() {
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
}