namespace Program04;

class Program()
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type some text and press Enter");
        string phrase = Console.ReadLine();

        Console.WriteLine("Please type the letter you want to count and press Enter");
        string letter = Console.ReadLine();


        int count_letters = 0;

        foreach (char i in phrase) {           
            if (i.ToString().ToLower() == letter.ToLower()) {  count_letters++; }
        }

        Console.WriteLine($"Quantidade de letras: {count_letters}");
    }
}