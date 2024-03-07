namespace HomeworksStudent.EventAction
{
    public class View
    {
        private int _coin;

        public void UpdateView(int value)
        {
            _coin = value;
            Console.WriteLine(_coin);
        }
    }
}

