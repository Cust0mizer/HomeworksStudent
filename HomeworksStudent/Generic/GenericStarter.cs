
namespace HomeworksStudent.Generic {
    public class GenericStarter : IEntryPoint
    {
        public void Start()
        {
            List1<int> myCollection = new List1<int>();
        }

        public void Sum<T>(T firstNum)
        {
            Console.WriteLine(firstNum.GetType().Name);
        }

        public void Swap<T>(T firstElem, T secondElem)
        {
            T temp = firstElem;
            firstElem = secondElem;
            secondElem = temp;
            Console.WriteLine(secondElem);
        }
    }
}



//Создать дженерик метод который принимает 2 любые переменные и меняет их местами после чего выводит на экарн

//Создать дженерик класс который хранит в себе дженерик массив, и имеет методы по добавлению в этот массив элементов, удаление элемента из массива и возврата размера массива.
