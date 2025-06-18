namespace Benday.HelloWorldUtil.Api;

public class RandomNumberCommand : DotnetToolCommandBase
{
    public RandomNumberCommand(string[] args) : base(args)
    {
    }

    public override void Execute()
    {
        var random = new Random();

        var number = random.Next(1, 100);

        Console.WriteLine($"Random number: {number}");
    }
}
