using System;
using System.Collections.Generic;

namespace Tp3.Models
{
    internal class Enseignant : Personnel
    {
        private int primeDeplacement;
        private int primeHeureSupp;
        private string grade;
        private int volumeHoraire;
        private Dictionary<string, List<Etudiants>> etudiants;

        public Enseignant(string code, string nom, string prenom, int salaire) : base(code, nom, prenom, salaire)
        {
            this.etudiants = new Dictionary<string, List<Etudiants>>();
        }

        public int PrimeDeplacement
        {
            get { return primeDeplacement; }
            set { primeDeplacement = value; }
        }

        public int PrimeHeureSupp
        {
            get { return primeHeureSupp; }
            set { primeHeureSupp = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int VolumeHoraire
        {
            get { return volumeHoraire; }
            set { volumeHoraire = value; }
        }

        public Dictionary<string, List<Etudiants>> Etudiants
        {
            get { return etudiants; }
            set { etudiants = value; }
        }
    }
}
