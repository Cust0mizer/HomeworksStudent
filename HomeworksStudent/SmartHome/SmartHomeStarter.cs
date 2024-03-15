using HomeworksStudent.PersonAbstract.StringBuilders;
using System.Text;

namespace HomeworksStudent.SmartHome
{
    public class SmartHomeStarter : IEntryPoint
    {
        public void Start()
        {
            //HomeManager.Instance.StartAction<LightOff>();
            //Thread.Sleep(2000);
            //HomeManager.Instance.StartAction<LightOn>();
            //Thread.Sleep(2000);
            //HomeManager.Instance.StartAction<WaterStart>();
        }
    }

    public interface IComandd
    {
        public string Description { get; }
        public void Run();
    }

    public class FirstComand : IComandd
    {
        public string Description => throw new NotImplementedException();

        public void Run()
        {
            Console.WriteLine("Эта реализация не похожа на вторую");
        }
    }

    public class SecondComand : IComandd
    {
        public string Description => throw new NotImplementedException();

        public void Run()
        {
            Console.WriteLine("Эта реализация не похожа на первую");
        }
    }

    public class Cart
    {
        #region Singletone
        public static readonly Cart Instance;
        private Cart()
        {

        }
        static Cart()
        {
            Instance = new Cart();
        }
        #endregion

        private List<Product> _products = new();

        public void AddProduct()
        {
            Console.WriteLine("Введите имя продукта!");
            string productName = Console.ReadLine();
            Console.WriteLine("Введите цену продукта");
            if (int.TryParse(Console.ReadLine(), out int priceValue))
            {
                if (!string.IsNullOrEmpty(productName))
                {
                    _products.Add(new Product(productName, priceValue));
                }
            }
        }

        public void RemoveProduct()
        {
            if (!CheckContainUser())
            {
                return;
            }

            while (true)
            {
                if (InputHelper.ChangeInput(GetDescription(), 1, _products.Count, out int inputValue))
                {
                    _products.RemoveAt(inputValue - 1);
                    break;
                }
            }
        }

        private StringBuilder GetDescription()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (var i = 0; i < _products.Count; i++)
            {
                Product? product = _products[i];
                stringBuilder.AppendLine($"{i + 1} - {product.Name}");
            }
            return stringBuilder;
        }

        private bool CheckContainUser()
        {
            return _products.Count > 0;
        }
    }

    public class AddComand : IAction, IDescription
    {
        public string Description => "Добавить продукт";

        public void Run()
        {
            Cart.Instance.AddProduct();
        }
    }

    public class RemoveComand : IAction, IDescription
    {
        public string Description => "Удаление продукта";

        public void Run()
        {
            Cart.Instance.RemoveProduct();
        }
    }

    public class SendComand : IAction, IDescription
    {
        public string Description => "Отправка запроса";

        public void Run()
        {
            Console.WriteLine("Отправил запрос о продукте");
        }
    }

    public class Product
    {
        public readonly string Name;
        public readonly int Price;

        public Product(string name, int price)
        {
            Price = price;
            Name = name;
        }
    }

    public class CartStarter : IEntryPoint
    {
        public void Start()
        {
            IAction[] actions = {
                new SendComand(),
                new RemoveComand(),
                new AddComand()
            };

            StringBuilder elem = ActionHelper.GetDescriptionForAction(actions);

            while (true)
            {
                if (InputHelper.ChangeInput(elem, 1, actions.Length, out int inputValue))
                {
                    actions[inputValue - 1].Run();
                }
            }
        }
    }
}



//Задача 1
//Система управления заказами в интернет-магазине: 
//Реализовать систему, которая позволяет пользователям добавлять товары в корзину, 
//удалять их, и отправлять заказ. 
//Каждая операция (добавление, удаление, отправка заказа(Cw("Отправил"))) 
//должна быть инкапсулирована в отдельный объект команды.
//Корзина должна быть синглетоном.

//Задача 2
//Система управления умным домом
//Команда на включения света
//Команда на выключение света
//Команда на запуск робота пылесоса
//Команда на подачу воды
//Команда на включение сигнализации
//Команда на заказ еды
//Работа команд осуществляется через Console.WriteLine();
//Написать Singletone менеджер, который запускает каждую команду по отдельности



//Задача 3
//Каждое действие - отдельная команда
//Система управления пользователями есть возможность:
//1 - Добавить пользователя.
//2 - Удалить пользователя.
//3 - Получить информацию о пользователях (Имя пользователя, фамилия пользователя, дата добавления пользователя)
//Пользователи должны храниться в менеджере пользователей который содержит коллекцию этих пользователей и производит с ними вышеописанные действия
//Удаление:
//Выводится список пользователей и их номера в списке
//Я могу выбрать нажатием на клавишу, какого пользователя я хочу удалить