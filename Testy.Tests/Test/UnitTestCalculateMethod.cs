using System;
using Testy.Methods;
using NUnit.Framework;
using Moq;

namespace Testy.Tests
{
    public class UnitTestCalculateMethod
    {
        [Test]
        public void SumScoreTest()
        {
            Assert.AreEqual(4, Calculate.SumScore(2, 2));
        }

        [Test]
        public void SumScoreTestWithFirstDigitIsNull()
        {
            Assert.That(() => Calculate.SumScore(null, 2), Throws.ArgumentNullException);
        }
  
        [Test]
        public void SumScoreTestWithTheSecendDigitIsNull()
        {
            Assert.That(() => Calculate.SumScore(4, null), Throws.ArgumentNullException);
        }

        [Test]
        public void SumScoreTestWithTheBothDigitAreNull()
        {
            Assert.That(() => Calculate.SumScore(null, null), Throws.ArgumentNullException);
        }


    }
}
