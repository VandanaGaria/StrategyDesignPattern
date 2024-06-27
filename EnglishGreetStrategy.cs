namespace strategyDesignPattern
{
    public class EnglishGreetStrategy : IGreetStrategy
    {
        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
