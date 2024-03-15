namespace HomeworksStudent.MenuProject
{
    public class MenuElement : IMenuItem, IAction
    {
        public string Description => "Первая кнопка";

        //public void ShowFrame()
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < Description.Length + 2; j++)
        //        {
        //            if (i == 0 || i == 2)
        //            {
        //                Console.Write("_");
        //            }
        //            else if (i == 1 && j == 0)
        //            {
        //                Console.Write($"|{Description}|");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

        public int PosX => 0;
        public int PosY => 0;

        public void Run()
        {
            Console.WriteLine("Первый!!!");
        }
    }
}