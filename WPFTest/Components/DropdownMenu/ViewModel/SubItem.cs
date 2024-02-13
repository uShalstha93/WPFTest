using System.Windows.Controls;

namespace WPFTest.Components.DropdownMenu.ViewModel
{
    class SubItem
    {
        public string Name { get; private set; }

        public UserControl Screen { get; private set; }

        public SubItem(string name, UserControl screen = null)
        {
            Name = name;
            Screen = screen;
        }
    }
}
