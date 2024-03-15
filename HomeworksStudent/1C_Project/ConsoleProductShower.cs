using HomeworksStudent;
using HomeworksStudent.SmartHome;
using System.Text;

namespace ProductShopAndMenu
{
    public class ConsoleProductShower : IProductShower
    {
        private BackButton _backButton = ServiceLocator.Instance.BackButton;

        public void ShowProduct(List<Product> products)
        {
            ShowAllProductInfo(products);
            while (true)
            {
                if (InputHelper.ChangeInput("", 1, products.Count, out int inputUserValue))
                {
                    ShowProductInfo(products[inputUserValue - 1]);
                    break;
                }
            }

            _backButton.AwaitBackClick();
        }

        public void ShowAllProductInfo(List<Product> products)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.GetDescriptionForNames(products);
            Console.WriteLine(stringBuilder);
        }

        private void ShowProductInfo(Product product)
        {
            Console.WriteLine($"ProductType - {product.ProductType}");
            Console.WriteLine($"Price - {product.Price}");
            Console.WriteLine($"Name - {product.Name}");
        }
    }
}