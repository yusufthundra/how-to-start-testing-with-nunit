using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToStartTestingWithNUnit.Tests
{
    [TestFixture]
    public class MathUtilsTests
    {
        // First version
        //[Test]
        //public void CalculateFibonacciNumberShouldReturnCorrectValue()
        //{
        //    // Arrage
        //    var numberIndex = 6;
        //    var expected = 8;

        //    // Act
        //    var actual = MathUtils.CalculateFibonacciNumber(numberIndex);

        //    // Assert
        //    Assert.That(actual, Is.EqualTo(expected));
        //}


        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(6, 8)]
        [TestCase(19, 4181)]
        public void CalculateFibonacciNumberShouldReturnCorrectValue(int numberIndex, int expected)
        {
            // Arrage
            // We only need parameters

            // Act
            var actual = MathUtils.CalculateFibonacciNumber(numberIndex);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CalculateFibonacciNumberShouldTrowArgumentExceptionForNegativeArgument()
        {
            // Arrage
            var numberIndex = -1;

            // Act
            TestDelegate actual = () => MathUtils.CalculateFibonacciNumber(numberIndex);

            // Assert
            Assert.That(actual, Throws.ArgumentException);
        }

        //[Test]
        //public void GetFibonacciSequenceShouldReturnCorrectSequence()
        //{
        //    // Arrage
        //    var expected = new List<int> { 0, 1, 1, 2 };

        //    // Act
        //    var actual = MathUtils.GetFibonacciSequence(3);

        //    // Assert
        //    CollectionAssert.AreEqual(expected, actual);
        //}

        [TestCaseSource(nameof(_getFibonacciSequenceShouldReturnCorrectSequenceData))]
        public void GetFibonacciSequenceShouldReturnCorrectSequence(int indexNumber, List<int> expected)
        {
            // Arrage

            // Act
            var actual = MathUtils.GetFibonacciSequence(indexNumber);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        static object[] _getFibonacciSequenceShouldReturnCorrectSequenceData =
        {
            new object[] { 0, new List<int> { 0 } },
            new object[] { 1, new List<int> { 0, 1 } },
            new object[] { 2, new List<int> { 0, 1, 1 } },
            new object[] { 3, new List<int> { 0, 1, 1, 2 } }
        };
    }
}
