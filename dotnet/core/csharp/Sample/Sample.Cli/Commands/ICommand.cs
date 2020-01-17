using McMaster.Extensions.CommandLineUtils;

namespace Sample.Cli.Commands
{
    public interface ICommand
    {
        void RegisterTo(CommandLineApplication app);
    }
}