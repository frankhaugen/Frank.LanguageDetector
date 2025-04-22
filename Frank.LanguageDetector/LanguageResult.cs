using Frank.LanguageDetector.Internals;

namespace Frank.LanguageDetector;

public class LanguageResult
{
    public Language Language { get; internal init; }
    public double Probability { get; internal init; }
    public string EnglishName => Language.GetEnglishName();
    public string LocalName => Language.GetLocalName();
    
    public override string ToString() => $"{Language.GetEnglishName()} ({Language.GetLocalName()}): {Probability:P2}";
}