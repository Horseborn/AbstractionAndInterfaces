using System.Threading.Channels;

namespace abstractionAndInterfaces;

class Program
{
    static void Main(string[] args)
    {
        GrönsakskakaFood kake = new GrönsakskakaFood();

        Console.WriteLine(
            $"Product name is {kake.Name}, its price is {kake.Price()}  and the product can be found in {kake.GetShelf()}.");
    }
}