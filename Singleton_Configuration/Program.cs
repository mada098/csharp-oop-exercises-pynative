public class Program
{
    public static void Main()
    {
        ConfigurationManager a = ConfigurationManager.GetInstance();
        ConfigurationManager b = ConfigurationManager.GetInstance();

        Console.WriteLine($"Same instance: {ReferenceEquals(a, b)}");
    }
}