using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Séance_1
{
    internal class Media
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
}
