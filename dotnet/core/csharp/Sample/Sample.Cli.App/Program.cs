using Sample.Cli.Commands;
using System;
using System.Threading.Tasks;

namespace Sample.Cli.App
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var helloWorldCommand = new DelegateCommand(
                "hello-world",
                "Output \"Hello World !\"",
                async c =>
                {
                    Console.WriteLine("Hello World !");
                    return 0;
                });

            var app = new CommandLineInterface("sample-cli", "Sample CLI", helloWorldCommand);
            await app.RunAsync(args);
        }
    }
}