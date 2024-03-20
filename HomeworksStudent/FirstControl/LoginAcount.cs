namespace HomeworksStudent.FirstControl
{
    public class LoginAcount : IComand
    {
        public string Description => "Войти в аккаунт";
        private int _maxTryCount = 3;

        public void Run()
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();

            if (AccountManager.Instance.ContainsLogin(login))
            {
                for (int tryCounter = 1; tryCounter <= _maxTryCount; tryCounter++)
                {
                    Console.WriteLine($"Попытка {tryCounter} из {_maxTryCount}");
                    Console.WriteLine("Введите пароль");
                    string password = Console.ReadLine();

                    if (AccountManager.Instance.CheckPassword(login, password))
                    {
                        TaskManager.Instance.SetAccount(AccountManager.Instance.GetAccount(login));
                        ProgramScreen programScreen = new ProgramScreen();
                        programScreen.Start();
                        return;
                    }
                }
            }
        }
    }
}