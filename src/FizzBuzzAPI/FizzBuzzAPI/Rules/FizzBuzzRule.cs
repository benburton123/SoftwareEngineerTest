using System;

namespace FizzBuzzAPI.Rules
{
    public class FizzBuzzRule : BaseRule
    {
        private const string FizzBuzz = "fizzbuzz";

        protected override Func<int, bool> Rule { get => (int number) => number % 3 == 0 && number % 5 == 0; }

        public override string Output { get => FizzBuzz; }

        public override string Name => FizzBuzz;
    }
}
