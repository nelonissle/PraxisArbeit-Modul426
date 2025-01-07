using System;
using System.Windows;
using WPFWordListApp.Models;


namespace WPFWordListApp
{


    public partial class Learningpage : Window
    {
        public string CurrentWord { get; set; } = "Fenêtre";
        public string CorrectTranslation { get; set; } = "Window";
        

        public Learningpage()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            var userInput = TranslationTextBox.Text.Trim();
            if (string.Equals(userInput, CorrectTranslation, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Richtig!", "Erfolg", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Falsch! Die richtige Übersetzung ist: {CorrectTranslation}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
