using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public static class ActionHelper
    {
        public static StringBuilder GetDescription(IDescription[] actions)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < actions.Length; i++)
            {
                IDescription action = actions[i];
                stringBuilder.Append($"{i + 1} - {action.Description}\n");
            }
            return stringBuilder;
        }

        public static StringBuilder GetDescriptionForAction<T>(T[] gameTasks)
        {
            IDescription[] actions = new IDescription[gameTasks.Length];

            for (var i = 0; i < gameTasks.Length; i++)
            {
                if (gameTasks[i] is IDescription description)
                {
                    actions[i] = description;
                }
                else
                {
                    InputHelper.PrintError("Ошибка преобразования");
                }
            }
            return GetDescription(actions);
        }
    }
}