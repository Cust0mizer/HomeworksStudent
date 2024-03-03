namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class ClearTextAction : IAction
    {
        public string Description => "Очистить весь текст";

        public ButtonYesOrNo _buttonYesOrNo = ButtonYesOrNo.Instance;
        public InputManager _inputManager = InputManager.Instance;

        public void Run()
        {
            if (_inputManager.ContainsInfo())
            {
                if (_buttonYesOrNo.GetResult("Вы уверенны что хотите сделать это? Данное действие удалит всю записанную инф-цию\n1 - Да, уверен!\nЛюбая другая цифра"))
                {
                    InputManager.Instance.Clear();
                    InputHelper.PrintWarning("Текст удалён");
                }
                else
                {
                    InputHelper.PrintWarning("Вы отказались от операции, текст не был удалён");
                }
            }
            else
            {
                InputHelper.PrintError("Нельзя отчистить того, чего нет!");
            }
        }
    }
}