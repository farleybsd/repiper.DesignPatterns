namespace Design.Patterns.Singleton.BAD;

public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}