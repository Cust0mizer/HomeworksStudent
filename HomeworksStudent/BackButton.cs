namespace HomeworksStudent
{
    public class BackButton
    {
        public void AwaitBackClick()
        {
            Console.WriteLine("Нажмите Backspace - для возврата!");
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Backspace)
                {
                    break;
                }
            }
        }
    }
}