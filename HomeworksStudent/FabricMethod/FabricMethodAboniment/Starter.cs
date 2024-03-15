namespace HomeworksStudent.FabricMethod.FabricMethod2
{
    public class FactoryMethodStarter : IEntryPoint
    {
        public void Start()
        {
            FabricManager fabricManager = new FabricManager();
            AbonimetnCreator_1 abonimetnCreator = new AbonimetnCreator_1();
            //Aboniment_1 elem = fabricManager.GetFactory<AbonimetnCreator_1>(100);
            //elem.GetInfo();
        }
    }

    public class FabricManager
    {
        public Dictionary<Type, IAbonimetnCreator> keyValuePairs = new Dictionary<Type, IAbonimetnCreator>();

        public Aboniment GetFactory<T>(float price) where T : IAbonimetnCreator
        {
            return keyValuePairs[typeof(T)].CreateAbonimetn(price);
        }
    }
}

namespace HomeworksStudent.KeyInput
{
    public class KeyInputStarter : IEntryPoint
    {
        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}



namespace ConsoleApp25
{
    internal class Program : IEntryPoint
    {
        public void Start()
        {
            List<Icommand> commands = new List<Icommand>() { new AppendUser(), new DeleteUser(), new GetInfo() };

            while (true)
            {
                Console.WriteLine("1-Добавить юзера\n2-Вырезать юзера\n3-Показать юзеров");
                int.TryParse(Console.ReadLine(), out int k);
                if (k == 1)
                {
                    commands[k - 1].Run();
                }

                else if (k == 2)
                {
                    commands[k - 1].Run();
                }
                else if (k == 3)
                {
                    commands[k - 1].Run();
                }
                else Console.WriteLine("Неверная команда!");
            }
        }
    }
    public class Manager
    {
        public static readonly Manager Instance;
        static Manager()
        {
            Instance = new Manager();
        }
        private Manager() { }
        List<User> listUser = new List<User>() { };

        public void AddUser(User user)
        {
            listUser.Add(user);
        }
        public void ShowUser()
        {
            for (int i = 0; i < listUser.Count; i++)
            {
                listUser[i].ShowUser();
            }
        }
        public void Deletee(int index)
        {

            listUser.RemoveAt(index - 1);
        }
        public int getCount()
        {
            int c = listUser.Count() - 1;
            return c;
        }
    }

    public class User
    {
        string _firstName;
        string _secondName;
        DateTime _data;
        public User(string firstName, string secondName)
        {
            _firstName = firstName;
            _secondName = secondName;
            _data = DateTime.Now;
        }
        public void ShowUser()
        {
            Console.WriteLine(_firstName + " " + _secondName + " " + _data);
        }
    }

    public interface Icommand
    {
        public void Run();
    }

    public class AppendUser : Icommand
    {
        public void Run()
        {

            bool G = true;

            while (G == true)
            {
                Console.WriteLine("Введи имя пользователя:");
                string a = Console.ReadLine();
                if (a != "")
                {
                    Console.WriteLine("Введи фамилию пользователя:");
                    string b = Console.ReadLine();
                    if (b != "")
                    {
                        DateTime t = DateTime.Now;
                        User user = new User(a, b);
                        Manager.Instance.AddUser(user);
                    }

                    else
                    {
                        Console.WriteLine("Пустой нельзя!");
                        G = false;
                    }
                }
                else
                {
                    Console.WriteLine("Пустой нельзя!");
                    G = false;
                }
                G = false;
            }
        }
    }
    public class DeleteUser : Icommand
    {
        public void Run()
        {
            bool N = true;
            while (N == true)
            {
                Console.WriteLine("Выбери кого вырезать");
                Manager.Instance.ShowUser();
                string a = Console.ReadLine();
                int.TryParse(a, out int b);
                if (b > Manager.Instance.getCount() || b == null)
                {
                    Console.WriteLine("Нет такого пользователя");
                    N = false;
                }
                else
                {
                    Manager.Instance.Deletee(b);
                }
            }
        }
    }

    public class GetInfo : Icommand
    {
        public void Run()
        {
            Manager.Instance.ShowUser();
        }
    }
}
