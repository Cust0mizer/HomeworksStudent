namespace HomeworksStudent.EventAbstract
{
    public class End2_2 : Event
    {
        public override void Run()
        {
            InputHelper.PrintColor("Вы развернулись назад, но оступились, упали и сломали ногу, вскоре дракон проснулся и убил вас", ConsoleColor.Red);
        }
    }
}