using HomeworksStudent;
using System.Text;

namespace ProductShopAndMenu {
    public class ConsoleProductShower : IProductShower {
        private BackButton _backButton;

        public ConsoleProductShower(ServiceLocator serviceLocator) {
            _backButton = serviceLocator.BackButton;
        }

        public void ShowProducts(List<Product> products) {
            if (products.Count == 0) {
                InputHelper.PrintError("Нет продуктов!");
            }
            else {
                ShowAllProductInfo(products);

                while (true) {
                    if (InputHelper.ChangeInput("", 1, products.Count, out int inputUserValue)) {
                        ShowProductInfo(products[inputUserValue - 1]);
                        break;
                    }
                }
            }

            _backButton.AwaitBackClick();
        }

        public void ShowAllProductInfo(List<Product> products) {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Выберети продукт");
            stringBuilder.GetDescriptionForNames(products);
            Console.WriteLine(stringBuilder);
        }

        private void ShowProductInfo(Product product) {
            Console.WriteLine($"ProductType - {product.ProductType}");
            Console.WriteLine($"Price - {product.Price}");
            Console.WriteLine($"Name - {product.Name}");
        }
    }
}