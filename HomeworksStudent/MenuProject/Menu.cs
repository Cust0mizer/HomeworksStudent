using System.Data.Common;

namespace HomeworksStudent.MenuProject
{
    public class Menu
    {
        private int _height;
        private int _width;

        //private const int COLUM = 3;
        //private float _heightMultiply;
        //private float _widthMultiply;

        private int _currentElementIndex;
        private IMenuItem[] _menuItems;
        private List<IAction> _actions = new();

        public Menu(IMenuItem[] menuItems)
        {
            SetWindow();
            _menuItems = menuItems;
            foreach (var item in menuItems)
            {
                if (item is IAction action)
                {
                    _actions.Add(action);
                }
            }
        }

        public void Start(bool isClear, string menuDescription)
        {
            if (isClear)
            {
                Console.Clear();
            }

            if (!string.IsNullOrWhiteSpace(menuDescription))
            {
                InputHelper.PrintWarning(menuDescription);
            }

            for (int i = 0; i < _menuItems.Length; i++)
            {
                SetMenuItem(_menuItems[i], i == _currentElementIndex);
            }
            Input(Console.ReadKey().Key, menuDescription);
        }

        private void Input(ConsoleKey consoleKey, string descriprion)
        {
            switch (consoleKey)
            {
                case ConsoleKey.DownArrow:
                    _currentElementIndex++;
                    break;
                case ConsoleKey.UpArrow:
                    _currentElementIndex--;
                    break;
                case ConsoleKey.Enter:
                    _actions[_currentElementIndex].Run();
                    return;
            }

            if (_currentElementIndex < 0)
            {
                _currentElementIndex = _actions.Count - 1;
            }
            else if (_currentElementIndex == _actions.Count)
            {
                _currentElementIndex = 0;
            }

            Start(true, descriprion);
        }

        public void SetMenuItem(IMenuItem menuItem, bool isSelectedItem)
        {
            //Console.CursorLeft = (int)(menuItem.PosX / _widthMultiply);
            //Console.CursorTop = (int)(menuItem.PosY / _heightMultiply);
            if (isSelectedItem)
            {
                InputHelper.PrintGoodMessage(menuItem.Description);
            }
            else
            {
                Console.WriteLine(menuItem.Description);
            }
        }

        private void SetWindow()
        {
            Console.Clear();
            //_height = Console.LargestWindowHeight;
            //_width = Console.LargestWindowWidth;
            //_widthMultiply = 1080 / _height;
            //_heightMultiply = 1920 / _width;
            //Console.SetWindowSize(_width, _height);
        }
    }
}

namespace CodeAnotation
{
    public class Anotation
    {
        public const string ERROR_MESSAGE = "";
        public string Description;
        private string _test;
        protected int Value;

        public Anotation(string description, string test, int value)
        {
            _test = test;
            Value = value;
            Description = description;
        }

        public void Test()
        {
            int value = Value;
            var value2 = value;
            DbConnectionStringBuilder dbConnectionStringBuilder = new();
        }
    }
}