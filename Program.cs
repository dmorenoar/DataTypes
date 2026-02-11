using DataTypes.Enums;
using DataTypes.Models;
using DataTypes.Records;
using DataTypes.Structs;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine(new String('*',20));
        Console.WriteLine("Enums");
        Console.WriteLine(new String('*', 20));

        /*
         Use enums like to represent a closed set of possible values.
         */

        Console.WriteLine("List Pizza Types");

        foreach (string pizza in Enum.GetNames(typeof(PizzaType)))
        {
            Console.WriteLine(pizza);
        }

        Console.WriteLine("Made a pizza: Type:Pepperoni - Size: Medium");
        Pizza pepperoni = new Pizza(PizzaType.Pepperoni, PizzaSize.Medium);

        Console.WriteLine($"How much I must pay? -> {pepperoni.Price.ToString("C")} ");

        Console.WriteLine(new String('*', 20));
        Console.WriteLine("Structs");
        Console.WriteLine(new String('*', 20));

        /*
         Use record when we need represent little data without identity
         Inmutable
         */

        PlayerStats playerStats = new PlayerStats(23,200);

        Console.WriteLine($"Data Player: Health - {playerStats.Health} | Mana - {playerStats.Mana} ");

        Console.WriteLine(new String('*', 20));
        Console.WriteLine("Records");
        Console.WriteLine(new String('*', 20));

        /*
         Use record when we need represent data without identity
        Inmutable
         */

        PlayerInitSetup playerInitSetup = new PlayerInitSetup(100, 20, 55, 0);
        Console.WriteLine(playerInitSetup);

        Console.WriteLine($"Damage default: {playerInitSetup.Damage}");

        InitUserConfig userConfig = new InitUserConfig(0, 10);

        Console.WriteLine(userConfig);
    }

    //Another option to represent a record
    public record InitUserConfig(int MinCoins, int Level);
}