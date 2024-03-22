﻿using HomeworksStudent.MenuProject;
using HomeworksStudent;

namespace ProductShopAndMenu
{
    public class Project1_C : IEntryPoint
    {
        private LocalizationManager _localizationManager = ServiceLocator.Instance.LocalizationManager;

        public void Start()
        {
            IButton[] noProductButton = {
                new AddComand(),
                new SetLocaleComand(),
            };

            IButton[] containsProductButton = {
                new AddComand(),
                new ShowProductInfoComand(),
                new RemoveComand(),
                new ShowProductForCategory(),
                new SetLocaleComand(),
            };

            Menu containsProductMenu = new Menu(containsProductButton);
            Menu noProductMenu = new Menu(noProductButton);

            while (true)
            {
                if (ServiceLocator.Instance.Shop.ContainsProduct())
                {
                    containsProductMenu.Start(_localizationManager.GetLocaleText(LocaleKey.SelectAction));
                }
                else
                {
                    noProductMenu.Start(_localizationManager.GetLocaleText(LocaleKey.SelectAction));
                }
            }
        }
    }
}

//Система управления проектами:
//Добавить проект
//Добавить задачу в проект(В каждом проекте свои задачи)
//Удалить проект
//Получить информацию о проекте
//Проект это:
//Название проекта,
//задачи на проект (Их может быть много)
//Задача это (Имя задачи, цели задачи, дата добавления)
//О каждой задаче можно посмотреть подробную информацию
//Добавить систему локализации в проект
//*Основное меню интерактивное
//*Прятать кнопки которые невозможно использовать
//Проект Имя
//   Задач в проекте Кол-во
//	   Задача №1
//	     Цель №1
//	     Цель №2
//	   Задача №2
//	     Цель №1

//Задача 2
//Система управления умным домом
//Команда на включения света
//Команда на выключение света
//Команда на запуск робота пылесоса
//Команда на подачу воды
//Команда на включение сигнализации
//Команда на заказ еды
//Работа команд осуществляется через Console.WriteLine();
//Написать Singletone менеджер,
//который запускает каждую команду по отдельности
//Сделать меню по запуску команд

//Задача 1
//Система управления заказами в интернет-магазине: 
//Реализовать систему, которая позволяет пользователям добавлять товары в корзину, 
//удалять их и отправлять заказ. 
//Каждая операция (добавление, удаление, отправка заказа(Cw("Отправил"))) 
//должна быть инкапсулирована в отдельный объект команды.
//Корзина должна быть синглетоном.
//В заказе должно быть:
//Цена, имя товара и вес
//Добавить команду на вывод информации о заказе
//Из команд надо собрать меню

//Реализовать класс продукта, в котором будут поля:
//Имя продукта – Энам (5 и больше позиций)
//Цена продукта

//Реализовать базовый класс платёжного средства, в котором будут поля:
//Текущее кол-во денег
//Так-же должен быть метод вычитания денег из платёжного средства.

//У класса платёжного средства должно быть 2 наследника (Наличный, безналичный)

//Реализовать магазин, где есть коллекция продуктов, и следующие методы:
//Метод добавления нового продукта.
//Метод проверки наличия продукта в магазине.
//Метод показа информации о всех продуктах в магазине.
//Метод покупки продукта в магазине.