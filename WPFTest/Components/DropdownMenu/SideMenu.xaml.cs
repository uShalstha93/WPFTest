using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using WPFTest.Components.DropdownMenu.ViewModel;

namespace WPFTest.Components.DropdownMenu
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    public partial class SideMenu : Window
    {
        public SideMenu()
        {
            InitializeComponent();

            var item0 = new ItemMenu("Dashboard", new UserControl(), PackIconKind.Home);

            var menuProductManager = new List<SubItem>();
            menuProductManager.Add(new SubItem("Product Category"));
            menuProductManager.Add(new SubItem("Product Sub Category"));
            menuProductManager.Add(new SubItem("Products"));
            menuProductManager.Add(new SubItem("Units"));
            var item1 = new ItemMenu("Product Manager", menuProductManager, PackIconKind.Menu);

            var menuAccounts = new List<SubItem>();
            menuAccounts.Add(new SubItem("Ledger"));
            menuAccounts.Add(new SubItem("Sub Ledger"));
            var item2 = new ItemMenu("Accounts", menuAccounts, PackIconKind.Account);

            var menuStakeHolders = new List<SubItem>();
            menuStakeHolders.Add(new SubItem("Share Holders"));
            menuStakeHolders.Add(new SubItem("Customers"));
            menuStakeHolders.Add(new SubItem("Suppliers"));
            menuStakeHolders.Add(new SubItem("Employes"));
            menuStakeHolders.Add(new SubItem("Other Parties"));
            var item3 = new ItemMenu("Stake Holders", menuStakeHolders, PackIconKind.Menu);

            Menu.Children.Add(new UserControlMenuItem());

        }
    }
}
