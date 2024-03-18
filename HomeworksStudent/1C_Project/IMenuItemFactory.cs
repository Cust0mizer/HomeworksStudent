using HomeworksStudent.MenuProject;

namespace ProductShopAndMenu {
    public interface IMenuItemFactory {
        public List<IMenuItem> GetButtons<T>(Action<T> action) where T : Enum;
    }
}