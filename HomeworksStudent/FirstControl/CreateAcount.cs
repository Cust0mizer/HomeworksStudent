namespace HomeworksStudent.FirstControl
{
    public class CreateAcount : IComand
    {
        public string Description => "Создать аккаунт";

        public void Run()
        {
            Console.WriteLine("Введите имя пользователя");
            string login = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(login))
            {
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(password))
                {
                    if (!AccountManager.Instance.ContainsLogin(login))
                    {
                        AccountManager.Instance.AddAccount(new Account(login, password));
                    }
                }
            }
        }
    }
}