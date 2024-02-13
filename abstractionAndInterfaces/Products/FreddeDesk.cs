using abstractionAndInterfaces.Interfaces;

namespace abstractionAndInterfaces;

public class FreddeDesk : Product, IOffice, IBedroom, IAssemblable
{
    public FreddeDesk()
    {
        Name = "Fredde";
    }

    public override float Price()
    {
        return 1500.00f;
    }
    
    public override string Description()
    {
        return "How do you make the perfect gaming station? That's what we set out to do with FREDDE " +
               "desk by researching competitive gaming and enlisting a gamer designer of our own.";
    }

    public override string GetShelf()
    {
        return "Gaming desk department";
    }

    public string Bedroom()
    {
        return "The perfect desk for your unnecessarily massive gaming pc and laughably large monitor/monitors.";
    }

    public string Office()
    {
        return "Don't use a gaming desk at work.";
    }

    public string Assemble()
    {
        return "Assemble as per the included YouTube link.";
    }
}