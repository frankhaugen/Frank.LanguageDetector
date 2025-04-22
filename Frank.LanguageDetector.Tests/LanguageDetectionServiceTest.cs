using FluentAssertions;

namespace Frank.LanguageDetector.Tests
{
    public class LanguageDetectionServiceTest
    {
        [Fact]
        public void Is_ShouldReturnFalse_WhenNoLanguageDetected()
        {
            var options = new LanguageDetectionOptions
            {
                NGramLength = 3,
                Timeout = TimeSpan.FromSeconds(2)
            };
            var sut = new LanguageDetectionService(options);

            // Act
            Assert.Throws<TimeoutException>(() => sut.Is(Language.ENG, "InvalidTextForLanguageDetection"));
        }
        
        [Fact]
        public void Detect_ShouldReturnNull_WhenNoLanguageDetected()
        {
            var options = new LanguageDetectionOptions
            {
                NGramLength = 3,
                Timeout = TimeSpan.FromSeconds(2)
            };
            var sut = new LanguageDetectionService(options);

            // Act
            var result = sut.Detect("Valid text and language");
            
            // Assert
            result.Should().BeNull();
        }

    }
}