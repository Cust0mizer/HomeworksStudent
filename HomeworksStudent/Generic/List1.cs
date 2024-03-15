namespace HomeworksStudent.Generic
{
    public class List1<T>
    {
        private T[] _values;

        public int Count => _values.Length;

        public void Remove(T item)
        {
            bool isContains = false;
            int index = 0;

            for (int i = 0; i < _values.Length; i++)
            {
                if (_values[i].Equals(item))
                {
                    index = i;
                    isContains = true;
                    break;
                }
            }

            if (!isContains)
            {
                return;
            }

            T[] newValues = new T[_values.Length - 1];

            for (int i = 0; i < newValues.Length; i++)
            {
                if (i == index && index == 0)
                {
                    continue;
                }
                if (index == i)
                {
                    if (i + 1 < Count)
                    {
                        newValues[i] = _values[i + 1];
                    }
                }
                else
                {
                    newValues[i] = _values[i];
                }
            }
            _values = newValues;
        }

        public void Add(T item)
        {
            if (_values == null)
            {
                _values = new T[1];
                _values[0] = item;
                return;
            }

            T[] newValues = new T[Count + 1];

            for (int i = 0; i < Count; i++)
            {
                newValues[i] = _values[i];
            }
            newValues[Count] = item;
            _values = newValues;
        }

        public void Print()
        {
            foreach (var item in _values)
            {
                Console.WriteLine(item);
            }
        }
    }
}