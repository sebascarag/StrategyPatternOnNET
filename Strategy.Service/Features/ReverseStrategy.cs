using Strategy.Service.Contracts;
using Strategy.Service.Enums;

namespace Strategy.Service.Features
{
    public class ReverseStrategy : IStrategy
    {
        public string Name => EStrategyName.Reverse.ToString();

        public string Execute(string message)
        {
            var charArray = message.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
