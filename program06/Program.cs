using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program05;

class Program()
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please choice the way you want to see the actual time and press Enter:");
        Console.WriteLine("1 - Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2 - Apenas a data no formato \'01/03/2024\'.");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4 - A data com o mês por extenso.");        
        
        Console.Write("Your option: ");
        int UserChoice = Convert.ToUInt16(Console.ReadLine());


        //DateTime day = new DateTime(2024,03,30,18,25,54);
        DateTime actual_day = DateTime.UtcNow;
        switch (UserChoice)
        {
            case 1:
                Console.WriteLine(actual_day.ToString("R",new CultureInfo("pt-BR")));
                break;
            case 2:
                Console.WriteLine(actual_day.ToString("d",new CultureInfo("pt-BR")));
                break;
            case 3:
                Console.WriteLine(actual_day.ToString("HH",new CultureInfo("pt-BR")));
                break;
            case 4:
                Console.WriteLine(actual_day.ToString("D",new CultureInfo("pt-BR")));        
                break;
            default:
                Console.WriteLine("No option identified!");        
                break;
        }

    }
}