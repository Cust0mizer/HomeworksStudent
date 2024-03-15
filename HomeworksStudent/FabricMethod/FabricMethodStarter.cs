using HomeworksStudent.FabricMethod.FabricMethodPlayer;

namespace HomeworksStudent.FabricMethod
{
    class Program : IEntryPoint
    {
        public void Start()
        {
            Player player = new Player();
            Base archerBase = new Base(new ArcherCreator());
            Base barbarianBase = new Base(new BarbarianCreator());
            var unitA = archerBase.CreateNewUnit();
            var unitB = barbarianBase.CreateNewUnit();
            unitA.Attack(player);
            unitB.Attack(player);
        }
    }
}

//1с для магазина
//Есть возможность добавить товар в магазин
//У товара есть: 1 - Имя, 2 - Цена, 3 - Группа
//Можно удалить товар из магазина:
//(Показывают список всех товаров в магазине
//Я выбираю из этого списка товар и он удаляется)
//Можно получить все товары которые хранятся в магазине
//Можно получить все товары, которые принадлежат определённой
//группе
//Группы товаров: 1 - фрукты, 2 - овощи, 3 - Выпечка
//Дубляж кода - зло!
//Добавить возможность получения товаров в диапозоне цен

//Создать метод который будет проверять введённые пользователем
//Значения, туда я буду принимать минимальное и максимальное 
//Значение которое должен ввести пользователь, если значение которое ввел пользователь находиться в диапозоне значений которые я хочу от него получить то вернуть TRUE и значение, которое ввёл пользователь, если пользователь ввел что угодно, кроме того что мы у него запросили, то фернуть FALSE
//ПРИМЕР:
//Я хочу получить от пользователя значение от 1 до 10, если пользователь вводит что угодно, кроме числа находящегося в диапозоне от 1 до 10, то возвращается FALSE, если вводит число находящееся в этом диапозоне то возвращаю TRUE и это число, которое он ввёл

namespace End
{
    public class MenuStarter : IEntryPoint
    {
        public void Start()
        {
            IComand[] addComands = {
                new RemoveComand(),
                new AddComand(),
            };

            Console.WriteLine("Введите число от 1 до 2");

            for (var i = 0; i < addComands.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {addComands[i].Description}");
            }

            if (int.TryParse(Console.ReadLine(), out int value))
            {
                if (value >= 1 && value <= 2)
                {
                    addComands[value - 1].Run();
                }
            }
        }
    }

    public interface IComand
    {
        public string Description { get; }
        public void Run();
    }

    public class AddComand : IComand
    {
        public string Description => "Добавить продукт";

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class RemoveComand : IComand
    {
        public string Description => "Удалить продукт";

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Shop
    {
        public readonly static Shop Instance = new Shop();
    }
}