internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Enter some text:");
        string? a = Console.ReadLine();
        if (string.IsNullOrEmpty(a))
        {
            Console.WriteLine("EWQRQWERWQERQWE");
        }
    }
}