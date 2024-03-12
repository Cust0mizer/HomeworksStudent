using HomeworksStudent.PersonAbstract.StringBuilders;

namespace HomeworksStudent.SmartHome
{
    public class HomeManager
    {
        public static readonly HomeManager Instance;
        private HomeManager()
        { }

        static HomeManager()
        {
            Instance = new HomeManager();
        }

        Dictionary<Type, IAction> _keyValuePairs = new()
            {
                { typeof(LightOn), new LightOn() },
                { typeof(LightOff), new LightOff() },
                { typeof(WaterStart), new WaterStart() }
            };

        List<IAction> actions = new List<IAction>() {
        new LightOn(),
        new LightOff(),
        new LightOn(),
        }
        ;

        public void StartAction<T>() where T : IAction
        {
            _keyValuePairs[typeof(T)].Run();
        }
    }
}
