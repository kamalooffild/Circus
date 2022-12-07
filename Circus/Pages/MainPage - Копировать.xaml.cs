using Circus.Model;
using Circus.Model.ModelEnums;
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

namespace Circus.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

        }




        private void BAddProps_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new PropsPage());
        }

        private void BEmployeeAdd_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new EmployeePage(new Employee()));
        }

        private void BAddAnimal_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new AnimalPage(new Animal()));
        }

        private void BAddPerformance_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new PerformancePage(new Performance()));
        }
    }
}
