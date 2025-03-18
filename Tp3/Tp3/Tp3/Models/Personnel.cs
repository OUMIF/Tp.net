using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3.Models
{
    internal class Personnel
    {

        private string code;
        private string nom;
        private string prenom;
        private int? salaire = null;// j'ai utulisé le ? pour permettre a var salaire de prendre null comme valeur 

        public Personnel(string code, string nom, string prenom, int salaire)
        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public int Salaire
        {
            get { return salaire ?? 0; }
            set { salaire = value; }
        }


    }
    }
