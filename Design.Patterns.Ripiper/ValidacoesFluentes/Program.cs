public interface IValidator<T>
{
    IValidator<T> Validate(Func<T, bool> rule, string errorMessage);
    List<string> GetErrors();
    bool IsValid();
}


public class Validator<T> : IValidator<T>
{
    private readonly List<string> _errors = new List<string>();
    private readonly T _instance;

    public Validator(T instance)
    {
        _instance = instance;
    }

    public IValidator<T> Validate(Func<T, bool> rule, string errorMessage)
    {
        if (!rule(_instance))
        {
            _errors.Add(errorMessage);
        }
        return this;
    }

    public List<string> GetErrors()
    {
        return _errors;
    }

    public bool IsValid()
    {
        return !_errors.Any();
    }
}


public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        var user = new User { Name = "", Age = 17 };

        IValidator<User> validator = new Validator<User>(user)
            .Validate(u => !string.IsNullOrEmpty(u.Name), "Name cannot be empty.")
            .Validate(u => u.Age >= 18, "User must be at least 18 years old.");

        if (!validator.IsValid())
        {
            foreach (var error in validator.GetErrors())
            {
                Console.WriteLine(error);
            }
        }
        else
        {
            Console.WriteLine("User is valid.");
        }
    }
}
