namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class ReplaceAction : IAction, IDescription
    {
        private StringBuilderService _inputManager = StringBuilderService.Instance;
        private ButtonYesOrNo _buttonYesOrNo = ButtonYesOrNo.Instance;

        public string Description => "Замена строк";
        private const string EMPTY_STRING_ERROR = "Строка не может быть пустой!";


        public void Run()
        {
            if (!_inputManager.ContainsInfo())
            {
                InputHelper.PrintError("Вы ничего не добавили в строку!");
                return;
            }
            _inputManager.PrintAll();
            string firstText = GetInputString("Введите строку, которую хотите заменить");
            string secondText = GetInputString("Введите вторую строку");
            InputHelper.PrintWarning("В строке:");
            _inputManager.PrintAll();
            InputHelper.PrintWarning($"Вы замените все {firstText} на {secondText}");

            if (_buttonYesOrNo.GetResult("Подвтердить?\n1 - Да\nЛюбой другой символ - нет"))
            {
                _inputManager.ReplaceText(firstText, secondText);
                InputHelper.PrintGoodMessage($"У вас получилось");
                _inputManager.PrintAll();
            }
            else
            {
                InputHelper.PrintWarning("Вы отказались от операции!");
            }
        }

        private string GetInputString(string description)
        {
            Console.WriteLine(description);
            string resultText = Console.ReadLine();

            while (string.IsNullOrEmpty(resultText))
            {
                InputHelper.PrintError(EMPTY_STRING_ERROR);
                Console.WriteLine(description);
                resultText = Console.ReadLine();
            }
            return resultText;
        }
    }
}
