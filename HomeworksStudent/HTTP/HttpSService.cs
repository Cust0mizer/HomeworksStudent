namespace HomeworksStudent.Http
{

    public class HttpSService
    {
        public void StartGet(string http)
        {
            Console.WriteLine("Введите число!");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Task.Run(() => Get($"{http}{value}")).Wait();
            }
        }

        private async Task Get(string http)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(http);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                TranslateService translateService = new TranslateService();
                translateService.StartTranslate(responseBody);
                await Task.Delay(1000);
            }
        }
    }
}