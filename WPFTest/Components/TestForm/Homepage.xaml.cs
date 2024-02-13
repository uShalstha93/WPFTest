using System.Windows;
using System.Windows.Controls;
using WPFTest.Components.Pages;

namespace WPFTest.Components.TestForm
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        public Homepage()
        {
            InitializeComponent();

            Frame sidebarMenu = new Frame();
            sidebarMenu.Navigate(new SidebarMenu());
            Frame dashboardMain = new Frame();
            dashboardMain.Navigate(new DashboardMain());
        }
    }
}
