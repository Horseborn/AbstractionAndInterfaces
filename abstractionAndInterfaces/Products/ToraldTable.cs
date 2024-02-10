using abstractionAndInterfaces.Interfaces;

namespace abstractionAndInterfaces;

public class ToraldTable : Product, IOffice, IBedroom, IAssemblable
{
    public string Assemble()
    {
        return "Build it properly using included instructions";
    }

    public string Office()
    {
        return "Perfect for that messy workplace you want to tidy up ..";
    }

    public string Bedroom()
    {
        return "If you want a simplistic, yet practical storage space in your bedroom .. this is it.";
    }

    public ToraldTable()
    {
        Name = "Torald";
    }

    public override float Price()
    {
        return 699.00f;
    }

    public override string Description()
    {
        return "Need a dedicated desk in a small area? Then TORALD desk is perfect! " +
               "It takes up minimal space in the room while being a practical place for studying, " +
               "drawing and doing various hobbies.";
    }

    public override string GetShelf()
    {
        return "Simple desk section";
    }
}