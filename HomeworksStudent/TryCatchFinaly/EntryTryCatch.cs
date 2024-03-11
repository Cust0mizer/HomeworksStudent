namespace HomeworksStudent.TryCatchFinaly
{
    public class EntryTryCatch : IEntryPoint
    {
        public void Start()
        {
            int[] ints = new int[10];

            try
            {
                ints[1] = 123;
            }
            catch (Exception)
            {
                Console.WriteLine("Не получилось");
            }
            finally
            {
                Console.WriteLine("Точно!");
            }

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}