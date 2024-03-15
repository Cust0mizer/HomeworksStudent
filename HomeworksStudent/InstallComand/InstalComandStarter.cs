namespace HomeworksStudent.InstallComand
{
    public class InstalComandStarter : IEntryPoint
    {
        private IComand[] comand = {
            new StartInstall(),
            new InstallPath(),
            new ConfirmInstall(),
        };

        public void Start()
        {
            InstallScreen installScreen = new InstallScreen();

            for (int i = 0; i < comand.Length; i++)
            {
                if (!comand[i].Run(installScreen))
                {
                    break;
                }
                Thread.Sleep(1000);
            }
            Thread.Sleep(1000);
            installScreen.PrintInfo();
            Thread.Sleep(1000);
        }
    }
}