namespace HomeworksStudent.Delegate
{
    public class DelegateStarter : IEntryPoint, IDisposable
    {
        public delegate int Delegate1(int value);
        private delegate void Delegate2();
        public Delegate1 _name;

        public void Start()
        {
            //Delegate2 delegate2 = new(TestMethod);
            //delegate2();
            //_name += TestMethod;
            //StartTest(_name);
            PriceLibrary.Instance.UpdateAllPrice += UpdatePrice;
            PriceLibrary.Instance.UpdatePrice();
        }

        public void UpdatePrice(int value)
        {
            Console.Clear();
            Console.WriteLine(value);
        }

        private void AnonimDelegate()
        {
            Delegate1 delegate1 = delegate (int value)
            {
                Console.WriteLine("Тут будет логика");
                return 123;
            };

            var result = delegate1(123);
        }

        private void StartTest(Delegate1 name)
        {
            Console.WriteLine(1);
            int.TryParse(Console.ReadLine(), out int value);
            var result = name?.Invoke(value);
            Console.WriteLine(result);
        }

        private int TestMethod(int value)
        {
            Console.WriteLine($"Пользователь ввёл значение {value}");
            return value * 2;
        }

        private void TestMethod()
        { }

        public void Dispose()
        {
            _name -= TestMethod;
            _name -= TestMethod;
            _name -= TestMethod;
            _name -= TestMethod;
            _name -= TestMethod;
        }
    }
}