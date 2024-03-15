namespace HomeworksStudent.InstallComand
{
    public class StartInstall : IComand, IDescription
    {
        private ButtonYesOrNo _serviceLocator = ServiceLocator.Instance.ButtonYesOrNo;
        public string Description => "Это преветственный экран";

        public bool Run(InstallScreen installScreen)
        {
            Console.WriteLine(Description);
            bool result = _serviceLocator.GetResult("Начать установку?\n1 - Да\n2 - Нет");
            installScreen.SetIsShowIstallScren();
            return result;
        }
    }
}