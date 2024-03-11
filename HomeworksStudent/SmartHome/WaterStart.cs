using HomeworksStudent.PersonAbstract.StringBuilders;

namespace HomeworksStudent.SmartHome
{
    public class WaterStart : IAction
    {
        public void Run()
        {
            Console.WriteLine("Подача воды");
        }
    }
}
