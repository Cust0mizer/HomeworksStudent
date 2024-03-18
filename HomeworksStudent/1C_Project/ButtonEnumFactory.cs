using HomeworksStudent.MenuProject;

namespace ProductShopAndMenu {
    public class ButtonEnumFactory {
        Dictionary<Type, ProductTypeFactory> _factories = new() {
                { typeof(ProductType), new ProductTypeFactory() },
                { typeof(Locales), new ProductTypeFactory() },
            };

        public IMenuItem[] GetButtons<T>(Action<T> action) where T : Enum {
            return _factories[typeof(T)].GetButtons(action).ToArray();
        }
    }
}