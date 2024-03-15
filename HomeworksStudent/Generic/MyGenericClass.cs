namespace HomeworksStudent.Generic {
    public class MyGenericClass<T> where T : class, new() {
        public MyGenericClass(T value) {
            T _value = new T();
            _value = value;
        }
    }
}