using System.Collections.ObjectModel;
using System.Windows;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            entries = new ObservableCollection<string>();
            InitializeComponent();
        }

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEntries.SelectedItem;
            if(selectedItem != null)
            {
                var result = MessageBox.Show($"Are you sure you want to remove: {(string)selectedItem}", "Sure ?", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Entries.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("No Data selected to Delete!","Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }
    }
}