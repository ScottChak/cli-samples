using McMaster.Extensions.CommandLineUtils;
using System.Threading.Tasks;
using Sample.Cli.Commands;

namespace Sample.Cli
{
    public class CommandLineInterface
    {
        private readonly CommandLineApplication _app;

        public CommandLineInterface(string name, string description, params ICommand[] commands)
        {
            _app = new CommandLineApplication
            {
                Name = name,
                Description = description
            };

            _app.HelpOption("-?|-h|--help");

            foreach (var command in commands)
            {
                command.RegisterTo(_app);
            }
        }

        public async Task RunAsync(string[] args)
        {
            await _app.ExecuteAsync(args);
        }
    }
}