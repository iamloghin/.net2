namespace CarService.WPF.Common
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class SelectableViewModel<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isChecked;
        private T _item;

        public SelectableViewModel()
        { }

        public SelectableViewModel(T item, bool isChecked = false)
        {
            this._item = item;
            this._isChecked = isChecked;
        }

        public T Item
        {
            get => _item;
            set
            {
                if (_item != null && _item.Equals(value)) return;
                _item = value;
                OnPropertyChanged();
            }
        }

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked == value) return;
                _isChecked = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
