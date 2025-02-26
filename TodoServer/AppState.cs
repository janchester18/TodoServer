namespace TodoServer
{
    public class AppState
    {
        public event Action OnChange;
        public bool IsLoading { get; private set; }

        public void SetLoading(bool isLoading)
        {
            IsLoading = isLoading;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
