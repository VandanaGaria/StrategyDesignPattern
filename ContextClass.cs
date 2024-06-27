namespace strategyDesignPattern
{
    public class ContextClass
    {
        private IGreetStrategy _greetStrategy;

        public void SetStrategy(IGreetStrategy greetStrategy)
        {
            _greetStrategy = greetStrategy;
        }

        public string Greet(string name)
        {
            return _greetStrategy.Greet(name);
        }
    }
}
