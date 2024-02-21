namespace HomeworksStudent.Calk
{
    public class ActionDivide : Action
    {
        public override string Description => "Деление числа А на число Б";

        public override void Run()
        {
            Console.WriteLine("Введите первое число");
            if (int.TryParse(Console.ReadLine(), out int firstValue))
            {
                Console.WriteLine("Введите второе число");
                if (int.TryParse(Console.ReadLine(), out int secondValue))
                {
                    int result = firstValue / secondValue;
                    Console.WriteLine($"{firstValue} / {secondValue} = {result}");
                    return;
                }
            }
            Console.WriteLine("!!!Ошибка!!!");
        }
    }
}