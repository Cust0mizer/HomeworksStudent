using ProductShopAndMenu;

public class ServiceLocator
{
    #region Singleton
    public static readonly ServiceLocator Instance;

    static ServiceLocator()
    {
        Instance = new ServiceLocator();
    }

    #endregion

    public readonly Shop Shop;

    private ServiceLocator()
    {
        Shop = new Shop();
    }
}
