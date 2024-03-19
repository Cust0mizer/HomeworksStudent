using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class SetLocaleComand : IAction, IMenuItem
    {
        private LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;
        private ButtonEnumFactory _enumFactory = ServiceLocator.Instance.ButtonEnumFactory;
        public string Description => _localizationManager.GetLocaleText(LocaleKey.Localization);

        public void Run()
        {
            Action<Locales> action = _localizationManager.SetLocale;
            Menu menu = new Menu(_enumFactory.GetButtonsByEnum(action));
            menu.Start(true, _localizationManager.GetLocaleText(LocaleKey.SelectAction));
        }
    }
}