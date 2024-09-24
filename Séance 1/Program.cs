public class Media
{
    public string Titre { get; set; }
    public int NumeroReference { get; set; }
    public int NombreExemplairesDisponibles { get; set; }

    public Media(string titre, int numeroReference, int nombreExemplairesDisponibles)
    {
        Titre = titre;
        NumeroReference = numeroReference;
        NombreExemplairesDisponibles = nombreExemplairesDisponibles;
    }

    public virtual void AfficherInfos()
    {
        Console.WriteLine($"Titre: {Titre}, Référence: {NumeroReference}, Exemplaires disponibles: {NombreExemplairesDisponibles}");
    }
}

public class Livre : Media
{
    public string Auteur { get; set; }

    public Livre(string titre, int numeroReference, int nombreExemplairesDisponibles, string auteur)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Auteur = auteur;
    }

    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine($"Auteur: {Auteur}");
    }
}

public class DVD : Media
{
    public double Duree { get; set; }

    public DVD(string titre, int numeroReference, int nombreExemplairesDisponibles, double duree)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Duree = duree;
    }

    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine($"Durée: {Duree} heures");
    }
}

public class CD : Media
{
    public string Artiste { get; set; }

    public CD(string titre, int numeroReference, int nombreExemplairesDisponibles, string artiste)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Artiste = artiste;
    }

    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine($"Artiste: {Artiste}");
    }
}
