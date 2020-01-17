using McMaster.Extensions.CommandLineUtils;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Cli.Commands
{
    public abstract class CommandBase : ICommand
    {
        private readonly string _name;
        private readonly string _description;

        protected CommandBase(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void RegisterTo(CommandLineApplication app)
        {
            app.Command(
                _name,
                c =>
                {
                    c.Description = _description;

                    c.HelpOption();

                    c.OnExecuteAsync(RunAsync);
                });
        }

        protected abstract Task<int> RunAsync(CancellationToken token);
    }
}