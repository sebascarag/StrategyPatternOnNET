using Strategy.Service.Contracts;
using Strategy.Service.Enums;

namespace Strategy.Api.Services
{
    public class StrategyContext : IStrategyContext
    {
        private readonly IEnumerable<IStrategy> _strategies;

        public StrategyContext(IEnumerable<IStrategy> strategies)
        {
            _strategies = strategies;
        }

        public string ExecuteStrategy(
            EStrategyName strategy,
            string message)
        {
            var instance = _strategies.FirstOrDefault(x => 
                                        x.Name.Equals(strategy.ToString(), StringComparison.InvariantCultureIgnoreCase));

            return instance is not null ?
                instance.Execute(message) :
                string.Empty;
        }
    }
}
