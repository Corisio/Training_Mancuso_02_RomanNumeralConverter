using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralConverter
{
    internal class RomanNumeralsConverter
    {
        private readonly IDictionary<int, string> equivalences = new Dictionary<int, string>()
        {
            {1, "I" },
            {5, "V" },
            {10, "X" },
            {50, "L" },
            {100, "C" },
            {500, "D" },
            {1000, "M" }
        };
        private readonly IDictionary<int, int> _specialCaseForEquivalence = new Dictionary<int, int>()
        {
            {5, 1 },
            {10, 1 },
            {50, 10 },
            {100, 10 },
            {500, 100 },
            {1000, 100 }
        };

        public string Convert(int valueToConvert)
        {
            var result = new StringBuilder();

            var arabicValues = equivalences.OrderByDescending(pair => pair.Key).Select(pair => pair.Key).ToArray();

            for (var index = 0; index < arabicValues.Count(); index++)
            {
                var currentArabicValue = arabicValues[index];
                while (valueToConvert >= currentArabicValue)
                {
                    result.Append(equivalences[currentArabicValue]);
                    valueToConvert -= currentArabicValue;
                }

                if (currentArabicValue != 1 && valueToConvert > 0)
                {
                    valueToConvert = ProcessPossibleCornerCase(valueToConvert, currentArabicValue, result);
                }
            }
            return result.ToString();
        }

        private int ProcessPossibleCornerCase(int valueToConvert, int currentArabicValue, StringBuilder result)
        {
            var specialCaseValue = _specialCaseForEquivalence[currentArabicValue];

            if (valueToConvert < currentArabicValue - specialCaseValue)
            {
                return valueToConvert;
            }

            result.Append(equivalences[specialCaseValue]);
            result.Append(equivalences[currentArabicValue]);
            valueToConvert -= currentArabicValue - specialCaseValue;

            return valueToConvert;
        }
    }
}