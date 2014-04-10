namespace MoqExample.ViewModel
{
  using System;
  using System.Windows.Input;

  public class RelayCommand: ICommand
  {

    private Action<object> _action;

    public RelayCommand(Action<object> action)
    {
      this._action = action;
    }

    public bool CanExecute(object parameter)
    {
      return true;
    }

    public void Execute(object parameter)
    {
      _action(null);
    }

    public event EventHandler CanExecuteChanged;
  }
}