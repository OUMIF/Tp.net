using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2Ex2.Instances
{
    internal class Documents
    {




        private static int numéroEnregistrement = 0;
        private string titre;
        private int numeroDoc;


        public Documents(string titre)
        {
            this.titre = titre;
            numéroEnregistrement++;
            numeroDoc = numéroEnregistrement;
        }




        public static int GetNombreEnregistrements()
        {
            return numéroEnregistrement;
        }

        public string GetTitre()
        {
            return titre;
        }
        public void setTitre(string titre)
        {
            this.titre = titre;
        }
        public int getNumeroDoc()
        {
            return numeroDoc;
        }
        public virtual string description()
        {
            return $"titre = {this.titre},numero doc = {this.getNumeroDoc()}";

        }
    }
        internal class Livre : Documents
        {

            private string nomAuteur;
            private int nombrePage;



            public Livre(string titre, string nom, int nombrePage) : base(titre)
            {

                this.nomAuteur = nom;
                this.nombrePage = nombrePage;
            }


            public string GetNomAuteur()
            {
                return nomAuteur;
            }


            public int GetNombrePages()
            {
                return nombrePage;
            }

            public void setNomAuteur(string nomAuteur)
            {
                this.nomAuteur = nomAuteur;
            }


            public void setNombrePages(int nombrePage)
            {
                this.nombrePage = nombrePage;
            }

            public override string description()
            {
                return base.description() + $"nom auteur = {this.GetNomAuteur()},nombre page = {this.GetNombrePages()}";
            }

        }


        internal class Dictionaire : Documents
        {
            private string langue;
            private int nombreDefinitions;

            public Dictionaire(string langue, int nombreDefinitions, string titre) : base(titre)
            {

                this.langue = langue;
                this.nombreDefinitions = nombreDefinitions;
            }

            public string GetLangue()
            {
                return langue;
            }


            public void SetLangue(string langue)
            {
                this.langue = langue;
            }


            public int GetNombreDefinitions()
            {
                return nombreDefinitions;
            }


            public void SetNombreDefinitions(int nombreDefinitions)
            {
                this.nombreDefinitions = nombreDefinitions;
            }

            public override string description()
            {
                return base.description() + $", Langue: {langue}, Définitions: {nombreDefinitions}";
            }


        }
    }


