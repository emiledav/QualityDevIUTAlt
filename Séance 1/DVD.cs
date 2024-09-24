using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Séance_1
{
    internal class DVD : Media
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
}
