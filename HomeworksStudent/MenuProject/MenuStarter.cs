using ProductShopAndMenu;

namespace HomeworksStudent.MenuProject
{
    public class MenuStarter : IEntryPoint
    {
        public void Start()
        {
            Menu menu = new Menu([new AddComand(), new RemoveComand(), new ShowProductInfoComand()]);
            menu.Start();
        }
    }
}