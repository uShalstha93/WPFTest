using System.Windows.Controls;

namespace OxpanPosDesktopUI.Views
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
