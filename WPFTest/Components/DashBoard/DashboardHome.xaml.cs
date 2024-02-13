using System.Windows;
using System.Windows.Controls;

namespace WPFTest.Components.DashBoard
{
    /// <summary>
    /// Interaction logic for DashboardHome.xaml
    /// </summary>
    public partial class DashboardHome : Window
    {
        public DashboardHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string contentName = button.Name.ToString() + "Content";
                StackPanel contentPanel = FindName(contentName) as StackPanel;
                if (contentPanel != null)
                {
                    contentPanel.Visibility = contentPanel.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }
    }

}
