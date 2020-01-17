using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Cli.Commands
{
    public class DelegateCommand : CommandBase
    {
        private readonly Func<CancellationToken, Task<int>> _onRunAsync;

        public DelegateCommand(string name, string description, Func<CancellationToken, Task<int>> onRunAsync) : base(name, description)
        {
            _onRunAsync = onRunAsync;
        }

        protected sealed override async Task<int> RunAsync(CancellationToken token) => await _onRunAsync(token);
    }
}