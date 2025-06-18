using Benday.HelloWorldUtil.Api;
using System.Diagnostics;
using System.Text;

if (args.Length == 0)
{
    DisplayUsage();
    return;
}
else
{
    var commandName = args[0].ToLowerInvariant();

    IDotnetToolCommand command;

    if (commandName == "hello")
    {
        command = new HelloWorldCommand(args);

        command.Execute();
    }
    else if (commandName == "random")
    {
        command = new RandomNumberCommand(args);

        command.Execute();
    }
    else if (commandName == "now")
    {
        command = new CurrentDateTimeCommand(args);

        command.Execute();
    }
    else
    {
        Console.WriteLine($"Unknown command: {commandName}");
        DisplayUsage();
        return;
    }
}

void DisplayUsage()
{
    var appExeName = "helloworldutil";

    var builder = new StringBuilder();

    builder.AppendLine("Hello World Util");
    builder.AppendLine("by Benjamin Day");
    builder.AppendLine("https://www.benday.com");

    builder.AppendLine();

    builder.AppendLine("Usage:");
    builder.AppendLine($"  {appExeName} <command-name> ...");
    builder.AppendLine();

    builder.AppendLine("Commands:");
    builder.AppendLine("  hello  - Displays a greeting for the specified name(s)");
    builder.AppendLine("  random - Displays a random number");
    builder.AppendLine("  now    - Displays the current time");

    builder.AppendLine();

    Console.WriteLine(builder.ToString());
}