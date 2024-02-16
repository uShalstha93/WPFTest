using System.Windows.Controls;

namespace OxpanPosDesktopUI.Views
{
    /// <summary>
    /// Interaction logic for ProductCategoryView.xaml
    /// </summary>
    public partial class ProductCategoryView : UserControl
    {
        public ProductCategoryView()
        {
            InitializeComponent();

            ProductCategory productCategory1 = new ProductCategory();
            productCategory1.ID = "01";
            productCategory1.Name = "Clothing";
            productCategory1.Description = "Cloths for men and women";
            productCategory1.Status = "Active";
            productCategory1.Action = "Edit/Delete";

            ProductCategory productCategory2 = new ProductCategory();
            productCategory2.ID = "01";
            productCategory2.Name = "Clothing";
            productCategory2.Description = "Cloths for men and women";
            productCategory2.Status = "Active";
            productCategory2.Action = "Edit/Delete";

            ProductCategory productCategory3 = new ProductCategory();
            productCategory3.ID = "01";
            productCategory3.Name = "Clothing";
            productCategory3.Description = "Cloths for men and women";
            productCategory3.Status = "Active";
            productCategory3.Action = "Edit/Delete";

            ProductCategory productCategory4 = new ProductCategory();
            productCategory4.ID = "01";
            productCategory4.Name = "Clothing";
            productCategory4.Description = "Cloths for men and women";
            productCategory4.Status = "Active";
            productCategory4.Action = "Edit/Delete";

            ProductCategory productCategory5 = new ProductCategory();
            productCategory5.ID = "01";
            productCategory5.Name = "Clothing";
            productCategory5.Description = "Cloths for men and women";
            productCategory5.Status = "Active";
            productCategory5.Action = "Edit/Delete";

            ProductCategoryList.Items.Add(productCategory1);
            ProductCategoryList.Items.Add(productCategory2);
            ProductCategoryList.Items.Add(productCategory3);
            ProductCategoryList.Items.Add(productCategory4);
            ProductCategoryList.Items.Add(productCategory5);
        }

        public class ProductCategory
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public string Action { get; set; }
        }
    }
}
