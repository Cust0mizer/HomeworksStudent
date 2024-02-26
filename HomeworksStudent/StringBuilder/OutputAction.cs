namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class OutputAction : IAction
    {
        public string Description => "Вывод текста";
        InputManager _inputManager = InputManager.Instance;

        public void Run()
        {
            if (_inputManager.ContainsInfo())
            {
                InputManager.Instance.PrintAll();
            }
            else
            {
                InputHelper.PrintError("Нету текста!");
            }
        }
    }
}