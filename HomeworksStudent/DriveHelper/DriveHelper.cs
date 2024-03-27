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
                string path = Path.Join(drive.RootDirectory.FullName, "ProgramData");
                if (Directory.Exists(@$"{path}"))
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