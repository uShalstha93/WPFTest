using System.Net.NetworkInformation;
using System.Windows;
using System.Windows.Controls;

namespace WPFTest.Components.ButtonStatus
{
    /// <summary>
    /// Interaction logic for HelloWorld.xaml
    /// </summary>
    /// 
   
    public partial class HelloWorld : Page
    {

        bool running = false;
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {

            if (running)
            {
                tbStatus.Text = "STOPPED";
                btnToggleRun.Content = "RUN";
            }
            else
            {
                tbStatus.Text = "RUNNING";
                btnToggleRun.Content = "STOP";
            }

            running = !running;

        }
    }

}
