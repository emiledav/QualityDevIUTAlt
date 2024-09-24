using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Séance_1
{
    internal class Livre : Media
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
}
