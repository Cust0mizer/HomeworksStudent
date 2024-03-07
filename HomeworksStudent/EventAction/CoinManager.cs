namespace HomeworksStudent.EventAction
{
    public class CoinManager
    {
        public static readonly CoinManager Instance;
        private CoinManager()
        { }

        static CoinManager()
        {
            Instance = new CoinManager();
        }

        public Action<int> CoinChanged;

        private int _coin;

        public void AddCoin(int value)
        {
            _coin += value;
            CoinChanged?.Invoke(_coin);
        }

        public void RemoveCoin(int value)
        {
            _coin -= value;
            CoinChanged?.Invoke(_coin);
        }
    }
}

