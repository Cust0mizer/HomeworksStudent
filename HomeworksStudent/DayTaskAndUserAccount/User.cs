namespace HomeworksStudent.DayTaskAndUserAccount
{
    public class User
    {
        public readonly string UserName;
        public readonly string Password;

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public bool PasswordIsTrue(string password)
        {
            return Password == password;
        }
    }
}