using System.Windows;
using WPF_Buttons.ViewModels;
using WPF_Buttons.Windows;

namespace WPF_Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
