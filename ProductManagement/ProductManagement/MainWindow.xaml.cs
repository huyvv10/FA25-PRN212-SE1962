using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProductManagement.Models;
using ProductManagement.ViewModel;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductBLL _prdBLL = new ProductBLL();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FillDataGridProduct()
        {
            dgProduct.ItemsSource = null;
            dgProduct.ItemsSource = _prdBLL.GetAllProduct();
        }
        private void frmProduct_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGridProduct();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Product? x = dgProduct.SelectedItem as Product;
            if (x == null)
            {
                MessageBox.Show("Please select a product to delete.","Select a product",MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            if (MessageBox.Show("Do you really want to delete?", "Confirmation delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _prdBLL.RemoveProduct(x);
                FillDataGridProduct();
            }                
            else
                return;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddUpdateProduct frmAddUpD = new AddUpdateProduct();
            frmAddUpD.Show();
            this.Hide();
            this.Close();
        }
    }
}