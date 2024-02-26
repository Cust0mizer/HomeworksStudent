using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class StringBuilderProgram
    {
        public static void Main(string[] args)
        {
            IAction[] actions = {
                new InputAction(),
                new OutputAction(),
                new ClearTextAction(),
                new ClearAction(),
            };

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < actions.Length; i++)
            {
                IAction action = actions[i];
                stringBuilder.Append($"{i + 1} - {action.Description}\n");
            }

            while (true)
            {
                if (InputHelper.Input(stringBuilder, 1, actions.Length, out int inputValue))
                {
                    actions[inputValue - 1].Run();
                }
            }
        }
    }

    public class ClearTextAction : IAction
    {
        public string Description => "Очистить весь текст";

        public void Run()
        {
            if (InputHelper.Input("Вы уверенны что хотите сделать это? Данное действие удалит всю записанную инф-цию\n1 - Да, уверен!\nЛюбая другая цифра", 1, 1, out int inputValue))
            {
                InputManager.Instance.Clear();
                InputHelper.PrintWarning("Текст удалён");
            }
            else
            {
                InputHelper.PrintWarning("Вы отказались от операции, текст не был удалён");
            }
        }
    }

    public enum LineMode
    {
        Line = 1,
        NewLine
    }
}