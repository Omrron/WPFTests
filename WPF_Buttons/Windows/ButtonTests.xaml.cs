using System.Windows;

namespace WPF_Buttons.Windows
{
    /// <summary>
    /// Interaction logic for ButtonTests.xaml
    /// </summary>
    public partial class ButtonTests : Window
    {
        public ButtonTests()
        {
            InitializeComponent();
            DataContext = new ButtonsTestViewModel();
        }
    }
}
