using HomeworksStudent.PersonAbstract.StringBuilders;

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

        public void ShowMenu(bool isClear)
        {
            if (isClear)
            {
                Console.Clear();
            }

            for (int i = 0; i < _menuItems.Length; i++)
            {
                SetMenuItem(_menuItems[i], i == _currentElementIndex);
            }
        }

        public void Input(ConsoleKey consoleKey)
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

            _currentElementIndex = Math.Clamp(_currentElementIndex, 0, _menuItems.Length - 1);
            ShowMenu(true);
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
            _height = Console.LargestWindowHeight / 2;
            _width = Console.LargestWindowWidth / 2;
            //_widthMultiply = 1080 / _height;
            //_heightMultiply = 1920 / _width;
            Console.SetWindowSize(_width, _height);
        }
    }
}