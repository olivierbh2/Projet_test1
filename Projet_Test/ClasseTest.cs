using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ExempleVoiture
{
    class Voiture
    {
        // Propriétés de la voiture
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Annee { get; set; }
        public string Couleur { get; set; }
        public int VitesseActuelle { get; private set; }

        // Constructeur
        public Voiture(string marque, string modele, int annee, string couleur)
        {
            Marque = marque;
            Modele = modele;
            Annee = annee;
            Couleur = couleur;
            VitesseActuelle = 0; // La vitesse initiale est à 0
        }

        // Méthode pour accélérer la voiture
        public void Accelerer(int increment)
        {
            VitesseActuelle += increment;
            Console.WriteLine($"La voiture accélère de {increment} km/h. Vitesse actuelle : {VitesseActuelle} km/h");
        }

        // Méthode pour freiner la voiture
        public void Freiner(int decrement)
        {
            if (VitesseActuelle - decrement >= 0)
            {
                VitesseActuelle -= decrement;
                Console.WriteLine($"La voiture freine de {decrement} km/h. Vitesse actuelle : {VitesseActuelle} km/h");
            }
            else
            {
                Console.WriteLine("La voiture est déjà à l'arrêt.");
            }
        }

        // Méthode pour afficher les détails de la voiture
        public void AfficherDetails()
        {
            Console.WriteLine($"Marque : {Marque}");
            Console.WriteLine($"Modèle : {Modele}");
            Console.WriteLine($"Année : {Annee}");
            Console.WriteLine($"Couleur : {Couleur}");
            Console.WriteLine($"Vitesse actuelle : {VitesseActuelle} km/h");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Voiture maVoiture = new Voiture("Toyota", "Corolla", 2023, "Bleue");
            maVoiture.Accelerer(50);
            maVoiture.Freiner(20);
            maVoiture.AfficherDetails();
        }
    }
}
