namespace HomeworksStudent.EventAbstract
{
    public class Event1_1 : Event
    {
        public override void Run()
        {
            Console.WriteLine("Вы входите в пещеру, у вас 2 пути, налево и направо");
            InputHelper.PrintColor("1 - Налево", ConsoleColor.Green);
            InputHelper.PrintColor("2 - Направо", ConsoleColor.Green);
        }
    }
}