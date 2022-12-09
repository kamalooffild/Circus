using Circus.Model;
using Clown.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PropsPage.xaml
    /// </summary>
    public partial class PropsPage : Page
    {
        Props contextProps;
        public PropsPage()
        {
            InitializeComponent();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string error = "";

            if (contextProps.Id == 0)
                App.DB.Props.Add(contextProps);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BEditImage_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextProps.Image = File.ReadAllBytes(dialog.FileName);
                DataContext = null;
                DataContext = contextProps;
            }
        }
    }
}
