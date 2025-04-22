using System.Text.Json;
using System.Text.Json.Serialization;
using Frank.LanguageDetector.Internals;

namespace Frank.LanguageDetector.Tests;

public class UnitTest1
{
    private readonly ITestOutputHelper _outputHelper;

    public UnitTest1(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }
    
    [Fact]
    public void TestTimoutHelper_ShouldThrowTimeoutExceptionWhenTimeoutIsExceeded()
    {
        Assert.Throws<TimeoutException>(() => TimeoutHelper.ExecuteWithTimeout(() => Thread.Sleep(3000), TimeSpan.FromSeconds(2)));
    }
    
    [Fact]
    public void TestTimoutHelper_ShouldNotThrowTimeoutExceptionWhenTimeoutIsNotExceeded()
    {
        TimeoutHelper.ExecuteWithTimeout(() => Thread.Sleep(1000), TimeSpan.FromSeconds(2));
    }

    // [Fact]
    public void Test1()
    {
        // Path to the JSON file
        var jsonPath = @"D:\frankrepos\Frank.LanguageDetector\Frank.LanguageDetector\languages.json";

        // Read and parse the JSON file
        var jsonData = File.ReadAllText(jsonPath);
        var languageItems = JsonSerializer.Deserialize<List<LanguageItem>>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, Converters = { new JsonStringEnumConverter() }, WriteIndented = true }) ?? new List<LanguageItem>();

        // Generate the LanguageModel class
        using (var writer = new StreamWriter("D://LanguageModel.generated.cs"))
        {
            writer.WriteLine("using System.Collections;");
            writer.WriteLine("using System.Collections.Generic;");
            writer.WriteLine("using System.Linq;");
            writer.WriteLine();
            writer.WriteLine("namespace Frank.LanguageDetector");
            writer.WriteLine("{");
            writer.WriteLine("    public class LanguageModel : IEnumerable<LanguageItem>");
            writer.WriteLine("    {");
            writer.WriteLine("        public LanguageItem this[Language languageCode] => this.First(x => x.Language == languageCode);");
            writer.WriteLine();
            writer.WriteLine("        public IEnumerator<LanguageItem> GetEnumerator()");
            writer.WriteLine("        {");

            // Add yield return statements
            foreach (var item in languageItems) writer.WriteLine($"            yield return Get{item.Language}();");

            writer.WriteLine("        }");
            writer.WriteLine();
            writer.WriteLine("        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();");
            writer.WriteLine();
            writer.WriteLine("        public static LanguageModel Instance { get; } = new LanguageModel();");
            writer.WriteLine();
            writer.WriteLine("        public static int Count => Instance.Count();");
            writer.WriteLine();

            // Add static methods for each LanguageItem
            foreach (var item in languageItems)
            {
                writer.WriteLine($"        public static LanguageItem Get{item.Language}()");
                writer.WriteLine("            => new LanguageItem()");
                writer.WriteLine("            {");
                writer.WriteLine($"                Language = Language.{item.Language},");

                // Write Frequency dictionary
                writer.WriteLine("                Frequency = new Dictionary<string, int>");
                writer.WriteLine("                {");
                foreach (var kvp in item.Frequency) writer.WriteLine($"                    {{ \"{kvp.Key}\", {kvp.Value} }},");

                writer.WriteLine("                },");

                // Write WordCount array
                writer.Write("                WordCount = new int[] { ");
                writer.Write(string.Join(", ", item.WordCount));
                writer.WriteLine(" }");
                writer.WriteLine("            };");
                writer.WriteLine();
            }

            writer.WriteLine("    }");
            writer.WriteLine("}");

            _outputHelper.WriteLine("LanguageModel.generated.cs has been created successfully.");
        }
    }
}