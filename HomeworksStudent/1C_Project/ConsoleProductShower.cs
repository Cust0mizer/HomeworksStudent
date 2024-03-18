using Google.Apis.Util;
using HomeworksStudent;
using HomeworksStudent.SmartHome;
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
            LocaleKey result = ConvertEnumToType<ProductType, LocaleKey>(product.ProductType);
            if (Enum.TryParse(product.ProductType.ToString(), out LocaleKey localeKey))
            {
                Console.WriteLine($"{_localizationManager.GetLocaleText(LocaleKey.ProductTypeText)} - {_localizationManager.GetLocaleText(localeKey)}");
            }
            else
            {
                throw new KeyNotFoundException($"Error parse {product.ProductType} to {localeKey}");
            }

            Console.WriteLine($"{_localizationManager.GetLocaleText(LocaleKey.ProductPriceText)} - {product.Price}");
            Console.WriteLine($"{_localizationManager.GetLocaleText(LocaleKey.ProductNameText)} - {product.Name}");
        }

        private ResultEnumType ConvertEnumToType<TargetEnumType, ResultEnumType>(TargetEnumType firstEnumType) where TargetEnumType : struct, Enum where ResultEnumType : struct, Enum
        {
            if (Enum.TryParse(firstEnumType.ToString(), out ResultEnumType localeKey))
            {
                return localeKey;
            }
            else
            {
                throw new KeyNotFoundException($"Error parse {firstEnumType.GetType().Name} to {localeKey.GetType().Name}");
            }
        }
    }
}