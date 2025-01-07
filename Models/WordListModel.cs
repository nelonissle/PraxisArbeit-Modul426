using System.Collections.ObjectModel;

namespace WPFWordListApp.Models
{
    public class WordListModel
    {
        public ObservableCollection<string> WordLists { get; set; } = new ObservableCollection<string>
        {
            "Lecture 1",
            "Lecture 2",
            "Lecture 3"
        };
    }
}