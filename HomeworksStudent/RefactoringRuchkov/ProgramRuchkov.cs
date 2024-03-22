using System.Text;
using System.Collections;

namespace HomeworksStudent.RefactoringRuchkov
{
    internal class ProgramRuchkov
    {
        static void MainR(string[] args)
        {
            IAction[] actions = {
                new ActionInput(),
                new PrintAction()

            };

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < actions.Length; i++)
            {
                stringBuilder.AppendLine($"{i + 1} - {actions[i].Description}");
            }

            while (true)
            {
                if (InputHelper.Input(stringBuilder.ToString(), 1, actions.Length, out int inputValue))
                {
                    actions[inputValue - 1].Run();
                }
                continue;

                int b = 1;
                if (b == 1)
                {

                }
                else if (b == 2 && stringBuilder.Length != 0)
                {

                }
                else if (b == 2 && stringBuilder.Length == 0)
                {

                }
                if (b == 3)
                {
                    if (stringBuilder.Length == 0)
                        Console.WriteLine("Там пусто!!!");
                    else
                    {
                        Clear();
                        string j = Console.ReadLine();
                        int.TryParse(j, out int k);
                        if (k == 1)
                            stringBuilder.Clear();
                        else
                            continue;
                    }
                }
                if (b == 4)
                {
                    if (stringBuilder.Length == 0)
                        Console.WriteLine("Там пусто!!!");
                    else
                    {
                        Console.WriteLine(stringBuilder);
                        Repl1();
                        string e = Console.ReadLine();
                        Repl2();
                        string r = Console.ReadLine();
                        Console.WriteLine("Вы хотите заменить все " + e + " на " + r + "?");
                        Console.WriteLine("Подтвердить?\n 1 - Да\n2 - Нет");
                        string u = Console.ReadLine();
                        int.TryParse(u, out int l);
                        if (l == 1)
                        {
                            stringBuilder.Replace(e, r);
                            Console.WriteLine(stringBuilder);
                        }
                        else
                            continue;
                    }
                }
                if (b == 5)
                {
                    Console.Clear();
                }
            }

            static void Menu()
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("|1 - Ввод текста        |");
                Console.WriteLine("|2 - Вывод текста       |");
                Console.WriteLine("|3 - Удалить весь текст |");
                Console.WriteLine("|4 - Заменить текст     |");
                Console.WriteLine("|5 - Отчистить экран    |");
                Console.WriteLine("-------------------------");
            }

            static void Clear()
            {
                Console.WriteLine("Вы уверены что хотите удалить весь текст?\n 1 - Да\n 2 - Нет");
            }

            static void Repl1()
            {
                Console.WriteLine("Какую строку вы хотите заменить?");
            }

            static void Repl2()
            {
                Console.WriteLine("На что вы хотите заменить ее?");
            }
        }
    }

    public class ActionInput : IAction
    {
        public string Description => "Ввод текста";

        public void Run()
        {
            IList<LineMode> modes = GetAndPrintLineModes();

            if (InputHelper.Input("", (int)modes[0], (int)modes[modes.Count - 1], out int inputValue))
            {
                Console.WriteLine("Введите текст");
                StringBuilderManager.Instance.AddContent(Console.ReadLine(), (LineMode)inputValue);
            }
        }

        private IList<LineMode> GetAndPrintLineModes()
        {
            LineMode[] lineModes = (LineMode[])Enum.GetValues(typeof(LineMode));
            StringBuilder stringBuilder = new StringBuilder();

            for (var i = 0; i < lineModes.Length; i++)
            {
                stringBuilder.Append($"{i + 1} - {lineModes[i]}");
            }
            Console.WriteLine(stringBuilder);
            return lineModes;
        }
    }

    public class PrintAction : IAction
    {
        public string Description => "Вывод информации";

        public void Run()
        {
            if (StringBuilderManager.Instance.ContainsInfo())
            {
                StringBuilderManager.Instance.PrintInfo();
            }
        }
    }

    public class StringBuilderManager
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();
        public static StringBuilderManager Instance;

        static StringBuilderManager()
        {
            Instance = new StringBuilderManager();
        }

        private StringBuilderManager()
        { }

        public void AddContent(string text, LineMode lineMode)
        {
            switch (lineMode)
            {
                case LineMode.WriteLine:
                    _stringBuilder.Append($"\n{text}");
                    break;
                case LineMode.Write:
                    _stringBuilder.Append(text);
                    break;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine(_stringBuilder);
        }

        public bool ContainsInfo()
        {
            return _stringBuilder.Length > 0;
        }

        public void ReplaceText(string firstText, string secondText)
        {
            _stringBuilder.Replace(firstText, secondText);
        }

        public void ClearAllText()
        {
            _stringBuilder.Clear();
        }
    }

    public static class InputHelper
    {
        public static bool Input(string description, int min, int max, out int inputValue)
        {
            Console.WriteLine(description);
            bool result = false;

            if (int.TryParse(Console.ReadLine(), out inputValue))
            {
                if (inputValue >= min && inputValue <= max)
                {
                    result = true;
                }
            }

            return result;
        }
    }

    public interface IAction
    {
        public string Description { get; }
        public void Run();
    }

    public enum LineMode
    {
        WriteLine = 1,
        Write
    }
}