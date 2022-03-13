using System;
using System.Windows.Input;

namespace WpfApp18
{
    public class Command : ICommand
    {
        Action<object> _execute;

        public event EventHandler? CanExecuteChanged;

        public Command(Action<object> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}