namespace HomeworksStudent.InstallComand
{
    public class InstallPath : IComand, IDescription
    {
        public string Description => "Укажите путь для установки";

        public bool Run(InstallScreen installScreen)
        {
            Console.WriteLine(Description);
            bool result = false;
            string path = Console.ReadLine();

            if (string.IsNullOrEmpty(path))
            {
                installScreen.SetInstallPath(Console.ReadLine());
                result = true;
            }
            else
            {
                installScreen.SetInstallPath("No path!!!");
            }

            return result;
        }
    }
}