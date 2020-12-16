using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodingChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //var length = 5;
            //var list = new List<KnownLetter>()
            //    {
            //        new KnownLetter{Letter='b',Position=2},
            //         new KnownLetter{Letter='z',Position=6},
            //    };
            //// assume user passes in int greater than 0 and vaild letter 
            //var words = program.FindWords(length, list);
            //Console.WriteLine(words.Count.ToString() + " Words Found");
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}

            Console.WriteLine(program.IsPalindrome("RatsLiveOnnoEvilStar"));
        }


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

        public bool IsPalindrome(string wordToTest)
        {
            var isPalindrome = true;
            try
            {
                var end = wordToTest.Length-1;
                for(var start = 0; start <  (int)Math.Floor((decimal)wordToTest.Length/2); start++)
                {
                    if(Char.ToLower(wordToTest[start]) != Char.ToLower(wordToTest[end]))
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
    }
}
