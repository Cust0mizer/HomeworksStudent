using HomeworksStudent.MenuProject;
using System.Collections;

namespace ProductShopAndMenu {
    public class EnumButtonFactory : IMenuItemFactory {
        public List<IMenuItem> GetButtons<T>(Action<T> action) where T : struct, Enum {
            IList enumsValue = Enum.GetValues(typeof(T));
            List<IMenuItem> _products = new();

            for (int i = 0; i < enumsValue.Count; i++) {
                _products.Add(new EnumMenuItem<T>(action, (T)enumsValue[i]));
            }

            return _products;
        }
    }
}