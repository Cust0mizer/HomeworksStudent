using HomeworksStudent.MenuProject;

namespace ProductShopAndMenu
{
    public class EnumButtonFactory : IMenuItemFactory
    {
        public List<IButton> GetButtons<T>(Action<T> action) where T : struct, Enum
        {
            IList<T> enumsValue = (IList<T>)Enum.GetValues(typeof(T));
            List<IButton> _products = new();

            for (int i = 0; i < enumsValue.Count; i++)
            {
                _products.Add(new EnumMenuItem<T>(action, enumsValue[i]));
            }

            return _products;
        }
    }

    public static class ProductItemFactory
    {
        public static List<IMenuItem> GetButtons<T>(Action<T> action, Product product)
        {
            IList<T> enumsValue = (IList<T>)Enum.GetValues(typeof(T));
            List<IMenuItem> _products = new();

            for (int i = 0; i < enumsValue.Count; i++)
            {
                _products.Add(new ProductButton<T>(action, (T)enumsValue[i], product.Name));
            }

            return _products;
        }
    }
}