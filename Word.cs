namespace EasyWords.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string English { get; set; }
        public string German { get; set; }
        public string Category { get; set; }
        public bool IsLearned { get; set; }
    }
}
