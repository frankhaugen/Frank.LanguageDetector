namespace Frank.LanguageDetector.Internals;

internal class ProbabilityEngine
{
    private readonly LanguageDetectionOptions _options;
    private readonly WordProbabilities _wordLanguageProbabilities;

    internal ProbabilityEngine(LanguageDetectionOptions options, WordProbabilities wordLanguageProbabilities)
    {
        _options = options;
        _wordLanguageProbabilities = wordLanguageProbabilities;
    }

    internal double[] InitializeProbabilities()
    {
        var prob = new double[LanguageModel.Count];
        for (var i = 0; i < prob.Length; i++)
        {
            prob[i] = 1.0 / LanguageModel.Count;
        }

        return prob;
    }

    internal void UpdateProbabilities(double[] prob, string word, double alpha)
    {
        if (!_wordLanguageProbabilities.ContainsKey(word))
        {
            return;
        }

        var languageProbabilities = _wordLanguageProbabilities[word];
        var weight = alpha / _options.BaseFrequency!.Value;

        for (var i = 0; i < prob.Length; i++)
        {
            var profile = LanguageModel
                .Instance
                .ElementAt(i);
            prob[i] *= weight
                       + (languageProbabilities.ContainsKey(profile)
                           ? languageProbabilities[profile]
                           : 0);
        }
    }

    internal double NormalizeProbabilities(double[] probs)
    {
        double maxp = 0, sump = 0;

        sump += probs.Sum();

        for (var i = 0; i < probs.Length; ++i)
        {
            var p = probs[i] / sump;
            if (maxp < p)
            {
                maxp = p;
            }

            probs[i] = p;
        }

        return maxp;
    }

    internal IEnumerable<LanguageResult> SortProbabilities(double[] probs)
    {
        var list = new List<LanguageResult>();

        for (var j = 0; j < probs.Length; j++)
        {
            var p = probs[j];

            if (!(p > _options.ProbabilityThreshold))
            {
                continue;
            }

            for (var i = 0; i <= list.Count; i++)
            {
                if (i != list.Count
                    && !(list[i]
                             .Probability
                         < p))
                {
                    continue;
                }

                list.Insert(i, new LanguageResult
                {
                    Language = LanguageModel
                        .Instance
                        .ElementAt(j)
                        .Language,
                    Probability = p
                });
                break;
            }
        }

        return list;
    }
}