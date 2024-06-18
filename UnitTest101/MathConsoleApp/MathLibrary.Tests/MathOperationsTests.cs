using NUnit.Framework;
using MathLibrary;

namespace MathLibrary.Tests
{
    [TestFixture]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [SetUp]
        public void Setup()
        {
            _mathOperations = new MathOperations();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            var result = _mathOperations.Add(2, 3);

            Assert.AreEqual(5, result);
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, -3)]
        [TestCase(-1, 1, 0)]
        [TestCase(100, 200, 300)]
        [TestCase(0, 0, 0)]
        public void Add_WhenCalled_ReturnsSumOfArguments2(int a, int b, int expected)
        {
            var result = _mathOperations.Add(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}
