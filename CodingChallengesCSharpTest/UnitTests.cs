using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CodingChallenges;

namespace CodingChallengesTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FindWordsTest1()
        {
            var program = new Program();
            var words = program.FindWords(3, new List<KnownLetter>()
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
            var program = new Program();
            var words = program.FindWords(5, new List<KnownLetter>()
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
            var program = new Program();
            var wordToTest = "Test";
            var isPalindrome = program.IsPalindrome(wordToTest);

            Assert.IsFalse(isPalindrome);
        }
        [TestMethod]
        public void IsPalindromeTest2()
        {
            var program = new Program();
            var wordToTest = "Racecar";
            var isPalindrome = program.IsPalindrome(wordToTest);

            Assert.IsTrue(isPalindrome);
        }
        [TestMethod]
        public void IsPalindromeTest3()
        {
            var program = new Program();
            var wordToTest = "RatsLiveOnNoEvilStar";
            var isPalindrome = program.IsPalindrome(wordToTest);

            Assert.IsTrue(isPalindrome);
        }
        [TestMethod]
        public void RemoveDuplicatesTest1()
        {
            var program = new Program();
            var list = new List<int>()
            {
                1,2,3,4,5,6,7
            };
            var expected = new List<int>()
            {
                1,2,3,4,5,6,7
            };

            var actual = program.RemoveDuplicates(list);
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void RemoveDuplicatesTest2()
        {
            var program = new Program();
            var list = new List<int>()
            {
                1,2,4,4,4,2,6,4,10,32
            };
            var expected = new List<int>()
            {
                1,2,4,6,10,32
            };

            var actual = program.RemoveDuplicates(list);
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void IsAnagramTest1()
        {
            var program = new Program();
            var word1 = "binary";
            var word2 = "brainy";
            var result = program.IsAnagram(word1, word2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsAnagramTest2()
        {
            var program = new Program();
            var word1 = "binAry";
            var word2 = "bRaIny";
            var result = program.IsAnagram(word1,word2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsAnagramTest3()
        {
            var program = new Program();
            var word1 = "binery";
            var word2 = "braIny";
            var result = program.IsAnagram(word1, word2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsAnagramTest4()
        {
            var program = new Program();
            var word1 = "Test";
            var word2 = "Testp";
            var result = program.IsAnagram(word1, word2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsAnagramTest5()
        {
            var program = new Program();
            var word1 = "meteor";
            var word2 = "remote";
            var result = program.IsAnagram(word1, word2);
            Assert.IsTrue(result);
        }
        //
        [TestMethod]
        public void SquareRootofIntegerTest1()
        {
            var program = new Program();
            var num = 14;
            var result = program.SquareRootofInteger(num);
            var actual = 3;
            Assert.AreEqual(result,actual);
        }
        [TestMethod]
        public void SquareRootofIntegerTest2()
        {
            var program = new Program();
            var num = 100;
            var result = program.SquareRootofInteger(num);
            var actual = 10;
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void SquareRootofIntegerTest3()
        {
            var program = new Program();
            var num = 999;
            var result = program.SquareRootofInteger(num);
            var actual = 31;
            Assert.AreEqual(result, actual);
        }
    }
}
