namespace HomeworksStudent.PersonAbstract.StringBuilders
{
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
}