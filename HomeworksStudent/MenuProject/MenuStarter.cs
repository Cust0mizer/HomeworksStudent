using HomeworksStudent.MenuProject;
using HomeworksStudent.PersonAbstract.StringBuilders;
using ProductShopAndMenu;
using System.Text;

namespace HomeworksStudent.MenuProject
{
    public class MenuStarter : IEntryPoint
    {
        public void Start()
        {
            Menu menu = new Menu([new AddComand(), new RemoveComand(), new ShowProductInfo()]);

            while (true)
            {
                menu.ShowMenu(true);
                menu.Input(Console.ReadKey().Key);
            }
        }
    }

    public class MenuElement : IMenuItem, IAction
    {
        public string Description => "Первая кнопка";

        //public void ShowFrame()
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < Description.Length + 2; j++)
        //        {
        //            if (i == 0 || i == 2)
        //            {
        //                Console.Write("_");
        //            }
        //            else if (i == 1 && j == 0)
        //            {
        //                Console.Write($"|{Description}|");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

        public int PosX => 0;
        public int PosY => 0;

        public void Run()
        {
            Console.WriteLine("Первый!!!");
        }
    }
    public class SecondElement : IMenuItem, IAction
    {
        public string Description => "Вторая кнопка";

        public int PosX => 0;
        public int PosY => 0;

        public void Run()
        {
            Console.WriteLine("Второй!!!");
        }
    }
}

namespace ProductShopAndMenu
{
    public enum ProductType
    {
        Vegetables,
        Fruits,
        Bakery
    }

    public class Shop
    {
        List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(int index)
        {
            _products.RemoveAt(index);
        }

        public void GetAllProductName()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {_products[i].Name}");
            }
        }
    }

    public class Product
    {
        public ProductType ProductType { get; private set; }
        public int Price { get; private set; }
        public string Name { get; private set; }

        public Product(ProductType productType, string name, int price)
        {
            ProductType = productType;
            Price = price;
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ProductType - {ProductType}");
            Console.WriteLine($"Price - {Price}");
            Console.WriteLine($"Name - {Name}");
        }
    }

    public class AddComand : IAction, IMenuItem
    {
        public string Description => "Добавление продуктов";

        private Shop _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            if (InputHelper.TextInputField("Введите имя продукта", out string productName))
            {
                Console.WriteLine("Введите цену продукта");
                if (int.TryParse(Console.ReadLine(), out int price))
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.GetDescriptionForEnum<ProductType>("Выберите категорию");
                    if (InputHelper.ChangeInput(stringBuilder, 1, Enum.GetValues(typeof(ProductType)).Length, out int inputValue))
                    {
                        _shop.AddProduct(new Product((ProductType)(inputValue - 1), productName, price));
                    }
                }
            }
        }
    }

    public class ProductMenuItem : IAction, IDescription
    {
        public string Description => throw new NotImplementedException();

        public ProductMenuItem()
        {

        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class RemoveComand : IAction, IMenuItem
    {
        public string Description => "Удаление продуктов";

        public void Run()
        {
            if (int.TryParse(Console.ReadLine(), out int inputValue))
            {

            }
        }
    }

    public class ShowProductInfo : IAction, IMenuItem
    {
        public string Description => "Показать информацию о продуктах";
        private Shop _shop = ServiceLocator.Instance.Shop;

        public void Run()
        {
            _shop.GetAllProductName();
        }
    }
}