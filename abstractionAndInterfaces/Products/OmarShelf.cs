using abstractionAndInterfaces.Interfaces;

namespace abstractionAndInterfaces;

public class OmarShelf : Product, IAssemblable, IKitchen
{
    public OmarShelf()
    {
        Name = "Omar";
    }

    public override float Price()
    {
        return 1999.0f;
    }

    public override string Description()
    {
        return "OMAR shelf unit makes your pantry look like a professional kitchen." +
               "But it isn’t only a kitchen dweller, it works " +
               "equally well across the home. Add sections and adjust the shelf heights to fit your needs.";
    }

    public override string GetShelf()
    {
        return "Kitchen Shelf department.";
    }

    public string Kitchen()
    {
        return "Perfect shelving unit for your kitchen needs.";
    }

    public string Assemble()
    {
        return "Follow the included instructions to properly set up your shelf.";
    }
}