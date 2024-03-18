using HomeworksStudent.MenuProject;

namespace ProductShopAndMenu {
    public class Project1_C : IEntryPoint {
        public void Start() {
            IMenuItem[] menuItems = {
                new AddComand(),
                new RemoveComand(),
                new ShowProductInfoComand(),
                new ShowProductForCategory(),
                new SetLocaleComand(),
            };
            Menu menu = new Menu(menuItems);
            while (true) {
                menu.Start(true);
            }
        }
    }
}