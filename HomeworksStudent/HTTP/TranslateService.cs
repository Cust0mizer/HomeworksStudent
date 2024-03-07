using Yandex.Translator;

namespace HomeworksStudent.Http
{
    public class TranslateService
    {
        public void StartTranslate(string text)
        {
            IYandexTranslator translator = Yandex.Translator.Yandex.Translator(api =>
                                     api.ApiKey("b1g9gdp0bckp33jjr2m3").Format(ApiDataFormat.Json));

            var translate = translator.Translate("en-ru", text);
            string result = translate.Text;
            //Task.Run(GetTranslate).Wait();
        }

        private async Task GetTranslate()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync(@"https://www.reverso.net/%D0%BF%D0%B5%D1%80%D0%B5%D0%B2%D0%BE%D0%B4-%D1%82%D0%B5%D0%BA%D1%81%D1%82%D0%B0#sl=eng&tl=rus&text=hello");
                string result = await responseMessage.Content.ReadAsStringAsync();
                await Console.Out.WriteLineAsync(result);
            }
        }
    }
}