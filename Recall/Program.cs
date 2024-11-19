using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Recall;

public class Program
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(100, 30);
        Display();
        Console.ReadLine();
    }

    private static void Display()
    {
        var now = DateTime.UtcNow.ToString("MM/dd/yyy");
        Console.WriteLine($"                         Welcome to RECALL    --daily reminder-- {now}");
        Console.WriteLine("                         ==================================================");
        Console.WriteLine();
        Console.WriteLine("You have [0] reminders today");
        Console.WriteLine();
    }
}
