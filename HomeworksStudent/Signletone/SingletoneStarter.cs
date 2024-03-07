namespace HomeworksStudent.Signletone
{
    public class SingletoneStarter : IEntryPoint
    {
        public void Start()
        {
            MarioSingle.Instance.Hill();
        }
    }
}
