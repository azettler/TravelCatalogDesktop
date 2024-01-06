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

namespace PersonalTravelCatalogDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TravelCatalogMain : Window
    {
        public TravelCatalogMain()
        {
            InitializeComponent();

            SetupXML();
        }

        private void SetupXML()
        {
            var catalog = new TravelCatalog();

            var filePath = "test.xml";

            catalog.SaveToFile(filePath);
        }

        private void locationsButton_Click(object sender, RoutedEventArgs e)
        {
            ContinentsWindow window = new ContinentsWindow();

            window.ShowDialog();
        }
    }
}
