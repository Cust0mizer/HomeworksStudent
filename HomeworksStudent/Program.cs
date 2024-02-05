namespace HomeworksStudent {
    internal class Program {
        private static void Main() {
            Student student1 = new Student();
            Student student2 = new Student(student1);
            student1.SetName("Алёша");
            student1.PrintStudentName();
            student2.PrintStudentName();
        }

        private static T[] Add<T>(T[] array, T newValue) {
            T[] newArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++) {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = newValue;
            return newArray;
        }

        private static void BubleSort(int[] intsArray) {
            for (int i = 0; i < intsArray.Length; i++) {
                for (int j = 0; j < intsArray.Length; j++) {
                    if (intsArray[j] > intsArray[i]) {
                        Swap(intsArray, i, j);
                    }
                }
            }
            #region Optimization
            //for (int i = 0; i < intsArray.Length; i++) {
            //    for (int j = 0; j < intsArray.Length - i - 1; j++) {
            //        if (intsArray[j] > intsArray[j + 1]) {
            //            Swap(intsArray, j, j + 1);
            //        }
            //    }
            //}
            #endregion
        }

        private static void Swap<T>(T[] values, int firstIndex, int secondIndex) {
            #region Cortage
            //(values[firstIndex], values[secondIndex]) = (values[secondIndex], values[firstIndex]);
            #endregion
            T temp = values[firstIndex];
            values[firstIndex] = values[secondIndex];
            values[secondIndex] = temp;
        }

        private static void PrintArray<T>(T[] array) {
            foreach (var item in array) {
                Console.WriteLine(item);
            }
        }

        private static void FillArray(int[] arrayInts, int minValue, int maxValue) {
            Random rnd = new Random();

            for (int i = 0; i < arrayInts.Length; i++) {
                arrayInts[i] = rnd.Next(minValue, maxValue);
            }
        }

        private static int GetSum(int[] intsArray) {
            int result = 0;

            foreach (var element in intsArray) {
                result += element;
            }
            return result;
        }

        private static int GetMin(int[] intsArray) {
            int result = intsArray[0];

            foreach (var element in intsArray) {
                if (element < result) {
                    result = element;
                }
            }
            return result;
        }

        private static int GetMax(int[] intsArray) {
            int result = intsArray[0];

            foreach (var element in intsArray) {
                if (element > result) {
                    result = element;
                }
            }
            return result;
        }

        private static int GetAVG(int[] intsArray) {
            return GetSum(intsArray) / intsArray.Length;
        }
    }
}
public class Student {
    private string _secondName;
    private string _firstName;
    private string _group;
    private Guid _guid;
    private int _age;

    public Student() {

    }

    public Student(Student student) {
        _secondName = student._secondName;
        _firstName = student._firstName;
        _guid = student._guid;
        _group = student._group;
        _age = student._age;
    }

    public Student(string firstName, string secondName, string group, int age) {
        _secondName = secondName;
        _firstName = firstName;
        _guid = Guid.NewGuid();
        _group = group;
        _age = age;
    }

    public void PrintStudentName() {
        Console.WriteLine($"Имя {_firstName} Фамилия {_secondName}");
    }

    public void SetName(string newName) {
        _secondName = newName;
    }
}
