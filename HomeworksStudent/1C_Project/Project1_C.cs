using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class Project1_C : IEntryPoint
    {
        LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;

        public void Start()
        {
            IMenuItem[] menuItems = {
                new AddComand(),
                new RemoveComand(),
                new ShowProductInfoComand(),
                new ShowProductForCategory(),
                new SetLocaleComand(),
            };

            Menu menu = new Menu(menuItems);
            while (true)
            {
                menu.Start(true, _localizationManager.GetLocaleText(LocaleKey.SelectAction));
            }
        }
    }

    public class MyDictionaryClass
    {
        public static readonly MyDictionaryClass Instance;
        static MyDictionaryClass()
        {
            Instance = new MyDictionaryClass();
        }
        private MyDictionaryClass() { }

        private Dictionary<string, string> _rootDictionary = new Dictionary<string, string>();

        public void SetLocale(Language language)
        {
            _rootDictionary = Localesss.GetLocale(language);
        }

        public string GetText(string key)
        {
            return _rootDictionary[key];
        }
    }

    public static class Localesss
    {
        private static Dictionary<string, string> _ruDictionary = new Dictionary<string, string>()
        {
            {"keyAddProduct","Добавить продукты!" },
            {"keyRemoveProduct","Удалить продукты!" },
            {"keyShowProductInfo","Показать информацию о продуктах!" },
        };

        private static Dictionary<string, string> _enDictionary = new Dictionary<string, string>()
        {
            {"keyAddProduct","Add product!" },
            {"keyRemoveProduct","Remove product!" },
            {"keyShowProductInfo","Show info product!" },
        };

        public static Dictionary<string, string> GetLocale(Language language)
        {
            switch (language)
            {
                case Language.English:
                return _enDictionary;
                default:
                return _ruDictionary;
            }
        }
    }

    public enum Language
    {
        English,
        Russian
    }
}