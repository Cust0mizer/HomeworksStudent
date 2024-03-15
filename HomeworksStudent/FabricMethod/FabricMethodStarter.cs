using HomeworksStudent.FabricMethod.FabricMethodPlayer;

namespace HomeworksStudent.FabricMethod
{
    class Program : IEntryPoint
    {
        public void Start()
        {
            Player player = new Player();
            Base archerBase = new Base(new ArcherCreator());
            Base barbarianBase = new Base(new BarbarianCreator());
            var unitA = archerBase.CreateNewUnit();
            var unitB = barbarianBase.CreateNewUnit();
            unitA.Attack(player);
            unitB.Attack(player);
        }
    }
}

//1с для магазина
//Есть возможность добавить товар в магазин
//У товара есть: 1 - Имя, 2 - Цена, 3 - Группа
//Можно удалить товар из магазина:
//(Показывают список всех товаров в магазине
//Я выбираю из этого списка товар и он удаляется)
//Можно получить все товары которые хранятся в магазине
//Можно получить все товары, которые принадлежат определённой
//группе
//Группы товаров: 1 - фрукты, 2 - овощи, 3 - Выпечка
//Дубляж кода - зло!


