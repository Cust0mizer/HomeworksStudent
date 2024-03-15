
namespace HomeworksStudent.Generic {
    public class List1<T>
    {
        private T[] values = new T[10];

        public void Add(T item)
        {
            T[] newValues = new T[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                newValues[i] = values[i];
            }
            newValues[newValues.Length - 1] = item;
        }

        public void Print()
        {
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}



//Создать дженерик метод который принимает 2 любые переменные и меняет их местами после чего выводит на экарн

//Создать дженерик класс который хранит в себе дженерик массив, и имеет методы по добавлению в этот массив элементов, удаление элемента из массива и возврата размера массива.
