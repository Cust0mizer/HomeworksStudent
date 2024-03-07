namespace HomeworksStudent.Http
{
    public class HttpStarter : IEntryPoint
    {
        public void Start()
        {
            HttpSService httpSService = new HttpSService();
            httpSService.StartGet(@"http://numbersapi.com/");
        }
    }
}