using System;

namespace FizzBuzzAPI.Rules
{
    public abstract class BaseRule : IRule
    {
        public int TotalPasses { get; private set; }

        public abstract string Name { get; }
        public abstract string Output { get; }

        protected abstract Func<int, bool> Rule { get; }

        public bool Run(int number)
        {
            var passed = Rule(number);

            if (passed) TotalPasses++;

            return passed;
        }
    }
}
