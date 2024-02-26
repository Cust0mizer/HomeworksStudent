namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class ClearConsoleAction : IAction
    {
        public string Description => "Очистить экран";

        public void Run()
        {
            Console.Clear();
        }
    }
}