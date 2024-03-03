using HomeworksStudent.Homeworks.Sedishev.Shop;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public partial class StringBuilderProgram
    {
        public const bool IS_CHANGE_APPEND_ENABLE = true;

        public static void Maisn(string[] args)
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
                if (InputHelper.Input(ActionHelper.GetDescriptionForAction(actions), 1, actions.Length, out int inputUserValue))
                {
                    actions[inputUserValue - 1].Run();
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