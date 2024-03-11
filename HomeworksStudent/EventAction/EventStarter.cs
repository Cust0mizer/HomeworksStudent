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

//Создать дженерик метод который принимает 2 любые переменные и меняет их местами после чего выводит на экарн

//Создать дженерик класс который хранит в себе дженерик массив, и имеет методы по добавлению в этот массив элементов, удаление элемента из массива и возврата размера массива.