using CodingChallenges;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesCSharp
{
    public interface ICodingChallenges
    {
        List<string> FindWords(int length, List<KnownLetter> KnownLetters);
        bool IsPalindrome(string wordToTest);
        List<int> RemoveDuplicates(List<int> list);
        bool IsAnagram(string word1, string word2);
        int SquareRootofInteger(int number);
        int[,] RotateMatrix(int[,] matrix);
        double MedianOfTwoArrays(int[] list1, int[] list2);
    }
}
