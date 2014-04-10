namespace MoqExample.ViewModel
{
  using System;
  using System.ComponentModel;
  using System.Linq.Expressions;
  using System.Windows;
  using System.Windows.Input;

  public class MoqExampleViewModel: INotifyPropertyChanged
  {
    private ICommand _buttonCommand;

    public event PropertyChangedEventHandler PropertyChanged;
    public string MyTextBox { get; set; }

    public MoqExampleViewModel()
    {
      MyTextBox = "This text is from ctor";
      UpdateTextBoxClick = new RelayCommand(UpdateTextBox);
      CalculateClick = new RelayCommand(Calculate);
    }

    private void Calculate(object obj)
    {
      MessageBox.Show("test");
    }

    public ICommand UpdateTextBoxClick
    {
      get
      {
        return _buttonCommand;
      }
      set
      {
        _buttonCommand = value;
      }
    }

    public ICommand CalculateClick
    {
      get
      {
        return _buttonCommand;
      }
      set
      {
        _buttonCommand = value;
      }
    }

    public void UpdateTextBox(object obj)
    {
      MyTextBox = "This text is from button click";
      OnPropertyChanged(() => this.MyTextBox);
    }

    protected void OnPropertyChanged<T>(Expression<Func<T>> property)
    {
      if (this.PropertyChanged != null)
      {
        var mex = property.Body as MemberExpression;
        string name = mex.Member.Name;
        this.PropertyChanged(this, new PropertyChangedEventArgs(name));
      }
    }
  }
}