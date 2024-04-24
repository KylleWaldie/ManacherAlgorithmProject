using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class ManacherAlgorithm
    {
        private static string AddSymbol(string s)
        {
            string processedString = "";
            foreach (char c in s)
            {
                processedString += "#" + c;
            }
            processedString += "#";
            return processedString;
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            int start = 0;
            int end = -1;

            string processedString = AddSymbol(s);

            int[] stringLength = new int[processedString.Length];

            int center = 0;
            int right = 0;

            for (int i = 0; i < processedString.Length; i++)
            {
                if (i <= right)
                {
                    int mirror = 2 * center - i;
                    stringLength[i] = Math.Min(right - i, stringLength[mirror]);
                }

                int leftSide = i - (stringLength[i] + 1);
                int rightSide = i + (stringLength[i] + 1);

                while (leftSide >= 0 && rightSide < processedString.Length && processedString[leftSide] == processedString[rightSide])
                {
                    stringLength[i]++;
                    leftSide--;
                    rightSide++;
                }

                if (i + stringLength[i] > right)
                {
                    center = i;
                    right = i + stringLength[i];
                }

                if (stringLength[i] > end - start)
                {
                    start = i - stringLength[i];
                    end = i + stringLength[i];
                }
            }

            string longestPalindrome = "";
            for (int i = start + 1; i < end; i += 2)
            {
                longestPalindrome += processedString[i];
            }

            return longestPalindrome;
        }
    }
}
