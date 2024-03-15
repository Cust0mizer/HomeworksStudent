using HomeworksStudent.MenuProject;
using HomeworksStudent;
using System.Text;

namespace ProductShopAndMenu
{
    public class AddComand : IAction, IMenuItem
    {
        public string Description => "Добавление продуктов";

        private Shop _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            if (InputHelper.TextInputField("Введите имя продукта", out string productName))
            {
                Console.WriteLine("Введите цену продукта");
                if (int.TryParse(Console.ReadLine(), out int price))
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.GetDescriptionForEnum<ProductType>("Выберите категорию");
                    if (InputHelper.ChangeInput(stringBuilder, 1, Enum.GetValues(typeof(ProductType)).Length, out int inputValue))
                    {
                        _shop.AddProduct(new Product((ProductType)(inputValue - 1), productName, price));
                    }
                }
            }
        }
    }
}