namespace HomeworksStudent.EventAbstract
{
    public class End1_1 : Event
    {
        public override void Run()
        {
            InputHelper.PrintColor("Вы начали собирать горы золота и вдруг пещера закрылась, вы останетесь там навсегда!", ConsoleColor.Red);
        }
    }
}