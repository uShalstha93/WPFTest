using System.Windows.Controls;

namespace WPFTest.Components.TestForm
{
    /// <summary>
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : UserControl
    {
        public Form()
        {
            InitializeComponent();
        }

        public string Title 
        { 
            get
            {
                return Title;
            }
            set
            {
                tbName.Text = value;
            }
        }

        public string Placeholder
        {
            get
            {
                return Placeholder;
            }
            set
            {
                tbPlaceholder.Text = value;
            }
        }


        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
                tbPlaceholder.Text = txtName.Text;
            else
                tbPlaceholder.Text = "";
        }
    }
}
