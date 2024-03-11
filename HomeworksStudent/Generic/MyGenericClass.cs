namespace HomeworksStudent.Generic {
    public class MyGenericClass<T> where T : class, new() {
        public MyGenericClass(T value) {
            T _value = new T();
            _value = value;
        }
    }
}


//Создать дженерик метод который принимает 2 любые переменные и меняет их местами после чего выводит на экарн

//Создать дженерик класс который хранит в себе дженерик массив, и имеет методы по добавлению в этот массив элементов, удаление элемента из массива и возврата размера массива.
