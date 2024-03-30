namespace Program01;


class Program()
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type your name and press Enter");
        string Name = Console.ReadLine();

        Console.WriteLine("Now, please type your last name and press Enter");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Olá, {Name} {LastName}! Seja muito bem-vindo!");
    }
}