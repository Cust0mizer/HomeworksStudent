using ProductShopAndMenu;

namespace HomeworksStudent {
    public class ServiceLocator {
        #region Singleton
        public static readonly ServiceLocator Instance;

        static ServiceLocator() {
            Instance = new ServiceLocator();
        }

        #endregion

        public readonly ButtonEnumFactory ButtonEnumFactory;
        public readonly LocalizationManager LocalizationManager;
        public readonly ButtonYesOrNo ButtonYesOrNo;
        public readonly BackButton BackButton;
        public readonly ShopModel Shop;

        private ServiceLocator() {
            ButtonEnumFactory = new ButtonEnumFactory();
            ButtonYesOrNo = new ButtonYesOrNo();
            BackButton = new BackButton();
            LocalizationManager = new LocalizationManager(Locales.Ru);
            Shop = new ShopModel(new ConsoleProductShower(this, LocalizationManager));
        }
    }
}