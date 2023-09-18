using Strategy.Service.Contracts;
using Strategy.Service.Enums;

namespace Strategy.Service.Features
{
    public class ToLowerStrategy : IStrategy
    {
        public string Name => EStrategyName.ToLower.ToString();

        public string Execute(string message)
        {
            return message.ToLower();
        }
    }
}
