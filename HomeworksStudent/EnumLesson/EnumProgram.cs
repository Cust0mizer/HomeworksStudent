using HomeworksStudent.Domino;
using System.Collections;

namespace HomeworksStudent.EnumLesson
{
    internal class EnumProgram
    {
        public static void Main()
        {
            Vector3S vector3S = new Vector3S(1, 2, 3);
            Vector3C vector3C = new Vector3C(1, 2, 3);
            Test(vector3S);
            Test(vector3C);
            vector3S.PrintInfo();    //1 2 3
            vector3C.PrintInfo();    //1123 3452 3456
        }

        private static void Test(Vector3S vector3)
        {
            vector3.SetNewVector(1567, 2123, 3345);
        }

        private static void Test(Vector3C vector3)
        {
            vector3.SetNewVector(1123, 3452, 3456);
        }

        public static void TryAdd(Dictionary<DayOfWeek, int> keyValuePairs, DayOfWeek key, int value)
        {
            if (!keyValuePairs.TryAdd(key, value))
            {
                keyValuePairs[key] += value;
            }
        }
    }

    public struct Vector3S
    {
        private float _x;
        private float _y;
        private float _z;

        public Vector3S(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"x = {_x}");
            Console.WriteLine($"y = {_y}");
            Console.WriteLine($"z = {_z}");
        }

        public void SetNewVector(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
    }

    public class Vector3C
    {
        private float _x;
        private float _y;
        private float _z;

        public Vector3C(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"x = {_x}");
            Console.WriteLine($"y = {_y}");
            Console.WriteLine($"z = {_z}");
        }

        public void SetNewVector(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
    }

    public enum EnumLesson
    {
        Red,
        Green,
        Yellow,
        Black
    }
}



//Получить перечисление дней
//недели из энама DayOfWeek
//И вывести его на экран в формате:
//Число - День