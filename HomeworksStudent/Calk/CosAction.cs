namespace HomeworksStudent.Calk
{
    public class CosAction : Action
    {
        public override string Description => "Это высчитает косинус числа";

        public override void Run()
        {
            Console.WriteLine("Введите число");
            int.TryParse(Console.ReadLine(), out int inputValue);
            float result = MathF.Cos(inputValue);
            Console.WriteLine($"Косинус числа {inputValue} равен {result}");
        }
    }

    public class SinAction : Action
    {
        public override string Description => "Расчет синуса числа";

        public override void Run()
        {
            Console.WriteLine("Введите число");

            if (int.TryParse(Console.ReadLine(), out int inputValue))
            {
                float result = MathF.Sin(inputValue);
                Console.WriteLine($"Синус числа {inputValue} равен {result}");
            }
            else
            {
                InputHelper.PrintError("Ошибка!");
            }
        }
    }
}

