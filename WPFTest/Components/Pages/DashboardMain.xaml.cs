using System.Windows.Controls;

namespace WPFTest.Components.Pages
{
    /// <summary>
    /// Interaction logic for DashboardMain.xaml
    /// </summary>
    public partial class DashboardMain : Page
    {
        public DashboardMain()
        {
            InitializeComponent();

            Frame topbarMenu = new Frame();
            topbarMenu.Navigate(new Topbar());
        }
    }
}
