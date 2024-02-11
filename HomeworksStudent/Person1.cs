public class Person {
    private string _secondName;
    private string _firstName;
    public Person(string firstName, string secondName) {
        _secondName = secondName;
        _firstName = firstName;
    }

    public void PrintName() {
        Console.WriteLine($"Моё имя {_firstName}");
    }
}