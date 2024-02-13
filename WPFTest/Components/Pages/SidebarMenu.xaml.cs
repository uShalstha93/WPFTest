using System.Windows;
using System.Windows.Controls;

namespace WPFTest.Components.Pages
{
    /// <summary>
    /// Interaction logic for SidebarMenu.xaml
    /// </summary>
    public partial class SidebarMenu : Page
    {
        public SidebarMenu()
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
