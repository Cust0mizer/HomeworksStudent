namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public partial class EntryStringBuilder : IEntryPoint
    {
        public const bool IS_CHANGE_APPEND_ENABLE = true;

        public void Start()
        {
            IAction[] actions = {
                new InputAction(),
                new OutputAction(),
                new ReplaceAction(),
                new ClearConsoleAction(),
                new ClearTextAction(),
            };

            while (true)
            {
                if (InputHelper.ChangeInput(ActionHelper.GetDescriptionForAction(actions), 1, actions.Length, out int inputUserValue))
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
