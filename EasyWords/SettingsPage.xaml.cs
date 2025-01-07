using System.Windows;

namespace WPFWordListApp.Views
{
    public partial class SettingsPage : Window
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Logik für Zurück-Button (z. B. Hauptmenü anzeigen)
            Close();
        }

        private void ResetStatistics_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Statistik wurde zurückgesetzt.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DeleteData_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Möchten Sie wirklich alle Daten löschen?", "Bestätigung",
                                         MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Daten wurden gelöscht.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ResetBuckets_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Buckets wurden zurückgesetzt.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ImportData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Stand wurde importiert.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ExportData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Stand wurde exportiert.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
