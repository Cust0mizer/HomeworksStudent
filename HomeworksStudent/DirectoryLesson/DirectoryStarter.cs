using HomeworksStudent.MenuProject;
using ProductShopAndMenu;
using System.Linq;

namespace HomeworksStudent.DirectoryLesson
{
    public class DirectoryStarter : IEntryPoint
    {
        public void Start()
        {
            //foreach (var item in DriveInfo.GetDrives())
            //{
            //    string path = Path.Combine(item.RootDirectory.Name, "Windows", "System32");
            //    Path.Join();
            //    if (Directory.Exists(path))
            //    {
            //        Console.WriteLine("Тут есть FKTYF");
            //    }
            //}

            //DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            //foreach (var item in Directory.EnumerateFiles(@"\\server\Total\!Воробьев\projects\HomeworksStudent\HomeworksStudent"))
            //{
            //    Console.WriteLine(item);
            //}





















            //foreach (var item in DriveInfo.GetDrives())
            //{
            //    if (item.IsReady)
            //    {
            //        Console.WriteLine(item.AvailableFreeSpace.ToGb());
            //    }
            //}
            //ServiceLocator.Instance.DirectoryManager.Show();
            //DriveInfo drive = DriveHelper.SearchSystemDrive();
            ////Console.WriteLine(drive.Name);
            //FillImage fillImage = new FillImage(0, drive.TotalSize.ToGb());
            //fillImage.FillAmount(drive.TotalFreeSpace.ToGb());


            //string path = Path.Combine(Directory.GetCurrentDirectory(), "FileBinary");
            //using (FileStream fileStream = new FileStream(path, FileMode.Append))
            //{
            //    using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            //    {
            //        binaryWriter.Write("Hello world!\n");
            //    }
            //}
            //using (FileStream fileStream = new FileStream(path, FileMode.Open))
            //{
            //    using (BinaryReader binaryWriter = new BinaryReader(fileStream))
            //    {
            //        foreach (var item in binaryWriter.ReadBytes(binaryWriter.Read()).ToString())
            //        {
            //            Console.WriteLine(item);
            //        }
            //        //binaryWriter.rea("Hello world!");
            //    }
            //}
            //Console.WriteLine($"Free {drive.TotalFreeSpace.ToGb()} for {drive.TotalSize.ToGb()}");

            //var files = Directory.EnumerateFiles(Directory.GetCurrentDirectory());
            //Console.WriteLine(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory()));
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}


            //foreach (var item in elements)
            //{
            //    Console.WriteLine(item);
            //}
            //using (FileStream elem = File.Open($@"{Directory.GetCurrentDirectory()}\newFile.txt", FileMode.Append))
            //{
            //    using (StreamWriter streamWriter = new StreamWriter(elem))
            //    {
            //        streamWriter.Write("Hello world");
            //    }
            //}

            //DriveInfo[] elements = DriveInfo.GetDrives();
            //foreach (var element in elements)
            //{
            //    ExtensionClasssss.ASDASD(element);
            //}
        }
    }

    public class DirectoryManager
    {
        private string _currentPath = @"C:\";

        public void Show()
        {
            Directory.SetCurrentDirectory(_currentPath);
            string[] directories = Directory.GetDirectories(_currentPath);
            LinkedList<IButton> items = new LinkedList<IButton>();

            for (int i = 0; i < directories.Length; i++)
            {
                Action<string> action = OpenDirectory;
                ButtonForString buttonForStringnew = new ButtonForString(@$"{directories[i]}", action);
                items.AddLast(buttonForStringnew);
            }

            Menu menu = new Menu(items.ToArray());
            menu.Start("Выберите папку");
        }

        public void OpenDirectory(string newPath)
        {
            _currentPath = Path.Join(_currentPath, newPath);
            Show();
        }
    }

    public class ButtonForString : IButton
    {
        public string Description => _buttonDescription;

        private string _buttonDescription;
        private readonly Action<string> _action;

        public ButtonForString(string buttonDescription, Action<string> action)
        {
            _buttonDescription = buttonDescription.Replace(@$"{Directory.GetCurrentDirectory()}", "");
            _action = action;
        }

        public void Run()
        {
            _action?.Invoke(_buttonDescription);
        }
    }

    public class ServiceLocator
    {
        #region Singletone
        public static readonly ServiceLocator Instance;
        static ServiceLocator()
        {
            Instance = new ServiceLocator();
        }
        #endregion 
        public readonly DirectoryManager DirectoryManager;

        private ServiceLocator()
        {
            DirectoryManager = new DirectoryManager();
        }
    }

    public class FillImage : IUIElement
    {
        private char[,] _panelSize;
        public int Width => 102;
        public int Height => 3;

        private readonly float _minValue;
        private readonly float _maxValue;

        public FillImage(float minValue, float maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            CreateFill();
        }

        private void CreateFill()
        {
            _panelSize = new char[Width, Height];

            for (int height = 0; height < Height; height++)
            {
                for (int width = 0; width < Width; width++)
                {
                    if (height == 1)
                    {
                        if (width == 0 || width == Width - 1)
                        {
                            _panelSize[width, height] = '|';
                            continue;
                        }
                    }

                    _panelSize[width, height] = ' ';
                }
            }
        }

        public void FillAmount(float currentValue)
        {
            int forPercent = (int)((currentValue - _minValue) / (_maxValue - _minValue) * 100);

            for (int i = 1; i < forPercent + 1; i++)
            {
                _panelSize[i, 1] = '=';
            }
            AppendToPanel($"{currentValue} for {_maxValue}", HeightGravity.Start, WidthGravity.Start);
            AppendToPanel($"{forPercent} precent is free", HeightGravity.End, WidthGravity.Center);
            _panelSize.PrintXY();
        }

        private void AppendToPanel(string text, HeightGravity verticalGravity, WidthGravity horizontalGravity)
        {
            char[] chars = text.ToCharArray();
            int horizontalCenter = chars.Length / 2;
            int horizontalPosition = GetHorizontalGravity(horizontalGravity);
            int verticalPosition = GetVerticalGravity(verticalGravity);

            for (int i = horizontalPosition - horizontalCenter, charIndex = 0; i < horizontalPosition + horizontalCenter; i++, charIndex++)
            {
                i = Math.Clamp(i, 0, _panelSize.Length);

                _panelSize[i, verticalPosition] = chars[charIndex];
            }

            if (horizontalPosition + text.Length > Width)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private int GetHorizontalGravity(WidthGravity horizontalGravity)
        {
            int result = 0;

            switch (horizontalGravity)
            {
                case WidthGravity.Center:
                    result = _panelSize.GetLength(0) / 2;
                    break;
                case WidthGravity.Start:
                    result = 0;
                    break;
                case WidthGravity.End:
                    result = _panelSize.GetLength(0) - 1;
                    break;
            }
            return result;
        }

        private int GetVerticalGravity(HeightGravity verticalGravity)
        {
            int result = 0;

            switch (verticalGravity)
            {
                case HeightGravity.Center:
                    result = _panelSize.GetLength(1) / 2;
                    break;
                case HeightGravity.Start:
                    result = 0;
                    break;
                case HeightGravity.End:
                    result = _panelSize.GetLength(1) - 1;
                    break;
            }
            return result;
        }
    }

    public interface IUIElement
    {
        public int Width { get; }
        public int Height { get; }
    }
}


//1с для магазина
//Есть возможность добавить товар в магазин
//У товара есть: 1 - Имя, 2 - Цена, 3 - Группа, 4 - Дата добавления
//Можно удалить товар из магазина:
//(Показывают список всех товаров в магазине
//Я выбираю из этого списка товар, и он удаляется)
//Можно получить все товары, которые хранятся в магазине
//Можно получить все товары, которые принадлежат определённой
//группе
//Выводиться список всех групп, я выбираю интересную мне и получаю из неё все товары.
//Группы товаров: 1 - фрукты, 2 - овощи, 3 - Выпечка
//Дубляж кода - зло!
//Очень важен правильный нейминг переменных и соблюдение одного код стайла
//Добавить возможность получения товаров в диапазоне цен
//Я ввожу минимальную цену и максимальную, получаю все товары в указанном диапазоне
//Кнопки:
//Получения товаров и удаления не должны появляться до тех пор, пока у меня нет ни одного товара 
//Все стринги которые должны будут выводиться пользователю на экран нужно поместить в отдельный
//Класс с константами


//Напишите программу которая определяет какой диск является системным 

public enum HeightGravity
{
    Center,
    Start,
    End
}

public enum WidthGravity
{
    Center,
    Start,
    End
}



//Метод который в процентах показывает свободное место на диске

//Написать экстеншен метод который переводит байты в гигобайты
//И с его помощью вывести свободное место на всех дисках в 
//гигабайтах

//Написать экстеншен метод для массива который проверяет наличие
//элементов в нём

//Записать в файл ваши ФИО

//Найти системный диск вашей системы.



public static class ExtensionClasssss
{
    public static float ToGb(this long value)
    {
        return value / 1000000000;
    }

    public static void ASDASD(DriveInfo driveInfo)
    {
        int wer = (int)((float)driveInfo.AvailableFreeSpace / driveInfo.TotalSize * 100);
        Console.WriteLine(wer);
    }
}

//Статический класс DriverHelper, который показывает
//Сколько есть свободного места на диске в процентах



public class PlayerManager
{
    private List<Playerrrrrr> startList;

    public PlayerManager()
    {
        startList = new List<Playerrrrrr>();
        for (int i = 0; i < 100; i++)
        {
            startList.Add(new Playerrrrrr());
        }

        List<Playerrrrrr> result1 = new List<Playerrrrrr>();
        foreach (var item in startList)
        {
            if (item.PlayerType == PlayerType.Human)
            {
                result1.Add(item);
            }
        }

        List<Playerrrrrr> result2 = startList.FindAll(item => item.PlayerType == PlayerType.Human);
        IEnumerable<Playerrrrrr> result3 = startList.Where(x => x.PlayerType == PlayerType.Human);
        startList.ForEach(x => x.PrintInfo());
    }
}

public class Playerrrrrr
{
    public PlayerType PlayerType { get; }

    public void PrintInfo()
    {
        Console.WriteLine(PlayerType);
    }
}

public enum PlayerType
{
    Human,
    Animal
}