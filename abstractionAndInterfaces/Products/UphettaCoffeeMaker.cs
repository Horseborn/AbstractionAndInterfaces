using abstractionAndInterfaces.Interfaces;

namespace abstractionAndInterfaces;

public class UphettaCoffeeMaker : Product, IKitchen, IOffice
{
    public UphettaCoffeeMaker()
    {
        Name = "Uphetta";
    }

    public override float Price()
    {
        return 5.00f;
    }

    public override string Description()
    {
        return "Many times, coffee and tea is what keeps you going – or makes you relax. " +
               "This coffee/tea maker serves your favourite beverages around the clock and in all seasons. " +
               "Hot and freshly made as it should be!";
    }

    public override string GetShelf()
    {
        return "Coffee accessories department";
    }

    public string Kitchen()
    {
        return "The perfect french press for your kitchen, buy another one if you'd" +
               "like one in your office as well";
    }

    public string Office()
    {
        return "he perfect french press for your office, buy another one if you'd" +
               "like one in your kitchen as well";
    }
}