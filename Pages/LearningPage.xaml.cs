using EasyWords;
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
using WPFWordListApp;
using WPFWordListApp.Views;

namespace WPFWordListApp
{
    /// <summary>
    /// Interaktionslogik für LearningPage.xaml
    /// </summary>
    public partial class Learningpage : Window
    {
        public void LearningPage()
        {
            InitializeComponent();
        }
        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigiere zur LecturePage
            LecturePage lecturePage = new LecturePage();
            lecturePage.Show(); // Zeige die LecturePage
            this.Close(); // Schließe die LearningPage
        }

        private void OpenSettingsPage_Click(object sender, RoutedEventArgs e)
        {
            SettingsPage infoWindow = new SettingsPage();
            infoWindow.Show();
            this.Close();
        }
        public void OnLearningCompleted()
        {
            StatisticsManager statsManager = new StatisticsManager();
            statsManager.ShowStatisticsPopup();
        }
    }
}
