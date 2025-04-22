namespace Frank.LanguageDetector.Internals;

/// <summary>
/// </summary>
public static class EnumAttributesExtensions
{
    /// <summary>
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetEnglishName(this Language value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attributes = field?.GetCustomAttributes(typeof(EnglishNameAttribute), false);
        return !(attributes?.SingleOrDefault() is EnglishNameAttribute attribute)
            ? value.ToString()
            : attribute.GetName();
    }

    /// <summary>
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetLocalName(this Language value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attributes = field?.GetCustomAttributes(typeof(LocalNameAttribute), false);
        return !(attributes?.SingleOrDefault() is LocalNameAttribute attribute)
            ? value.ToString()
            : attribute.GetName();
    }
}