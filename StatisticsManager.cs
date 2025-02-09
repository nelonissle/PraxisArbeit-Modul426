using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Xml;
using Newtonsoft.Json;


namespace EasyWords
{
    public class WordStatistics
    {
        public string Word { get; set; }
        public int CorrectCount { get; set; }
        public int IncorrectCount { get; set; }
    }

    public class StatisticsManager
    {
        private static string filePath = "word_statistics.json";
        private Dictionary<string, WordStatistics> statistics;

        public StatisticsManager()
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    statistics = JsonConvert.DeserializeObject<Dictionary<string, WordStatistics>>(json) ?? new Dictionary<string, WordStatistics>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading statistics: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    statistics = new Dictionary<string, WordStatistics>();
                }
            }
            else
            {
                statistics = new Dictionary<string, WordStatistics>();
            }
        }

        private void SaveStatistics()
        {
            try
            {
                string json = JsonConvert.SerializeObject(statistics, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving statistics: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void UpdateStatistics(string word, bool correct)
        {
            if (!statistics.ContainsKey(word))
            {
                statistics[word] = new WordStatistics { Word = word, CorrectCount = 0, IncorrectCount = 0 };
            }

            if (correct)
            {
                statistics[word].CorrectCount++;
            }
            else
            {
                statistics[word].IncorrectCount++;
            }
            SaveStatistics();
        }

        public void ShowStatisticsPopup()
        {
            string message = "Word Statistics:\n";
            foreach (var entry in statistics.Values)
            {
                message += $"{entry.Word}: Correct - {entry.CorrectCount}, Incorrect - {entry.IncorrectCount}\n";
            }
            MessageBox.Show(message, "Statistics", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void ResetStatistics()
        {
            statistics.Clear();
            SaveStatistics();
        }
    }
}
