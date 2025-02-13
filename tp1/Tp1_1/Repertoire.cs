using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class Repertoire
    {
        private String Name;
        private int nbrFichiers;
        private Fichier[] fichiers;


        public Repertoire(String name, int nbrFichiers)
        {
            this.Name = name;
            this.nbrFichiers = nbrFichiers;
            this.fichiers = new Fichier[30];
        }

        public void Afficher()
        {
            Console.WriteLine(" Repertoire : " + this.Name);
            for (int i = 0; i < nbrFichiers; i++)
            {
                if (fichiers[i] != null)
                {
                    Console.WriteLine("Nom du fichier : " + fichiers[i].getNom());
                }
            }
        }


        public int Rechercher(String name)
        {
            int i = 0;
            foreach (Fichier fichier in fichiers)
            {
                if (fichier.getNom().Equals(name))
                {
                    return i;
                }
                else { i++; }
            }
            return -1;
        }

        public bool Ajouter(Fichier fichier)
        {
            if (nbrFichiers < fichiers.Length) 
            {
                fichiers[nbrFichiers] = fichier;
                nbrFichiers++; 
                return true;
            }
            return false; 
        }


        public List<string> RechercherPdfs()
        {
            List<string> pdfs = new List<string>();

            foreach (Fichier fichier in fichiers)
            {
                if (fichier != null && fichier.getExtension().Equals("pdf", StringComparison.OrdinalIgnoreCase))
                {
                    pdfs.Add(fichier.getNom());
                }
            }

            return pdfs;
        }

        public bool delete(string name)
        {

            int j = this.Rechercher(name);
            if (j == -1)
                return false;

            for (int i = j; i < nbrFichiers - 1; i++)
            {
                fichiers[i] = fichiers[i + 1];
            }
            fichiers[nbrFichiers - 1] = null;
            nbrFichiers--;
            return true;
        }

        public bool Renommer(string name,String newName)
        {
            int i = this.Rechercher(name);
            if (i == -1) return false;
            fichiers[i].setNom(newName);
            return true;
        }

        public bool Modifier(string name, float newTaille)
        {
            int i = this.Rechercher(name);
            if (i == -1) return false;
            fichiers[i].setTaille(newTaille);
            return true;

        }





    }


}
