public class Student : Person {
    public Student(string firstName, string secondName) : base(firstName, secondName) {
    }

    public void Learning() {
        Console.WriteLine("Я студент и я учусь!");
    }
}
