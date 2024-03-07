namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class OutputAction : IAction, IDescription
    {
        public string Description => "Вывод текста";
        StringBuilderService _inputManager = StringBuilderService.Instance;

        public void Run()
        {
            if (_inputManager.ContainsInfo())
            {
                _inputManager.PrintAll();
            }
            else
            {
                InputHelper.PrintError("Нету текста!");
            }
        }
    }
}