using System;

namespace FizzBuzzAPI.Rules
{
    public class FizzRule : BaseRule
    {
        private const string Fizz = "fizz";

        protected override Func<int, bool> Rule { get => (int number) => number % 3 == 0; }

        public override string Output { get => Fizz; }

        public override string Name => Fizz;
    }
}
