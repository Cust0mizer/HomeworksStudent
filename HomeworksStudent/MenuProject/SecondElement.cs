namespace HomeworksStudent.MenuProject
{
    public class SecondElement : IMenuItem, IAction
    {
        public string Description => "Вторая кнопка";

        public int PosX => 0;
        public int PosY => 0;

        public void Run()
        {
            Console.WriteLine("Второй!!!");
        }
    }
}