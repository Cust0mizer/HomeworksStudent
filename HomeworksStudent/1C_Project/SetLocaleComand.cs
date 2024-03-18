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
            if (InputHelper.ChangeInput("", 1, 2, out int value))
            {
                if (value == 1)
                {
 ServiceLocator.Instance.LocalizationManager.SetLocale(Locales.Ru);
                }
                else
                {
  ServiceLocator.Instance.LocalizationManager.SetLocale(Locales.En);
                }
            }


            Action<Locales> action = _localizationManager.SetLocale;
            Menu menu = new Menu(_enumFactory.GetButtonsByEnum(action));
            menu.Start(true, _localizationManager.GetLocaleText(LocaleKey.SelectAction));
        }
    }
}