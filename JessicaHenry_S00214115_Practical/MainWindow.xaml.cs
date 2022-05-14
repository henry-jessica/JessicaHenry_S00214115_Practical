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

namespace JessicaHenry_S00214115_Practical
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CarData db = new CarData();
        List<Car> allCars = new List<Car>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Cars
                        select c;
            allCars = query.ToList();
            blxCars.ItemsSource = allCars;
        }

        private void lbxCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car selected = blxCars.SelectedItem as Car; 
           
            if (selected != null)
            {
                tbxCarsDetails.Text = selected.CarDetails();
                imgCar.Source = new BitmapImage(new Uri(selected.Car_Image, UriKind.Relative));
            }
        }


    }
}
