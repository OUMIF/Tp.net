using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3.Models
{
    internal class Groupes
    {
        private string nom;
        private List<Etudiants> etudiants;

        public Groupes(string nom, List<Etudiants> etudiants)
        {
            this.nom = nom;
            this.etudiants = new List<Etudiants>();
            this.etudiants = etudiants;
        }


        public string Name { get { return nom; } set { nom = value; } }

        public bool ajouterEtudiant(Etudiants etudiant)
        {
            if (etudiant == null) return false;
            else
                etudiants.Add(etudiant);
            return true;
        }


        public void AfficherEtudiants()
        {

            Console.WriteLine($" Nom du groupe = {this.Name} ");
            foreach (var etudiant in etudiants)
            {
                Console.WriteLine($"listes etudiants \n Code = {etudiant.Code} Nom = {etudiant.Nom} Prenom = {etudiant.Prenom}");
            }

        }


    }
}
