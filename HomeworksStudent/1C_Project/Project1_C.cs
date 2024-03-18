using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class Project1_C : IEntryPoint
    {
        LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;

        public void Start()
        {
            IMenuItem[] menuItems = {
                new AddComand(),
                new RemoveComand(),
                new ShowProductInfoComand(),
                new ShowProductForCategory(),
                new SetLocaleComand(),
            };
            Menu menu = new Menu(menuItems);
            while (true)
            {
                menu.Start(true, _localizationManager.GetLocaleText(LocaleKey.SelectAction));
            }
        }
    }
}