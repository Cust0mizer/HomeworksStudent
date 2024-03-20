namespace ProductShopAndMenu
{
    public static class Locale
    {
        //Key/text

        private static readonly Dictionary<LocaleKey, string> RuLocale = new Dictionary<LocaleKey, string>() {
            { LocaleKey.Vegetables, "Овощи" },
            { LocaleKey.Fruits, "Фрукты" },
            { LocaleKey.Bakery, "Выпечка" },
            { LocaleKey.SetProductName, "Введите имя продукта" },
            { LocaleKey.Localization, "Локализация" },
            { LocaleKey.AddProduct, "Добавление продуктов" },
            { LocaleKey.SetProductPrice, "Введите цену продукта" },
            { LocaleKey.SetProductType, "Выберети тип продукта" },
            { LocaleKey.SelectAction, "Выберите действие" },
            { LocaleKey.NoProduct, "Нет продуктов в магазине" },
            { LocaleKey.SelectProductType, "Выберете категорию" },
            { LocaleKey.ShowProductsByCategory, "Показать продукты по категории" },
            { LocaleKey.ShowProductInfo, "Показать информацию о продуктах" },
            { LocaleKey.RemoveProduct, "Удалить продукты" },
            { LocaleKey.SelectProduct, "Выберете продукт" },
            { LocaleKey.ProductPriceText, "Цена продукта" },
            { LocaleKey.ProductNameText, "Имя продукта" },
            { LocaleKey.ProductTypeText, "Категория продукта" },
            { LocaleKey.Ru, "Русский" },
            { LocaleKey.En, "Английский" },
        };

        private static readonly Dictionary<LocaleKey, string> EnLocale = new Dictionary<LocaleKey, string>() {
            { LocaleKey.Vegetables, "Vegetables" },
            { LocaleKey.Fruits, "Fruits" },
            { LocaleKey.Bakery, "Bakery" },
            { LocaleKey.SetProductName, "Set product name" },
            { LocaleKey.Localization, "Localization" },
            { LocaleKey.AddProduct, "Add Product" },
            { LocaleKey.SetProductPrice, "Set product price" },
            { LocaleKey.SetProductType, "Set product type" },
            { LocaleKey.SelectAction, "Select action" },
            { LocaleKey.NoProduct, "No products by shop" },
            { LocaleKey.SelectProductType, "Select product type" },
            { LocaleKey.ShowProductsByCategory, "Show products by category" },
            { LocaleKey.ShowProductInfo, "Show product info" },
            { LocaleKey.RemoveProduct, "Remove product" },
            { LocaleKey.SelectProduct, "Select product" },
            { LocaleKey.ProductPriceText, "Product price" },
            { LocaleKey.ProductNameText, "Product name" },
            { LocaleKey.ProductTypeText, "Product type" },
            { LocaleKey.Ru, "Russian" },
            { LocaleKey.En, "English" },
        };

        public static Dictionary<LocaleKey, string> GetLocale(Locales locales)
        {
            Dictionary<LocaleKey, string> result = null;

            switch (locales)
            {
                case Locales.En:
                    result = EnLocale;
                    break;
                default:
                    result = RuLocale;
                    break;
            }

            return result;
        }
    }

    public enum LocaleKey
    {
        Vegetables,
        Fruits,
        Bakery,
        SetProductName,
        Localization,
        AddProduct,
        SetProductPrice,
        SetProductType,
        SelectAction,
        SelectProductType,
        NoProduct,
        ShowProductsByCategory,
        ShowProductInfo,
        SelectProduct,
        RemoveProduct,
        ProductNameText,
        ProductTypeText,
        ProductPriceText,
        Ru,
        En
    }

    public enum Locales
    {
        Ru = 1,
        En
    }
}



//Создать класс который будет содержать словарь где ключ и значение будут string
//Сделать из класса синглетон
//Создать метод, куда мы будем передавать ключ и получать значение из словоря по ключу
//Создать статический класс, который содержит в себе 2 словоря, с английскими словами и русскими
//Заполнить словарь вашими ключами и значениями из программы