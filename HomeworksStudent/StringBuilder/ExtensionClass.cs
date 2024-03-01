using System.Text;

static class ExtensionClass
{
    public static void NewLine(this StringBuilder stringBuilder, string text)
    {
        stringBuilder.Append($"\n{text}");
    }
}




//Метод расширения для String Builder 
//который позволит добавлять текст в 
//новую строку с использованием переноса строки 


//Создать приложение "Распорядок дня"
//МОжно добавить задачу
//Удалить задачу
//Получить информацию о всех задачах
    //При выводе, выводить время добавления задачи