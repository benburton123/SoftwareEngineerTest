using System;

namespace FizzBuzzAPI.Rules
{
    public class BuzzRule : BaseRule
    {
        private const string Buzz = "buzz";

        protected override Func<int, bool> Rule { get => (int number) => number % 5 == 0; }

        public override string Output { get => Buzz; }

        public override string Name => Buzz;
    }
}
