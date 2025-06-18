namespace Benday.HelloWorldUtil.Api;

public class HelloWorldCommand : DotnetToolCommandBase
{
    public HelloWorldCommand(string[] args) : base(args)
    {
    }

    public override void Execute()
    {
        if (Args.Length == 0)
        {
            Console.WriteLine($"Hello, {string.Join(" ", Args)}!");            
        }
        else
        {
            Console.WriteLine($"Hello, {string.Join(" ", Args[0])}");
        }
    }
}
