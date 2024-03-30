using System.Text.RegularExpressions;

namespace Program05;

class Program()
{
    static void Main(string[] args)
    {
        bool b_IsValid = true;


        Console.WriteLine("Please write the car plate and press Enter");
        string plate = Console.ReadLine();
        for (int i = 0; i < 7; i++)
        {
            if (plate.Length != 7)
            {
                b_IsValid = false; break;
            }
            else if (i < 3 & !Regex.IsMatch(plate[i].ToString(), @"^[a-zA-Z]+$"))
            {
                b_IsValid = false; break;
            }
            else if (i >= 3 & !Regex.IsMatch(plate[i].ToString(), @"^[0-9]+$"))
            {
                b_IsValid = false; break;
            }
        }


        string status = b_IsValid ? "valid" : "invalid";
        Console.WriteLine($"The plate '{plate}' is {status}");
        
    }
}