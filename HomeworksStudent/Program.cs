using System.Drawing;
using System;

namespace HomeworksStudent {
    internal sealed class Program {
        private static void Main() {
            int[] goodCombination = { -160, 224, 3445, 441, 510 };
            CombinationLock combinationLock = new CombinationLock(goodCombination);
            //combinationLock.SetNewCombination();

            //while (!combinationLock.IsOpen || Console.ReadKey().Key == ConsoleKey.Enter) {
            //    Console.WriteLine("Введите число");
            //    int.TryParse(Console.ReadLine(), out int value);
            //    combinationLock.TryOpenLock(value);
            //}

            Brutforce.GetPassword(combinationLock, -10000, 10000);
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

public enum LockState {
    Lock,
    Open
}