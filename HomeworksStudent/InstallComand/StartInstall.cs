namespace HomeworksStudent.InstallComand
{
    public class StartInstall : IComand, IDescription
    {
        public string Description => "Это преветственный экран";

        public bool Run(InstallScreen installScreen)
        {
            Console.WriteLine(Description);
            bool result = false;

            if (InputHelper.ChangeInput("Начать установку?\n1 - Да\n2 - Нет", 1, 2, out int value))
            {
                result = value == 1;
                installScreen.SetIsShowIstallScren();
            }

            return result;
        }
    }
}