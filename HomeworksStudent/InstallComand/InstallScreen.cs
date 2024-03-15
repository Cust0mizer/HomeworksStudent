namespace HomeworksStudent.InstallComand
{
    public class InstallScreen
    {
        private bool _isShowInstallScreen;
        private string _installPath;
        private bool _confirmInstall;

        public void SetIsShowIstallScren()
        {
            _isShowInstallScreen = true;
        }

        public void SetInstallPath(string path)
        {
            _installPath = path;
        }

        public void SetConfirmInstall()
        {
            _confirmInstall = true;
        }

        public void PrintInfo()
        {
            Console.WriteLine(_isShowInstallScreen);
            Console.WriteLine(_installPath);
            Console.WriteLine(_confirmInstall);
        }
    }
}