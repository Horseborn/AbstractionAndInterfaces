using abstractionAndInterfaces.Interfaces;

namespace abstractionAndInterfaces;

public class GrönsakskakaFood : Product, IOffice, IKitchen
{
    public GrönsakskakaFood()
    {
        Name = "Grönsakskaka";
    }

    public override float Price()
    {
        return 9.99f;
    }

    public override string Description()
    {
        return "A ready-made, potato-based dish with broccoli, leek, onions and " +
               "cheese that you easily prepare in the oven. Great to serve with chicken, " +
               "meat or fish – or on their own as a delicious vegetarian dish.";
    }

    public override string GetShelf()
    {
        return "Premade food department";
    }

    public string Kitchen()
    {
        return "This goes great with chicken, meat and fish. Easy to prepare," +
               " just throw in the oven and wait.";
    }

    public string Office()
    {
        return "A great and filling dish to eat at work, as long as" +
               "it is not prepared with seafood. Do not ever bring seafood to work.";
    }
}