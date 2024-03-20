namespace ProductShopAndMenu
{
    public class LocalizationManager
    {
        private Dictionary<LocaleKey, string> _currentLocale = new();

        public LocalizationManager(Locales locales)
        {
            SetLocale(locales);
        }

        public string GetLocaleText(LocaleKey key)
        {
            return _currentLocale[key];
        }

        public void SetLocale(Locales locales)
        {
            _currentLocale = Locale.GetLocale(locales);
        }
    }
}



//Создать класс который будет содержать словарь где ключ и значение будут string
//Сделать из класса синглетон
//Создать метод, куда мы будем передавать ключ и получать значение из словоря по ключу
//Создать статический класс, который содержит в себе 2 словоря, с английскими словами и русскими
//Заполнить словарь вашими ключами и значениями из программы