using Strategy.Service.Enums;

namespace Strategy.Service.Contracts
{
    public interface IStrategyContext
    {
        public string ExecuteStrategy(EStrategyName strategy, string message);
    }

}
