namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class ReplaceAction : IAction
    {
        private InputManager _inputManager = InputManager.Instance;

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
            _inputManager.ReplaceText(firstText, secondText);
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