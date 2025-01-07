using EasyWords;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using WPFWordListApp.Views;

namespace EasyWords
{
    /// <summary>
    /// Interaktionslogik für InfoView.xaml
    /// </summary>
    public partial class InfoPage : Window
    {
        private readonly MainWindow _mainWindow;

        public InfoPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

            // Setze das aktuelle Datum als Text für den TextBlock
            VersionDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
        public InfoPage()
        {
            InitializeComponent();
        }

        // Button-Click Event, um InfoWindow zu öffnen und MainWindow zu schließen
        private void OpenSettingsPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow infoWindow = new MainWindow();
            infoWindow.Show(); // InfoWindow anzeigen
            this.Close(); // MainWindow schließen
        }
    }
}
