using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProductManagement.Models;
using ProductManagement.ViewModel;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for AddUpdateProduct.xaml
    /// </summary>
    public partial class AddUpdateProduct : Window
    {
        private CategoryBLL _catBLL=new();
        private ProductBLL _productBLL=new();
        public AddUpdateProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
            this.Close();
        }

        private void FillCboCategory()
        {
            cboCategory.ItemsSource = null;
            cboCategory.ItemsSource =_catBLL.GetAllCategory();
            cboCategory.DisplayMemberPath = "CatName";
            cboCategory.SelectedValuePath = "CatId";
            cboCategory.SelectedIndex = 0;
        }
        private void frmAddUpdate_Loaded(object sender, RoutedEventArgs e)
        {
            FillCboCategory();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                string id = txtID.Text.Trim();
                string name=txtName.Text.Trim();
                string unit=txtUnit.Text.Trim();
                int qty=int.Parse(txtQty.Text.Trim());
                string? catId = cboCategory.SelectedValue.ToString();
                Product x = new Product();
                x.Id = id;
                x.Name = name;
                x.Unit = unit;
                x.Qty = qty;
                x.CatId = catId;
                _productBLL.AddNewProduct(x);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
                this.Close();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Added unsucessfully");
            //}
        }
    }
}
