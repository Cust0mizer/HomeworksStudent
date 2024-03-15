namespace HomeworksStudent.EventAbstract
{
    public class Event2_1 : Event
    {
        public override void Run()
        {
            Console.WriteLine("Вы проходите налево и видите перед собой горы золота, стоит ли начать собирать его?");
            InputHelper.PrintColor("1 - Да!", ConsoleColor.Green);
            InputHelper.PrintColor("2 - Нет(", ConsoleColor.Green);

            if (InputHelper.ChangeInput("", 1, 2, out int inputValue2_1))
            {
                switch (inputValue2_1)
                {
                    case 1:
                        End1_1 end1_1 = new End1_1();
                        end1_1.Run();
                        break;
                    case 2:
                        End1_2 end1_2 = new End1_2();
                        end1_2.Run();
                        break;
                }
            }
        }
    }
}