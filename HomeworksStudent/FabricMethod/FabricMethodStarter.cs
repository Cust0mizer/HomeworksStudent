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

    public class Base
    {
        private Creator _currentCreator;

        public Base(Creator creator)
        {
            _currentCreator = creator;
        }

        public IUnit CreateNewUnit()
        {
            return _currentCreator.Create();
        }
    }

    public interface IUnit
    {
        public int Damage { get; }
        public int Healht { get; }

        public void Attack(Player player);
    }

    public class Archer : IUnit
    {
        public int Damage => 20;

        public int Healht => 10;

        public void Attack(Player player)
        {
            player.TakeDamage(Damage);
            Console.WriteLine("Стрелы пиу пиу!");
        }
    }

    public class Barbarian : IUnit
    {
        public int Damage => 10;

        public int Healht => 30;

        public void Attack(Player player)
        {
            player.TakeDamage(Damage);
            Console.WriteLine("Варвар атакует мечём!");
        }
    }

    public abstract class Creator
    {
        public abstract IUnit Create();
    }

    public class ArcherCreator : Creator
    {
        public override IUnit Create()
        {
            return new Archer();
        }
    }

    public class BarbarianCreator : Creator
    {
        public override IUnit Create()
        {
            return new Barbarian();
        }
    }

    public class Player
    {
        private int _health = 100;

        public void TakeDamage(int damageValue)
        {
            _health -= damageValue;
            Console.WriteLine($"О нет, я получил урон! {damageValue} и теперь у меня {_health}");
        }
    }
}
