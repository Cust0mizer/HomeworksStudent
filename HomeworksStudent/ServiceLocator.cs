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
        public readonly TranslateModule TranslateModule;
        public readonly ButtonYesOrNo ButtonYesOrNo;
        public readonly BackButton BackButton;
        public readonly ShopModel Shop;

        private ServiceLocator() {
            ButtonEnumFactory = new ButtonEnumFactory();
            TranslateModule = new TranslateModule(Locales.Ru);
            ButtonYesOrNo = new ButtonYesOrNo();
            BackButton = new BackButton();
            Shop = new ShopModel(new ConsoleProductShower(this));
        }
    }
}