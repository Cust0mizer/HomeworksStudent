namespace HomeworksStudent.EventAbstract
{
    public class Event2_2 : Event
    {
        public override void Run()
        {
            Console.WriteLine("Вы поворачиваете направо и видите спящего дракона, попробовать пойти дальше или развернуться и уйти?");
            InputHelper.PrintColor("1 - Дальше?", ConsoleColor.Green);
            InputHelper.PrintColor("2 - Назад(", ConsoleColor.Green);

            if (InputHelper.ChangeInput("", 1, 2, out int inputValue2_2))
            {
                switch (inputValue2_2)
                {
                    case 1:
                        End2_1 end2_1 = new End2_1();
                        end2_1.Run();
                        break;
                    case 2:
                        End2_2 end2_2 = new End2_2();
                        end2_2.Run();
                        break;
                }
            }
        }
    }
}