using HomeworksStudent.MenuProject;

namespace ProductShopAndMenu {
    public class ButtonEnumFactory {
        private EnumButtonFactory enumButtonFactory = new();

        public IMenuItem[] GetButtonsByEnum<T>(Action<T> action) where T : struct, Enum {
            return enumButtonFactory.GetButtons(action).ToArray();
        }
    }
}