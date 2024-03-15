﻿public class GlobalSingleton<T> where T : class, new()
{
    private static readonly T _instance;

    static GlobalSingleton()
    {
        _instance = new T();
    }

    public static T Instance
    {
        get
        {
            return _instance;
        }
    }
}

//Создать синглтон класс по менеджменту монеток
//ДОбавление, удаление, и отображение инфы