using ProductShopAndMenu;

namespace HomeworksStudent.MenuProject
{
    public class Menu
    {
        private int _currentElementIndex;
        private IButton[] _menuItems;
        private List<IAction> _actions = new();

        public Menu(IButton[] menuItems)
        {
            Console.Clear();
            _menuItems = menuItems;

            foreach (var item in menuItems)
            {
                _actions.Add(item);
            }
        }

        public void Start(string menuDescription)
        {
            Console.Clear();

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
            Clamp();
            Start(descriprion);
        }

        public void SetMenuItem(IButton menuItem, bool isSelectedItem)
        {
            if (isSelectedItem)
            {
                InputHelper.PrintGoodMessage(menuItem.Description);
            }
            else
            {
                Console.WriteLine(menuItem.Description);
            }
        }

        private void Clamp()
        {
            if (_currentElementIndex < 0)
            {
                _currentElementIndex = _actions.Count - 1;
            }
            else if (_currentElementIndex == _actions.Count)
            {
                _currentElementIndex = 0;
            }
        }
    }
}