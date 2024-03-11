using HomeworksStudent.PersonAbstract.StringBuilders;

namespace HomeworksStudent.SmartHome
{
    public class LightOff : IAction
    {
        public void Run()
        {
            Console.WriteLine("Свет Выключился");
        }
    }
}
