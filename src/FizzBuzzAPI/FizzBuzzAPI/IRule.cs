namespace FizzBuzzAPI
{
    public interface IRule
    {
        string Name { get; }

        bool Run(int number);

        int TotalPasses { get; }

        string Output { get; }
    }
}
