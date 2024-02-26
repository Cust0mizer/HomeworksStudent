using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public partial class StringBuilderProgram
    {
        public static class ActionHelper
        {
            public static StringBuilder GetDescriptionForAction(IAction[] actions)
            {
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < actions.Length; i++)
                {
                    IAction action = actions[i];
                    stringBuilder.Append($"{i + 1} - {action.Description}\n");
                }
                return stringBuilder;
            }

            public static StringBuilder GetDescriptionForAction(List<IAction> actions)
            {
                return GetDescriptionForAction(actions.ToArray());
            }
        }
    }
}