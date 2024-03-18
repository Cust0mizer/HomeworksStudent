using ProductShopAndMenu;

namespace HomeworksStudent.MenuProject {
    public class MenuStarter : IEntryPoint {
        public void Start() {
            Menu menu = new Menu([new AddComand(), new RemoveComand(), new ShowProductInfoComand()]);
            menu.Start(true);
        }
    }
}


namespace ASDASD {
    namespace ConsoleApp8 {
        internal class Programasdasd : IEntryPoint {
            public void Start() {
                GenericArray<int> asdf = new GenericArray<int>();
                asdf.Add(1);
                asdf.Add(1);
                asdf.Add(1);
                asdf.Remove(112);
            }
        }
    }
    public class GenericArray<T> {
        private T[] arr;
        public GenericArray() {
            arr = new T[0];
        }
        public void Add(T data) {
            T[] arr2 = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++) {
                arr2[i] = arr[i];
            }
            arr2[arr.Length] = data;
        }
        public void Remove(int index) {
            if (index >= arr.Length || index < 0) {
                Console.WriteLine("Вы вышли за рамки массива");
            }
            T[] arr2 = new T[arr.Length - 1];
            int id = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (i != index) {
                    arr2[id] = arr[i];
                    id++;
                }
            }
            arr = arr2;
        }
        public T GetItemByIndex(int index) {
            if (index >= arr.Length) {
                Console.WriteLine("Вы вышли за рамки массива");
            }
            return arr[index];
        }
        public int GetArrayLength() {
            return arr.Length;
        }
    }
}