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
using System.Windows.Navigation;
using System.Windows.Shapes;
using EF_Models;
using EF_DataAccess;
using System.Diagnostics;

namespace EF_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            SagarEntities objtest = new SagarEntities();
            var data= objtest.employees.ToList();
        }              

        private void hpUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update objUpdate = new Update();
            this.Hide();
            objUpdate.ShowDialog();
        }

        private void hpRemove_Click(object sender, RoutedEventArgs e)
        {
            Remove objRemove = new Remove();
            this.Hide();
            objRemove.ShowDialog();
        }

        private void hpAdd_Click(object sender, RoutedEventArgs e)
        {
            Addition objAddition = new Addition();
            this.Hide();
            objAddition.ShowDialog();
        }
    }
}
