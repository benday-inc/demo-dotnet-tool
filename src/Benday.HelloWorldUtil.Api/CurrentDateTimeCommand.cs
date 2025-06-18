namespace Benday.HelloWorldUtil.Api;

public class CurrentDateTimeCommand : DotnetToolCommandBase
{
    public CurrentDateTimeCommand(string[] args) : base(args)
    {
    }

    public override void Execute()
    {
        Console.WriteLine($"{DateTime.Now}");
    }
}
