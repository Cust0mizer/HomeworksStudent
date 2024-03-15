namespace HomeworksStudent.DayTaskAndUserAccount
{
    public class UserManager
    {
        private static UserManager _instance;
        public static UserManager GetInstance()
        {
            return _instance == null ? _instance = new UserManager() : _instance;
        }

        private UserManager()
        { }

        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public bool CheckUser(string userName, string password)
        {
            bool result = false;

            foreach (var item in _users)
            {
                if (item.UserName == userName)
                {
                    result = item.PasswordIsTrue(password);
                }
            }
            return result;
        }
    }
}

