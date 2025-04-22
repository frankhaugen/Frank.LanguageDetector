using Frank.LanguageDetector.Internals;

namespace Frank.LanguageDetector;

public class LanguageDetectionService
{
    private readonly DetectionEngine _detectionEngine;
    private readonly LanguageDetectionOptions _options;

    public LanguageDetectionService(LanguageDetectionOptions options)
    {
        _options = options;
        var wordLanguageProbabilities = new WordProbabilities();
        _detectionEngine = new DetectionEngine(options, wordLanguageProbabilities);
        wordLanguageProbabilities.AddLanguages(options.NGramLength.GetValueOrDefault(3));
    }

    /// <summary>
    ///     Checks to see if the provided language is the one provided
    /// </summary>
    /// <param name="languageCode">The three-letter ISO language code</param>
    /// <param name="text">The <paramref name="text" /> to be analyzed</param>
    /// <returns>True, false or null</returns>
    public bool Is(Language languageCode, string text)
    {
        TimeoutHelper.ExecuteWithTimeout(() =>
        {
            var detectedLanguage = _detectionEngine.DetectAll(text)
                .FirstOrDefault();
        
            return detectedLanguage != null && detectedLanguage.Language == languageCode;
        }, _options.Timeout ?? TimeSpan.FromSeconds(2));
        
        throw new TimeoutException("The language detection took too long to complete.");
    }

    /// <summary>
    ///     Detects and selects the most likely language. Can return null if probability is too low
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public LanguageResult? Detect(string text)
    {
        TimeoutHelper.ExecuteWithTimeout(() =>
        {
            var detectedLanguage = _detectionEngine.DetectAll(text)
                .FirstOrDefault();
        
            return detectedLanguage;
        }, _options.Timeout ?? TimeSpan.FromSeconds(2));
        
        throw new TimeoutException("The language detection took too long to complete.");
    }

    /// <summary>
    ///     Gets the list of languages detected from the text inputted
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public IEnumerable<LanguageResult> DetectAll(string text)
    {
        TimeoutHelper.ExecuteWithTimeout(() =>
        {
            var detectedLanguages = _detectionEngine.DetectAll(text);
        
            return detectedLanguages;
        }, _options.Timeout ?? TimeSpan.FromSeconds(2));
        
        throw new TimeoutException("The language detection took too long to complete.");
    }
}