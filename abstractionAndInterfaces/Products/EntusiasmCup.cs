using abstractionAndInterfaces.Interfaces;

namespace abstractionAndInterfaces;

public class EntusiasmCup : Product, IKitchen, ILivingRoom, IOffice
{
    public EntusiasmCup()
    {
        Name = "Entusiasm";
    }

    public string Kitchen()
    {
        return "The perfect cup for all your liquid needs in the kitchen.";
    }

    public string Office()
    {
        return "The perfect cup for all your liquid needs in the office.";
    }

    public string LivingRoom()
    {
        return "The perfect cup for all your liquid needs in the Living Room.";
    }

    public override float Price()
    {
        return 4999.00f;
    }

    public override string Description()
    {
        return "ENTUSIASM is available as a mug and bowl for simpler dishes," +
               " perfect to combine thanks to their various patterns.";
    }

    public override string GetShelf()
    {
        return "Cup department";
    }
}