namespace HomeworksStudent.Calk
{
    public class ActionConsoleClear : Action
    {
        public override string Description => "Это очистит консоль!";

        public override void Run()
        {
            Console.Clear();
        }
    }
}