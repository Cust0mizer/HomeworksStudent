﻿using HomeworksStudent.MenuProject;

namespace ProductShopAndMenu
{
    public class Project1_C : IEntryPoint
    {
        public void Start()
        {
            IMenuItem[] menuItems = { new AddComand(), new RemoveComand(), new ShowProductInfoComand() };
            Menu menu = new Menu(menuItems);
            menu.Start();
        }
    }
}