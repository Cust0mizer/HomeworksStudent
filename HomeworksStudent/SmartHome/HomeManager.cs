using HomeworksStudent.PersonAbstract.StringBuilders;

namespace HomeworksStudent.SmartHome
{
    public class HomeManager
    {
        Dictionary<Type, IAction> _keyValuePairs = new()
            {
                { typeof(LightOn), new LightOn() },
                { typeof(LightOff), new LightOff() },
                { typeof(WaterStart), new WaterStart() }
            };

        public void StartAction<T>() where T : IAction
        {
            _keyValuePairs[typeof(T)].Run();
        }
    }
}
