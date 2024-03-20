using HomeworksStudent.MenuProject;

namespace ProductShopAndMenu
{
    public class ButtonEnumFactory {
        private EnumButtonFactory enumButtonFactory = new();

        public IButton[] GetButtonsByEnum<T>(Action<T> action) where T : struct, Enum {
            return enumButtonFactory.GetButtons(action).ToArray();
        }

        //public IMenuItem[] GetButtonsByShopItem<T>(Action<T> action) where T : struct, Enum {
        //    return
        //}
    }

    //public class 
}