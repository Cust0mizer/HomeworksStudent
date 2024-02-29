namespace HomeworksStudent.Domino
{
    public class DominoManager
    {
        private List<Domino> _dominos = new List<Domino>();
        private List<Domino> _useDomino = new List<Domino>();
        private Random _randomDominoChanger = new Random();

        public void CreateDomino()
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    if (j + i > 6)
                    {
                        continue;
                    }
                    _dominos.Add(new Domino(i, j + i));
                }
            }
        }

        public void TakeDomino()
        {
            int randomDominoIndex = _randomDominoChanger.Next(0, _dominos.Count - 1);
            Console.WriteLine($"Вы взяли домино с номером ");
            _dominos[randomDominoIndex].PrintInfo();
            _useDomino.Add(_dominos[randomDominoIndex]);
            _dominos.Remove(_dominos[randomDominoIndex]);
        }

        public void PrintAllDominoIndex()
        {
            for (int i = 0; i < _dominos.Count; i++)
            {
                _dominos[i].PrintInfo();
            }
        }
    }
}