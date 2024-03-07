namespace HomeworksStudent.EventAction
{
    public class CoinObserver : IDisposable
    {
        private View _view;

        public CoinObserver(View view)
        {
            _view = view;
            CoinManager.Instance.CoinChanged += _view.UpdateView;
        }

        public void Dispose()
        {
            CoinManager.Instance.CoinChanged -= _view.UpdateView;
        }
    }
}

