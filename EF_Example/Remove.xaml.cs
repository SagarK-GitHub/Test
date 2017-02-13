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
using EF_DataAccess;
using EF_Models;
namespace EF_Example
{
    /// <summary>
    /// Interaction logic for Remove.xaml
    /// </summary>
    public partial class Remove : Window
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            CrudOperations objCrudOperations = new CrudOperations();
            objCrudOperations.Remove(Convert.ToInt32(txtEmpId.Text));
            MessageBox.Show("Record Deleted Successfully");
            Reset();
        }

        private void txtSearchId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchId.Text.ToString()))
            {
                CrudOperations objcrud = new CrudOperations();
                EmployeeDetails emp = objcrud.GetDetails(Convert.ToInt32(txtSearchId.Text));
                if (emp != null)
                {
                    txtEmpId.Text = emp.empId.ToString();
                    txtEmpName.Text = emp.empName.ToString();
                    txtExperience.Text = emp.experience.ToString();
                    txtDesignation.Text = emp.designation.ToString();
                    txtSalary.Text = emp.salary.ToString();
                    txtSkillSet.Text = emp.skillSet.ToString();
                }
                else
                {
                    Reset();
                }
            }
            else
            {
                Reset();
            }
        }

        public void Reset()
        {
            txtEmpId.Text = txtEmpName.Text = txtExperience.Text = txtDesignation.Text = txtSalary.Text = txtSkillSet.Text = "";
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            objMain.Hide();
            this.Hide();
            objMain.Show();
        }
    }
}
