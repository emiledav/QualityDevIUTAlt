using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Séance_1
{
    internal class CD : Media
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
}
