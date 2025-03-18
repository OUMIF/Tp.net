using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3.Models
{
    internal class Etudiants : Personnel
    {
        public Etudiants(string code, string nom , string prenom, int salaire) : base(code, nom, prenom, salaire)
        {
        }
    }
}
