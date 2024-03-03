namespace HomeworksStudent.Domino
{
    public class Domino
    {
        private int _secondValue;
        private int _firstValue;

        public Domino(int firstValue, int secondValue)
        {
            _secondValue = secondValue;
            _firstValue = firstValue;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{_firstValue}\t{_secondValue}");
        }
    }
}