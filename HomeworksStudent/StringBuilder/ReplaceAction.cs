namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class ReplaceAction : IAction
    {
        private InputManager _inputManager = InputManager.Instance;
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
            string firstText = GetString("Введите строку, которую хотите заменить");
            string secondText = GetString("Введите вторую строку");
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
                Console.WriteLine("Вы отказались от операции!");
            }
        }

        private string GetString(string description)
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
