using System.Numerics;

namespace HomeworksStudent.Generic
{
    public class GenericStarter : IEntryPoint
    {
        public void Start()
        {
            List1<int> list = new List1<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Print();
            list.Remove(1);
            list.Print();


            Print(123, new Random());
            Print(new GenericStarter(), new DateTime());
            Print(new Random());
            Print(new DateTime());
            Print(DayOfWeek.Sunday);

            Sum(123, 123.123f);
            ClassTest(new GenericStarter(), new GenericStarter());
            StructTest(new DateTime(), new DateTime());
            EnumTest(DayOfWeek.Friday, DayOfWeek.Tuesday);
        }

        public void Swap<T>(T firstElem, T secondElem)
        {
            Console.WriteLine($"{firstElem}\t{secondElem}");
            (firstElem, secondElem) = (secondElem, firstElem);
            Console.WriteLine($"{firstElem}\t{secondElem}");
        }

        public void Print<T, T2>(T firstValue, T2 seconValue)
        {
            Console.WriteLine(firstValue.GetType().Name);
            Console.WriteLine(seconValue.GetType().Name);
        }

        public void Print<T>(T firstValue)
        {
            Console.WriteLine(firstValue.GetType().Name);
        }

        public static void Sum(int firstValue, int secondValue)
        {
            Console.WriteLine(firstValue + secondValue);
        }

        public static void Sum(long firstValue, long secondValue)
        {
            Console.WriteLine(firstValue + secondValue);
        }

        public static void Sum<T>(T firstValue, T secondValue) where T : INumber<T>
        {
            T result = firstValue + secondValue;
            Console.WriteLine(result);
        }

        public static void ClassTest<T>(T firstValue, T secondValue) where T : class
        {
        }

        public static void StructTest<T>(T firstValue, T secondValue) where T : struct
        {
        }

        public static void EnumTest<T>(T firstValue, T secondValue) where T : Enum
        {
        }

        public void DefaultTest<T>(T value)
        {
            T newValue = default;
        }
    }
}



//Создать дженерик метод который принимает 2 любые переменные и меняет их местами после чего выводит на экарн

//Создать дженерик класс который хранит в себе дженерик массив, и имеет методы по добавлению в этот массив элементов, удаление элемента из массива и возврата размера массива.
