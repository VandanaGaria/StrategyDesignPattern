namespace strategyDesignPattern
{
    public class SpanishGreetStrategy : IGreetStrategy
    {
        public string Greet(string name)
        {
            return $"Hola,{name}!";
        }
    }
}
