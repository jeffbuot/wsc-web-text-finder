using System.Windows.Input;

namespace WSC.WebTextFinder.Core;

public class RelayCommand : ICommand {
    private readonly Action _execute;
    private readonly Func<bool> _canExecute;

    public RelayCommand(Action execute, Func<bool> canExecute = null) {
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter) => _canExecute == null || _canExecute();
    public void Execute(object parameter) => _execute();
    public event EventHandler CanExecuteChanged;
}
public class RelayCommand<T> : ICommand {
    private readonly Action<T> _execute;
    private readonly Func<T, bool> _canExecute;

    public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null) {
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter) => _canExecute == null || _canExecute((T)parameter);

    public void Execute(object parameter) => _execute((T)parameter);

    public event EventHandler CanExecuteChanged;
}
public class AsynchronousCommand : ICommand {
    private readonly Func<CancellationToken, Task> _execute;
    private readonly Func<bool> _canExecute;
    private CancellationTokenSource _cancellationTokenSource;
    private bool _isExecuting;

    public AsynchronousCommand(Func<CancellationToken, Task> execute, Func<bool> canExecute = null) {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter) {
        return !_isExecuting && (_canExecute?.Invoke() ?? true);
    }

    public async void Execute(object parameter) {
        _isExecuting = true;
        _cancellationTokenSource = new CancellationTokenSource();
        RaiseCanExecuteChanged();

        try {
            await _execute(_cancellationTokenSource.Token);
        }
        finally {
            _isExecuting = false;
            RaiseCanExecuteChanged();
        }
    }

    public void Cancel() {
        if (_isExecuting) {
            _cancellationTokenSource.Cancel();
        }
    }

    public event EventHandler CanExecuteChanged;

    protected virtual void RaiseCanExecuteChanged() {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}