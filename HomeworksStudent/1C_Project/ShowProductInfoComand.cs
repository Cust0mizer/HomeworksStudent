using HomeworksStudent.MenuProject;
using HomeworksStudent;
using System.Text;
using HomeworksStudent.InstallComand;

namespace ProductShopAndMenu
{
    public class ShowProductInfoComand : IAction, IMenuItem
    {
        public string Description => "Показать информацию о продуктах";
        private BackButton _backButton = ServiceLocator.Instance.BackButton;
        private ShopModel _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            if (_shop.ContainsProduct())
            {
                _shop.ShowProductInfo();
            }
            else
            {
                ShopErrorHelper.NoProductMessage();
                _backButton.AwaitBackClick();
            }
        }
    }










    public class ControlStarter : IEntryPoint
    {
        public void Start()
        {
            //Main
            IComand[] createAcounts =
            {
                new CreateAcount(),     //0
                new ShowInfoAcount(),   //1
                new LoginAcount()       //2
            };

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Выберите действие!");

            for (int i = 0; i < createAcounts.Length; i++)
            {
                stringBuilder.AppendLine($"{i + 1} - {createAcounts[i].Description}");
            }

            while (true)
            {
                Console.WriteLine(stringBuilder);
                if (int.TryParse(Console.ReadLine(), out int inputValue))
                {
                    if (inputValue >= 1 && inputValue <= createAcounts.Length)
                    {
                        createAcounts[inputValue - 1].Run();
                    }
                }
            }
        }
    }

    public interface IComand
    {
        public string Description { get; }
        public void Run();
    }

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

    public class ShowInfoAcount : IComand
    {
        public string Description => "Показать информацию о аккаунтах";

        public void Run()
        {
            AccountManager.Instance.ShowAccountInfo();
        }
    }

    public class LoginAcount : IComand
    {
        public string Description => "Войти в аккаунт";

        public void Run()
        {
            Console.WriteLine("Пока ничего нет!");
        }
    }

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

        public void LoginAccount()
        {

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
    }

    public class Account
    {
        public string Login { get; private set; }
        public string Password { get; private set; }

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void PrintInfo()
        {
            Console.Write($"Login - {Login}\tPassword - {Password}");
        }
    }
}