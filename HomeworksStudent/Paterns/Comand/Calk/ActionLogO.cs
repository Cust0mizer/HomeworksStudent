namespace HomeworksStudent.Paterns.Comand.Calk
{
    public class ActionLogO : Action
    {
        public override string Description => "Расчет логарифмической сложности";

        public override void Run()
        {
            Console.WriteLine("Введите длинну массива");
            if (int.TryParse(Console.ReadLine(), out int inputValue))
            {
                float result = MathF.Ceiling(MathF.Log2(inputValue));
                InputHelper.PrintGoodMessage($"Логарифмическая сложность равна {result}");
            }
            else
            {
                InputHelper.PrintError("Что-то не то(");
            }
        }
    }
}