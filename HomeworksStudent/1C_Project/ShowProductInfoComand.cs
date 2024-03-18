using HomeworksStudent;
using System.Text;

namespace ProductShopAndMenu
{
    public class ShowProductInfoComand : IAction, IMenuItem
    {
        public string Description => _localizationManager.GetLocaleText(LocaleKey.ShowProductInfo);
        private LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;
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
}

//Это контрольная для рпо 1
namespace Control
{
    public class ControlStarter123123123123123123 : IEntryPoint
    {
        public void Start()
        {
            //Main
            IComand[] createAcounts =
            {
                new CreateAcount(),
                new ShowInfoAcount(),
                new LoginAcount()
            };

            while (true)
            {
                if (InputHelper.CheckInput(DescriptionHelper.GetDescription(createAcounts), 1, createAcounts.Length, out int inputValue))
                {
                    createAcounts[inputValue - 1].Run();
                }
            }
        }
    }

    public static class InputHelper
    {
        public static bool CheckInput(StringBuilder stringBuilder, int minValue, int maxValue, out int inputValue)
        {
            bool result = false;

            Console.WriteLine(stringBuilder);
            if (int.TryParse(Console.ReadLine(), out inputValue))
            {
                if (inputValue >= minValue && inputValue <= maxValue)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool CheckInput(string text, int minValue, int maxValue, out int inputValue)
        {
            bool result = false;

            if (!string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine(text);
            }

            if (int.TryParse(Console.ReadLine(), out inputValue))
            {
                if (inputValue >= minValue && inputValue <= maxValue)
                {
                    result = true;
                }
            }

            return result;
        }
    }

    public static class DescriptionHelper
    {
        public static StringBuilder GetDescription(IComand[] comands)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Выберите действие!");

            for (int i = 0; i < comands.Length; i++)
            {
                stringBuilder.AppendLine($"{i + 1} - {comands[i].Description}");
            }
            return stringBuilder;
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

                    }
                }
            }
        }
    }

    public class ProgramScreen
    {
        public void Start()
        {
            while (true)
            {
                IComand[] createAcounts =
                {

                };

                while (true)
                {
                    if (InputHelper.CheckInput(DescriptionHelper.GetDescription(createAcounts), 1, createAcounts.Length, out int inputValue))
                    {
                        createAcounts[inputValue - 1].Run();
                    }
                }
            }
        }
    }

    public class AddTask : IComand
    {
        public string Description => "Добавить новую задачу";

        public void Run()
        {
            Console.WriteLine("Введить имя задачи");
            string taskName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(taskName))
            {
                Console.WriteLine("Введить описание задачи");
                string taskDescriprion = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(taskDescriprion))
                {
                    TaskManager.Instance.AddTask(new Task(taskName, taskDescriprion));
                }
            }
        }
    }

    public class RemoveTask : IComand
    {
        public string Description => "Удалить задачу";

        public void Run()
        {
            if (TaskManager.Instance.GetListCount() > 0)
            {
                TaskManager.Instance.ShowTaskName();
                if (InputHelper.CheckInput("", 1, TaskManager.Instance.GetListCount(), out int inputValue))
                {
                    TaskManager.Instance.RemoveTask(inputValue - 1);
                }
            }
        }
    }

    public class ShowInfoTask : IComand
    {
        public string Description => "Показать информацию о задаче";

        public void Run()
        {
            if (TaskManager.Instance.GetListCount() > 0)
            {
                TaskManager.Instance.ShowTaskName();
                if (InputHelper.CheckInput("", 1, TaskManager.Instance.GetListCount(), out int inputValue))
                {
                    TaskManager.Instance.ShowTaskInfo(inputValue);
                }
            }
        }
    }

    public class TaskManager
    {
        #region Singletone
        public readonly static TaskManager Instance;

        static TaskManager()
        {
            Instance = new TaskManager();
        }
        private TaskManager() { }
        #endregion

        private List<Task> _tasks = new List<Task>();

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            _tasks.RemoveAt(index);
        }

        public void ShowTaskInfo(int index)
        {
            _tasks[index].ShowTaskInfo();
        }

        public void ShowTaskName()
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {_tasks[i].Name}");
            }
        }

        public int GetListCount()
        {
            return _tasks.Count;
        }
    }

    public class Task
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime DateTime { get; private set; }

        public Task(string name, string description)
        {
            Description = description;
            DateTime = DateTime.Now;
            Name = name;
        }

        public void ShowTaskInfo()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Description {Description}");
            Console.WriteLine($"DateTime {DateTime}");
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