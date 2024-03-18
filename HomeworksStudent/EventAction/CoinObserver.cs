using R3;

namespace HomeworksStudent.EventAction {
    public class CoinObserver : IDisposable {
        private View _view;

        public CoinObserver(View view) {
            _view = view;
            CoinManager.Instance.CoinChanged += _view.UpdateView;
        }

        public void Dispose() {
            CoinManager.Instance.CoinChanged -= _view.UpdateView;
        }
    }
}

public class ReactiveStart : IEntryPoint {
    public void Start() {
        COinManagerrr cOinManagerrr = new COinManagerrr();
        cOinManagerrr.Coin.Subscribe(PrintCoin);
        cOinManagerrr.AddCoin(10);
        Thread.Sleep(1000);
        cOinManagerrr.AddCoin(10);
        Thread.Sleep(1000);
        cOinManagerrr.AddCoin(10);

    }

    public void PrintCoin(int value) {
        Console.WriteLine(value);
    }
}

public class EvenNumberObservable : IObservable<int> {
    private int _value = 0;

    public IDisposable Subscribe(IObserver<int> observer) {
        Random random = new Random();
        _value += random.Next(1, 100);
        observer.OnNext(_value);
        return Disposable.Empty;
    }
}

public class ConsoleLogObserver : IObserver<int> {
    public void OnCompleted() {
        Console.WriteLine("End");
    }

    public void OnError(Exception error) {
        throw new NotImplementedException();
    }

    public void OnNext(int value) {
        Console.WriteLine($"{value}");
    }
}

public class COinManagerrr {
    public ReactiveProperty<int> Coin = new ReactiveProperty<int>();

    public void AddCoin(int value) {
        Coin.Value += value;
    }
}