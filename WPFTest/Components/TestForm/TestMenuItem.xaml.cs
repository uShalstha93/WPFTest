using System.Windows;
using System.Windows.Controls;

namespace WPFTest.Components.TestForm
{
    /// <summary>
    /// Interaction logic for TestMenuItem.xaml
    /// </summary>
    public partial class TestMenuItem : Window
    {
        public TestMenuItem()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string contentName = button.Content.ToString() + "Content";
                StackPanel contentPanel = FindName(contentName) as StackPanel;
                if (contentPanel != null)
                {
                    contentPanel.Visibility = contentPanel.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }

    }
}
