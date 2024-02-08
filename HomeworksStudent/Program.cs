using System.Drawing;
using System;

namespace HomeworksStudent {
    internal sealed class Program {
        private static void Main() {
            int[] goodCombination = { 1, 2, 3, 4, 5 };
            CombinationLock combinationLock = new CombinationLock(goodCombination);
            combinationLock.SetNewCombination();

            while (!combinationLock.IsOpen || Console.ReadKey().Key == ConsoleKey.Enter) {
                Console.WriteLine("Введите число");
                int.TryParse(Console.ReadLine(), out int value);
                combinationLock.TryOpenLock(value);
            }
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

public class CombinationLock {
    public bool IsOpen { get; private set; }

    private int[] _goodCombination;
    private int _currentLockIndex;

    public CombinationLock(int[] goolCombination) {
        _goodCombination = goolCombination;
    }

    public void TryOpenLock(int combinationVariant) {
        if (IsOpen) {
            return;
        }

        if (_goodCombination[_currentLockIndex] == combinationVariant) {
            _currentLockIndex++;
            if (_currentLockIndex == _goodCombination.Length) {
                Console.WriteLine($"Ступень {_currentLockIndex} пройдена");
                SetLockState(LockState.Open);
            }
            else {
                Console.WriteLine($"Ступень {_currentLockIndex} пройдена");
            }
        }
        else {
            Console.WriteLine($"Неверная комбинация");
            _currentLockIndex = 0;
        }
    }

    public void SetNewCombination() {
        while (!IsOpen) {
            Console.WriteLine("Введите число");
            int.TryParse(Console.ReadLine(), out int value);
            TryOpenLock(value);
        }

        for (int i = 0; i < _goodCombination.Length; i++) {
            Console.WriteLine($"Введите число для ступени {i + 1}");
            int.TryParse(Console.ReadLine(), out int value);
            _goodCombination[i] = value;
        }
        SetLockState(LockState.Lock);
    }

    private void SetLockState(LockState lockState) {
        switch (lockState) {
            case LockState.Lock:
                IsOpen = false;
                Console.WriteLine("Замок закрыт");
                break;
            case LockState.Open:
                IsOpen = true;
                _currentLockIndex = 0;
                Console.WriteLine("Замок Открыт");
                break;
        }
    }
}

public enum LockState {
    Lock,
    Open
}