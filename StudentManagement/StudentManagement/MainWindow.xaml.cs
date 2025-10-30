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
using StudentManagement.BLL;
using StudentManagement.Models;

namespace StudentManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentBLL _studentBLL = new();
        private MajorBLL _majorBLL = new();
        private DepartmentBLL _departmentBLL = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FillComboMajor()
        {
            cboMajor.ItemsSource = null;
            cboMajor.ItemsSource = _majorBLL.GetAllMajor();
            cboMajor.SelectedValuePath = "MajorId";
            cboMajor.DisplayMemberPath = "MajorName";
            cboMajor.SelectedIndex = 0;
        }

        private void FillDataGrid()
        {
            dgStudentList.ItemsSource = null;
            dgStudentList.ItemsSource = _studentBLL.GetAllStudents();
        }

        private void FillDepartmentList()
        {
            lstDepartment.ItemsSource = null;
            lstDepartment.ItemsSource = _departmentBLL.GetAllDepartment();
            lstDepartment.DisplayMemberPath = "DeptName";
            lstDepartment.SelectedValuePath = "DeptId";
        }
        private void frmStudent_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboMajor();
            FillDataGrid();
            FillDepartmentList();
        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgStudentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student? s = dgStudentList.SelectedItem as Student;
            if (s != null)
            {
                txtId.Text = s.Id.ToString();
                txtName.Text = s.Name.ToString();
                txtAddress.Text = s.Address.ToString();
                radMale.IsChecked = (s.Gender == "Nam" ? true : false);
                radFemale.IsChecked = (s.Gender == "Nữ" ? true : false);
                dpkDOB.SelectedDate= s.Dob;
                cboMajor.SelectedValue = s.MajorId;
                lstDepartment.SelectedValue = s.DeptId;
                chkPython.IsChecked = s.Skills.Contains("Python");
                chkJava.IsChecked = s.Skills.Contains("Java");
                chkCShap.IsChecked = s.Skills.Contains("C#");
                chkCpp.IsChecked = s.Skills.Contains("C++");
                chkNodeJs.IsChecked = s.Skills.Contains("Node JS");
                chkDotNET.IsChecked = s.Skills.Contains(".NET");

            }
            else
            {
                return;
            }
        }
    }
}