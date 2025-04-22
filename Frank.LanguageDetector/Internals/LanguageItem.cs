namespace Frank.LanguageDetector.Internals;

public class LanguageItem
{
    public Language Language { get; set; }
    public Dictionary<string, int> Frequency { get; set; } = new();
    public int[] WordCount { get; set; } = [];
}