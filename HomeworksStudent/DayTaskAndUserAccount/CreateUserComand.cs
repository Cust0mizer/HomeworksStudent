using HomeworksStudent.SmartHome;

namespace HomeworksStudent.DayTaskAndUserAccount
{
    public class CreateUserComand : IComandd
    {
        public string Description => "Создать пользователя";

        public void Run()
        {
            Console.WriteLine("Введите имя пользователя");
            string userName = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string userPassword = Console.ReadLine();
            UserManager.GetInstance().AddUser(new User(userName, userPassword));
        }
    }
}