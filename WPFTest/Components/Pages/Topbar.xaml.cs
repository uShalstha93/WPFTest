using System.Windows.Controls;
using WPFTest.Components.TestForm;

namespace WPFTest.Components.Pages
{
    /// <summary>
    /// Interaction logic for Topbar.xaml
    /// </summary>
    public partial class Topbar : Page
    {
        public Topbar()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
