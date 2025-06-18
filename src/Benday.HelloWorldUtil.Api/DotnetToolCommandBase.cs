namespace Benday.HelloWorldUtil.Api;

public abstract class DotnetToolCommandBase : IDotnetToolCommand
{
    protected string[] Args { get; }

    public DotnetToolCommandBase(string[] args)
    {
        Args = args;
    }

    public abstract void Execute();
}
