namespace Strategy.Service.Contracts
{
    public interface IStrategy
    {
        string Name { get; }
        string Execute(string message);
    }
}
