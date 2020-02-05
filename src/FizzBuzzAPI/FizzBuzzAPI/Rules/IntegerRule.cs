using System;

namespace FizzBuzzAPI.Rules
{
    public class IntegerRule : BaseRule
    {
        private string _number;

        protected override Func<int, bool> Rule { get => (int number) =>
        {
            _number = number.ToString();

            return number % 3 != 0 && number % 5 != 0;
        }; }

        public override string Output { get => _number; }

        public override string Name => "integer";
    }
}
