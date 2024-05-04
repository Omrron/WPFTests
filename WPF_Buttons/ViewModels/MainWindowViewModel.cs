using System.Linq;
using System.Windows;
using System.Windows.Input;
using WPF_Buttons.CommonHandlers;
using WPF_Buttons.Windows;

namespace WPF_Buttons.ViewModels
{
    class MainWindowViewModel
    {
        private readonly ButtonTests m_nextWindow;
        public MainWindowViewModel() 
        {
            m_nextWindow = new ButtonTests();
        }

        private ICommand _clickCommand;
        public ICommand SwitchWindowCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => MyAction(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                return true;
            }
        }

        public void MyAction()
        {
            var currentWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            currentWindow.Close();
            m_nextWindow.Show();
        }
    }
}
