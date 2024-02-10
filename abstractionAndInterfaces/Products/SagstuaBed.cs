using abstractionAndInterfaces.Interfaces;

namespace abstractionAndInterfaces;

public class SagstuaBed : Product, IAssemblable, IBedroom
{
    public SagstuaBed()
    {
        Name = "Sagstua";
    }

    public override float Price()
    {
        return 3499.00f;
    }

    public override string Description()
    {
        return "A classic bed frame with a brass twist. The curved headboard and brass-colored details " +
               "soften the sturdy steel." +
               " Dressed with your favorite linens, it becomes a statement piece and your " +
               "own personal haven.";
    }

    public override string GetShelf()
    {
        return "Fancy bed department";
    }

    public string Bedroom()
    {
        return "This bed will improve your bedroom aura by at least 8%.";
    }

    public string Assemble()
    {
        return "Assemble the ornamental steel parts properly then put the separately bought mattress on top.";
    }
}