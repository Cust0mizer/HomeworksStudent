using ProductShopAndMenu;

namespace HomeworksStudent.MenuProject {
    public class MenuStarter : IEntryPoint {
        LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;

        public void Start() {
            Menu menu = new Menu([new AddComand(), new RemoveComand(), new ShowProductInfoComand()]);
            menu.Start(_localizationManager.GetLocaleText(LocaleKey.SelectAction));
        }
    }
}