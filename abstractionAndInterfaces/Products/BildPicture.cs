using abstractionAndInterfaces.Interfaces;

namespace abstractionAndInterfaces;

public class BildPicture : Product, IOffice, IBedroom, IKitchen, ILivingRoom
{
    public BildPicture()
    {
        Name = "Bild";
    }

    public override float Price()
    {
        return 0.99f;
    }

    public override string Description()
    {
        return "With BILD posters you can decorate with art that doesn’t cost a fortune. Combine with a frame in" +
               " a suitable size and adapt according to " +
               "your home and your taste – the possibilities are almost endless.";
    }

    public override string GetShelf()
    {
        return "Poster department";
    }

    public string Kitchen()
    {
        return "It's a poster, it'll do ok in any room.";
    }

    public string LivingRoom()
    {
        return "It's a poster, it'll do ok in any room.";
    }

    public string Office()
    {
        return "It's a poster, it'll do ok in any room.";
    }

    public string Bedroom()
    {
        return "It's a poster, it'll do ok in any room.";
    }
}