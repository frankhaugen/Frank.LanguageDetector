namespace Frank.LanguageDetector;

/// <summary>
///     Attribute to store an alternative name
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class EnglishNameAttribute : Attribute
{
    private readonly string _name;

    /// <inheritdoc />
    public EnglishNameAttribute(string name) => _name = name;

    /// <summary>
    /// </summary>
    /// <returns>
    ///     <see cref="string" />
    /// </returns>
    public string GetName() => _name;
}