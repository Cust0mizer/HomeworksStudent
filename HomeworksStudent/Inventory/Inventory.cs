namespace HomeworksStudent.ConsoleGame
{
    public class Inventory
    {
        private Dictionary<string, List<IIetem>> _itemss = new();

        public void AddItem(IIetem ietem)
        {
            if (_itemss.ContainsKey(ietem.ToString()))
            {
                if (ietem.ICanStack)
                {
                    _itemss[ietem.ToString()].Add(ietem);
                }
            }
            else
            {
                _itemss.Add(ietem.ToString(), new List<IIetem>() { ietem });
            }
        }

        public void RemoveItem(IIetem ietem)
        {
            _itemss[ietem.ToString()].Remove(ietem);
        }

        public bool ContainsItem<T>(ref T searchElement) where T : IIetem
        {
            if (_itemss.ContainsKey(searchElement.ToString()))
            {
                if (_itemss[searchElement.ToString()].Count > 0)
                {
                    searchElement = (T)_itemss[searchElement.ToString()].ElementAt(0);
                    return true;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            foreach (KeyValuePair<string, List<IIetem>> keey in _itemss)
            {
                foreach (IIetem value in keey.Value)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
