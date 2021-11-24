using CodingChallenges;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodingChallengesCSharp
{
    public class CodingChallenges : ICodingChallenges
    {
        //this method should return all words in the dictionary(english.csv) that are the correct 
        //length and that contain those letters at those positions that the user passes in
        public List<string> FindWords(int length, List<KnownLetter> KnownLetters)
        {
            List<string> list = new List<string>();
            try
            {
                using (var reader = new StreamReader("english.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var word = reader.ReadLine();
                        // check word length
                        if (word.Length == length)
                        {
                            var isValid = false;
                            foreach (KnownLetter letter in KnownLetters)
                            {
                                // check if position is less than or equal to length, check if letter in position is in same position in Word from CSV 
                                if (letter.Position <= length && word.ToLower()[letter.Position - 1] == Char.ToLower(letter.Letter))
                                {
                                    isValid = true;
                                }
                                else
                                {
                                    // if one of letters in in wrong position then break out of loop and don't add letter
                                    isValid = false;
                                    break;
                                }
                            }
                            if (isValid)
                            {
                                list.Add(word);
                            }
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        //User passes in string and method returns true if the string is a palindrome and false if not
        public bool IsPalindrome(string wordToTest)
        {
            var isPalindrome = true;
            try
            {
                var end = wordToTest.Length - 1;
                for (var start = 0; start < (int)Math.Floor((decimal)wordToTest.Length / 2); start++)
                {
                    if (Char.ToLower(wordToTest[start]) != Char.ToLower(wordToTest[end]))
                    {
                        // if letters don't match break out fo loop and return false
                        isPalindrome = false;
                        break;
                    }
                    end--;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isPalindrome;
        }
        // remove duplicates in list of ints 
        public List<int> RemoveDuplicates(List<int> list)
        {
            var response = new List<int>();
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (!response.Any(num => num == list[i]))
                    {
                        response.Add(list[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return response;
        }
        // check if two words being passed in are anagrams 
        public bool IsAnagram(string word1, string word2)
        {
            var isAnagram = false;
            try
            {
                // add helper method to sort string 
                if (SortString(word1.ToLower()) == SortString(word2.ToLower()))
                {
                    isAnagram = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return isAnagram;
        }

        private string SortString(string str)
        {
            var listOfChars = str.ToArray();
            Array.Sort(listOfChars);
            return new string(listOfChars);
        }
        //returns the square root of an integer and if number is not a perfect square, then return floor for number 
        public int SquareRootofInteger(int number)
        {
            int squareRoot = -1;
            try
            {
                squareRoot = (int)Math.Truncate(Math.Sqrt(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return squareRoot;
        }
        //rotates matrix 90 degrees to the right 
        public int[,] RotateMatrix(int[,] matrix)
        {
            // get number rows and columns to know size of rotated matrix
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);
            int[,] returnMatrix = new int[col, row];
            try
            {
                // tempCol is used the the index of the last row becomes the index of first column
                var tempCol = row - 1;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        returnMatrix[j, tempCol] = matrix[i, j];
                    }
                    tempCol--;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return returnMatrix;
        }

        public double MedianOfTwoArrays(int[] list1, int[] list2)
        {
            try
            {
                var fullList = new int[list1.Length + list2.Length];
                Array.Copy(list1, fullList, list1.Length);
                Array.Copy(list2, 0, fullList, list1.Length, list2.Length);
                Array.Sort(fullList);
                if (fullList.Length % 2 == 0)
                {
                    var middleLow = Math.Floor(Convert.ToDecimal(fullList.Length / 2) - 1);
                    var middleHigh = Math.Ceiling(Convert.ToDecimal(fullList.Length / 2));
                    var test = fullList[Convert.ToInt32(middleLow)] + fullList[Convert.ToInt32(middleHigh)];
                    var test2 = (double)test / 2;
                    return ((double)fullList[Convert.ToInt32(middleLow)] + fullList[Convert.ToInt32(middleHigh)]) / 2;
                }
                else
                {
                    return fullList[fullList.Length / 2];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
