using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.LongestPalindromicSubstring
{
    public class LongestPalindromicSubstSolution
    {
        public string LongestPalindrome(string s)
        {
            //Separarlo en letras ordenadas
            //Recorrer todas las letras
            string maxPalindromeString = "";
            for (int i = 0; i <= s.Length; i++)
            {
                //Recorrer todas las letras que vienen despues
                for (int j = 0; j <= s.Length - i; j++)
                {
                    //Para cada una fijarme si es capicua desde la primera
                    char[] currWord = s.Substring(i, j).ToCharArray();
                    if (IsPalindrome(currWord))
                    {
                        // Si es capicua y mas grande que la palabra capicua que ya tenia de antes guardo
                        maxPalindromeString = maxPalindromeString.Length > currWord.Length ? maxPalindromeString : new string(currWord);
                    }
                }
            }
            return maxPalindromeString;
        }
        public bool IsPalindrome(char[] word)
        {
            if (word.Length < 2)
            {
                return true;
            }
            int halfSize = word.Length / 2;
            char[] firstHalf = new char[halfSize];
            char[] secondHalfReversed = new char[halfSize];

            Array.Copy(word, 0, firstHalf, 0, halfSize);
            int additionalForOdd = 0;
            if (word.Length % 2 != 0)
            {
                additionalForOdd++;
            }
            Array.Copy(word, halfSize + additionalForOdd, secondHalfReversed, 0, halfSize);
            secondHalfReversed = secondHalfReversed.Reverse().ToArray();

            if (firstHalf.SequenceEqual(secondHalfReversed))
            {
                return true;
            }
            return false;
        }

        public string LongestPalindrome2(string word)
        {
            int maxPalBeg = 0;
            int maxPalEnd = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var evenPalindromeRes = CheckPalLimits(word, i, i);
                if (maxPalEnd - maxPalBeg < evenPalindromeRes.end - evenPalindromeRes.beginning)
                {
                    (maxPalBeg, maxPalEnd) = evenPalindromeRes;
                }
                var oddPalindromeRes = CheckPalLimits(word, i, i + 1);
                if(maxPalEnd - maxPalBeg < oddPalindromeRes.end - oddPalindromeRes.beginning)
                {
                    (maxPalBeg, maxPalEnd) = oddPalindromeRes;
                }
            }
            string res = word[maxPalBeg..maxPalEnd];
            return res;
        }

        private static (int beginning, int end) CheckPalLimits(string word,int beginning, int end)
        {

            while (beginning >= 0 && end < word.Length)
            {
                if (word[beginning] == word[end])
                {
                    beginning--;
                    end++;
                }
                else
                {
                    return (beginning + 1, end);
                }
            }
            return (beginning + 1, end);
        }
    }
}
