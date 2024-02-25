using System.Numerics;
using System.Text;

namespace HomeworksStudent.Calk
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action[] actions = CreateAndGetActions();

            while (true)
            {
                if (InputHelper.Input(GetDescriptinoForActions(actions), min: 1, max: actions.Length, out var inputValue))
                {
                    actions[inputValue - 1].Run();
                }
            }
        }

        private static string GetDescriptinoForActions(Action[] actions)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (var i = 0; i < actions.Length; i++)
            {
                stringBuilder.AppendLine($"{i + 1} - {actions[i].Description}");
            }
            return stringBuilder.ToString();
        }

        private static Action[] CreateAndGetActions()
        {
            Action[] actions = {
                new ActionSum(),
                new ActionMinus(),
                new ActionDivide(),
                new ActionMultiply(),
                new CosAction(),
                new SinAction(),
                new ActionConsoleClear(),
            };
            return actions;
        }
    }
}


//Создать абтсрактный класс человека с методом "Работать"
//Создать 3х наследников от класса человека и прописать каждому
//Свою реализацию метода работать
//Реализация должна быть через консольный вывод

//В мейн методе, создайте коллекцию из наследников
//И вызовите у каждого метод работать в цикле Форич

//Дополнительно, в каждом из наследников создайте по одному любому 
//Методу с выводом текста на консоль, а в методе мейн в цикле сделайте
//Проверку для каждого наследника и вызовите созданный метод



public abstract class Person
{
    public abstract void Work();
}

public class FirstWorker : Person
{
    public override void Work()
    {
        Console.WriteLine("Я первый работник и я работаю");
    }

    public void SuperWork()
    {
        Console.WriteLine("Делаю очень сложное действие!");
    }
}

public class SecondWorker : Person
{
    public override void Work()
    {
        Console.WriteLine("Я Второй работник и я работаю");
    }
}

public class ThirdWorker : Person
{
    public override void Work()
    {
        Console.WriteLine("Я третий работник и я работаю");
    }
}