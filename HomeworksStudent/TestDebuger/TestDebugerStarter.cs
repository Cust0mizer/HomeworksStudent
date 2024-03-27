using Catharsis.Commons;
using Convert = System.Convert;

namespace HomeworksStudent.TestDebuger {
    public class TestDebugerStarter : IEntryPoint {
        public void Start() {
            List<Player> _players = new List<Player>();
            for (int i = 0; i < 100; i++) {
                _players.Add(new Player(i, i, i.ToString()));
            }

            //_players.Where(player => player.PlayerType == PlayerType.Animal).ToList().ForEach(player => player.PrintInfo());
            //elements.ForEach(player => player.PrintInfo());

            //List<Player> elements = new List<Player>();
            //for (int i = 0; i < _players.Count; i++) {
            //    if (_players[i].PlayerType == PlayerType.Animal) {
            //        elements.Add(_players[i]);
            //    }
            //}
            //for (int i = 0; i < elements.Count; i++) {
            //    elements[i].PrintInfo();
            //}

            foreach (var item in GetPlayers(_players)) {
                item.PrintInfo();
            }
        }

        private IEnumerable<Player> GetPlayers(List<Player> players) {
            for (int i = 0; i < players.Count; i++) {
                if (players[i].Health >= 50) {
                    yield return players[i];
                }
            }
        }
    }

    public class Player {
        public int Health { get; private set; }
        private int _damage;
        private string _name;
        public PlayerType PlayerType { get; private set; }

        public Player(int health, int damage, string name) {
            Health = health;
            _damage = damage;
            _name = name;
        }

        public void PrintInfo() {
            Console.WriteLine(Health);
        }
    }

    public enum PlayerType {
        Animal,
        Human
    }
}
