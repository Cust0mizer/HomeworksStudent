namespace HomeworksStudent.DriveHelperLesson
{
    public static class DriveHelper
    {
        public static DriveInfo SearchSystemDrive()
        {
            DriveInfo result = null;
            DriveInfo[] drivers = DriveInfo.GetDrives();

            foreach (var drive in drivers)
            {
                Directory.SetCurrentDirectory(drive.RootDirectory.FullName);
                if (Directory.Exists(@"\ProgramData"))
                {
                    result = drive;
                    break;
                }
            }

            return result;
        }
    }
}

//Создать программу которая найдет системный диск на ПК