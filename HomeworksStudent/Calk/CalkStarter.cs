using System.Text;

namespace HomeworksStudent.Calk
{
    public class CalkStarter : IEntryPoint
    {
        public void Start()
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
                new ActionLogO(),
                new ActionConsoleClear(),
            };
            return actions;
        }
    }
}
