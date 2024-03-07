namespace HomeworksStudent.Signletone
{
    public class MarioSingle
    {
        public static readonly MarioSingle Instance;

        static MarioSingle()
        {
            Instance = new MarioSingle();
        }

        private MarioSingle()
        { }

        public void Hill()
        {
            Console.WriteLine("Я вылечился!");
        }
    }
}