using Circus.Model;
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
    /// Interaction logic for AnimalPage.xaml
    /// </summary>
    public partial class AnimalPage : Page
    {
        Animal contextAnimal;
        public AnimalPage(Animal animal)
        {
            InitializeComponent();
            CBTypes.ItemsSource = App.DB.TypeAnimal.ToList();
            CBCages.ItemsSource = App.DB.Cell.ToList();
            contextAnimal = animal;
            DataContext = animal;

        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(contextAnimal.Name))
            {
                errorMessage += "Введите имя\n";
            }
            if (contextAnimal.Age == 0 || contextAnimal.Age < 0)
            {
                errorMessage += "Введите корректный возраст\n";
            }
            if (contextAnimal.TypeAnimal == null)
            {
                errorMessage += "Выберите вид\n";
            }
            if (contextAnimal.Cell == null)
            {
                errorMessage += "Выберите клетку\n";
            }

            if (string.IsNullOrWhiteSpace(errorMessage) == false)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            if (contextAnimal.Id == 0) //проверочка на добавление или редактирование
            {
                App.DB.Animal.Add(contextAnimal);
            }

            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
