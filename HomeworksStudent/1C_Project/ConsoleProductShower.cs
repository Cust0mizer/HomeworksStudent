using HomeworksStudent;
using System.Text;

namespace ProductShopAndMenu
{
    public class ConsoleProductShower : IProductShower
    {
        private LocalizationManager _localizationManager;
        private BackButton _backButton;

        public ConsoleProductShower(ServiceLocator serviceLocator, LocalizationManager localizationManager)
        {
            _localizationManager = localizationManager;
            _backButton = serviceLocator.BackButton;
        }

        public void ShowProducts(List<Product> products)
        {
            if (products.Count == 0)
            {
                InputHelper.PrintError(_localizationManager.GetLocaleText(LocaleKey.NoProduct));
            }
            else
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
            }

            _backButton.AwaitBackClick();
        }

        public void ShowAllProductInfo(List<Product> products)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(_localizationManager.GetLocaleText(LocaleKey.SelectProduct));
            stringBuilder.GetDescriptionForNames(products);
            Console.WriteLine(stringBuilder);
        }

        private void ShowProductInfo(Product product)
        {
            if (InputHelper.ConvertEnumToType(product.ProductType, out LocaleKey resultValue))
            {
                Console.WriteLine($"{_localizationManager.GetLocaleText(LocaleKey.ProductTypeText)} - {_localizationManager.GetLocaleText(resultValue)}");
            }
            else
            {
                throw new KeyNotFoundException($"Error parse {product.ProductType} to {resultValue}");
            }

            Console.WriteLine($"{_localizationManager.GetLocaleText(LocaleKey.ProductPriceText)} - {product.Price}");
            Console.WriteLine($"{_localizationManager.GetLocaleText(LocaleKey.ProductNameText)} - {product.Name}");
        }
    }
}



//В классе где один словарь сделать метод SetLocale, где в зависимости от принимаемого значения, Ru или En, присваивать в наш словарь именно тот словарь, который нужен:]

//Добавить команду, которая реализует интерфейс команды и предоставляет пользователю выбор, 1 или 2
//Добавить в программу команду, где пользователю дается выбор, при нажатии на 1 - выбирается английский язык, при нажатии на 2 - выбирается русский язык.
//Везде где используется текст, нужно прокинуть ссылку на ЛОКАЛЕ МАНАДЖЕР, и во всей программе, вместо текста нужно использовать GetLocaleText(key).
