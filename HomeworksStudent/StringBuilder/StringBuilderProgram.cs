using System;
using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public partial class StringBuilderProgram
    {
        public static void Main(string[] args)
        {
            IAction[] actions = {
                new InputAction(),
                new OutputAction(),
                new ClearTextAction(),
                new ReplaceAction(),
                new ClearConsoleAction(),
            };

            while (true)
            {
                if (InputHelper.Input(ActionHelper.GetDescriptionForAction(actions), 1, actions.Length, out int inputValue))
                {
                    actions[inputValue - 1].Run();
                }
            }
        }
    }

    public enum LineMode
    {
        Line = 1,
        NewLine
    }
}