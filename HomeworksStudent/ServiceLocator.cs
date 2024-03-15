using ProductShopAndMenu;

namespace HomeworksStudent
{
    public class ServiceLocator
    {
        #region Singleton
        public static readonly ServiceLocator Instance;

        static ServiceLocator()
        {
            Instance = new ServiceLocator();
        }

        #endregion

        public readonly ButtonYesOrNo ButtonYesOrNo;
        public readonly BackButton BackButton;
        public readonly Shop Shop;

        private ServiceLocator()
        {
            ButtonYesOrNo = new ButtonYesOrNo();
            BackButton = new BackButton();
            Shop = new Shop();
        }
    }
}