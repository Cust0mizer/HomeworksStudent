namespace HomeworksStudent.FirstControl
{
    public class AccountManager
    {
        #region Singletone
        public readonly static AccountManager Instance;

        static AccountManager()
        {
            Instance = new AccountManager();
        }
        private AccountManager() { }
        #endregion

        private List<Account> _accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public Account GetAccount(string login)
        {
            Account? result = null;

            foreach (var account in _accounts)
            {
                if (account.Login == login)
                {
                    result = account;
                    break;
                }
            }
            return result;
        }

        public void ShowAccountInfo()
        {
            foreach (var item in _accounts)
            {
                item.PrintInfo();
            }
        }

        public bool ContainsLogin(string login)
        {
            bool result = false;

            foreach (var account in _accounts)
            {
                if (account.Login == login)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool CheckPassword(string login, string password)
        {
            bool result = false;
            foreach (var account in _accounts)
            {
                if (account.Login == login)
                {
                    if (account.Password == password)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}