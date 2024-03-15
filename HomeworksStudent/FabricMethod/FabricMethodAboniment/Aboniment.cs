namespace HomeworksStudent.FabricMethod.FabricMethod2
{
    public abstract class Aboniment
    {
        public abstract string Description { get; }
        public abstract string Name { get; }
        public float Price => _price;
        private float _price;

        public Aboniment(float price)
        {
            _price = price;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Description\t\t {Description}");
            Console.WriteLine($"Name\t\t\t {Name}");
            Console.WriteLine($"Price\t\t\t {Price}");
        }
    }
}
