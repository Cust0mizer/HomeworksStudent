namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class ClearAction : IAction
    {
        public string Description => "Очистить экран";

        public void Run()
        {
            Console.Clear();
        }
    }
}