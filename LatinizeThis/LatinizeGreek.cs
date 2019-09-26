using System;
using System.Collections.Generic;
using System.Text;

namespace LatinizeThis
{
    public static class LatinizeGreek
    {
        static IReadOnlyDictionary<string, string> Letters = new Dictionary<string, string>()
        {
            { "α", "a"},
            { "β", "b" },
            { "γ", "g" },
            { "δ", "d"},
            { "ε", "e"},
            { "ζ", "z"},
            { "η", "i"},
            { "θ", "th"},
            { "ι", "i"},
            { "κ", "k"},
            { "λ", "l"},
            { "μ", "m"},
            { "ν", "n"},
            { "ξ", "ks"},
            { "ο", "o"},
            { "π", "p"},
            { "ρ", "r"},
            { "σ", "s"},
            { "τ", "t"},
            { "υ", "u"},
            { "φ", "f"},
            { "χ", "ch"},
            { "ψ", "ps"},
            { "ω", "o"},
        };

        public static string GetLatinizedChar(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                throw new ArgumentNullException(nameof(ch));

            return Letters.ContainsKey(ch)
                ? Letters[ch]
                : string.Empty;
        }


        public static string FromGreek(string text)
        {
            var latinized = string.Empty;

            foreach(var ch in text)
            {
                latinized += GetLatinizedChar(ch.ToString());
            }

            return latinized;
        }
    }
}
