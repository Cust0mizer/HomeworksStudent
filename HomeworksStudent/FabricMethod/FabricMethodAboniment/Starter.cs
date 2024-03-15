namespace HomeworksStudent.FabricMethod.FabricMethod2
{
    public class FactoryMethodStarter : IEntryPoint
    {
        public void Start()
        {
            FabricManager fabricManager = new FabricManager();
            AbonimetnCreator_1 abonimetnCreator = new AbonimetnCreator_1();
            //Aboniment_1 elem = fabricManager.GetFactory<AbonimetnCreator_1>(100);
            //elem.GetInfo();
        }
    }

    public class FabricManager
    {
        public Dictionary<Type, IAbonimetnCreator> keyValuePairs = new Dictionary<Type, IAbonimetnCreator>();

        public Aboniment GetFactory<T>(float price) where T : IAbonimetnCreator
        {
            return keyValuePairs[typeof(T)].CreateAbonimetn(price);
        }
    }
}