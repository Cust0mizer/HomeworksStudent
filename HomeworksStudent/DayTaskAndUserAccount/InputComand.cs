using HomeworksStudent.SmartHome;

namespace HomeworksStudent.DayTaskAndUserAccount
{
    public class InputComand : IComandd
    {
        public string Description => "Вход в аккаунт";

        public void Run()
        {
            Console.WriteLine("Введите имя пользователя");
            string userName = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string userPassword = Console.ReadLine();
            if (UserManager.GetInstance().CheckUser(userName, userPassword))
            {
                Console.WriteLine("Вы вошли в приложение!");
            }
        }
    }
}