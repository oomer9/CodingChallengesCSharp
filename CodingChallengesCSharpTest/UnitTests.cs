using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CodingChallenges;
using CodingChallengesCSharp;

namespace CodingChallengesTest
{
    [TestClass]
    public class UnitTests
    {
        private readonly ICodingChallenges _codingChallenges;

        public  UnitTests()
        {
            _codingChallenges = new CodingChallengesCSharp.CodingChallenges();
        }
        [TestMethod]
        public void FindWordsTest1()
        {
            
            var words = _codingChallenges.FindWords(3, new List<KnownLetter>()
            {
                new KnownLetter()
                {
                    Letter='a',
                    Position=2
                }
            });
            var expected = new List<string>()
            {
                "AAH","AAL","AAS","BAA","BAD","BAG","BAH","BAL","BAM","BAN","BAP","BAR","BAS","BAT","BAY","CAB","CAD","CAM","CAN","CAP","CAR","CAT","CAW","CAY","DAB","DAD","DAG","DAH","DAK","DAL","DAM","DAP","DAW","DAY","EAR","EAT","EAU","FAD","FAG","FAN","FAR","FAS","FAT","FAX","FAY","GAB","GAD","GAE","GAG","GAL","GAM","GAN","GAP","GAR","GAS","GAT","GAY","HAD","HAE","HAG","HAH","HAJ","HAM","HAO","HAP","HAS","HAT","HAW","HAY","JAB","JAG","JAM","JAR","JAW","JAY","KAB","KAE","KAF","KAS","KAT","KAY","LAB","LAC","LAD","LAG","LAM","LAP","LAR","LAS","LAT","LAV","LAW","LAX","LAY","MAC","MAD","MAE","MAG","MAN","MAP","MAR","MAS","MAT","MAW","MAX","MAY","NAB","NAE","NAG","NAH","NAM","NAN","NAP","NAW","NAY","OAF","OAK","OAR","OAT","PAC","PAD","PAH","PAL","PAM","PAN","PAP","PAR","PAS","PAT","PAW","PAX","PAY","QAT","RAD","RAG","RAH","RAJ","RAM","RAN","RAP","RAS","RAT","RAW","RAX","RAY","SAB","SAC","SAD","SAE","SAG","SAL","SAP","SAT","SAU","SAW","SAX","SAY","TAB","TAD","TAE","TAG","TAJ","TAM","TAN","TAO","TAP","TAR","TAS","TAT","TAU","TAV","TAW","TAX","VAC","VAN","VAR","VAS","VAT","VAU","VAV","VAW","WAB","WAD","WAE","WAG","WAN","WAP","WAR","WAS","WAT","WAW","WAX","WAY","YAH","YAK","YAM","YAP","YAR","YAW","YAY","ZAG","ZAP","ZAX"
            };
            CollectionAssert.AreEqual(words, expected);
        }
        [TestMethod]
        public void FindWordsTest2()
        {
            
            var words = _codingChallenges.FindWords(5, new List<KnownLetter>()
            {
                    new KnownLetter{Letter='b',Position=2},
                    new KnownLetter{Letter='z',Position=5},
            });
            var expected = new List<string>()
            {
                "ABUZZ"
            };
            CollectionAssert.AreEqual(words, expected);
        }
        [TestMethod]
        public void IsPalindromeTest1()
        {
            
            var wordToTest = "Test";
            var isPalindrome = _codingChallenges.IsPalindrome(wordToTest);

            Assert.IsFalse(isPalindrome);
        }
        [TestMethod]
        public void IsPalindromeTest2()
        {
            
            var wordToTest = "Racecar";
            var isPalindrome = _codingChallenges.IsPalindrome(wordToTest);

            Assert.IsTrue(isPalindrome);
        }
        [TestMethod]
        public void IsPalindromeTest3()
        {
            
            var wordToTest = "RatsLiveOnNoEvilStar";
            var isPalindrome = _codingChallenges.IsPalindrome(wordToTest);

            Assert.IsTrue(isPalindrome);
        }
        [TestMethod]
        public void RemoveDuplicatesTest1()
        {
            
            var list = new List<int>()
            {
                1,2,3,4,5,6,7
            };
            var expected = new List<int>()
            {
                1,2,3,4,5,6,7
            };

            var actual = _codingChallenges.RemoveDuplicates(list);
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void RemoveDuplicatesTest2()
        {
            
            var list = new List<int>()
            {
                1,2,4,4,4,2,6,4,10,32
            };
            var expected = new List<int>()
            {
                1,2,4,6,10,32
            };

            var actual = _codingChallenges.RemoveDuplicates(list);
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void IsAnagramTest1()
        {
            
            var word1 = "binary";
            var word2 = "brainy";
            var result = _codingChallenges.IsAnagram(word1, word2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsAnagramTest2()
        {
            
            var word1 = "binAry";
            var word2 = "bRaIny";
            var result = _codingChallenges.IsAnagram(word1,word2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsAnagramTest3()
        {
            
            var word1 = "binery";
            var word2 = "braIny";
            var result = _codingChallenges.IsAnagram(word1, word2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsAnagramTest4()
        {
            
            var word1 = "Test";
            var word2 = "Testp";
            var result = _codingChallenges.IsAnagram(word1, word2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsAnagramTest5()
        {
            
            var word1 = "meteor";
            var word2 = "remote";
            var result = _codingChallenges.IsAnagram(word1, word2);
            Assert.IsTrue(result);
        }
        //
        [TestMethod]
        public void SquareRootofIntegerTest1()
        {
            
            var num = 14;
            var result = _codingChallenges.SquareRootofInteger(num);
            var expected = 3;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void SquareRootofIntegerTest2()
        {
            
            var num = 100;
            var result = _codingChallenges.SquareRootofInteger(num);
            var expected = 10;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void SquareRootofIntegerTest3()
        {
            
            var num = 999;
            var result = _codingChallenges.SquareRootofInteger(num);
            var expected = 31;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void RotateMatrixTest1()
        {
            
            int[,] array2Da = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            var actual = _codingChallenges.RotateMatrix(array2Da);
            int[,] expected = new int[,] { { 7, 5, 3, 1 }, { 8, 6, 4, 2} };
           CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RotateMatrixTest2()
        {
            
            int[,] array2Da = new int[,] { { 1, 2 ,3}, {  4, 5, 6  }, { 7, 8, 9}, { 10, 11, 12} };
            var actual = _codingChallenges.RotateMatrix(array2Da);
            int[,] expected = new int[,] { { 10, 7, 4, 1 }, { 11, 8, 5, 2 },{12, 9, 6, 3 } };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RotateMatrixTest3()
        {
            
            int[,] array2Da = new int[,] { { 1, 2, 3, 4, 5, 6 },};
            var actual = _codingChallenges.RotateMatrix(array2Da);
            int[,] expected = new int[,] { { 1 }, { 2 }, { 3 },{ 4},{5 },{ 6} };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MedianOfTwoArraysTest1()
        {
            
            int[] list1 = new int[] { 1, 2};
            int[] list2 = new int[] { 3,4,5 };
            double actual = _codingChallenges.MedianOfTwoArrays(list1,list2);
            double expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MedianOfTwoArraysTest2()
        {
            
            int[] list1 = new int[] { 1, 2 };
            int[] list2 = new int[] { 3, 4 };
            double actual = _codingChallenges.MedianOfTwoArrays(list1, list2);
            double expected = 2.5;
            Assert.AreEqual(expected, actual);
        }
    }
}
