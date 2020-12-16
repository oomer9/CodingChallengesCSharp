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
            var porgram = new Program();
            var wordToTest = "Test";
            var isPalindrome = porgram.IsPalindrome(wordToTest);

            Assert.IsFalse(isPalindrome);
        }
        [TestMethod]
        public void IsPalindromeTest2()
        {
            var porgram = new Program();
            var wordToTest = "Racecar";
            var isPalindrome = porgram.IsPalindrome(wordToTest);

            Assert.IsTrue(isPalindrome);
        }
        [TestMethod]
        public void IsPalindromeTest3()
        {
            var porgram = new Program();
            var wordToTest = "RatsLiveOnNoEvilStar";
            var isPalindrome = porgram.IsPalindrome(wordToTest);

            Assert.IsTrue(isPalindrome);
        }
    }
}
