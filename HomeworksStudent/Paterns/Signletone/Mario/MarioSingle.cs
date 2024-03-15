namespace HomeworksStudent.Paterns.Signletone.Mario
{
    public class MarioSingle : GlobalSingleton<MarioSingle>
    {
        public void Hill()
        {
            Console.WriteLine("Я вылечился!");
        }
    }
}