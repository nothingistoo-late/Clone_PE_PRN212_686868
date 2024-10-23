using Clone_PRN_HoangNT2.Entities;
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

namespace Clone_PRN_HoangNT2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AirCondDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void QuitButton(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Do You Really Want To Exit???", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }



        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detailWindow = new DetailWindow();
            detailWindow.ShowDialog();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detailWindow = new DetailWindow();
            detailWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<AirCon> arr = new();
            arr.Add(new AirCon() { AirConId = "01", AirConName = "Toshiba", Warranty = "10/10/2024", Feature = "Lanh Vl", Price = "100", Quantity = "10", SoundLevel = "High", SupplierID = "ABC", SupplierName = "Mr.A" });
            arr.Add(new AirCon() { AirConId = "02", AirConName = "Samsung", Warranty = "12/12/2024", Feature = "Cooling Pro", Price = "200", Quantity = "15", SoundLevel = "Low", SupplierID = "DEF", SupplierName = "Mr.B" });
            arr.Add(new AirCon() { AirConId = "03", AirConName = "LG", Warranty = "05/05/2025", Feature = "Quiet Mode", Price = "150", Quantity = "12", SoundLevel = "Medium", SupplierID = "GHI", SupplierName = "Mr.C" });
            arr.Add(new AirCon() { AirConId = "04", AirConName = "Daikin", Warranty = "11/11/2023", Feature = "Energy Saver", Price = "250", Quantity = "8", SoundLevel = "Low", SupplierID = "JKL", SupplierName = "Mr.D" });
            arr.Add(new AirCon() { AirConId = "05", AirConName = "Panasonic", Warranty = "07/07/2024", Feature = "Fast Cooling", Price = "180", Quantity = "20", SoundLevel = "Medium", SupplierID = "MNO", SupplierName = "Mr.E" });
            arr.Add(new AirCon() { AirConId = "06", AirConName = "Sharp", Warranty = "03/03/2025", Feature = "Eco Mode", Price = "220", Quantity = "7", SoundLevel = "High", SupplierID = "PQR", SupplierName = "Mr.F" });
            arr.Add(new AirCon() { AirConId = "07", AirConName = "Mitsubishi", Warranty = "01/01/2024", Feature = "Smart Cooling", Price = "300", Quantity = "6", SoundLevel = "Low", SupplierID = "STU", SupplierName = "Mr.G" });
            arr.Add(new AirCon() { AirConId = "08", AirConName = "Electrolux", Warranty = "09/09/2025", Feature = "Turbo Cooling", Price = "270", Quantity = "5", SoundLevel = "High", SupplierID = "VWX", SupplierName = "Mr.H" });
            arr.Add(new AirCon() { AirConId = "09", AirConName = "Hitachi", Warranty = "04/04/2024", Feature = "Humidity Control", Price = "240", Quantity = "14", SoundLevel = "Medium", SupplierID = "YZA", SupplierName = "Mr.I" });
            arr.Add(new AirCon() { AirConId = "10", AirConName = "Fujitsu", Warranty = "02/02/2025", Feature = "Silent Mode", Price = "190", Quantity = "9", SoundLevel = "Low", SupplierID = "BCD", SupplierName = "Mr.J" });
            AirCondDataGrid.ItemsSource = arr;
        }
    }
}