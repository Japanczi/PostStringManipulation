using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PostStringManipulation
{
    public static class StringHelpers
    {
        static StringHelpers()
        {

        }

        public static string ReplaceTextWithPattern(string input, string pattern)
        {
            Regex rx = new Regex(pattern + regexSeparator);
            MatchCollection matchCollection = rx.Matches(input);
            if (matchCollection.Count == 0)
                return string.Empty;

            int firstMatchIndex = matchCollection[0].Index;
            input = RemoveMatchedStringFromInput(input, matchCollection);

            return BuildFinalString(input, firstMatchIndex);
        }

        public static string BuildFinalString(string input, int firstMatchIndex)
        {
            int incrementChange = startOn;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < repeatValue; i++)
            {
                string stringToAppend = $"${{yyyy, -{incrementChange}, M}}";
                sb.Append(stringToAppend);

                if (i < repeatValue - 1)
                    sb.Append(",");

                incrementChange += incrementValue;
            }

            return input.Insert(firstMatchIndex, sb.ToString());
        }

        public static string RemoveMatchedStringFromInput(string temporaryText, MatchCollection matchCollection)
        {
            foreach (Match currentMatch in matchCollection)
            {
                temporaryText = Regex.Replace(temporaryText, currentMatch.Value, string.Empty);
            }

            return temporaryText;
        }

        public const string regexSeparator = ",?";
        public static int startOn;
        public static int incrementValue;
        public static int repeatValue;
    }
}
