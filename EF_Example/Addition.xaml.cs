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
using EF_Models;
using EF_DataAccess;

namespace EF_Example
{
    /// <summary>
    /// Interaction logic for Addition.xaml
    /// </summary>
    public partial class Addition : Window
    {
        public Addition()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDetails objEmpDetails = new EmployeeDetails();
            objEmpDetails.empId = Convert.ToInt32(txtEmpId.Text);
            objEmpDetails.empName = txtEmpName.Text;
            objEmpDetails.experience = txtExperience.Text;
            objEmpDetails.designation = txtDesignation.Text;
            objEmpDetails.salary = Convert.ToDecimal(txtSalary.Text);
            objEmpDetails.skillSet = txtSkillSet.Text;
            CrudOperations objCrudOp = new CrudOperations();
            objCrudOp.Add(objEmpDetails);
            MessageBox.Show("Data Saved Successfully");
            Reset();
        }

        private void Reset()
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
