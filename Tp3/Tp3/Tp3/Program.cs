using System;
using System.Collections.Generic;
using Tp3.Models;

namespace Tp3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Etudiants etudiant1 = new Etudiants("E001", "Ali", "Karim",0);
            Etudiants etudiant2 = new Etudiants("E002", "Sofia", "Ben",0);
            Etudiants etudiant3 = new Etudiants("E003", "Mehdi", "Tariq",0);

           
            List<Etudiants> listeEtudiants = new List<Etudiants> { etudiant1, etudiant2, etudiant3 };

            
            Groupes groupe1 = new Groupes("Groupe A", listeEtudiants);
            groupe1.AfficherEtudiants();

            
            Enseignant enseignant1 = new Enseignant("ENS001", "Ahmed", "Zahraoui", 5000);
            Enseignant enseignant2 = new Enseignant("ENS002", "Fatima", "Bouchaib", 5500);

           
            RessourcesHumaines rh = new RessourcesHumaines();

            
            rh.ajouter(enseignant1, groupe1);
            rh.ajouter(enseignant2, groupe1);
            enseignant1.Etudiants.Add("groupe1", listeEtudiants);

           
            Console.WriteLine("Liste des enseignants et leurs groupes :");
            rh.AfficherEnseignants();

            
            Console.Write("\nEntrez le code de l'enseignant à rechercher : ");
            string codeRecherche = Console.ReadLine();
            Enseignant resultat = rh.RechercherEns(codeRecherche);

            if (resultat != null)
            {
                Console.WriteLine($"Enseignant trouvé : {resultat.Code} - {resultat.Nom} {resultat.Prenom}");
            }
            else
            {
                Console.WriteLine("Enseignant non trouvé.");
            }

           
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
