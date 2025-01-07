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


namespace WPFWordListApp.Views
{
    public partial class AddWordPage : Window
    {
        public AddWordPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var englishWord = EnglishTextBox.Text.Trim();
            var germanWord = GermanTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(englishWord) || string.IsNullOrWhiteSpace(germanWord))
            {
                MessageBox.Show("Bitte geben Sie sowohl das englische als auch das deutsche Wort ein.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Hier kannst du die Logik zum Speichern hinzufügen
            MessageBox.Show($"Das Wortpaar wurde gespeichert: {englishWord} - {germanWord}", "Erfolg", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}


        






