namespace TutorialRater.Entities
{
    public enum FormatType
    {
        Video,
        Text,
        VideoAndText,
        Audio
    }
    public class Tutorial
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public FormatType Format { get; set; } 
    }
}
