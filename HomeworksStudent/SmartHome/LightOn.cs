using HomeworksStudent.PersonAbstract.StringBuilders;

namespace HomeworksStudent.SmartHome
{
    public class LightOn : IAction
    {
        public void Run()
        {
            Console.WriteLine("Свет включился");
        }
    }
}
