namespace HomeworksStudent.Paterns.Signletone.Mario
{
    public class SingletoneStarter : IEntryPoint
    {
        public void Start()
        {
            MarioSingle.Instance.Hill();
        }
    }
}
