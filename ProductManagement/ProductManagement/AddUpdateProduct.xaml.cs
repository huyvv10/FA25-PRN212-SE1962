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
        public Product prdFlag { get; set; } = null;
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

        private void FillDataFormUpdate(Product x)
        {
            txtID.Text = x.Id;
            txtName.Text = x.Name;
            txtUnit.Text = x.Unit;
            txtQty.Text=x.Qty.ToString();   //x.Qty+"";
            cboCategory.Text=x.Cat.CatName.ToString();
        }
        private void frmAddUpdate_Loaded(object sender, RoutedEventArgs e)
        {
            FillCboCategory();
            if (prdFlag != null)
            {
                btnSave.Content = "Update";
                txtID.IsReadOnly = true;
                FillDataFormUpdate(prdFlag);
            }
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

                if (prdFlag != null)
                {
                    _productBLL.UpdateProduct(x);
                }
                else
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
