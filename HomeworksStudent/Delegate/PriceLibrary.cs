namespace HomeworksStudent.Delegate
{
    public class PriceLibrary
    {
        private PriceLibrary() { }
        public static readonly PriceLibrary Instance = new PriceLibrary();

        public delegate void PriceDelegate(int value);
        public PriceDelegate UpdateAllPrice;

        public void UpdatePrice()
        {
            Random random = new Random();
            int currentValue = random.Next(0, 1000);
            Thread.Sleep(1000);
            UpdateAllPrice?.Invoke(currentValue);
        }
    }
}

