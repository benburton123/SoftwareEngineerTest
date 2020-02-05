using FizzBuzzAPI.Rules;
using NUnit.Framework;

namespace FizzBuzzAPI.Tests
{
    [TestFixture]
    public class IntegerRuleTests
    {
        private IRule _rule;

        private bool _result1;
        private bool _result2;
        private bool _result3;
        private int _passes;

        [OneTimeSetUp]
        public void WhenRunIsCalledMultipleTimes()
        {
            _rule = new IntegerRule();

            _result1 = _rule.Run(1);

            _result2 = _rule.Run(3);

            _result3 = _rule.Run(2);

            _passes = _rule.TotalPasses;
        }

        [Test]
        public void ThenTheFirstResultIsPass()
        {
            Assert.That(_result1, Is.True);
        }

        [Test]
        public void ThenTheSecondResultIsFail()
        {
            Assert.That(_result2, Is.False);
        }

        [Test]
        public void ThenTheThirdResultIsPass()
        {
            Assert.That(_result3, Is.True);
        }

        [Test]
        public void ThenPassesIsCorrectNumber()
        {
            Assert.That(_passes, Is.EqualTo(2));
        }

        [Test]
        public void ThenTheOutputIsSetToTheLastOutput()
        {
            Assert.That(_rule.Output, Is.EqualTo("2"));
        }

        [Test]
        public void ThenTheNameIsCorrect()
        {
            Assert.That(_rule.Name, Is.EqualTo("integer"));
        }
    }
}