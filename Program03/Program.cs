using System.Text;

namespace Program01;

class Program()
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type a valid number press Enter");
        double Num1 = Convert.ToDouble((Console.ReadLine()));

        Console.WriteLine("Please type a second valid number press Enter");
        double Num2 = Convert.ToDouble((Console.ReadLine()));


        Console.WriteLine($"Sum: + {(Num1 + Num2)}");
        Console.WriteLine($"Subtract: + {(Num1 - Num2)}");
        Console.WriteLine($"Multiply: + {(Num1 * Num2)}");
        
        StringBuilder sb = new StringBuilder("Divide: ");
        sb.Append((Num1 / Num2));
        Console.WriteLine(sb.ToString());

        Console.WriteLine($"Average: + {((Num1 + Num2)/2)}");
    }
}