using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3.Models
{
    internal class Directeur : Personnel
    {
        private int primeDeplacement;

        public Directeur(string code, string nom, string prenom, int salaire,int primeDeplacement) : base(code, nom, prenom, salaire)
        {
            this.primeDeplacement = primeDeplacement;
        }

    }
}
