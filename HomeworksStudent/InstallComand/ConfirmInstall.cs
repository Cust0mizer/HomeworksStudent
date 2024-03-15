namespace HomeworksStudent.InstallComand
{
    public class ConfirmInstall : IComand, IDescription
    {
        public string Description => "Начинаю добавление";

        public bool Run(InstallScreen installScreen)
        {
            Console.WriteLine(Description);
            bool result = false;

            if (InputHelper.ChangeInput("Начать установку?\n1 - Да\n2 - Нет", 1, 2, out int value))
            {
                result = value == 1;
                installScreen.SetConfirmInstall();
            }

            return result;
        }
    }
}