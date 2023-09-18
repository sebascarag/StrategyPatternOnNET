using Strategy.Service.Contracts;
using Strategy.Service.Enums;

namespace Strategy.Service.Features
{
    public class ToUpperStrategy : IStrategy
    {
        public string Name => EStrategyName.ToUpper.ToString();

        public string Execute(string message)
        {
            return message.ToUpper();
        }
    }
}
