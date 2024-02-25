namespace HomeworksStudent.EventAbstract
{
    public class End2_1 : Event
    {
        public override void Run()
        {
            InputHelper.PrintColor("Вы тихо прошли мимо дракона и он вас не услышал, вы остались живы!", ConsoleColor.Green);
        }
    }
}