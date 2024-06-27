using strategyDesignPattern;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ContextClass>();

var app = builder.Build();

app.MapGet("/", (ContextClass greeter) =>
{
    var englishStrategy = new EnglishGreetStrategy();
    var spanishStrategy = new SpanishGreetStrategy();

    greeter.SetStrategy(englishStrategy);
    var englishGreeting = greeter.Greet("VG");

    greeter.SetStrategy(spanishStrategy);
    var spanishGreeting = greeter.Greet("VG");

    return englishGreeting +"\n"+ spanishGreeting;
});

app.Run();
