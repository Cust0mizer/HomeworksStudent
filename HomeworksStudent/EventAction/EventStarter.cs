namespace HomeworksStudent.EventAction {
    public class EventStarter : IEntryPoint {
        public void Start() {
            View view = new View();
            CoinObserver playerObserver = new CoinObserver(view);
            CoinManager.Instance.AddCoin(1231);
            CoinManager.Instance.RemoveCoin(1231);
        }
    }
}